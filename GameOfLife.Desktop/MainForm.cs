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
			_playButton.Enabled = false;
			_stepButton.Enabled = false;
			_pauseButton.Enabled = true;
			_stopButton.Enabled = true;
		}

		private void StepButton_Click(object sender, EventArgs e)
		{
			_worldView.Step();
		}

		private void PauseButton_Click(object sender, EventArgs e)
		{
			_worldView.Stop();
			_playButton.Enabled = true;
			_stepButton.Enabled = true;
			_pauseButton.Enabled = false;
			_stopButton.Enabled = false;
		}

		private void StopButton_Click(object sender, EventArgs e)
		{
			_worldView.Stop();
			_worldView.Clear();
			_playButton.Enabled = true;
			_stepButton.Enabled = true;
			_pauseButton.Enabled = false;
			_stopButton.Enabled = false;
		}
	}
}
