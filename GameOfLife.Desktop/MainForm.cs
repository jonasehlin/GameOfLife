using System;
using System.Windows.Forms;

namespace GameOfLife.Desktop
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void PlayButton_Click(object sender, EventArgs e)
		{
			_worldView.Start();
		}

		private void StepButton_Click(object sender, EventArgs e)
		{
			_worldView.Step();
		}

		private void PauseButton_Click(object sender, EventArgs e)
		{
			_worldView.Stop();
		}

		private void StopButton_Click(object sender, EventArgs e)
		{
			_worldView.Stop();
			_worldView.Clear();
		}
	}
}
