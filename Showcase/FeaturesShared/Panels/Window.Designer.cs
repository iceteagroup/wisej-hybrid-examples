namespace FeaturesShared.Panels
{
	partial class Window
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
			this.button1 = new Wisej.Web.Button();
			this.textBoxUrl = new Wisej.Web.TextBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Dock = Wisej.Web.DockStyle.Top;
			this.button1.Location = new System.Drawing.Point(16, 143);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(618, 37);
			this.button1.TabIndex = 20;
			this.button1.Text = "Open New Window";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxUrl
			// 
			this.textBoxUrl.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxUrl.LabelText = "URL";
			this.textBoxUrl.Location = new System.Drawing.Point(16, 68);
			this.textBoxUrl.Name = "textBoxUrl";
			this.textBoxUrl.Size = new System.Drawing.Size(618, 55);
			this.textBoxUrl.TabIndex = 21;
			this.textBoxUrl.Text = "https://google.com";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 123);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// Window
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.textBoxUrl);
			this.Hint = "Open new device windows (not supported on all platforms).";
			this.Name = "Window";
			this.Controls.SetChildIndex(this.textBoxUrl, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.button1, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Button button1;
		private Wisej.Web.TextBox textBoxUrl;
		private Wisej.Web.Spacer spacer1;
	}
}
