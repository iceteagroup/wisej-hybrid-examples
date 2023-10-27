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
			this.SuspendLayout();
			// 
			// buttonEmbedded
			// 
			this.buttonEmbedded.Anchor = Wisej.Web.AnchorStyles.Top;
			this.buttonEmbedded.Location = new System.Drawing.Point(227, 257);
			this.buttonEmbedded.Name = "buttonEmbedded";
			this.buttonEmbedded.Size = new System.Drawing.Size(196, 37);
			this.buttonEmbedded.TabIndex = 23;
			this.buttonEmbedded.Text = "Embedded Scanner";
			this.buttonEmbedded.Click += new System.EventHandler(this.buttonEmbedded_Click);
			// 
			// buttonNative
			// 
			this.buttonNative.Anchor = Wisej.Web.AnchorStyles.Top;
			this.buttonNative.Location = new System.Drawing.Point(227, 185);
			this.buttonNative.Name = "buttonNative";
			this.buttonNative.Size = new System.Drawing.Size(196, 37);
			this.buttonNative.TabIndex = 22;
			this.buttonNative.Text = "Native Scanner";
			this.buttonNative.Click += new System.EventHandler(this.buttonNative_Click);
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
			this.Controls.Add(this.buttonNative);
			this.Name = "TextScanner";
			this.Controls.SetChildIndex(this.buttonNative, 0);
			this.Controls.SetChildIndex(this.buttonEmbedded, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Button buttonEmbedded;
		private Wisej.Web.Button buttonNative;
	}
}
