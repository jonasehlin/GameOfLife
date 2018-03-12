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
			_playToolStripButton.Enabled = false;
			_stepToolStripButton.Enabled = false;
			_stopToolStripButton.Enabled = true;
		}

		private void StepButton_Click(object sender, EventArgs e)
		{
			_worldView.Step();
		}

		private void StopButton_Click(object sender, EventArgs e)
		{
			_worldView.Stop();
			_playToolStripButton.Enabled = true;
			_stepToolStripButton.Enabled = true;
			_stopToolStripButton.Enabled = false;
		}

		private void ClearButton_Click(object sender, EventArgs e)
		{
			_worldView.Stop();
			_worldView.Clear();
			_playToolStripButton.Enabled = true;
			_stepToolStripButton.Enabled = true;
			_stopToolStripButton.Enabled = false;
		}

		private void WorldView_Advanced(object sender, WorldArgs e)
		{
			_worldStatsToolStripStatusLabel.Text = $"Age = {e.World.Age}, Cells = {e.World.Count}, Born = {e.Generation.CellsBorn}, Died = {e.Generation.CellsDied}";
		}
	}
}
