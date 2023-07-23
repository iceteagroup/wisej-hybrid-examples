namespace Wisej.Hybrid.Features.Panels
{
	partial class Toast
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
			this.textBox1 = new Wisej.Web.TextBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Dock = Wisej.Web.DockStyle.Top;
			this.button1.Location = new System.Drawing.Point(16, 199);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(618, 37);
			this.button1.TabIndex = 19;
			this.button1.Text = "Show";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBoxMessage
			// 
			this.textBox1.Dock = Wisej.Web.DockStyle.Top;
			this.textBox1.LabelText = "Text";
			this.textBox1.Location = new System.Drawing.Point(16, 128);
			this.textBox1.Name = "textBoxMessage";
			this.textBox1.Size = new System.Drawing.Size(618, 55);
			this.textBox1.TabIndex = 20;
			this.textBox1.Text = "Hello, World!";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 183);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 16);
			// 
			// Toast
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.textBox1);
			this.Name = "Toast";
			this.Controls.SetChildIndex(this.textBox1, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.button1, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Button button1;
		private Web.TextBox textBox1;
		private Web.Spacer spacer1;
	}
}
