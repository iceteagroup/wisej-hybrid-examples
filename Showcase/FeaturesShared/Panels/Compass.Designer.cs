namespace Wisej.Hybrid.Features.Panels
{
	partial class Compass
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
			this.label1 = new Wisej.Web.Label();
			this.labelHeading = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.None;
			this.label1.Location = new System.Drawing.Point(171, 252);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(308, 59);
			this.label1.TabIndex = 22;
			this.label1.Text = " The heading (measured in degrees) relative to magnetic north.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelHeading
			// 
			this.labelHeading.Anchor = Wisej.Web.AnchorStyles.None;
			this.labelHeading.Location = new System.Drawing.Point(171, 195);
			this.labelHeading.Name = "labelHeading";
			this.labelHeading.Size = new System.Drawing.Size(308, 15);
			this.labelHeading.TabIndex = 21;
			this.labelHeading.Text = "heading";
			this.labelHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Compass
			// 
   this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelHeading);
			this.Name = "Compass";
			this.Appear += new System.EventHandler(this.Compass_Appear);
			this.Disappear += new System.EventHandler(this.Compass_Disappear);
			this.Controls.SetChildIndex(this.labelHeading, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Label label1;
		private Web.Label labelHeading;
	}
}
