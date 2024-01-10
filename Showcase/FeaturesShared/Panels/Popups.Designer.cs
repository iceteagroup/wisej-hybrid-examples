namespace Wisej.Hybrid.Features.Panels
{
	partial class Popups
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
			this.buttonShow = new Wisej.Web.Button();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.groupBox1 = new Wisej.Web.GroupBox();
			this.textBoxOption1 = new Wisej.Web.TextBox();
			this.textBoxOption2 = new Wisej.Web.TextBox();
			this.textBoxOption3 = new Wisej.Web.TextBox();
			this.comboBoxPopupType = new Wisej.Web.ComboBox();
			this.textBoxMessage = new Wisej.Web.TextBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.spacer3 = new Wisej.Web.Spacer();
			this.spacer4 = new Wisej.Web.Spacer();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonShow
			// 
			this.buttonShow.Dock = Wisej.Web.DockStyle.Top;
			this.buttonShow.Location = new System.Drawing.Point(16, 492);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(618, 40);
			this.buttonShow.TabIndex = 2;
			this.buttonShow.Text = "Show";
			this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.AutoSize = false;
			this.textBoxTitle.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxTitle.Location = new System.Drawing.Point(16, 128);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(618, 40);
			this.textBoxTitle.TabIndex = 0;
			this.textBoxTitle.Text = "Title";
			this.textBoxTitle.Watermark = "Message";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxOption1);
			this.groupBox1.Controls.Add(this.textBoxOption2);
			this.groupBox1.Controls.Add(this.textBoxOption3);
			this.groupBox1.Dock = Wisej.Web.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(16, 248);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(618, 164);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.Text = "Options";
			// 
			// textBoxOption1
			// 
			this.textBoxOption1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxOption1.AutoSize = false;
			this.textBoxOption1.Location = new System.Drawing.Point(6, 36);
			this.textBoxOption1.Name = "textBoxOption1";
			this.textBoxOption1.Size = new System.Drawing.Size(606, 30);
			this.textBoxOption1.TabIndex = 1;
			this.textBoxOption1.Text = "John";
			this.textBoxOption1.Watermark = "Text";
			// 
			// textBoxOption2
			// 
			this.textBoxOption2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxOption2.AutoSize = false;
			this.textBoxOption2.Location = new System.Drawing.Point(6, 80);
			this.textBoxOption2.Name = "textBoxOption2";
			this.textBoxOption2.Size = new System.Drawing.Size(606, 30);
			this.textBoxOption2.TabIndex = 4;
			this.textBoxOption2.Text = "Jane";
			this.textBoxOption2.Watermark = "Text";
			// 
			// textBoxOption3
			// 
			this.textBoxOption3.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxOption3.AutoSize = false;
			this.textBoxOption3.Location = new System.Drawing.Point(6, 124);
			this.textBoxOption3.Name = "textBoxOption3";
			this.textBoxOption3.Size = new System.Drawing.Size(606, 30);
			this.textBoxOption3.TabIndex = 7;
			this.textBoxOption3.Text = "Jenny";
			this.textBoxOption3.Watermark = "Text";
			// 
			// comboBoxPopupType
			// 
			this.comboBoxPopupType.AutoSize = false;
			this.comboBoxPopupType.Dock = Wisej.Web.DockStyle.Top;
			this.comboBoxPopupType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxPopupType.Items.AddRange(new object[] {
            "Alert",
            "Prompt",
            "ActionSheet"});
			this.comboBoxPopupType.Location = new System.Drawing.Point(16, 432);
			this.comboBoxPopupType.Name = "comboBoxPopupType";
			this.comboBoxPopupType.Size = new System.Drawing.Size(618, 40);
			this.comboBoxPopupType.TabIndex = 3;
			this.comboBoxPopupType.Text = "ActionSheet";
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.AutoSize = false;
			this.textBoxMessage.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxMessage.Location = new System.Drawing.Point(16, 188);
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(618, 40);
			this.textBoxMessage.TabIndex = 4;
			this.textBoxMessage.Text = "Message";
			this.textBoxMessage.Watermark = "Message";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 472);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 228);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer3
			// 
			this.spacer3.Dock = Wisej.Web.DockStyle.Top;
			this.spacer3.Location = new System.Drawing.Point(16, 412);
			this.spacer3.Name = "spacer3";
			this.spacer3.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer4
			// 
			this.spacer4.Dock = Wisej.Web.DockStyle.Top;
			this.spacer4.Location = new System.Drawing.Point(16, 168);
			this.spacer4.Name = "spacer4";
			this.spacer4.Size = new System.Drawing.Size(618, 20);
			// 
			// Popups
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonShow);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.comboBoxPopupType);
			this.Controls.Add(this.spacer3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.textBoxMessage);
			this.Controls.Add(this.spacer4);
			this.Controls.Add(this.textBoxTitle);
			this.Name = "Popups";
			this.Size = new System.Drawing.Size(650, 593);
			this.Controls.SetChildIndex(this.textBoxTitle, 0);
			this.Controls.SetChildIndex(this.spacer4, 0);
			this.Controls.SetChildIndex(this.textBoxMessage, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.groupBox1, 0);
			this.Controls.SetChildIndex(this.spacer3, 0);
			this.Controls.SetChildIndex(this.comboBoxPopupType, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonShow, 0);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonShow;
		private Web.TextBox textBoxTitle;
		private Web.GroupBox groupBox1;
		private Web.TextBox textBoxOption3;
		private Web.TextBox textBoxOption2;
		private Web.TextBox textBoxOption1;
		private Web.ComboBox comboBoxPopupType;
		private Web.TextBox textBoxMessage;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
		private Web.Spacer spacer3;
		private Web.Spacer spacer4;
	}
}
