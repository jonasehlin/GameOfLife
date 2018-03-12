namespace GameOfLife.Desktop
{
	class ComboItem<TValue>
	{
		public string Text { get; set; }
		public TValue Value { get; set; }

		public ComboItem()
		{
		}

		public ComboItem(string text, TValue value)
		{
			Text = text;
			Value = value;
		}

		public override string ToString()
		{
			return Text;
		}
	}
}
