namespace Wisej.Hybrid.Features.Panels
{
	partial class TitleBar
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
			this.textBoxBackColor = new Wisej.Web.TextBox();
			this.textBoxTextColor = new Wisej.Web.TextBox();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.buttonSetTitle = new Wisej.Web.Button();
			this.checkBoxVisible = new Wisej.Web.CheckBox();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxBackColor
			// 
			this.flowLayoutPanel1.SetFillWeight(this.textBoxBackColor, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.textBoxBackColor, true);
			this.textBoxBackColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxBackColor.LabelText = "Background Color";
			this.textBoxBackColor.Location = new System.Drawing.Point(312, 59);
			this.textBoxBackColor.Name = "textBoxBackColor";
			this.textBoxBackColor.Size = new System.Drawing.Size(303, 55);
			this.textBoxBackColor.TabIndex = 19;
			this.textBoxBackColor.Text = "#FFFFFF";
			this.textBoxBackColor.TextChanged += new System.EventHandler(this.textBoxBackColor_TextChanged);
			// 
			// textBoxTextColor
			// 
			this.flowLayoutPanel1.SetFillWeight(this.textBoxTextColor, 1);
			this.textBoxTextColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxTextColor.LabelText = "Text Color";
			this.textBoxTextColor.Location = new System.Drawing.Point(3, 59);
			this.textBoxTextColor.Name = "textBoxTextColor";
			this.textBoxTextColor.Size = new System.Drawing.Size(303, 55);
			this.textBoxTextColor.TabIndex = 20;
			this.textBoxTextColor.Text = "#FFFFFF";
			this.textBoxTextColor.TextChanged += new System.EventHandler(this.textBoxTextColor_TextChanged);
			// 
			// textBoxTitle
			// 
			this.flowLayoutPanel1.SetFillWeight(this.textBoxTitle, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.textBoxTitle, true);
			this.textBoxTitle.LabelText = "Title";
			this.textBoxTitle.Location = new System.Drawing.Point(3, 120);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(612, 55);
			this.textBoxTitle.TabIndex = 24;
			this.textBoxTitle.Text = "Wisej.NET";
			// 
			// buttonSetTitle
			// 
			this.flowLayoutPanel1.SetFillWeight(this.buttonSetTitle, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.buttonSetTitle, true);
			this.buttonSetTitle.Location = new System.Drawing.Point(3, 194);
			this.buttonSetTitle.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.buttonSetTitle.Name = "buttonSetTitle";
			this.buttonSetTitle.Size = new System.Drawing.Size(612, 37);
			this.buttonSetTitle.TabIndex = 25;
			this.buttonSetTitle.Text = "Set Title";
			this.buttonSetTitle.Click += new System.EventHandler(this.buttonSetTitle_Click);
			// 
			// checkBoxVisible
			// 
			this.checkBoxVisible.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxVisible.AutoSize = false;
			this.checkBoxVisible.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxVisible, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxVisible, true);
			this.checkBoxVisible.Location = new System.Drawing.Point(3, 3);
			this.checkBoxVisible.Name = "checkBoxVisible";
			this.checkBoxVisible.Size = new System.Drawing.Size(612, 50);
			this.checkBoxVisible.TabIndex = 31;
			this.checkBoxVisible.Text = "Visible";
			this.checkBoxVisible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxVisible.CheckedChanged += new System.EventHandler(this.checkBoxVisible_CheckedChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.checkBoxVisible);
			this.flowLayoutPanel1.Controls.Add(this.textBoxTextColor);
			this.flowLayoutPanel1.Controls.Add(this.textBoxBackColor);
			this.flowLayoutPanel1.Controls.Add(this.textBoxTitle);
			this.flowLayoutPanel1.Controls.Add(this.buttonSetTitle);
			this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 68);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 410);
			this.flowLayoutPanel1.TabIndex = 32;
			// 
			// TitleBar
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
			this.Name = "TitleBar";
			this.Appear += new System.EventHandler(this.TitleBar_Appear);
			this.Disappear += new System.EventHandler(this.TitleBar_Disappear);
			this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Web.TextBox textBoxBackColor;
		private Web.TextBox textBoxTextColor;
		private Web.TextBox textBoxTitle;
		private Web.Button buttonSetTitle;
        private Web.CheckBox checkBoxVisible;
		private Web.FlowLayoutPanel flowLayoutPanel1;
	}
}
