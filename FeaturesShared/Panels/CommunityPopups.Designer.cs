namespace Wisej.Hybrid.Features.Panels
{
	partial class CommunityPopups
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
			this.splitButton1 = new Wisej.Web.SplitButton();
			this.SuspendLayout();
			// 
			// splitButton1
			// 
			this.splitButton1.Location = new System.Drawing.Point(189, 150);
			this.splitButton1.Name = "splitButton1";
			this.splitButton1.Size = new System.Drawing.Size(213, 51);
			this.splitButton1.TabIndex = 19;
			this.splitButton1.Text = "splitButton1";
			this.splitButton1.Click += new System.EventHandler(this.splitButton1_Click);
			// 
			// CommunityPopups
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.splitButton1);
			this.Name = "CommunityPopups";
			this.Controls.SetChildIndex(this.splitButton1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.SplitButton splitButton1;
	}
}
