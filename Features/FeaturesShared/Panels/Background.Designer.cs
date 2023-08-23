namespace FeaturesShared.Panels
{
	partial class Background
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
			this.textBoxBackgroundColor = new Wisej.Web.TextBox();
			this.SuspendLayout();
			// 
			// textBoxBackgroundColor
			// 
			this.textBoxBackgroundColor.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxBackgroundColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxBackgroundColor.LabelText = "Background Color";
			this.textBoxBackgroundColor.Location = new System.Drawing.Point(16, 128);
			this.textBoxBackgroundColor.Name = "textBoxBackgroundColor";
			this.textBoxBackgroundColor.Size = new System.Drawing.Size(618, 55);
			this.textBoxBackgroundColor.TabIndex = 20;
			this.textBoxBackgroundColor.TextChanged += new System.EventHandler(this.textBoxBackgroundColor_TextChanged);
			// 
			// Background
			// 
   this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.textBoxBackgroundColor);
			this.Name = "Background";
			this.Appear += new System.EventHandler(this.Background_Appear);
			this.Disappear += new System.EventHandler(this.Background_Disappear);
			this.Controls.SetChildIndex(this.textBoxBackgroundColor, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.TextBox textBoxBackgroundColor;
	}
}
