namespace Wisej.Hybrid.Features.Panels
{
	partial class SecureStorage
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
			this.buttonSave = new Wisej.Web.Button();
			this.textBox1 = new Wisej.Web.TextBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonSave
			// 
			this.buttonSave.Dock = Wisej.Web.DockStyle.Top;
			this.buttonSave.Location = new System.Drawing.Point(16, 121);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(618, 37);
			this.buttonSave.TabIndex = 23;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// textBox1
			// 
			this.textBox1.AutoSize = false;
			this.textBox1.Dock = Wisej.Web.DockStyle.Top;
			this.textBox1.Location = new System.Drawing.Point(16, 68);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(618, 37);
			this.textBox1.TabIndex = 22;
			this.textBox1.Watermark = "Enter a value...";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 105);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 16);
			// 
			// SecureStorage
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.textBox1);
			this.Hint = "Save secure key/value pairs to the device.";
			this.Name = "SecureStorage";
			this.Load += new System.EventHandler(this.SecureStorage_Load);
			this.Controls.SetChildIndex(this.textBox1, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonSave;
		private Web.TextBox textBox1;
		private Web.Spacer spacer1;
	}
}
