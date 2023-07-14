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
			this.spacer1 = new Wisej.Web.Spacer();
			this.spacer2 = new Wisej.Web.Spacer();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.buttonSetTitle = new Wisej.Web.Button();
			this.spacer3 = new Wisej.Web.Spacer();
			this.spacer4 = new Wisej.Web.Spacer();
			this.checkBoxVisible = new Wisej.Web.CheckBox();
			this.SuspendLayout();
			// 
			// textBoxBackColor
			// 
			this.textBoxBackColor.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxBackColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxBackColor.LabelText = "Background Color";
			this.textBoxBackColor.Location = new System.Drawing.Point(16, 198);
			this.textBoxBackColor.Name = "textBoxBackColor";
			this.textBoxBackColor.Size = new System.Drawing.Size(618, 50);
			this.textBoxBackColor.TabIndex = 19;
			this.textBoxBackColor.Text = "#FFFFFF";
			this.textBoxBackColor.TextChanged += new System.EventHandler(this.textBoxBackColor_TextChanged);
			// 
			// textBoxTextColor
			// 
			this.textBoxTextColor.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxTextColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxTextColor.LabelText = "Text Color";
			this.textBoxTextColor.Location = new System.Drawing.Point(16, 268);
			this.textBoxTextColor.Name = "textBoxTextColor";
			this.textBoxTextColor.Size = new System.Drawing.Size(618, 50);
			this.textBoxTextColor.TabIndex = 20;
			this.textBoxTextColor.Text = "#FFFFFF";
			this.textBoxTextColor.TextChanged += new System.EventHandler(this.textBoxTextColor_TextChanged);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 248);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 318);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxTitle.LabelText = "Title";
			this.textBoxTitle.Location = new System.Drawing.Point(16, 338);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(618, 50);
			this.textBoxTitle.TabIndex = 24;
			this.textBoxTitle.Text = "Wisej.NET";
			// 
			// buttonSetTitle
			// 
			this.buttonSetTitle.Dock = Wisej.Web.DockStyle.Top;
			this.buttonSetTitle.Location = new System.Drawing.Point(16, 408);
			this.buttonSetTitle.Name = "buttonSetTitle";
			this.buttonSetTitle.Size = new System.Drawing.Size(618, 37);
			this.buttonSetTitle.TabIndex = 25;
			this.buttonSetTitle.Text = "Set Title";
			this.buttonSetTitle.Click += new System.EventHandler(this.buttonSetTitle_Click);
			// 
			// spacer3
			// 
			this.spacer3.Dock = Wisej.Web.DockStyle.Top;
			this.spacer3.Location = new System.Drawing.Point(16, 388);
			this.spacer3.Name = "spacer3";
			this.spacer3.Size = new System.Drawing.Size(618, 20);
			// 
			// spacer4
			// 
			this.spacer4.Dock = Wisej.Web.DockStyle.Top;
			this.spacer4.Location = new System.Drawing.Point(16, 178);
			this.spacer4.Name = "spacer4";
			this.spacer4.Size = new System.Drawing.Size(618, 20);
			// 
			// checkBoxVisible
			// 
			this.checkBoxVisible.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxVisible.AutoSize = false;
			this.checkBoxVisible.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxVisible.Dock = Wisej.Web.DockStyle.Top;
			this.checkBoxVisible.Location = new System.Drawing.Point(16, 128);
			this.checkBoxVisible.Name = "checkBoxVisible";
			this.checkBoxVisible.Size = new System.Drawing.Size(618, 50);
			this.checkBoxVisible.TabIndex = 31;
			this.checkBoxVisible.Text = "Visible";
			this.checkBoxVisible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxVisible.CheckedChanged += new System.EventHandler(this.checkBoxVisible_CheckedChanged);
			// 
			// Title
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonSetTitle);
			this.Controls.Add(this.spacer3);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.textBoxTextColor);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.textBoxBackColor);
			this.Controls.Add(this.spacer4);
			this.Controls.Add(this.checkBoxVisible);
			this.Name = "Title";
			this.Load += new System.EventHandler(this.Title_Load);
			this.Disposed += new System.EventHandler(this.Title_Disposed);
			this.Controls.SetChildIndex(this.checkBoxVisible, 0);
			this.Controls.SetChildIndex(this.spacer4, 0);
			this.Controls.SetChildIndex(this.textBoxBackColor, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.textBoxTextColor, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.textBoxTitle, 0);
			this.Controls.SetChildIndex(this.spacer3, 0);
			this.Controls.SetChildIndex(this.buttonSetTitle, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.TextBox textBoxBackColor;
		private Web.TextBox textBoxTextColor;
		private Web.Spacer spacer1;
		private Web.Spacer spacer2;
		private Web.TextBox textBoxTitle;
		private Web.Button buttonSetTitle;
		private Web.Spacer spacer3;
        private Web.Spacer spacer4;
        private Web.CheckBox checkBoxVisible;
    }
}
