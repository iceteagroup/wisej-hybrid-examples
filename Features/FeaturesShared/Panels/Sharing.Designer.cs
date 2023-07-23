namespace Wisej.Hybrid.Features.Panels
{
	partial class Sharing
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
			this.textBoxText = new Wisej.Web.TextBox();
			this.buttonText = new Wisej.Web.Button();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.buttonUri = new Wisej.Web.Button();
			this.spacer3 = new Wisej.Web.Spacer();
			this.textBoxUri = new Wisej.Web.TextBox();
			this.spacer4 = new Wisej.Web.Spacer();
			this.buttonFiles = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// textBoxText
			// 
			this.textBoxText.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxText.Location = new System.Drawing.Point(16, 128);
			this.textBoxText.Name = "textBoxText";
			this.textBoxText.Size = new System.Drawing.Size(618, 30);
			this.textBoxText.TabIndex = 19;
			this.textBoxText.Text = "Hello, World!";
			// 
			// buttonText
			// 
			this.buttonText.Dock = Wisej.Web.DockStyle.Top;
			this.buttonText.Location = new System.Drawing.Point(16, 168);
			this.buttonText.Name = "buttonText";
			this.buttonText.Size = new System.Drawing.Size(618, 37);
			this.buttonText.TabIndex = 20;
			this.buttonText.Text = "Share Text";
			this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 158);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 10);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 205);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 40);
			// 
			// buttonUri
			// 
			this.buttonUri.Dock = Wisej.Web.DockStyle.Top;
			this.buttonUri.Location = new System.Drawing.Point(16, 285);
			this.buttonUri.Name = "buttonUri";
			this.buttonUri.Size = new System.Drawing.Size(618, 37);
			this.buttonUri.TabIndex = 26;
			this.buttonUri.Text = "Share Uri";
			this.buttonUri.Click += new System.EventHandler(this.buttonUri_Click);
			// 
			// spacer3
			// 
			this.spacer3.Dock = Wisej.Web.DockStyle.Top;
			this.spacer3.Location = new System.Drawing.Point(16, 275);
			this.spacer3.Name = "spacer3";
			this.spacer3.Size = new System.Drawing.Size(618, 10);
			// 
			// textBoxUri
			// 
			this.textBoxUri.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxUri.Location = new System.Drawing.Point(16, 245);
			this.textBoxUri.Name = "textBoxUri";
			this.textBoxUri.Size = new System.Drawing.Size(618, 30);
			this.textBoxUri.TabIndex = 25;
			this.textBoxUri.Text = "https://wisej.com";
			// 
			// spacer4
			// 
			this.spacer4.Dock = Wisej.Web.DockStyle.Top;
			this.spacer4.Location = new System.Drawing.Point(16, 322);
			this.spacer4.Name = "spacer4";
			this.spacer4.Size = new System.Drawing.Size(618, 40);
			// 
			// buttonFiles
			// 
			this.buttonFiles.Dock = Wisej.Web.DockStyle.Top;
			this.buttonFiles.Location = new System.Drawing.Point(16, 362);
			this.buttonFiles.Name = "buttonFiles";
			this.buttonFiles.Size = new System.Drawing.Size(618, 37);
			this.buttonFiles.TabIndex = 30;
			this.buttonFiles.Text = "Share Files";
			this.buttonFiles.Click += new System.EventHandler(this.buttonFiles_Click);
			// 
			// Sharing
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonFiles);
			this.Controls.Add(this.spacer4);
			this.Controls.Add(this.buttonUri);
			this.Controls.Add(this.spacer3);
			this.Controls.Add(this.textBoxUri);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.buttonText);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.textBoxText);
			this.Name = "Sharing";
			this.Controls.SetChildIndex(this.textBoxText, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonText, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.textBoxUri, 0);
			this.Controls.SetChildIndex(this.spacer3, 0);
			this.Controls.SetChildIndex(this.buttonUri, 0);
			this.Controls.SetChildIndex(this.spacer4, 0);
			this.Controls.SetChildIndex(this.buttonFiles, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.TextBox textBoxText;
		private Web.Button buttonText;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
		private Web.Button buttonUri;
		private Web.Spacer spacer3;
		private Web.TextBox textBoxUri;
		private Web.Spacer spacer4;
		private Web.Button buttonFiles;
	}
}
