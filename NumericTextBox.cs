using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace VisualCPU
{
	class NumericTextBox : TextBox
	{
		private bool mInteger;
		private double mValue;
		private double mMinValue;
		private double mMaxValue;

		public NumericTextBox()
		{
			mInteger = true;
			mMinValue = 0;
			mMaxValue = Int32.MaxValue;
			mValue = 0;
		}

		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			if (e.KeyChar == '-' || Char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Delete || e.KeyChar == (char)Keys.Back)
				e.Handled = false;
			else
				e.Handled = true;

			if (e.KeyChar == '.' && mInteger)
				e.Handled = true;

			base.OnKeyPress(e); 
		}

		protected override void OnLeave(EventArgs e)
		{
			mValue = GetClosestValidNumber();
			Text = mValue.ToString();

			base.OnLeave(e);
		}

		public double GetClosestValidNumber()
		{
			double result;
			if (double.TryParse(Text, out result)) {
				result = Math.Min(Math.Max(mMinValue, result), mMaxValue);
				if (mInteger)
					return (double)((int)result);
				else
					return result;
			} else {
				return mValue;
			}
		}

		[DefaultValue(0)]
		public double MinimumValue
		{
			get
			{
				return mMinValue;
			}
			set
			{
				mMinValue = value;
			}
		}

		[DefaultValue(Double.MaxValue)]
		public double MaximumValue
		{
			get
			{
				return mMaxValue;
			}
			set
			{
				mMaxValue = value;
			}
		}

		public double Value
		{
			get
			{
				return mValue;
			}
			set
			{
				mValue = value;
				Text = mValue.ToString();
				mValue = GetClosestValidNumber();
				Text = mValue.ToString();
			}
		}

		[DefaultValue(true)]
		public bool Integer
		{
			get
			{
				return mInteger;
			}
			set
			{
				mInteger = value;
			}
		}
	}
}
