using System;

namespace GameOfLife.Desktop
{
	public class ValueEventArgs<TValue> : EventArgs
	{
		public TValue Value { get; private set; }

		public ValueEventArgs(TValue value)
		{
			Value = value;
		}
	}
}
