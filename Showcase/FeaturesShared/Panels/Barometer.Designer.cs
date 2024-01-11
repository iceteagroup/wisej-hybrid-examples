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
			this.labelPressure = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// labelPressure
			// 
			this.labelPressure.Dock = Wisej.Web.DockStyle.Top;
			this.labelPressure.Location = new System.Drawing.Point(16, 68);
			this.labelPressure.Name = "labelPressure";
			this.labelPressure.Size = new System.Drawing.Size(618, 30);
			this.labelPressure.TabIndex = 23;
			this.labelPressure.Text = "pressure";
			this.labelPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Barometer
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.labelPressure);
			this.Hint = "The barometer measures the current pressure in hectopascals.";
			this.Name = "Barometer";
			this.Appear += new System.EventHandler(this.Barometer_Appear);
			this.Disappear += new System.EventHandler(this.Barometer_Disappear);
			this.Controls.SetChildIndex(this.labelPressure, 0);
			this.ResumeLayout(false);

		}

		#endregion
		private Web.Label labelPressure;
	}
}
