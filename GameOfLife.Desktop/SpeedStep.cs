namespace GameOfLife.Desktop
{
	class SpeedStep
	{
		public string Text { get; set; }
		public int Speed { get; set; }

		public SpeedStep()
		{
		}

		public SpeedStep(string text, int speed)
		{
			Text = text;
			Speed = speed;
		}

		public override string ToString()
		{
			return Text;
		}
	}
}
