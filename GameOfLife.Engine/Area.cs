namespace GameOfLife.Engine
{
	public struct Area
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int Width { get; set; }
		public int Height { get; set; }

		public Area(int x, int y, int width, int height)
		{
			X = x;
			Y = y;
			Width = width;
			Height = height;
		}

		public int Top
		{
			get { return Y; }
			set { Y = value; }
		}

		public int Left
		{
			get { return X; }
			set { X = value; }
		}

		public int Bottom
		{
			get { return Y + Height; }
			set { Height = value - Y; }
		}

		public int Right
		{
			get { return X + Width; }
			set { Width = value - X; }
		}

		public override string ToString()
		{
			return $"X = {X}, Y = {Y}, Width = {Width}, Height = {Height}";
		}
	}
}
