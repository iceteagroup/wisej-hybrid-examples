namespace Wisej.Hybrid.Features
{
	partial class Authentication
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

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBoxAuthenticate = new Wisej.Web.PictureBox();
			this.buttonAuthenticate = new Wisej.Web.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthenticate)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxAuthenticate
			// 
			this.pictureBoxAuthenticate.Dock = Wisej.Web.DockStyle.Top;
			this.pictureBoxAuthenticate.ImageSource = "Images\\face-id.png";
			this.pictureBoxAuthenticate.Location = new System.Drawing.Point(16, 68);
			this.pictureBoxAuthenticate.Name = "pictureBoxAuthenticate";
			this.pictureBoxAuthenticate.Padding = new Wisej.Web.Padding(16);
			this.pictureBoxAuthenticate.Size = new System.Drawing.Size(618, 128);
			this.pictureBoxAuthenticate.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// buttonAuthenticate
			// 
			this.buttonAuthenticate.Dock = Wisej.Web.DockStyle.Top;
			this.buttonAuthenticate.Location = new System.Drawing.Point(16, 196);
			this.buttonAuthenticate.Name = "buttonAuthenticate";
			this.buttonAuthenticate.Size = new System.Drawing.Size(618, 37);
			this.buttonAuthenticate.TabIndex = 1;
			this.buttonAuthenticate.Text = "Authenticate";
			this.buttonAuthenticate.Click += new System.EventHandler(this.buttonAuthenticate_Click);
			// 
			// Authentication
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonAuthenticate);
			this.Controls.Add(this.pictureBoxAuthenticate);
			this.Hint = "Use biometric authentication to authorize the current user.";
			this.Name = "Authentication";
			this.Load += new System.EventHandler(this.Authentication_Load);
			this.Controls.SetChildIndex(this.pictureBoxAuthenticate, 0);
			this.Controls.SetChildIndex(this.buttonAuthenticate, 0);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAuthenticate)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.PictureBox pictureBoxAuthenticate;
		private Web.Button buttonAuthenticate;
	}
}
