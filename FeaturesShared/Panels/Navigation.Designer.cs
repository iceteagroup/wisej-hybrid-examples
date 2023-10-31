namespace Wisej.Hybrid.Features.Panels
{
	partial class Navigation
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
			this.buttonShow = new Wisej.Web.Button();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonShow
			// 
			this.buttonShow.Dock = Wisej.Web.DockStyle.Top;
			this.buttonShow.Location = new System.Drawing.Point(16, 203);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(618, 37);
			this.buttonShow.TabIndex = 19;
			this.buttonShow.Text = "Show MAUI View";
			this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxTitle.LabelText = "Page Title";
			this.textBoxTitle.Location = new System.Drawing.Point(16, 128);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(618, 55);
			this.textBoxTitle.TabIndex = 20;
			this.textBoxTitle.Text = "Hello from Wisej.NET";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 183);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// Views
			// 
   this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonShow);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.textBoxTitle);
			this.Name = "Views";
			this.Controls.SetChildIndex(this.textBoxTitle, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonShow, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Button buttonShow;
		private Web.TextBox textBoxTitle;
		private Web.Spacer spacer1;
	}
}
