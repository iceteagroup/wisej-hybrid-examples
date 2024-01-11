namespace Wisej.Hybrid.Features.Panels
{
	partial class Flashlight
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
			this.buttonOn = new Wisej.Web.Button();
			this.buttonOff = new Wisej.Web.Button();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonOn
			// 
			this.buttonOn.Dock = Wisej.Web.DockStyle.Top;
			this.buttonOn.Location = new System.Drawing.Point(16, 68);
			this.buttonOn.Name = "buttonOn";
			this.buttonOn.Size = new System.Drawing.Size(618, 40);
			this.buttonOn.TabIndex = 0;
			this.buttonOn.Text = "Turn On";
			this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
			// 
			// buttonOff
			// 
			this.buttonOff.Dock = Wisej.Web.DockStyle.Top;
			this.buttonOff.Location = new System.Drawing.Point(16, 124);
			this.buttonOff.Name = "buttonOff";
			this.buttonOff.Size = new System.Drawing.Size(618, 40);
			this.buttonOff.TabIndex = 1;
			this.buttonOff.Text = "Turn Off";
			this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 108);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 16);
			// 
			// Flashlight
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonOff);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.buttonOn);
			this.Hint = "Toggle the device\'s flashlight (if available).";
			this.Name = "Flashlight";
			this.Controls.SetChildIndex(this.buttonOn, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonOff, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonOn;
		private Web.Button buttonOff;
		private Web.Spacer spacer1;
	}
}
