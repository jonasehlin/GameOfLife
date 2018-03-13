using GameOfLife.Engine;
using System;
using System.Windows.Forms;

namespace GameOfLife.Desktop
{
	public partial class MainForm : Form
	{
		private int? _stableAge;
		private ComboItem<int>[] _speeds = new[]
		{
			new ComboItem<int>("Slowest", 500),
			new ComboItem<int>("Slow", 250),
			new ComboItem<int>("Normal", 100),
			new ComboItem<int>("Fast", 50),
			new ComboItem<int>("Fastest", 1),
		};
		private ComboItem<float>[] _zoomFactors = new[]
		{
			new ComboItem<float>("1", 1),
			new ComboItem<float>("5", 5),
			new ComboItem<float>("10", 10),
			new ComboItem<float>("25", 25),
			new ComboItem<float>("50", 50),
		};

		public MainForm()
		{
			InitializeComponent();

			_speedToolStripComboBox.ComboBox.DataSource = _speeds;
			_speedToolStripComboBox.ComboBox.SelectedIndex = 2;

			_zoomToolStripComboBox.ComboBox.DataSource = _zoomFactors;
			_zoomToolStripComboBox.ComboBox.SelectedIndex = 2;

			_worldView.CellHover += WorldView_CellHover;
		}

		private void UpdateMenuItems(bool running)
		{
			_playToolStripMenuItem.Enabled = _playToolStripButton.Enabled = !running;
			_stepToolStripMenuItem.Enabled = _stepToolStripButton.Enabled = !running;
			_pauseToolStripMenuItem.Enabled = _pauseToolStripButton.Enabled = running;
		}

		private void Play_Click(object sender, EventArgs e)
		{
			_worldView.Start();
			UpdateMenuItems(true);
		}

		private void Step_Click(object sender, EventArgs e)
		{
			_worldView.Step();
		}

		private void Pause_Click(object sender, EventArgs e)
		{
			_worldView.Stop();
			UpdateMenuItems(false);
		}

		private void Clear_Click(object sender, EventArgs e)
		{
			_worldView.Stop();
			_worldView.Clear();
			UpdateMenuItems(false);
		}

		private void LoadWorld_Click(object sender, EventArgs e)
		{
			if (_openWorldFileDialog.ShowDialog() != DialogResult.OK)
				return;

			_worldView.LoadFromFile(_openWorldFileDialog.FileName);
		}

		private void SaveWorld_Click(object sender, EventArgs e)
		{
			if (_saveWorldFileDialog.ShowDialog() != DialogResult.OK)
				return;

			_worldView.SaveToFile(_saveWorldFileDialog.FileName);
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
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
			var speedStep = (ComboItem<int>)_speedToolStripComboBox.ComboBox.SelectedItem;
			_worldView.SetTimerInterval(speedStep.Value);
		}

		private void ZoomToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var zoomFactor = (ComboItem<float>)_zoomToolStripComboBox.ComboBox.SelectedItem;
			_worldView.ZoomTowards(zoomFactor.Value, _worldView.ClientRectangle.Center());
		}

		private void WorldView_CellSizeChanged(object sender, EventArgs e)
		{
			// TODO: Disconnect event handler for Zoom selected...
			_zoomToolStripComboBox.ComboBox.Text = _worldView.CellSize.ToString("0.#");
		}

		private void WorldView_CellHover(object sender, ValueEventArgs<Coordinate> e)
		{
			_cellHoverToolStripStatusLabel.Text = $"{e.Value.X}, {e.Value.Y}";
		}
	}
}
