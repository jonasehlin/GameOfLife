namespace GameOfLife.Desktop
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._mainToolTip = new System.Windows.Forms.ToolTip(this.components);
			this._mainToolStripContainer = new System.Windows.Forms.ToolStripContainer();
			this._mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this._mainStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this._mainToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this._worldView = new GameOfLife.Desktop.WorldView();
			this._statisticsToolStrip = new System.Windows.Forms.ToolStrip();
			this._ageToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this._totalCellsToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this._bornToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this._diedToolStripLabel = new System.Windows.Forms.ToolStripLabel();
			this._mainToolStrip = new System.Windows.Forms.ToolStrip();
			this._playToolStripButton = new System.Windows.Forms.ToolStripButton();
			this._stepToolStripButton = new System.Windows.Forms.ToolStripButton();
			this._stopToolStripButton = new System.Windows.Forms.ToolStripButton();
			this._resetToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this._speedToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
			this._mainToolStripContainer.BottomToolStripPanel.SuspendLayout();
			this._mainToolStripContainer.ContentPanel.SuspendLayout();
			this._mainToolStripContainer.LeftToolStripPanel.SuspendLayout();
			this._mainToolStripContainer.TopToolStripPanel.SuspendLayout();
			this._mainToolStripContainer.SuspendLayout();
			this._mainStatusStrip.SuspendLayout();
			this._statisticsToolStrip.SuspendLayout();
			this._mainToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// _mainToolStripContainer
			// 
			// 
			// _mainToolStripContainer.BottomToolStripPanel
			// 
			this._mainToolStripContainer.BottomToolStripPanel.Controls.Add(this._mainStatusStrip);
			// 
			// _mainToolStripContainer.ContentPanel
			// 
			this._mainToolStripContainer.ContentPanel.Controls.Add(this._worldView);
			this._mainToolStripContainer.ContentPanel.Size = new System.Drawing.Size(805, 505);
			this._mainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// _mainToolStripContainer.LeftToolStripPanel
			// 
			this._mainToolStripContainer.LeftToolStripPanel.Controls.Add(this._statisticsToolStrip);
			this._mainToolStripContainer.LeftToolStripPanel.MinimumSize = new System.Drawing.Size(80, 0);
			this._mainToolStripContainer.Location = new System.Drawing.Point(0, 0);
			this._mainToolStripContainer.Name = "_mainToolStripContainer";
			this._mainToolStripContainer.Size = new System.Drawing.Size(885, 552);
			this._mainToolStripContainer.TabIndex = 5;
			this._mainToolStripContainer.Text = "toolStripContainer1";
			// 
			// _mainToolStripContainer.TopToolStripPanel
			// 
			this._mainToolStripContainer.TopToolStripPanel.Controls.Add(this._mainToolStrip);
			// 
			// _mainStatusStrip
			// 
			this._mainStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
			this._mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._mainStripStatusLabel,
            this._mainToolStripStatusLabel});
			this._mainStatusStrip.Location = new System.Drawing.Point(0, 0);
			this._mainStatusStrip.Name = "_mainStatusStrip";
			this._mainStatusStrip.Size = new System.Drawing.Size(885, 22);
			this._mainStatusStrip.TabIndex = 0;
			// 
			// _mainStripStatusLabel
			// 
			this._mainStripStatusLabel.Name = "_mainStripStatusLabel";
			this._mainStripStatusLabel.Size = new System.Drawing.Size(0, 17);
			// 
			// _mainToolStripStatusLabel
			// 
			this._mainToolStripStatusLabel.Name = "_mainToolStripStatusLabel";
			this._mainToolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
			this._mainToolStripStatusLabel.Text = "Stable";
			// 
			// _worldView
			// 
			this._worldView.BackColor = System.Drawing.SystemColors.Window;
			this._worldView.CellSize = 10F;
			this._worldView.Cursor = System.Windows.Forms.Cursors.Cross;
			this._worldView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._worldView.ForeColor = System.Drawing.Color.Blue;
			this._worldView.Location = new System.Drawing.Point(0, 0);
			this._worldView.Name = "_worldView";
			this._worldView.Size = new System.Drawing.Size(805, 505);
			this._worldView.TabIndex = 4;
			this._worldView.Advanced += new System.EventHandler<GameOfLife.Desktop.WorldArgs>(this.WorldView_Advanced);
			// 
			// _statisticsToolStrip
			// 
			this._statisticsToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._statisticsToolStrip.AutoSize = false;
			this._statisticsToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this._statisticsToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ageToolStripLabel,
            this._totalCellsToolStripLabel,
            this._bornToolStripLabel,
            this._diedToolStripLabel});
			this._statisticsToolStrip.Location = new System.Drawing.Point(0, 3);
			this._statisticsToolStrip.Name = "_statisticsToolStrip";
			this._statisticsToolStrip.Size = new System.Drawing.Size(77, 102);
			this._statisticsToolStrip.TabIndex = 0;
			// 
			// _ageToolStripLabel
			// 
			this._ageToolStripLabel.Name = "_ageToolStripLabel";
			this._ageToolStripLabel.Size = new System.Drawing.Size(75, 15);
			this._ageToolStripLabel.Text = "Age: 0";
			this._ageToolStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _totalCellsToolStripLabel
			// 
			this._totalCellsToolStripLabel.Name = "_totalCellsToolStripLabel";
			this._totalCellsToolStripLabel.Size = new System.Drawing.Size(75, 15);
			this._totalCellsToolStripLabel.Text = "Cells: 0";
			this._totalCellsToolStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _bornToolStripLabel
			// 
			this._bornToolStripLabel.Name = "_bornToolStripLabel";
			this._bornToolStripLabel.Size = new System.Drawing.Size(75, 15);
			this._bornToolStripLabel.Text = "Born: 0";
			this._bornToolStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _diedToolStripLabel
			// 
			this._diedToolStripLabel.Name = "_diedToolStripLabel";
			this._diedToolStripLabel.Size = new System.Drawing.Size(75, 15);
			this._diedToolStripLabel.Text = "Died: 0";
			this._diedToolStripLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _mainToolStrip
			// 
			this._mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this._mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._playToolStripButton,
            this._stepToolStripButton,
            this._stopToolStripButton,
            this._resetToolStripButton,
            this.toolStripSeparator1,
            this._speedToolStripComboBox});
			this._mainToolStrip.Location = new System.Drawing.Point(3, 0);
			this._mainToolStrip.Name = "_mainToolStrip";
			this._mainToolStrip.Size = new System.Drawing.Size(233, 25);
			this._mainToolStrip.TabIndex = 0;
			// 
			// _playToolStripButton
			// 
			this._playToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._playToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._playToolStripButton.Name = "_playToolStripButton";
			this._playToolStripButton.Size = new System.Drawing.Size(23, 22);
			this._playToolStripButton.Text = "▶";
			this._playToolStripButton.ToolTipText = "Start simulation";
			this._playToolStripButton.Click += new System.EventHandler(this.PlayButton_Click);
			// 
			// _stepToolStripButton
			// 
			this._stepToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._stepToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._stepToolStripButton.Name = "_stepToolStripButton";
			this._stepToolStripButton.Size = new System.Drawing.Size(23, 22);
			this._stepToolStripButton.Text = "⏯";
			this._stepToolStripButton.ToolTipText = "Advance one generation";
			this._stepToolStripButton.Click += new System.EventHandler(this.StepButton_Click);
			// 
			// _stopToolStripButton
			// 
			this._stopToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._stopToolStripButton.Enabled = false;
			this._stopToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._stopToolStripButton.Name = "_stopToolStripButton";
			this._stopToolStripButton.Size = new System.Drawing.Size(23, 22);
			this._stopToolStripButton.Text = "■";
			this._stopToolStripButton.ToolTipText = "Stop simulation";
			this._stopToolStripButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// _resetToolStripButton
			// 
			this._resetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._resetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._resetToolStripButton.Name = "_resetToolStripButton";
			this._resetToolStripButton.Size = new System.Drawing.Size(23, 22);
			this._resetToolStripButton.Text = "X";
			this._resetToolStripButton.ToolTipText = "Remove all cells and stop simulation";
			this._resetToolStripButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// _speedToolStripComboBox
			// 
			this._speedToolStripComboBox.AutoSize = false;
			this._speedToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._speedToolStripComboBox.Items.AddRange(new object[] {
            "1",
            "10"});
			this._speedToolStripComboBox.Name = "_speedToolStripComboBox";
			this._speedToolStripComboBox.Size = new System.Drawing.Size(90, 23);
			this._speedToolStripComboBox.ToolTipText = "Speed";
			this._speedToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.SpeedToolStripComboBox_SelectedIndexChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 552);
			this.Controls.Add(this._mainToolStripContainer);
			this.Name = "MainForm";
			this.Text = "Game of Life";
			this._mainToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			this._mainToolStripContainer.BottomToolStripPanel.PerformLayout();
			this._mainToolStripContainer.ContentPanel.ResumeLayout(false);
			this._mainToolStripContainer.LeftToolStripPanel.ResumeLayout(false);
			this._mainToolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this._mainToolStripContainer.TopToolStripPanel.PerformLayout();
			this._mainToolStripContainer.ResumeLayout(false);
			this._mainToolStripContainer.PerformLayout();
			this._mainStatusStrip.ResumeLayout(false);
			this._mainStatusStrip.PerformLayout();
			this._statisticsToolStrip.ResumeLayout(false);
			this._statisticsToolStrip.PerformLayout();
			this._mainToolStrip.ResumeLayout(false);
			this._mainToolStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private WorldView _worldView;
		private System.Windows.Forms.ToolTip _mainToolTip;
		private System.Windows.Forms.ToolStripContainer _mainToolStripContainer;
		private System.Windows.Forms.StatusStrip _mainStatusStrip;
		private System.Windows.Forms.ToolStrip _mainToolStrip;
		private System.Windows.Forms.ToolStripButton _playToolStripButton;
		private System.Windows.Forms.ToolStripButton _stepToolStripButton;
		private System.Windows.Forms.ToolStripButton _stopToolStripButton;
		private System.Windows.Forms.ToolStripButton _resetToolStripButton;
		private System.Windows.Forms.ToolStrip _statisticsToolStrip;
		private System.Windows.Forms.ToolStripLabel _totalCellsToolStripLabel;
		private System.Windows.Forms.ToolStripLabel _ageToolStripLabel;
		private System.Windows.Forms.ToolStripLabel _bornToolStripLabel;
		private System.Windows.Forms.ToolStripLabel _diedToolStripLabel;
		private System.Windows.Forms.ToolStripStatusLabel _mainStripStatusLabel;
		private System.Windows.Forms.ToolStripStatusLabel _mainToolStripStatusLabel;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripComboBox _speedToolStripComboBox;
	}
}

