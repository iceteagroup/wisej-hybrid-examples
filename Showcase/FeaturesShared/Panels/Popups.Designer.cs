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
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.groupBox1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonShow
			// 
			this.flowLayoutPanel1.SetFillWeight(this.buttonShow, 1);
			this.buttonShow.Location = new System.Drawing.Point(312, 216);
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new System.Drawing.Size(303, 37);
			this.buttonShow.TabIndex = 2;
			this.buttonShow.Text = "Show";
			this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.textBoxTitle, 1);
			this.textBoxTitle.Location = new System.Drawing.Point(3, 3);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(303, 37);
			this.textBoxTitle.TabIndex = 0;
			this.textBoxTitle.Text = "Title";
			this.textBoxTitle.Watermark = "Message";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBoxOption1);
			this.groupBox1.Controls.Add(this.textBoxOption2);
			this.groupBox1.Controls.Add(this.textBoxOption3);
			this.flowLayoutPanel1.SetFillWeight(this.groupBox1, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.groupBox1, true);
			this.groupBox1.Location = new System.Drawing.Point(3, 46);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(612, 164);
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
			this.textBoxOption1.Size = new System.Drawing.Size(600, 30);
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
			this.textBoxOption2.Size = new System.Drawing.Size(600, 30);
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
			this.textBoxOption3.Size = new System.Drawing.Size(600, 30);
			this.textBoxOption3.TabIndex = 7;
			this.textBoxOption3.Text = "Jenny";
			this.textBoxOption3.Watermark = "Text";
			// 
			// comboBoxPopupType
			// 
			this.comboBoxPopupType.AutoSize = false;
			this.comboBoxPopupType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.flowLayoutPanel1.SetFillWeight(this.comboBoxPopupType, 1);
			this.comboBoxPopupType.Items.AddRange(new object[] {
            "Alert",
            "Prompt",
            "ActionSheet"});
			this.comboBoxPopupType.Location = new System.Drawing.Point(3, 216);
			this.comboBoxPopupType.Name = "comboBoxPopupType";
			this.comboBoxPopupType.Size = new System.Drawing.Size(303, 37);
			this.comboBoxPopupType.TabIndex = 3;
			this.comboBoxPopupType.Text = "ActionSheet";
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.textBoxMessage, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.textBoxMessage, true);
			this.textBoxMessage.Location = new System.Drawing.Point(312, 3);
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(303, 37);
			this.textBoxMessage.TabIndex = 4;
			this.textBoxMessage.Text = "Message";
			this.textBoxMessage.Watermark = "Message";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
			this.flowLayoutPanel1.Controls.Add(this.textBoxTitle);
			this.flowLayoutPanel1.Controls.Add(this.textBoxMessage);
			this.flowLayoutPanel1.Controls.Add(this.groupBox1);
			this.flowLayoutPanel1.Controls.Add(this.comboBoxPopupType);
			this.flowLayoutPanel1.Controls.Add(this.buttonShow);
			this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 68);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.ScrollBars = Wisej.Web.ScrollBars.Hidden;
			this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 410);
			this.flowLayoutPanel1.TabIndex = 25;
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
			this.Controls.Add(this.flowLayoutPanel1);
			this.Hint = "Show native device popups.";
			this.Name = "Popups";
			this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
			this.groupBox1.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
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
		private Web.FlowLayoutPanel flowLayoutPanel1;
	}
}
