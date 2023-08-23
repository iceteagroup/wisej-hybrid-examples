namespace Wisej.Hybrid.Features.Panels
{
	partial class Magnetometer
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
			this.labelZ = new Wisej.Web.Label();
			this.labelY = new Wisej.Web.Label();
			this.labelX = new Wisej.Web.Label();
			this.label1 = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// labelZ
			// 
			this.labelZ.Anchor = Wisej.Web.AnchorStyles.None;
			this.labelZ.Location = new System.Drawing.Point(171, 279);
			this.labelZ.Name = "labelZ";
			this.labelZ.Size = new System.Drawing.Size(308, 15);
			this.labelZ.TabIndex = 5;
			this.labelZ.Text = "Z";
			this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelY
			// 
			this.labelY.Anchor = Wisej.Web.AnchorStyles.None;
			this.labelY.Location = new System.Drawing.Point(171, 232);
			this.labelY.Name = "labelY";
			this.labelY.Size = new System.Drawing.Size(308, 15);
			this.labelY.TabIndex = 4;
			this.labelY.Text = "Y";
			this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelX
			// 
			this.labelX.Anchor = Wisej.Web.AnchorStyles.None;
			this.labelX.Location = new System.Drawing.Point(171, 185);
			this.labelX.Name = "labelX";
			this.labelX.Size = new System.Drawing.Size(308, 15);
			this.labelX.TabIndex = 3;
			this.labelX.Text = "X";
			this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.None;
			this.label1.Location = new System.Drawing.Point(171, 336);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(308, 31);
			this.label1.TabIndex = 19;
			this.label1.Text = "The magnetic field vector in microteslas (µ).";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Magnetometer
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
			this.Controls.Add(this.labelZ);
			this.Controls.Add(this.labelY);
			this.Controls.Add(this.labelX);
			this.Name = "Magnetometer";
			this.Appear += new System.EventHandler(this.Magnetometer_Appear);
			this.Disappear += new System.EventHandler(this.Magnetometer_Disappear);
			this.Controls.SetChildIndex(this.labelX, 0);
			this.Controls.SetChildIndex(this.labelY, 0);
			this.Controls.SetChildIndex(this.labelZ, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Label labelZ;
		private Web.Label labelY;
		private Web.Label labelX;
		private Web.Label label1;
	}
}
