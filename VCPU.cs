using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Drawing;

namespace VisualCPU
{
	class VCPU
	{
		private Random mRandom;
		private List<TaskSnake> mTaskSnakes;
		private int mUpdateCnt;

		private Rectangle mBounds;
		private TaskShape mTaskShape;

		private int mOurProcessId;

		private bool mMaxMemProportional;
		private bool mWindowsOnly;
		private bool mShowThreads;

		private int mVisibleProcesses;
		private int mTotalProcesses;
		private int mVisibleThreads;
		private int mTotalThreads;

		private List<string> mHideUsers = new List<string>();

		public VCPU()
		{
			mRandom = new Random();
			mTaskSnakes = new List<TaskSnake>();

			mTaskShape = TaskShape.Circle;

			mOurProcessId = Process.GetCurrentProcess().Id;
		}

		public void Clear()
		{
			mTaskSnakes.Clear();
		}

		public void RefreshCPU()
		{
			//Set tasks to false refresh
			foreach (TaskSnake task in mTaskSnakes) {
				task.Refreshed = false;
			}

			//Refresh tasks
			Process[] processes = Process.GetProcesses();
			mTotalProcesses = processes.Length;
			int totalThreads = 0;
			foreach (Process process in processes) {
				TaskSnake task = GetTaskByID(process.Id);
				if (task != null) {
					task.Refresh(process);
					task.Refreshed = true;
				} else {
					task = new TaskSnake(this, process);
					task.Refreshed = true;
					mTaskSnakes.Add(task);
				}

				totalThreads += process.Threads.Count;
			}

			mTotalThreads = totalThreads;

			//Remove tasks that are no longer alive
			for (int i = 0; i < mTaskSnakes.Count; i++) {
				if (!mTaskSnakes[i].Refreshed) {
					mTaskSnakes.RemoveAt(i);
					i--;
				}
			}

			mTaskSnakes.Sort(new Comparison<TaskSnake>(CompareTaskSize));

			Update();
		}

		public string[] GetAllPossibleUsers()
		{
			

			List<string> users = new List<string>();

			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes) {
				string owner;

				owner = APICalls.GetProcessUser(process);

				if (!users.Contains(owner))
					users.Add(owner);
			}

			return users.ToArray();
		}

		private int CompareTaskSize(TaskSnake a, TaskSnake b)
		{
			if (a.Size < b.Size)
				return 1;
			else if (a.Size > b.Size)
				return -1;
			else
				return 0;
		}

		public void Update()
		{
			mUpdateCnt = (mUpdateCnt + 1) % Int32.MaxValue;

			foreach (TaskSnake task in mTaskSnakes) {
				task.Update();
			}
		}

		public void Draw(Graphics g)
		{
			g.TranslateTransform(Bounds.X, Bounds.Y);

			int vc = 0;
			int vtc = 0;

			foreach (TaskSnake task in mTaskSnakes) {

				if (!IsTaskVisible(task))
					continue;

				task.Draw(g);

				vc++;
				vtc += task.Moons;
			}

			mVisibleProcesses = vc;
			mVisibleThreads = vtc;
		}

		public bool IsTaskVisible(TaskSnake task)
		{
			if (mWindowsOnly && !task.HasWindow)
				return false;

			if (mHideUsers.Contains(task.User))
				return false;

			return true;
		}

		public TaskSnake GetTaskByID(int id)
		{
			foreach (TaskSnake task in mTaskSnakes) {
				if (task.ID == id)
					return task;
			}

			return null;
		}

		public TaskSnake GetTaskAt(int x, int y)
		{
			foreach (TaskSnake task in mTaskSnakes.Reverse<TaskSnake>()) {
				if (task.DoesPointLieOnTask(x, y) && IsTaskVisible(task))
					return task;
			}

			return null;
		}

		public void ProduceShockwave(float x, float y)
		{
			float swRadius = 400.0f;
			float swPower = 25.0f;

			foreach (TaskSnake task in mTaskSnakes) {
				float hyp = task.GetDistanceFromRadiusTo(x, y) - (task.Size / 2);
				if (hyp > swRadius)
					continue;

				float additionalSpeed = ((swRadius - hyp) / swRadius) * swPower;
				float angle = (float)Math.Atan((task.Y - y) / (task.X - x));

				if (task.X - x < 0.0f)
					angle += (float)Math.PI * 1.0f;

				float vx = (float)Math.Cos(angle) * additionalSpeed;
				float vy = (float)Math.Sin(angle) * additionalSpeed;

				task.VX += vx;
				task.VY += vy;
			}

			Console.Beep(800, 50);
		}

		public APICalls.MEMORYSTATUSEX GetMemoryInfo()
		{
			APICalls.MEMORYSTATUSEX memStatus = new APICalls.MEMORYSTATUSEX();
			if (APICalls.GlobalMemoryStatusEx(memStatus)) {
				return memStatus;
			} else {
				return null;
			}
		}

		public Rectangle Bounds
		{
			get
			{
				return mBounds;
			}
			set
			{
				mBounds = value;
			}
		}

		public Random Random
		{
			get
			{
				return mRandom;
			}
		}

		public TaskShape TaskShape
		{
			get
			{
				return mTaskShape;
			}
			set
			{
				mTaskShape = value;
			}
		}

		public bool MaxMemProportional
		{
			get
			{
				return mMaxMemProportional;
			}
			set
			{
				mMaxMemProportional = value;
			}
		}

		public bool WindowsOnly
		{
			get
			{
				return mWindowsOnly;
			}
			set
			{
				mWindowsOnly = value;
			}
		}

		public List<string> HideUsers
		{
			get
			{
				return mHideUsers;
			}
		}

		public bool ShowThreads
		{
			get
			{
				return mShowThreads;
			}
			set
			{
				mShowThreads = value;
			}
		}

		public int VisibleProcesses
		{
			get
			{
				return mVisibleProcesses;
			}
			set
			{
				mVisibleProcesses = value;
			}
		}

		public int TotalProcesses
		{
			get
			{
				return mTotalProcesses;
			}
			set
			{
				mTotalProcesses = value;
			}
		}

		public int VisibleThreads
		{
			get
			{
				return mVisibleThreads;
			}
			set
			{
				mVisibleThreads = value;
			}
		}

		public int TotalThreads
		{
			get
			{
				return mTotalThreads;
			}
			set
			{
				mTotalThreads = value;
			}
		}

		public int OurProcessId
		{
			get
			{
				return mOurProcessId;
			}
		}
	}
}
