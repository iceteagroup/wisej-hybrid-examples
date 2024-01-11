namespace Wisej.Hybrid.Features.Panels
{
	partial class Sms
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
			this.tagTextBoxRecipients = new Wisej.Web.TagTextBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.textBoxBody = new Wisej.Web.TextBox();
			this.spacer2 = new Wisej.Web.Spacer();
			this.buttonCompose = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// tagTextBoxRecipients
			// 
			this.tagTextBoxRecipients.AutoSize = false;
			this.tagTextBoxRecipients.Dock = Wisej.Web.DockStyle.Top;
			this.tagTextBoxRecipients.LabelText = "Recipients";
			this.tagTextBoxRecipients.Location = new System.Drawing.Point(16, 68);
			this.tagTextBoxRecipients.MaxTagWidth = 150;
			this.tagTextBoxRecipients.Name = "tagTextBoxRecipients";
			this.tagTextBoxRecipients.Size = new System.Drawing.Size(618, 60);
			this.tagTextBoxRecipients.TabIndex = 19;
			this.tagTextBoxRecipients.Text = "123-456-7890,234-567-8910";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 128);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 16);
			// 
			// textBoxBody
			// 
			this.textBoxBody.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxBody.LabelText = "Body";
			this.textBoxBody.Location = new System.Drawing.Point(16, 144);
			this.textBoxBody.Name = "textBoxBody";
			this.textBoxBody.Size = new System.Drawing.Size(618, 55);
			this.textBoxBody.TabIndex = 21;
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 199);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 16);
			// 
			// buttonCompose
			// 
			this.buttonCompose.Dock = Wisej.Web.DockStyle.Top;
			this.buttonCompose.Location = new System.Drawing.Point(16, 215);
			this.buttonCompose.Name = "buttonCompose";
			this.buttonCompose.Size = new System.Drawing.Size(618, 37);
			this.buttonCompose.TabIndex = 24;
			this.buttonCompose.Text = "Compose";
			this.buttonCompose.Click += new System.EventHandler(this.buttonCompose_Click);
			// 
			// Sms
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonCompose);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.textBoxBody);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.tagTextBoxRecipients);
			this.Hint = "Compose SMS messages.";
			this.Name = "Sms";
			this.Load += new System.EventHandler(this.Sms_Load);
			this.Controls.SetChildIndex(this.tagTextBoxRecipients, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.textBoxBody, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.buttonCompose, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.TagTextBox tagTextBoxRecipients;
		private Web.Spacer spacer1;
		private Web.TextBox textBoxBody;
		private Web.Spacer spacer2;
		private Web.Button buttonCompose;
	}
}
