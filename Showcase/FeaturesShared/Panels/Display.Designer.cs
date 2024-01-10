namespace FeaturesShared.Panels
{
	partial class Display
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
			this.checkBoxKeepOn = new Wisej.Web.CheckBox();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBoxKeepOn.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxKeepOn.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxKeepOn.Dock = Wisej.Web.DockStyle.Top;
			this.checkBoxKeepOn.Location = new System.Drawing.Point(16, 128);
			this.checkBoxKeepOn.Name = "checkBox1";
			this.checkBoxKeepOn.Size = new System.Drawing.Size(618, 53);
			this.checkBoxKeepOn.TabIndex = 20;
			this.checkBoxKeepOn.Text = "Keep Screen On";
			this.checkBoxKeepOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxKeepOn.CheckedChanged += new System.EventHandler(this.checkBoxKeepOn_CheckedChanged);
			// 
			// Display
			// 
   this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.checkBoxKeepOn);
			this.Name = "Display";
			this.Controls.SetChildIndex(this.checkBoxKeepOn, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.CheckBox checkBoxKeepOn;
	}
}
