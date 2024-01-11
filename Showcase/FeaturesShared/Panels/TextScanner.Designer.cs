namespace FeaturesShared.Panels
{
	partial class TextScanner
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

		#region Wisej.NET Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonEmbedded = new Wisej.Web.Button();
			this.buttonNative = new Wisej.Web.Button();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonEmbedded
			// 
			this.buttonEmbedded.Dock = Wisej.Web.DockStyle.Top;
			this.buttonEmbedded.Location = new System.Drawing.Point(16, 121);
			this.buttonEmbedded.Name = "buttonEmbedded";
			this.buttonEmbedded.Size = new System.Drawing.Size(618, 37);
			this.buttonEmbedded.TabIndex = 23;
			this.buttonEmbedded.Text = "Embedded Scanner";
			this.buttonEmbedded.Click += new System.EventHandler(this.buttonEmbedded_Click);
			// 
			// buttonNative
			// 
			this.buttonNative.Dock = Wisej.Web.DockStyle.Top;
			this.buttonNative.Location = new System.Drawing.Point(16, 68);
			this.buttonNative.Name = "buttonNative";
			this.buttonNative.Size = new System.Drawing.Size(618, 37);
			this.buttonNative.TabIndex = 22;
			this.buttonNative.Text = "Native Scanner";
			this.buttonNative.Click += new System.EventHandler(this.buttonNative_Click);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 105);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 16);
			// 
			// TextScanner
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonEmbedded);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.buttonNative);
			this.Hint = "Use VisionKit (iOS) and Google MLKit to perform real-time OCR.";
			this.Name = "TextScanner";
			this.Controls.SetChildIndex(this.buttonNative, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonEmbedded, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Button buttonEmbedded;
		private Wisej.Web.Button buttonNative;
		private Wisej.Web.Spacer spacer1;
	}
}
