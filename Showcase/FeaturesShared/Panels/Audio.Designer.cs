namespace Wisej.Hybrid.Features.Panels
{
	partial class Audio
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
			this.buttonPlayAudio = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// buttonPlayAudio
			// 
			this.buttonPlayAudio.Dock = Wisej.Web.DockStyle.Top;
			this.buttonPlayAudio.Location = new System.Drawing.Point(16, 68);
			this.buttonPlayAudio.Name = "buttonPlayAudio";
			this.buttonPlayAudio.Size = new System.Drawing.Size(618, 37);
			this.buttonPlayAudio.TabIndex = 0;
			this.buttonPlayAudio.Text = "Play Audio";
			this.buttonPlayAudio.Click += new System.EventHandler(this.buttonPlayAudio_Click);
			// 
			// Audio
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonPlayAudio);
			this.Hint = "Play audio through the application. Ensure audio is off \"silent\".";
			this.Name = "Audio";
			this.Controls.SetChildIndex(this.buttonPlayAudio, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonPlayAudio;
	}
}
