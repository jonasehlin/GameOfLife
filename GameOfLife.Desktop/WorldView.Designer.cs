namespace GameOfLife.Desktop
{
	partial class WorldView
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this._worldTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// _worldTimer
			// 
			this._worldTimer.Tick += new System.EventHandler(this.WorldTimer_Tick);
			// 
			// WorldView
			// 
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WorldView_KeyPress);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WorldView_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WorldView_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WorldView_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer _worldTimer;
	}
}
