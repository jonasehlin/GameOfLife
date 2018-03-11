using System;

namespace GameOfLife.Engine
{
	public struct Coordinate : IEquatable<Coordinate>
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Coordinate(int x, int y)
		{
			X = x;
			Y = y;
		}

		public Coordinate Offset(Coordinate offset)
		{
			return new Coordinate(X + offset.X, Y + offset.Y);
		}

		public Coordinate Offset(int dx, int dy)
		{
			return new Coordinate(X + dx, Y + dy);
		}

		public override string ToString()
		{
			return $"X = {X}, Y = {Y}";
		}

		public override int GetHashCode()
		{
			return X ^ Y;
		}

		public int CompareTo(object obj)
		{
			throw new NotImplementedException();
		}

		public override bool Equals(object other)
		{
			if (other == null)
				return false;

			if (other.GetType() == GetType())
				return this == (Coordinate)other;

			throw new NotImplementedException();
		}

		public bool Equals(Coordinate other)
		{
			return this == other;
		}

		public static bool operator ==(Coordinate a, Coordinate b)
		{
			return a.X == b.X && a.Y == b.Y;
		}

		public static bool operator !=(Coordinate a, Coordinate b)
		{
			return !(a == b);
		}
	}
}
