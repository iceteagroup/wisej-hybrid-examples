namespace Wisej.Hybrid.Features.Panels
{
	partial class Clipboard
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
			this.buttonRead = new Wisej.Web.Button();
			this.labelClipboard = new Wisej.Web.Label();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.textBoxClipboard = new Wisej.Web.TextBox();
			this.buttonSet = new Wisej.Web.Button();
			this.spacer3 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonRead
			// 
			this.buttonRead.Dock = Wisej.Web.DockStyle.Top;
			this.buttonRead.Location = new System.Drawing.Point(16, 128);
			this.buttonRead.Name = "buttonRead";
			this.buttonRead.Size = new System.Drawing.Size(618, 37);
			this.buttonRead.TabIndex = 19;
			this.buttonRead.Text = "Read Clipboard";
			this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
			// 
			// labelClipboard
			// 
			this.labelClipboard.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.labelClipboard.Dock = Wisej.Web.DockStyle.Top;
			this.labelClipboard.Location = new System.Drawing.Point(16, 185);
			this.labelClipboard.Name = "labelClipboard";
			this.labelClipboard.Size = new System.Drawing.Size(618, 145);
			this.labelClipboard.TabIndex = 20;
			this.labelClipboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 165);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 330);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// textBoxClipboard
			// 
			this.textBoxClipboard.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxClipboard.Location = new System.Drawing.Point(16, 350);
			this.textBoxClipboard.Name = "textBoxClipboard";
			this.textBoxClipboard.Size = new System.Drawing.Size(618, 30);
			this.textBoxClipboard.TabIndex = 24;
			// 
			// buttonSet
			// 
			this.buttonSet.Dock = Wisej.Web.DockStyle.Top;
			this.buttonSet.Location = new System.Drawing.Point(16, 386);
			this.buttonSet.Name = "buttonSet";
			this.buttonSet.Size = new System.Drawing.Size(618, 37);
			this.buttonSet.TabIndex = 25;
			this.buttonSet.Text = "Set Clipboard Contents";
			this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
			// 
			// spacer3
			// 
			this.spacer3.Dock = Wisej.Web.DockStyle.Top;
			this.spacer3.Location = new System.Drawing.Point(16, 380);
			this.spacer3.Name = "spacer3";
			this.spacer3.Size = new System.Drawing.Size(618, 6);
			// 
			// Clipboard
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonSet);
			this.Controls.Add(this.spacer3);
			this.Controls.Add(this.textBoxClipboard);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.labelClipboard);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.buttonRead);
			this.Name = "Clipboard";
			this.Controls.SetChildIndex(this.buttonRead, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.labelClipboard, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.textBoxClipboard, 0);
			this.Controls.SetChildIndex(this.spacer3, 0);
			this.Controls.SetChildIndex(this.buttonSet, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Button buttonRead;
		private Web.Label labelClipboard;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
		private Web.TextBox textBoxClipboard;
		private Web.Button buttonSet;
		private Web.Spacer spacer3;
	}
}
