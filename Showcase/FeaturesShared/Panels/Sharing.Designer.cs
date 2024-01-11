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
			this.buttonUri = new Wisej.Web.Button();
			this.textBoxUri = new Wisej.Web.TextBox();
			this.buttonFiles = new Wisej.Web.Button();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxText
			// 
			this.textBoxText.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.textBoxText, 1);
			this.textBoxText.Location = new System.Drawing.Point(3, 3);
			this.textBoxText.Name = "textBoxText";
			this.textBoxText.Size = new System.Drawing.Size(506, 37);
			this.textBoxText.TabIndex = 19;
			this.textBoxText.Text = "Hello, World!";
			// 
			// buttonText
			// 
			this.flowLayoutPanel1.SetFlowBreak(this.buttonText, true);
			this.buttonText.Location = new System.Drawing.Point(515, 3);
			this.buttonText.Name = "buttonText";
			this.buttonText.Size = new System.Drawing.Size(100, 37);
			this.buttonText.TabIndex = 20;
			this.buttonText.Text = "Share Text";
			this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
			// 
			// buttonUri
			// 
			this.flowLayoutPanel1.SetFlowBreak(this.buttonUri, true);
			this.buttonUri.Location = new System.Drawing.Point(515, 59);
			this.buttonUri.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.buttonUri.Name = "buttonUri";
			this.buttonUri.Size = new System.Drawing.Size(100, 37);
			this.buttonUri.TabIndex = 26;
			this.buttonUri.Text = "Share Uri";
			this.buttonUri.Click += new System.EventHandler(this.buttonUri_Click);
			// 
			// textBoxUri
			// 
			this.textBoxUri.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.textBoxUri, 1);
			this.textBoxUri.Location = new System.Drawing.Point(3, 59);
			this.textBoxUri.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.textBoxUri.Name = "textBoxUri";
			this.textBoxUri.Size = new System.Drawing.Size(506, 37);
			this.textBoxUri.TabIndex = 25;
			this.textBoxUri.Text = "https://wisej.com";
			// 
			// buttonFiles
			// 
			this.flowLayoutPanel1.SetFillWeight(this.buttonFiles, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.buttonFiles, true);
			this.buttonFiles.Location = new System.Drawing.Point(3, 115);
			this.buttonFiles.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.buttonFiles.Name = "buttonFiles";
			this.buttonFiles.Size = new System.Drawing.Size(612, 37);
			this.buttonFiles.TabIndex = 30;
			this.buttonFiles.Text = "Share Files";
			this.buttonFiles.Click += new System.EventHandler(this.buttonFiles_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.textBoxText);
			this.flowLayoutPanel1.Controls.Add(this.buttonText);
			this.flowLayoutPanel1.Controls.Add(this.textBoxUri);
			this.flowLayoutPanel1.Controls.Add(this.buttonUri);
			this.flowLayoutPanel1.Controls.Add(this.buttonFiles);
			this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 68);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 410);
			this.flowLayoutPanel1.TabIndex = 35;
			// 
			// Sharing
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Hint = "Share data to other users and apps.";
			this.Name = "Sharing";
			this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.TextBox textBoxText;
		private Web.Button buttonText;
		private Web.Button buttonUri;
		private Web.TextBox textBoxUri;
		private Web.Button buttonFiles;
		private Web.FlowLayoutPanel flowLayoutPanel1;
	}
}
