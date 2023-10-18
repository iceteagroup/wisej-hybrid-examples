namespace Wisej.Hybrid.Features.Panels
{
    partial class Flyout
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
			this.checkBoxVisible = new Wisej.Web.CheckBox();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.textBoxBackgroundColor = new Wisej.Web.TextBox();
			this.label1 = new Wisej.Web.Label();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBoxVisible
			// 
			this.checkBoxVisible.Anchor = Wisej.Web.AnchorStyles.None;
			this.checkBoxVisible.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxVisible.AutoSize = false;
			this.checkBoxVisible.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxVisible.CheckState = Wisej.Web.CheckState.Checked;
			this.flowLayoutPanel1.SetFillWeight(this.checkBoxVisible, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.checkBoxVisible, true);
			this.checkBoxVisible.Location = new System.Drawing.Point(312, 3);
			this.checkBoxVisible.Name = "checkBoxVisible";
			this.checkBoxVisible.Size = new System.Drawing.Size(303, 55);
			this.checkBoxVisible.TabIndex = 19;
			this.checkBoxVisible.Text = "Visible";
			this.checkBoxVisible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxVisible.CheckedChanged += new System.EventHandler(this.checkBoxVisible_CheckedChanged);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.textBoxBackgroundColor);
			this.flowLayoutPanel1.Controls.Add(this.checkBoxVisible);
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 128);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 350);
			this.flowLayoutPanel1.TabIndex = 21;
			// 
			// textBoxBackgroundColor
			// 
			this.flowLayoutPanel1.SetFillWeight(this.textBoxBackgroundColor, 1);
			this.textBoxBackgroundColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxBackgroundColor.LabelText = "Background Color";
			this.textBoxBackgroundColor.Location = new System.Drawing.Point(3, 3);
			this.textBoxBackgroundColor.Name = "textBoxBackgroundColor";
			this.textBoxBackgroundColor.Size = new System.Drawing.Size(303, 55);
			this.textBoxBackgroundColor.TabIndex = 22;
			this.textBoxBackgroundColor.TextChanged += new System.EventHandler(this.textBoxBackgroundColor_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 20);
			this.label1.TabIndex = 23;
			this.label1.Text = "Drag from the left edge of the screen";
			// 
			// Flyout
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
			this.Name = "Flyout";
			this.Appear += new System.EventHandler(this.Flyout_Appear);
			this.Disappear += new System.EventHandler(this.Flyout_Disappear);
			this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private Web.CheckBox checkBoxVisible;
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.TextBox textBoxBackgroundColor;
		private Web.Label label1;
	}
}
