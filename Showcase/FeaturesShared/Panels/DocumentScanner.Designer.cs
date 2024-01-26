#if !WINDOWS

namespace Wisej.Hybrid.Features.Panels
{
	partial class DocumentScanner
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
			this.buttonScan = new Wisej.Web.Button();
			this.trackBarQuality = new Wisej.Web.TrackBar();
			this.spacer2 = new Wisej.Web.Spacer();
			this.label1 = new Wisej.Web.Label();
			((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonScan
			// 
			this.buttonScan.Dock = Wisej.Web.DockStyle.Top;
			this.buttonScan.Location = new System.Drawing.Point(16, 138);
			this.buttonScan.Name = "buttonScan";
			this.buttonScan.Size = new System.Drawing.Size(618, 40);
			this.buttonScan.TabIndex = 1;
			this.buttonScan.Text = "Scan Documents";
			this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
			// 
			// trackBarQuality
			// 
			this.trackBarQuality.Dock = Wisej.Web.DockStyle.Top;
			this.trackBarQuality.LargeChange = 2;
			this.trackBarQuality.Location = new System.Drawing.Point(16, 88);
			this.trackBarQuality.Name = "trackBarQuality";
			this.trackBarQuality.Size = new System.Drawing.Size(618, 34);
			this.trackBarQuality.TabIndex = 20;
			this.trackBarQuality.Text = "1";
			this.trackBarQuality.TickStyle = Wisej.Web.TickStyle.None;
			this.trackBarQuality.Value = 1;
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 122);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 16);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = Wisej.Web.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(16, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(618, 20);
			this.label1.TabIndex = 22;
			this.label1.Text = "Image Scale Factor";
			// 
			// DocumentScanner
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonScan);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.trackBarQuality);
			this.Controls.Add(this.label1);
			this.Hint = "Scan documents using VisionKit (iOS) and OpenCV (Android)";
			this.Name = "DocumentScanner";
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.trackBarQuality, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.buttonScan, 0);
			((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Web.Button buttonScan;
		private Web.TrackBar trackBarQuality;
		private Web.Spacer spacer2;
        private Web.Label label1;
    }
}

#endif