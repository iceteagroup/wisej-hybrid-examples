namespace Wisej.Hybrid.Features.Panels
{
	partial class Preferences
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
			this.textBox1 = new Wisej.Web.TextBox();
			this.buttonSave = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Anchor = Wisej.Web.AnchorStyles.None;
			this.textBox1.Location = new System.Drawing.Point(180, 191);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(290, 30);
			this.textBox1.TabIndex = 20;
			this.textBox1.Text = "Saving to device preferences...";
			// 
			// buttonSave
			// 
			this.buttonSave.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonSave.Location = new System.Drawing.Point(180, 250);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(290, 37);
			this.buttonSave.TabIndex = 21;
			this.buttonSave.Text = "Set Value for key \"hybridtest\"";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// Preferences
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
			this.Controls.Add(this.textBox1);
			this.Name = "Preferences";
			this.Load += new System.EventHandler(this.Preferences_Load);
			this.Controls.SetChildIndex(this.textBox1, 0);
			this.Controls.SetChildIndex(this.buttonSave, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.TextBox textBox1;
		private Web.Button buttonSave;
	}
}
