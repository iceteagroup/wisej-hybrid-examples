namespace FeaturesShared.Panels
{
	partial class VideoViewer
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
			this.video1 = new Wisej.Web.Video();
			this.SuspendLayout();
			// 
			// video1
			// 
			this.video1.Dock = Wisej.Web.DockStyle.Fill;
			this.video1.Location = new System.Drawing.Point(16, 128);
			this.video1.Name = "video1";
			this.video1.Size = new System.Drawing.Size(618, 334);
			this.video1.SourceURL = "https://filesamples.com/samples/video/mp4/sample_960x400_ocean_with_audio.mp4";
			this.video1.TabIndex = 20;
			this.video1.Volume = 0.5D;
			// 
			// VideoViewer
			// 
   this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.video1);
			this.Name = "VideoViewer";
			this.Padding = new Wisej.Web.Padding(16, 0, 16, 16);
			this.Controls.SetChildIndex(this.video1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Video video1;
	}
}
