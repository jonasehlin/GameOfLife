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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this._mainToolStrip = new System.Windows.Forms.ToolStrip();
			this._playToolStripButton = new System.Windows.Forms.ToolStripButton();
			this._stepToolStripButton = new System.Windows.Forms.ToolStripButton();
			this._stopToolStripButton = new System.Windows.Forms.ToolStripButton();
			this._resetToolStripButton = new System.Windows.Forms.ToolStripButton();
			this._worldView = new GameOfLife.Desktop.WorldView();
			this._mainToolStripContainer.BottomToolStripPanel.SuspendLayout();
			this._mainToolStripContainer.ContentPanel.SuspendLayout();
			this._mainToolStripContainer.TopToolStripPanel.SuspendLayout();
			this._mainToolStripContainer.SuspendLayout();
			this._mainToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// _mainToolStripContainer
			// 
			// 
			// _mainToolStripContainer.BottomToolStripPanel
			// 
			this._mainToolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip1);
			// 
			// _mainToolStripContainer.ContentPanel
			// 
			this._mainToolStripContainer.ContentPanel.Controls.Add(this._worldView);
			this._mainToolStripContainer.ContentPanel.Size = new System.Drawing.Size(885, 505);
			this._mainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
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
			// statusStrip1
			// 
			this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.statusStrip1.Location = new System.Drawing.Point(0, 0);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(885, 22);
			this.statusStrip1.TabIndex = 0;
			// 
			// _mainToolStrip
			// 
			this._mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
			this._mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._playToolStripButton,
            this._stepToolStripButton,
            this._stopToolStripButton,
            this._resetToolStripButton});
			this._mainToolStrip.Location = new System.Drawing.Point(3, 0);
			this._mainToolStrip.Name = "_mainToolStrip";
			this._mainToolStrip.Size = new System.Drawing.Size(137, 25);
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
			this._stepToolStripButton.Size = new System.Drawing.Size(25, 22);
			this._stepToolStripButton.Text = "I>I";
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
			// _worldView
			// 
			this._worldView.BackColor = System.Drawing.SystemColors.Window;
			this._worldView.CellSize = 10F;
			this._worldView.Cursor = System.Windows.Forms.Cursors.Cross;
			this._worldView.Dock = System.Windows.Forms.DockStyle.Fill;
			this._worldView.ForeColor = System.Drawing.Color.Blue;
			this._worldView.Location = new System.Drawing.Point(0, 0);
			this._worldView.Name = "_worldView";
			this._worldView.Size = new System.Drawing.Size(885, 505);
			this._worldView.TabIndex = 4;
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
			this._mainToolStripContainer.TopToolStripPanel.ResumeLayout(false);
			this._mainToolStripContainer.TopToolStripPanel.PerformLayout();
			this._mainToolStripContainer.ResumeLayout(false);
			this._mainToolStripContainer.PerformLayout();
			this._mainToolStrip.ResumeLayout(false);
			this._mainToolStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private WorldView _worldView;
		private System.Windows.Forms.ToolTip _mainToolTip;
		private System.Windows.Forms.ToolStripContainer _mainToolStripContainer;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStrip _mainToolStrip;
		private System.Windows.Forms.ToolStripButton _playToolStripButton;
		private System.Windows.Forms.ToolStripButton _stepToolStripButton;
		private System.Windows.Forms.ToolStripButton _stopToolStripButton;
		private System.Windows.Forms.ToolStripButton _resetToolStripButton;
	}
}

