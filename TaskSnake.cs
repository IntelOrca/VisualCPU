using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace VisualCPU
{
	enum TaskShape
	{
		Snake,
		Circle,
	}

	struct SnakePoint
	{
		public float Angle;
		public float X;
		public float Y;

		public override string ToString()
		{
			return String.Format("{0}, {1} Angle = {2}", X, Y, Angle);
		}
	}

	class TaskSnake
	{
		private const float SnakeWidth = 8.0f;

		private List<SnakePoint> mSnakePoints;

		private VCPU mVCPU;

		private int mID;
		private bool mRefreshed;

		private Process mProcess;
		private string mUser;
		private string mProcessName;
		private bool mHasWindow;

		private Color mColour;

		private float mX;
		private float mY;
		private float mVX;
		private float mVY;
		private float mAX;
		private float mAY;
		private float mSize;
		private float mAngle;

		private float mDestSize;

		private float mTopSpeed;
		private int mMoons;
		private float mAcceleration;
		private float mAngularPosition;
		private float mAngularSpeed;

		private bool mIsSpecial;

		public TaskSnake(VCPU vcpu, Process process)
		{
			mVCPU = vcpu;
			mID = process.Id;
			mProcess = process;
			mUser = APICalls.GetProcessUser(process);

			Random rand = mVCPU.Random;
			mX = rand.Next(0, mVCPU.Bounds.Width);
			mY = rand.Next(0, mVCPU.Bounds.Height);

			mIsSpecial = (mVCPU.OurProcessId == mID);

			if (mIsSpecial) {
				mColour = Color.Black;
			} else {
				mColour = new HSLColor(rand.Next(0, 240), rand.Next(0, 240), 120);
			}

			mSnakePoints = new List<SnakePoint>();

			float range = Settings.TaskAcceleration - (Settings.TaskAcceleration * 0.5f);
			mAcceleration = Settings.TaskAcceleration - ((float)mVCPU.Random.NextDouble() * range);

			range = Settings.TaskTopSpeed - (Settings.TaskTopSpeed * 0.5f);
			mTopSpeed = Settings.TaskTopSpeed - ((float)mVCPU.Random.NextDouble() * range);

			range = Settings.TaskAngularSpeed - (Settings.TaskAngularSpeed * 0.5f);
			mAngularSpeed = Settings.TaskAngularSpeed - ((float)mVCPU.Random.NextDouble() * range);

			Refresh(process);
		}

		public void Refresh(Process process)
		{
			mProcess = process;
			mProcessName = process.ProcessName;
			//mSpeed = 5.0f;
			mDestSize = (int)(process.PrivateMemorySize64 / 1000000);
			SetNumSnakePoints((int)(process.PrivateMemorySize64 / 5000000));

			if (mVCPU.MaxMemProportional) {
				double area = (double)mVCPU.Bounds.Width * (double)mVCPU.Bounds.Height;
				double ratio = area / (double)mVCPU.GetMemoryInfo().ullTotalPhys;

				double sizeArea = (double)process.PrivateMemorySize64 * ratio;
				double radius = Math.Sqrt(sizeArea / Math.PI);

				mDestSize = (float)radius * 2.0f;
			}

			mMoons = process.Threads.Count;

			mHasWindow = (process.MainWindowHandle != IntPtr.Zero);

			//mSpeed = (float)Math.Max(0.1, mSize / 50);
		}

		public void Update()
		{
			switch (mVCPU.TaskShape) {
				case TaskShape.Snake:
					UpdateSnake();
					break;
				case TaskShape.Circle:
					UpdateCircle();
					break;
			}
		}

		public void Draw(Graphics g)
		{
			switch (mVCPU.TaskShape) {
				case TaskShape.Snake:
					DrawSnake(g);
					break;
				case TaskShape.Circle:
					DrawCircle(g);
					break;
			}
		}

		private void DrawSnake(Graphics g)
		{
			List<PointF> pnts = new List<PointF>();

			pnts.Add(new PointF(mSnakePoints[0].X, mSnakePoints[0].Y));

			//Top
			for (int i = 1; i < mSnakePoints.Count; i++) {
				float angle = mSnakePoints[i].Angle + (float)(Math.PI * 0.5f);
				float x = mSnakePoints[i].X + ((float)Math.Cos(angle) * SnakeWidth);
				float y = mSnakePoints[i].Y + ((float)Math.Sin(angle) * SnakeWidth);

				pnts.Add(new PointF(x, y));
			}

			//Bottom
			for (int i = mSnakePoints.Count - 1; i >= 1; i--) {
				float angle = mSnakePoints[i].Angle - (float)(Math.PI * 0.5f);
				float x = mSnakePoints[i].X + ((float)Math.Cos(angle) * SnakeWidth);
				float y = mSnakePoints[i].Y + ((float)Math.Sin(angle) * SnakeWidth);

				pnts.Add(new PointF(x, y));
			}

			Brush brush = new SolidBrush(mColour);

			g.SmoothingMode = SmoothingMode.HighQuality;

			g.FillPolygon(brush, pnts.ToArray());

			g.SmoothingMode = SmoothingMode.Default;
		}

		private void DrawCircle(Graphics g)
		{
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.TextRenderingHint = TextRenderingHint.AntiAlias;

			Brush brush = new SolidBrush(mColour);
			Brush outline = new SolidBrush(Color.Black);

			if (mIsSpecial)
				outline = new SolidBrush(Color.White);

			g.FillEllipseWrap(outline, mX - (mSize / 2), mY - (mSize / 2), mSize, mSize, mVCPU.Bounds);

			float innerRadius = mSize / 2.1f;
			g.FillEllipseWrap(brush, mX - innerRadius, mY - innerRadius, innerRadius * 2, innerRadius * 2, mVCPU.Bounds);

			if (mVCPU.ShowThreads) {
				float angDiv = ((float)Math.PI * 2.0f) / (float)mMoons;
				for (int i = 0; i < mMoons; i++) {
					float angle = (angDiv * i) + mAngularPosition;
					float tr = 8.0f / (mMoons / 4);

					if (tr > mSize / 4)
						tr = mSize / 8;

					float td = tr + 2.0f;

					float tx = (float)Math.Cos(angle) * ((mSize / 2.0f) + td);
					float ty = (float)Math.Sin(angle) * ((mSize / 2.0f) + td);

					g.FillEllipseWrap(Brushes.White, (mX + tx) - tr, (mY + ty) - tr, tr * 2.0f, tr * 2.0f, mVCPU.Bounds);
				}
			}

			if (mSize > 20) {
				
				Font f = new Font("Arial", 10.0f * (mSize / 100.0f), FontStyle.Regular);
				SizeF fsize = g.MeasureString(mProcessName, f);
				float x = mX - (fsize.Width / 2.0f);
				float y = mY - (fsize.Height / 2.0f);

				g.DrawStringWrap(mProcessName, f, Brushes.White, x, y, mVCPU.Bounds);

				if (Settings.ShowMemorySize) {
					string memSize = (mProcess.WorkingSet64 / 1000000).ToString() + " MB";
					Font f2 = new Font("Arial", 10.0f * (mSize / 150.0f), FontStyle.Regular);
					SizeF fsize2 = g.MeasureString(memSize, f2);
					float x2 = mX - (fsize2.Width / 2.0f);
					float y2 = mY - (fsize2.Height / 2.0f) + f2.Height;

					g.DrawStringWrap(memSize, f2, Brushes.White, x2, y2, mVCPU.Bounds);
				}
			}

			g.TextRenderingHint = TextRenderingHint.SystemDefault;
			g.SmoothingMode = SmoothingMode.Default;
		}

		private void SetNumSnakePoints(int count)
		{
			count += 10;

			if (count == 0)
				count = 1;

			if (mSnakePoints.Count > count) {
				mSnakePoints.RemoveRange(count, mSnakePoints.Count - count);
			} else if (mSnakePoints.Count < count) {
				SnakePoint sp = new SnakePoint();
				sp.X = mX;
				sp.Y = mY;
				sp.Angle = mAngle;
				for (int i = 0; i < count - mSnakePoints.Count; i++) {
					mSnakePoints.Add(sp);
				}
			}
		}

		private void UpdateSnake()
		{
			//Shift all point info along
			for (int i = mSnakePoints.Count - 1; i > 0; i--) {
				mSnakePoints[i] = mSnakePoints[i - 1];
			}

			//Calculate a new position
			SetNextSnakePosition();

			//Create the snake point
			SnakePoint sp = mSnakePoints[0];
			sp.X = mX;
			sp.Y = mY;
			sp.Angle = mAngle;

			//Set the first snake point to this new one
			mSnakePoints[0] = sp;
		}

		private void SetNextSnakePosition()
		{
			Random rand = mVCPU.Random;

			float ca;
			//if (IsFacingCentre() && IsNearEdge()) {
			//    ca = 0.0f;
			//} else if (IsNearEdge()) {
			//    ca = 10.0f / 20.0f;
			//} else {
				ca = ((float)rand.Next(0, 10)) / 20.0f;
				if (rand.Next(0, 2) == 1)
					ca *= -1;
			//}

			mVX = (float)Math.Cos(mAngle) * mTopSpeed;
			mVY = (float)Math.Sin(mAngle) * mTopSpeed;

			mX += mVX;
			mY += mVY;

			mX = (((mX - mVCPU.Bounds.X) + mVCPU.Bounds.Width) % mVCPU.Bounds.Width) + mVCPU.Bounds.X;
			mY = (((mY - mVCPU.Bounds.Y) + mVCPU.Bounds.Height) % mVCPU.Bounds.Height) + mVCPU.Bounds.Y;

			mAngle += ca;
		}

		private void UpdateCircle()
		{
			Random rand = mVCPU.Random;

			if (Settings.TaskResizeSpeed == 0) {
				mSize = mDestSize;
			} else {
				if (mDestSize > mSize)
					mSize = Math.Min(mSize + Settings.TaskResizeSpeed, mDestSize);
				else
					mSize = Math.Max(mSize - Settings.TaskResizeSpeed, mDestSize);
			}

			float ca;
			ca = ((float)rand.Next(0, 10)) / 20.0f;
			if (rand.Next(0, 2) == 1)
				ca *= -1;

			if (Speed > mTopSpeed) {
				if (mVX > 0.0f)
					mAX = -Math.Min(Math.Abs(mVX), Settings.TaskDrag);
				else
					mAX = Math.Min(Math.Abs(mVX), Settings.TaskDrag);

				if (mVY > 0.0f)
					mAY = -Math.Min(Math.Abs(mVY), Settings.TaskDrag);
				else
					mAY = Math.Min(Math.Abs(mVY), Settings.TaskDrag);
			} else {
				mAX = (float)Math.Cos(mAngle) * mAcceleration;
				mAY = (float)Math.Sin(mAngle) * mAcceleration;
			}

			mVX += mAX;
			mVY += mAY;

			mX += mVX;
			mY += mVY;

			mX = (((mX - mVCPU.Bounds.X) + mVCPU.Bounds.Width) % mVCPU.Bounds.Width) + mVCPU.Bounds.X;
			mY = (((mY - mVCPU.Bounds.Y) + mVCPU.Bounds.Height) % mVCPU.Bounds.Height) + mVCPU.Bounds.Y;

			mAngle += ca;

			mAngularPosition = (float)Math.IEEERemainder(mAngularPosition + mAngularSpeed, Math.PI * 2.0);
		}

		private bool IsNearEdge()
		{
			float edge = 10.0f;

			if (mX < (mVCPU.Bounds.X + edge) ||
				mY < (mVCPU.Bounds.Y + edge) ||
				mX > (mVCPU.Bounds.Width - edge) ||
				mY > (mVCPU.Bounds.Height - edge)) {
				return true;
			}

			return false;
		}

		private bool IsFacingCentre()
		{
			float cx = mVCPU.Bounds.X + (mVCPU.Bounds.Width / 2);
			float cy = mVCPU.Bounds.Y + (mVCPU.Bounds.Height / 2);

			float dx = Math.Abs(mX - cx);
			float dy = Math.Abs(mY - cy);
			float ca = (float)Math.Atan(dx / dy);

			float a = (float)Math.PI - ca;
			return (a > mAngle - 0.5f && a < mAngle + 0.5f);
		}

		public float GetDistanceFromRadiusTo(float x, float y)
		{
			float dx = Math.Abs((float)x - mX);
			float dy = Math.Abs((float)y - mY);

			float hyp = (float)Math.Sqrt((dx * dx) + (dy * dy));

			return hyp;
		}

		public bool DoesPointLieOnTask(int x, int y)
		{
			if (mVCPU.TaskShape == TaskShape.Circle) {
				float hyp = GetDistanceFromRadiusTo((float)x, (float)y);
				if (hyp <= (mSize / 2.0f))
					return true;
			}

			return false;
		}

		public Process Process
		{
			get
			{
				return mProcess;
			}
		}

		public int ID
		{
			get
			{
				return mID;
			}
		}

		public bool Refreshed
		{
			get
			{
				return mRefreshed;
			}
			set
			{
				mRefreshed = value;
			}
		}

		public float Size
		{
			get
			{
				return mSize;
			}
		}

		public bool HasWindow
		{
			get
			{
				return mHasWindow;
			}
		}

		public float X
		{
			get
			{
				return mX;
			}
			set
			{
				mX = value;
			}
		}

		public float Y
		{
			get
			{
				return mY;
			}
			set
			{
				mY = value;
			}
		}

		public float VX
		{
			get
			{
				return mVX;
			}
			set
			{
				mVX = value;
			}
		}

		public float VY
		{
			get
			{
				return mVY;
			}
			set
			{
				mVY = value;
			}
		}

		public float Speed
		{
			get
			{
				return (float)Math.Sqrt((mVX * mVX) + (mVY * mVY));
			}
		}

		public string User
		{
			get
			{
				return mUser;
			}
		}

		public int Moons
		{
			get
			{
				return mMoons;
			}
		}
	}
}
