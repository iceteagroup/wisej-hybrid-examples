namespace Wisej.Hybrid.Features.Panels
{
	partial class Launcher
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
			this.buttonSettings = new Wisej.Web.Button();
			this.buttonOpenPdf = new Wisej.Web.Button();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonSettings
			// 
			this.buttonSettings.Dock = Wisej.Web.DockStyle.Top;
			this.buttonSettings.Location = new System.Drawing.Point(16, 68);
			this.buttonSettings.Name = "buttonSettings";
			this.buttonSettings.Size = new System.Drawing.Size(618, 37);
			this.buttonSettings.TabIndex = 20;
			this.buttonSettings.Text = "Open Image";
			this.buttonSettings.Click += new System.EventHandler(this.buttonOpenImage_Click);
			// 
			// buttonOpenPdf
			// 
			this.buttonOpenPdf.Dock = Wisej.Web.DockStyle.Top;
			this.buttonOpenPdf.Location = new System.Drawing.Point(16, 121);
			this.buttonOpenPdf.Name = "buttonOpenPdf";
			this.buttonOpenPdf.Size = new System.Drawing.Size(618, 37);
			this.buttonOpenPdf.TabIndex = 21;
			this.buttonOpenPdf.Text = "Open PDF";
			this.buttonOpenPdf.Click += new System.EventHandler(this.buttonOpenPdf_Click);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 105);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 16);
			// 
			// Launcher
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonOpenPdf);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.buttonSettings);
			this.Hint = "Open other apps from within your app.";
			this.Name = "Launcher";
			this.Controls.SetChildIndex(this.buttonSettings, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonOpenPdf, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonSettings;
		private Web.Button buttonOpenPdf;
		private Web.Spacer spacer1;
	}
}
