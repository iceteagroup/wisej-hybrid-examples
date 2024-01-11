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
			this.tagTextBoxTo = new Wisej.Web.TagTextBox();
			this.tagTextBoxCC = new Wisej.Web.TagTextBox();
			this.textBoxBody = new Wisej.Web.TextBox();
			this.buttonCompose = new Wisej.Web.Button();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxSubject
			// 
			this.flowLayoutPanel1.SetFillWeight(this.textBoxSubject, 1);
			this.textBoxSubject.LabelText = "Subject";
			this.textBoxSubject.Location = new System.Drawing.Point(3, 82);
			this.textBoxSubject.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.textBoxSubject.Name = "textBoxSubject";
			this.textBoxSubject.Size = new System.Drawing.Size(300, 55);
			this.textBoxSubject.TabIndex = 19;
			this.textBoxSubject.Text = "Hello";
			// 
			// tagTextBoxTo
			// 
			this.tagTextBoxTo.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.tagTextBoxTo, 1);
			this.tagTextBoxTo.LabelText = "To";
			this.tagTextBoxTo.Location = new System.Drawing.Point(3, 3);
			this.tagTextBoxTo.Name = "tagTextBoxTo";
			this.tagTextBoxTo.Size = new System.Drawing.Size(300, 60);
			this.tagTextBoxTo.TabIndex = 21;
			this.tagTextBoxTo.Text = "john@doe.com,jane@doe.com";
			// 
			// tagTextBoxCC
			// 
			this.tagTextBoxCC.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.tagTextBoxCC, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.tagTextBoxCC, true);
			this.tagTextBoxCC.LabelText = "CC";
			this.tagTextBoxCC.Location = new System.Drawing.Point(309, 3);
			this.tagTextBoxCC.Name = "tagTextBoxCC";
			this.tagTextBoxCC.Size = new System.Drawing.Size(300, 60);
			this.tagTextBoxCC.TabIndex = 24;
			this.tagTextBoxCC.Text = "info@doe.com";
			// 
			// textBoxBody
			// 
			this.flowLayoutPanel1.SetFillWeight(this.textBoxBody, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.textBoxBody, true);
			this.textBoxBody.LabelText = "Body";
			this.textBoxBody.Location = new System.Drawing.Point(309, 82);
			this.textBoxBody.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.textBoxBody.Name = "textBoxBody";
			this.textBoxBody.Size = new System.Drawing.Size(300, 55);
			this.textBoxBody.TabIndex = 27;
			this.textBoxBody.Text = "Hello, World!";
			// 
			// buttonCompose
			// 
			this.flowLayoutPanel1.SetFillWeight(this.buttonCompose, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.buttonCompose, true);
			this.buttonCompose.Location = new System.Drawing.Point(3, 156);
			this.buttonCompose.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.buttonCompose.Name = "buttonCompose";
			this.buttonCompose.Size = new System.Drawing.Size(606, 37);
			this.buttonCompose.TabIndex = 30;
			this.buttonCompose.Text = "Compose";
			this.buttonCompose.Click += new System.EventHandler(this.buttonCompose_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
			this.flowLayoutPanel1.Controls.Add(this.tagTextBoxTo);
			this.flowLayoutPanel1.Controls.Add(this.tagTextBoxCC);
			this.flowLayoutPanel1.Controls.Add(this.textBoxSubject);
			this.flowLayoutPanel1.Controls.Add(this.textBoxBody);
			this.flowLayoutPanel1.Controls.Add(this.buttonCompose);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(19, 74);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.ScrollBars = Wisej.Web.ScrollBars.Hidden;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(612, 331);
			this.flowLayoutPanel1.TabIndex = 35;
			// 
			// Email
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
			this.Hint = "Compose emails within the application.";
			this.Name = "Email";
			this.Load += new System.EventHandler(this.Email_Load);
			this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.TextBox textBoxSubject;
		private Web.TagTextBox tagTextBoxTo;
		private Web.TagTextBox tagTextBoxCC;
		private Web.TextBox textBoxBody;
		private Web.Button buttonCompose;
		private Web.FlowLayoutPanel flowLayoutPanel1;
	}
}
