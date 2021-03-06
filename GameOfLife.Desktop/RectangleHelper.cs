﻿using System.Drawing;

namespace GameOfLife.Desktop
{
	public static class RectangleHelper
	{
		public static Point Center(this Rectangle rect)
		{
			return new Point(
				rect.Left + rect.Width / 2,
				rect.Top + rect.Height / 2);
		}
	}
}
