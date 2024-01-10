namespace Wisej.Hybrid.Features.Panels
{
	partial class Screen
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
			this.buttonScreenshot = new Wisej.Web.Button();
			this.buttonRecording = new Wisej.Web.Button();
			this.spacer2 = new Wisej.Web.Spacer();
			this.buttonStopRecording = new Wisej.Web.Button();
			this.spacer3 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonScreenshot
			// 
			this.buttonScreenshot.Dock = Wisej.Web.DockStyle.Top;
			this.buttonScreenshot.Location = new System.Drawing.Point(16, 128);
			this.buttonScreenshot.Name = "buttonScreenshot";
			this.buttonScreenshot.Size = new System.Drawing.Size(601, 37);
			this.buttonScreenshot.TabIndex = 19;
			this.buttonScreenshot.Text = "Take Screenshot";
			this.buttonScreenshot.Click += new System.EventHandler(this.buttonScreenshot_Click);
			// 
			// buttonRecording
			// 
			this.buttonRecording.Dock = Wisej.Web.DockStyle.Top;
			this.buttonRecording.Location = new System.Drawing.Point(16, 185);
			this.buttonRecording.Name = "buttonRecording";
			this.buttonRecording.Size = new System.Drawing.Size(601, 37);
			this.buttonRecording.TabIndex = 20;
			this.buttonRecording.Text = "Record Screen";
			this.buttonRecording.Click += new System.EventHandler(this.buttonRecord_Click);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 165);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(601, 20);
			// 
			// buttonStopRecording
			// 
			this.buttonStopRecording.Dock = Wisej.Web.DockStyle.Top;
			this.buttonStopRecording.Location = new System.Drawing.Point(16, 242);
			this.buttonStopRecording.Name = "buttonStopRecording";
			this.buttonStopRecording.Size = new System.Drawing.Size(601, 37);
			this.buttonStopRecording.TabIndex = 30;
			this.buttonStopRecording.Text = "Stop Recording";
			this.buttonStopRecording.Click += new System.EventHandler(this.buttonStopRecording_Click);
			// 
			// spacer3
			// 
			this.spacer3.Dock = Wisej.Web.DockStyle.Top;
			this.spacer3.Location = new System.Drawing.Point(16, 222);
			this.spacer3.Name = "spacer3";
			this.spacer3.Size = new System.Drawing.Size(601, 20);
			// 
			// Screen
			// 
   this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.AutoScrollMargin = new System.Drawing.Size(0, 20);
			this.Controls.Add(this.buttonStopRecording);
			this.Controls.Add(this.spacer3);
			this.Controls.Add(this.buttonRecording);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.buttonScreenshot);
			this.Name = "Screen";
			this.Size = new System.Drawing.Size(633, 618);
			this.Load += new System.EventHandler(this.Screen_Load);
			this.Controls.SetChildIndex(this.buttonScreenshot, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.buttonRecording, 0);
			this.Controls.SetChildIndex(this.spacer3, 0);
			this.Controls.SetChildIndex(this.buttonStopRecording, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonScreenshot;
		private Web.Button buttonRecording;
		private Web.Spacer spacer2;
		private Web.Button buttonStopRecording;
		private Web.Spacer spacer3;
	}
}
