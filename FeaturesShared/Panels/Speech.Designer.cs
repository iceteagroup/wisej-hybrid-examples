namespace Wisej.Hybrid.Features.Panels
{
	partial class Speech
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
			this.textBoxText = new Wisej.Web.TextBox();
			this.buttonSpeak = new Wisej.Web.Button();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// textBoxText
			// 
			this.textBoxText.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxText.LabelText = "Text to Speak";
			this.textBoxText.Location = new System.Drawing.Point(16, 128);
			this.textBoxText.Name = "textBoxText";
			this.textBoxText.Size = new System.Drawing.Size(618, 55);
			this.textBoxText.TabIndex = 19;
			this.textBoxText.Text = "Hello World!";
			// 
			// buttonSpeak
			// 
			this.buttonSpeak.Dock = Wisej.Web.DockStyle.Top;
			this.buttonSpeak.Location = new System.Drawing.Point(16, 203);
			this.buttonSpeak.Name = "buttonSpeak";
			this.buttonSpeak.Size = new System.Drawing.Size(618, 37);
			this.buttonSpeak.TabIndex = 20;
			this.buttonSpeak.Text = "Speak";
			this.buttonSpeak.Click += new System.EventHandler(this.buttonSpeak_Click);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 183);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// Speech
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonSpeak);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.textBoxText);
			this.Dock = Wisej.Web.DockStyle.Top;
			this.Name = "Speech";
			this.Controls.SetChildIndex(this.textBoxText, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonSpeak, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.TextBox textBoxText;
		private Web.Button buttonSpeak;
		private Web.Spacer spacer1;
	}
}
