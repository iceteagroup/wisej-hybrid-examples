namespace Wisej.Hybrid.Features.Panels
{
	partial class Email
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
			this.textBoxSubject = new Wisej.Web.TextBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.tagTextBoxTo = new Wisej.Web.TagTextBox();
			this.spacer2 = new Wisej.Web.Spacer();
			this.tagTextBoxCC = new Wisej.Web.TagTextBox();
			this.spacer3 = new Wisej.Web.Spacer();
			this.textBoxBody = new Wisej.Web.TextBox();
			this.spacer4 = new Wisej.Web.Spacer();
			this.buttonCompose = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// textBoxSubject
			// 
			this.textBoxSubject.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxSubject.LabelText = "Subject";
			this.textBoxSubject.Location = new System.Drawing.Point(16, 268);
			this.textBoxSubject.Name = "textBoxSubject";
			this.textBoxSubject.Size = new System.Drawing.Size(618, 55);
			this.textBoxSubject.TabIndex = 19;
			this.textBoxSubject.Text = "Hello";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 188);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 10);
			// 
			// tagTextBoxTo
			// 
			this.tagTextBoxTo.AutoSize = false;
			this.tagTextBoxTo.Dock = Wisej.Web.DockStyle.Top;
			this.tagTextBoxTo.LabelText = "To";
			this.tagTextBoxTo.Location = new System.Drawing.Point(16, 128);
			this.tagTextBoxTo.Name = "tagTextBoxTo";
			this.tagTextBoxTo.Size = new System.Drawing.Size(618, 60);
			this.tagTextBoxTo.TabIndex = 21;
			this.tagTextBoxTo.Text = "john@doe.com,jane@doe.com";
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 323);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 10);
			// 
			// tagTextBoxCC
			// 
			this.tagTextBoxCC.AutoSize = false;
			this.tagTextBoxCC.Dock = Wisej.Web.DockStyle.Top;
			this.tagTextBoxCC.LabelText = "CC";
			this.tagTextBoxCC.Location = new System.Drawing.Point(16, 198);
			this.tagTextBoxCC.Name = "tagTextBoxCC";
			this.tagTextBoxCC.Size = new System.Drawing.Size(618, 60);
			this.tagTextBoxCC.TabIndex = 24;
			this.tagTextBoxCC.Text = "info@doe.com";
			// 
			// spacer3
			// 
			this.spacer3.Dock = Wisej.Web.DockStyle.Top;
			this.spacer3.Location = new System.Drawing.Point(16, 258);
			this.spacer3.Name = "spacer3";
			this.spacer3.Size = new System.Drawing.Size(618, 10);
			// 
			// textBoxBody
			// 
			this.textBoxBody.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxBody.LabelText = "Body";
			this.textBoxBody.Location = new System.Drawing.Point(16, 333);
			this.textBoxBody.Name = "textBoxBody";
			this.textBoxBody.Size = new System.Drawing.Size(618, 55);
			this.textBoxBody.TabIndex = 27;
			this.textBoxBody.Text = "Hello, World!";
			// 
			// spacer4
			// 
			this.spacer4.Dock = Wisej.Web.DockStyle.Top;
			this.spacer4.Location = new System.Drawing.Point(16, 388);
			this.spacer4.Name = "spacer4";
			this.spacer4.Size = new System.Drawing.Size(618, 10);
			// 
			// buttonCompose
			// 
			this.buttonCompose.Dock = Wisej.Web.DockStyle.Top;
			this.buttonCompose.Location = new System.Drawing.Point(16, 398);
			this.buttonCompose.Name = "buttonCompose";
			this.buttonCompose.Size = new System.Drawing.Size(618, 37);
			this.buttonCompose.TabIndex = 30;
			this.buttonCompose.Text = "Compose";
			this.buttonCompose.Click += new System.EventHandler(this.buttonCompose_Click);
			// 
			// Email
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonCompose);
			this.Controls.Add(this.spacer4);
			this.Controls.Add(this.textBoxBody);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.textBoxSubject);
			this.Controls.Add(this.spacer3);
			this.Controls.Add(this.tagTextBoxCC);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.tagTextBoxTo);
			this.Name = "Email";
			this.Load += new System.EventHandler(this.Email_Load);
			this.Controls.SetChildIndex(this.tagTextBoxTo, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.tagTextBoxCC, 0);
			this.Controls.SetChildIndex(this.spacer3, 0);
			this.Controls.SetChildIndex(this.textBoxSubject, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.textBoxBody, 0);
			this.Controls.SetChildIndex(this.spacer4, 0);
			this.Controls.SetChildIndex(this.buttonCompose, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.TextBox textBoxSubject;
		private Web.Spacer spacer1;
		private Web.TagTextBox tagTextBoxTo;
		private Web.Spacer spacer2;
		private Web.TagTextBox tagTextBoxCC;
		private Web.Spacer spacer3;
		private Web.TextBox textBoxBody;
		private Web.Spacer spacer4;
		private Web.Button buttonCompose;
	}
}
