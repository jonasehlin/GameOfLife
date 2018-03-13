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
			this._mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._mainToolStrip = new System.Windows.Forms.ToolStrip();
			this._playToolStripButton = new System.Windows.Forms.ToolStripButton();
			this._stepToolStripButton = new System.Windows.Forms.ToolStripButton();
			this._pauseToolStripButton = new System.Windows.Forms.ToolStripButton();
			this._resetToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this._speedToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this._zoomToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
			this._openWorldFileDialog = new System.Windows.Forms.OpenFileDialog();
			this._saveWorldFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._stepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this._mainToolStripContainer.BottomToolStripPanel.SuspendLayout();
			this._mainToolStripContainer.ContentPanel.SuspendLayout();
			this._mainToolStripContainer.LeftToolStripPanel.SuspendLayout();
			this._mainToolStripContainer.TopToolStripPanel.SuspendLayout();
			this._mainToolStripContainer.SuspendLayout();
			this._mainStatusStrip.SuspendLayout();
			this._statisticsToolStrip.SuspendLayout();
			this._mainMenuStrip.SuspendLayout();
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
			this._mainToolStripContainer.ContentPanel.Size = new System.Drawing.Size(805, 481);
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
			this._mainToolStripContainer.TopToolStripPanel.Controls.Add(this._mainMenuStrip);
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
			this._worldView.Size = new System.Drawing.Size(805, 481);
			this._worldView.TabIndex = 4;
			this._worldView.Advanced += new System.EventHandler<GameOfLife.Desktop.WorldArgs>(this.WorldView_Advanced);
			this._worldView.CellSizeChanged += new System.EventHandler(this.WorldView_CellSizeChanged);
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
			// _mainMenuStrip
			// 
			this._mainMenuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this._mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controlToolStripMenuItem});
			this._mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this._mainMenuStrip.Name = "_mainMenuStrip";
			this._mainMenuStrip.Size = new System.Drawing.Size(885, 24);
			this._mainMenuStrip.TabIndex = 1;
			this._mainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._loadToolStripMenuItem,
            this._saveToolStripMenuItem,
            this.toolStripMenuItem1,
            this._exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// _loadToolStripMenuItem
			// 
			this._loadToolStripMenuItem.Name = "_loadToolStripMenuItem";
			this._loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this._loadToolStripMenuItem.Text = "&Load...";
			this._loadToolStripMenuItem.Click += new System.EventHandler(this.LoadWorld_Click);
			// 
			// _saveToolStripMenuItem
			// 
			this._saveToolStripMenuItem.Name = "_saveToolStripMenuItem";
			this._saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this._saveToolStripMenuItem.Text = "&Save...";
			this._saveToolStripMenuItem.Click += new System.EventHandler(this.SaveWorld_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
			// 
			// _exitToolStripMenuItem
			// 
			this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
			this._exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this._exitToolStripMenuItem.Text = "&Exit";
			this._exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// _mainToolStrip
			// 
			this._mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this._mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._playToolStripButton,
            this._stepToolStripButton,
            this._pauseToolStripButton,
            this._resetToolStripButton,
            this.toolStripSeparator1,
            this._speedToolStripComboBox,
            this.toolStripSeparator2,
            this._zoomToolStripComboBox});
			this._mainToolStrip.Location = new System.Drawing.Point(3, 24);
			this._mainToolStrip.Name = "_mainToolStrip";
			this._mainToolStrip.Size = new System.Drawing.Size(260, 25);
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
			this._playToolStripButton.Click += new System.EventHandler(this.Play_Click);
			// 
			// _stepToolStripButton
			// 
			this._stepToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._stepToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._stepToolStripButton.Name = "_stepToolStripButton";
			this._stepToolStripButton.Size = new System.Drawing.Size(23, 22);
			this._stepToolStripButton.Text = "⏯";
			this._stepToolStripButton.ToolTipText = "Advance one generation";
			this._stepToolStripButton.Click += new System.EventHandler(this.Step_Click);
			// 
			// _pauseToolStripButton
			// 
			this._pauseToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._pauseToolStripButton.Enabled = false;
			this._pauseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._pauseToolStripButton.Name = "_pauseToolStripButton";
			this._pauseToolStripButton.Size = new System.Drawing.Size(23, 22);
			this._pauseToolStripButton.Text = "❚❚";
			this._pauseToolStripButton.ToolTipText = "Pause simulation";
			this._pauseToolStripButton.Click += new System.EventHandler(this.Pause_Click);
			// 
			// _resetToolStripButton
			// 
			this._resetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._resetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this._resetToolStripButton.Name = "_resetToolStripButton";
			this._resetToolStripButton.Size = new System.Drawing.Size(23, 22);
			this._resetToolStripButton.Text = "X";
			this._resetToolStripButton.ToolTipText = "Remove all cells and stop simulation";
			this._resetToolStripButton.Click += new System.EventHandler(this.Clear_Click);
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
			this._speedToolStripComboBox.ToolTipText = "Speed of simulation";
			this._speedToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.SpeedToolStripComboBox_SelectedIndexChanged);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// _zoomToolStripComboBox
			// 
			this._zoomToolStripComboBox.AutoSize = false;
			this._zoomToolStripComboBox.Name = "_zoomToolStripComboBox";
			this._zoomToolStripComboBox.Size = new System.Drawing.Size(50, 23);
			this._zoomToolStripComboBox.ToolTipText = "Zoom factor";
			this._zoomToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.ZoomToolStripComboBox_SelectedIndexChanged);
			// 
			// _openWorldFileDialog
			// 
			this._openWorldFileDialog.DefaultExt = "txt";
			this._openWorldFileDialog.Filter = "World files|*.txt|All files|*.*";
			// 
			// _saveWorldFileDialog
			// 
			this._saveWorldFileDialog.DefaultExt = "txt";
			this._saveWorldFileDialog.Filter = "World files|*.txt|All files|*.*";
			// 
			// controlToolStripMenuItem
			// 
			this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._playToolStripMenuItem,
            this._stepToolStripMenuItem,
            this._pauseToolStripMenuItem,
            this._clearToolStripMenuItem});
			this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
			this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.controlToolStripMenuItem.Text = "&Control";
			// 
			// _playToolStripMenuItem
			// 
			this._playToolStripMenuItem.Name = "_playToolStripMenuItem";
			this._playToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this._playToolStripMenuItem.Text = "&Play";
			this._playToolStripMenuItem.Click += new System.EventHandler(this.Play_Click);
			// 
			// _pauseToolStripMenuItem
			// 
			this._pauseToolStripMenuItem.Name = "_pauseToolStripMenuItem";
			this._pauseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this._pauseToolStripMenuItem.Text = "P&ause";
			this._pauseToolStripMenuItem.Click += new System.EventHandler(this.Pause_Click);
			// 
			// _stepToolStripMenuItem
			// 
			this._stepToolStripMenuItem.Name = "_stepToolStripMenuItem";
			this._stepToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this._stepToolStripMenuItem.Text = "&Step";
			this._stepToolStripMenuItem.Click += new System.EventHandler(this.Step_Click);
			// 
			// _clearToolStripMenuItem
			// 
			this._clearToolStripMenuItem.Name = "_clearToolStripMenuItem";
			this._clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this._clearToolStripMenuItem.Text = "&Clear";
			this._clearToolStripMenuItem.Click += new System.EventHandler(this.Clear_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(885, 552);
			this.Controls.Add(this._mainToolStripContainer);
			this.MainMenuStrip = this._mainMenuStrip;
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
			this._mainMenuStrip.ResumeLayout(false);
			this._mainMenuStrip.PerformLayout();
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
		private System.Windows.Forms.ToolStripButton _pauseToolStripButton;
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
		private System.Windows.Forms.ToolStripComboBox _zoomToolStripComboBox;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.MenuStrip _mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem _loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _saveToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog _openWorldFileDialog;
		private System.Windows.Forms.SaveFileDialog _saveWorldFileDialog;
		private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _playToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _stepToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _pauseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _clearToolStripMenuItem;
	}
}

