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
			this._playButton = new System.Windows.Forms.Button();
			this._worldView = new GameOfLife.Desktop.WorldView();
			this._stepButton = new System.Windows.Forms.Button();
			this._pauseButton = new System.Windows.Forms.Button();
			this._stopButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// _playButton
			// 
			this._playButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._playButton.Location = new System.Drawing.Point(9, 9);
			this._playButton.Margin = new System.Windows.Forms.Padding(0);
			this._playButton.Name = "_playButton";
			this._playButton.Size = new System.Drawing.Size(38, 32);
			this._playButton.TabIndex = 1;
			this._playButton.Text = "▶";
			this._playButton.UseVisualStyleBackColor = false;
			this._playButton.Click += new System.EventHandler(this.PlayButton_Click);
			// 
			// _worldView
			// 
			this._worldView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._worldView.BackColor = System.Drawing.SystemColors.Window;
			this._worldView.CellSize = 10F;
			this._worldView.ForeColor = System.Drawing.Color.Blue;
			this._worldView.Location = new System.Drawing.Point(216, 12);
			this._worldView.Name = "_worldView";
			this._worldView.Size = new System.Drawing.Size(364, 338);
			this._worldView.TabIndex = 0;
			// 
			// _stepButton
			// 
			this._stepButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._stepButton.Location = new System.Drawing.Point(47, 9);
			this._stepButton.Margin = new System.Windows.Forms.Padding(0);
			this._stepButton.Name = "_stepButton";
			this._stepButton.Size = new System.Drawing.Size(38, 32);
			this._stepButton.TabIndex = 2;
			this._stepButton.Text = "I>I";
			this._stepButton.UseVisualStyleBackColor = false;
			this._stepButton.Click += new System.EventHandler(this.StepButton_Click);
			// 
			// _pauseButton
			// 
			this._pauseButton.Enabled = false;
			this._pauseButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._pauseButton.Location = new System.Drawing.Point(85, 9);
			this._pauseButton.Margin = new System.Windows.Forms.Padding(0);
			this._pauseButton.Name = "_pauseButton";
			this._pauseButton.Size = new System.Drawing.Size(38, 32);
			this._pauseButton.TabIndex = 3;
			this._pauseButton.Text = "II";
			this._pauseButton.UseVisualStyleBackColor = false;
			this._pauseButton.Click += new System.EventHandler(this.PauseButton_Click);
			// 
			// _stopButton
			// 
			this._stopButton.Enabled = false;
			this._stopButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this._stopButton.Location = new System.Drawing.Point(123, 9);
			this._stopButton.Margin = new System.Windows.Forms.Padding(0);
			this._stopButton.Name = "_stopButton";
			this._stopButton.Size = new System.Drawing.Size(38, 32);
			this._stopButton.TabIndex = 4;
			this._stopButton.Text = "■";
			this._stopButton.UseVisualStyleBackColor = false;
			this._stopButton.Click += new System.EventHandler(this.StopButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 362);
			this.Controls.Add(this._stopButton);
			this.Controls.Add(this._pauseButton);
			this.Controls.Add(this._stepButton);
			this.Controls.Add(this._playButton);
			this.Controls.Add(this._worldView);
			this.Name = "MainForm";
			this.Text = "Game of Life";
			this.ResumeLayout(false);

		}

		#endregion

		private WorldView _worldView;
		private System.Windows.Forms.Button _playButton;
		private System.Windows.Forms.Button _stepButton;
		private System.Windows.Forms.Button _pauseButton;
		private System.Windows.Forms.Button _stopButton;
	}
}

