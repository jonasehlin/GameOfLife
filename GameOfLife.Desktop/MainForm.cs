using System;
using System.Windows.Forms;

namespace GameOfLife.Desktop
{
	public partial class MainForm : Form
	{
		private int? _stableAge;
		private SpeedStep[] _speeds = new[]
		{
			new SpeedStep("Slowest", 500),
			new SpeedStep("Slow", 250),
			new SpeedStep("Normal", 100),
			new SpeedStep("Fast", 50),
			new SpeedStep("Maximum", 1),
		};

		public MainForm()
		{
			InitializeComponent();

			_speedToolStripComboBox.ComboBox.DataSource = _speeds;
			_speedToolStripComboBox.ComboBox.SelectedIndex = 2;
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
			_ageToolStripLabel.Text = $"Age: {e.World.Age}";
			_totalCellsToolStripLabel.Text = $"Cells: {e.World.Count}";
			_bornToolStripLabel.Text = $"Born: {e.Generation.CellsBorn}";
			_diedToolStripLabel.Text = $"Died: {e.Generation.CellsDied}";

			string text;
			if (e.Generation.CellsBorn == e.Generation.CellsDied)
			{
				if (_stableAge == null)
					_stableAge = e.World.Age;

				text = $"Stable since age: {_stableAge.Value}";
			}
			else if (e.Generation.CellsBorn > e.Generation.CellsDied)
			{
				text = "Growing";
				_stableAge = null;
			}
			else
			{
				text = "Shrinking";
				_stableAge = null;
			}
			_mainToolStripStatusLabel.Text = text;
		}

		private void SpeedToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var speedStep = (SpeedStep)_speedToolStripComboBox.ComboBox.SelectedItem;
			_worldView.SetTimerInterval(speedStep.Speed);
		}
	}
}
