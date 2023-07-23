namespace Wisej.Hybrid.Features.Panels
{
	partial class MauiBarcodeScanner
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
			this.SuspendLayout();
			// 
			// buttonScan
			// 
			this.buttonScan.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonScan.Location = new System.Drawing.Point(223, 221);
			this.buttonScan.Name = "buttonScan";
			this.buttonScan.Size = new System.Drawing.Size(205, 37);
			this.buttonScan.TabIndex = 20;
			this.buttonScan.Text = "Scan Barcodes";
			this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
			// 
			// MauiBarcodeScanner
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
			this.Name = "MauiBarcodeScanner";
			this.Controls.SetChildIndex(this.buttonScan, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonScan;
	}
}
