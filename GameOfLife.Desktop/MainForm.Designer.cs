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
			this._worldView = new GameOfLife.Desktop.WorldView();
			this.SuspendLayout();
			// 
			// _worldView
			// 
			this._worldView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._worldView.BackColor = System.Drawing.SystemColors.Window;
			this._worldView.ForeColor = System.Drawing.Color.Blue;
			this._worldView.Location = new System.Drawing.Point(216, 12);
			this._worldView.Name = "_worldView";
			this._worldView.Size = new System.Drawing.Size(364, 338);
			this._worldView.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 362);
			this.Controls.Add(this._worldView);
			this.Name = "MainForm";
			this.Text = "Game of Life";
			this.ResumeLayout(false);

		}

		#endregion

		private WorldView _worldView;
	}
}

