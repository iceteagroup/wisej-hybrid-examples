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
			this.SuspendLayout();
			// 
			// buttonSettings
			// 
			this.buttonSettings.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonSettings.Location = new System.Drawing.Point(191, 190);
			this.buttonSettings.Name = "buttonSettings";
			this.buttonSettings.Size = new System.Drawing.Size(268, 37);
			this.buttonSettings.TabIndex = 20;
			this.buttonSettings.Text = "Open Image";
			this.buttonSettings.Click += new System.EventHandler(this.buttonOpenImage_Click);
			// 
			// buttonOpenPdf
			// 
			this.buttonOpenPdf.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonOpenPdf.Location = new System.Drawing.Point(191, 252);
			this.buttonOpenPdf.Name = "buttonOpenPdf";
			this.buttonOpenPdf.Size = new System.Drawing.Size(268, 37);
			this.buttonOpenPdf.TabIndex = 21;
			this.buttonOpenPdf.Text = "Open PDF";
			this.buttonOpenPdf.Click += new System.EventHandler(this.buttonOpenPdf_Click);
			// 
			// Launcher
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonOpenPdf);
			this.Controls.Add(this.buttonSettings);
			this.Name = "Launcher";
			this.Controls.SetChildIndex(this.buttonSettings, 0);
			this.Controls.SetChildIndex(this.buttonOpenPdf, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonSettings;
		private Web.Button buttonOpenPdf;
	}
}
