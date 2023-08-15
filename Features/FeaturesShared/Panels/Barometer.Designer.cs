namespace Wisej.Hybrid.Features.Panels
{
	partial class Barometer
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
			this.labelPressure = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.None;
			this.label1.Location = new System.Drawing.Point(171, 238);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(308, 59);
			this.label1.TabIndex = 24;
			this.label1.Text = "The current pressure in hectopascals.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelPressure
			// 
			this.labelPressure.Anchor = Wisej.Web.AnchorStyles.None;
			this.labelPressure.Location = new System.Drawing.Point(171, 181);
			this.labelPressure.Name = "labelPressure";
			this.labelPressure.Size = new System.Drawing.Size(308, 22);
			this.labelPressure.TabIndex = 23;
			this.labelPressure.Text = "pressure";
			this.labelPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Barometer
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelPressure);
			this.Name = "Barometer";
			this.Appear += new System.EventHandler(this.Barometer_Appear);
			this.Disappear += new System.EventHandler(this.Barometer_Disappear);
			this.Controls.SetChildIndex(this.labelPressure, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Label label1;
		private Web.Label labelPressure;
	}
}
