namespace Wisej.Hybrid.Features.Panels
{
	partial class AppInfo
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
			this.button1 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Dock = Wisej.Web.DockStyle.Top;
			this.button1.Location = new System.Drawing.Point(16, 68);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(618, 37);
			this.button1.TabIndex = 20;
			this.button1.Text = "Show App Settings";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// AppInfo
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.button1);
			this.Hint = "Access the application settings page to toggle permissions.";
			this.Name = "AppInfo";
			this.Controls.SetChildIndex(this.button1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button button1;
	}
}
