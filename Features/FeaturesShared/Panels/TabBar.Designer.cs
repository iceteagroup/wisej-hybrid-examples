namespace Wisej.Hybrid.Features.Panels
{
	partial class TabBar
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
			this.textBoxSelectedColor = new Wisej.Web.TextBox();
			this.label1 = new Wisej.Web.Label();
			this.barButton1 = new Wisej.Hybrid.Features.Panels.BarButton();
			this.flowLayoutPanelItems = new Wisej.Web.FlowLayoutPanel();
			this.barButton2 = new Wisej.Hybrid.Features.Panels.BarButton();
			this.barButton3 = new Wisej.Hybrid.Features.Panels.BarButton();
			this.barButton4 = new Wisej.Hybrid.Features.Panels.BarButton();
			this.buttonUpdate = new Wisej.Web.Button();
			this.textBoxUnselectedColor = new Wisej.Web.TextBox();
			this.textBoxBackColor = new Wisej.Web.TextBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.panel1 = new Wisej.Web.Panel();
			this.flowLayoutPanelItems.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// checkBoxVisible
			// 
			this.checkBoxVisible.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxVisible.AutoSize = false;
			this.checkBoxVisible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxVisible.Dock = Wisej.Web.DockStyle.Top;
			this.checkBoxVisible.Focusable = false;
			this.checkBoxVisible.Location = new System.Drawing.Point(16, 128);
			this.checkBoxVisible.MinimumSize = new System.Drawing.Size(180, 0);
			this.checkBoxVisible.Name = "checkBoxVisible";
			this.checkBoxVisible.Size = new System.Drawing.Size(618, 40);
			this.checkBoxVisible.TabIndex = 1;
			this.checkBoxVisible.Text = "Visible";
			this.checkBoxVisible.CheckedChanged += new System.EventHandler(this.checkBoxVisible_CheckedChanged);
			// 
			// textBoxSelectedColor
			// 
			this.textBoxSelectedColor.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.textBoxSelectedColor.AutoSize = false;
			this.textBoxSelectedColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxSelectedColor.Location = new System.Drawing.Point(576, 9);
			this.textBoxSelectedColor.Name = "textBoxSelectedColor";
			this.textBoxSelectedColor.Size = new System.Drawing.Size(34, 34);
			this.textBoxSelectedColor.TabIndex = 3;
			this.textBoxSelectedColor.TextChanged += new System.EventHandler(this.textBoxSelectedColor_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 33);
			this.label1.TabIndex = 4;
			this.label1.Text = "Colors";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// barButton1
			// 
			this.barButton1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.barButton1, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.barButton1, true);
			this.barButton1.IconSource = "resource.wx/FeaturesShared/Images/Icons/Home.png";
			this.barButton1.Label = "Home";
			this.barButton1.Location = new System.Drawing.Point(3, 3);
			this.barButton1.Name = "barButton1";
			this.barButton1.Show = true;
			this.barButton1.Size = new System.Drawing.Size(612, 50);
			this.barButton1.TabIndex = 5;
			// 
			// flowLayoutPanelItems
			// 
			this.flowLayoutPanelItems.Controls.Add(this.barButton1);
			this.flowLayoutPanelItems.Controls.Add(this.barButton2);
			this.flowLayoutPanelItems.Controls.Add(this.barButton3);
			this.flowLayoutPanelItems.Controls.Add(this.barButton4);
			this.flowLayoutPanelItems.Dock = Wisej.Web.DockStyle.Top;
			this.flowLayoutPanelItems.Location = new System.Drawing.Point(16, 220);
			this.flowLayoutPanelItems.Name = "flowLayoutPanelItems";
			this.flowLayoutPanelItems.Size = new System.Drawing.Size(618, 240);
			this.flowLayoutPanelItems.TabIndex = 6;
			this.flowLayoutPanelItems.Text = "Buttons";
			// 
			// barButton2
			// 
			this.barButton2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.barButton2, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.barButton2, true);
			this.barButton2.IconSource = "resource.wx/FeaturesShared/Images/Icons/Edit.png";
			this.barButton2.Label = "Options";
			this.barButton2.Location = new System.Drawing.Point(3, 59);
			this.barButton2.Name = "barButton2";
			this.barButton2.Show = true;
			this.barButton2.Size = new System.Drawing.Size(612, 50);
			this.barButton2.TabIndex = 6;
			// 
			// barButton3
			// 
			this.barButton3.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.barButton3, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.barButton3, true);
			this.barButton3.IconSource = "resource.wx/FeaturesShared/Images/Icons/Settings.png";
			this.barButton3.Label = "Settings";
			this.barButton3.Location = new System.Drawing.Point(3, 115);
			this.barButton3.Name = "barButton3";
			this.barButton3.Show = true;
			this.barButton3.Size = new System.Drawing.Size(612, 50);
			this.barButton3.TabIndex = 7;
			// 
			// barButton4
			// 
			this.barButton4.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.barButton4, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.barButton4, true);
			this.barButton4.IconSource = "resource.wx/FeaturesShared/Images/Icons/More.png";
			this.barButton4.Label = "More";
			this.barButton4.Location = new System.Drawing.Point(3, 171);
			this.barButton4.Name = "barButton4";
			this.barButton4.Show = true;
			this.barButton4.Size = new System.Drawing.Size(612, 50);
			this.barButton4.TabIndex = 8;
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Dock = Wisej.Web.DockStyle.Top;
			this.buttonUpdate.Location = new System.Drawing.Point(16, 480);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(618, 40);
			this.buttonUpdate.TabIndex = 7;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// textBoxUnselectedColor
			// 
			this.textBoxUnselectedColor.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.textBoxUnselectedColor.AutoSize = false;
			this.textBoxUnselectedColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxUnselectedColor.Location = new System.Drawing.Point(536, 9);
			this.textBoxUnselectedColor.Name = "textBoxUnselectedColor";
			this.textBoxUnselectedColor.Size = new System.Drawing.Size(34, 34);
			this.textBoxUnselectedColor.TabIndex = 8;
			this.textBoxUnselectedColor.TextChanged += new System.EventHandler(this.textBoxUnselectedColor_TextChanged);
			// 
			// textBoxBackColor
			// 
			this.textBoxBackColor.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.textBoxBackColor.AutoSize = false;
			this.textBoxBackColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxBackColor.Location = new System.Drawing.Point(496, 9);
			this.textBoxBackColor.Name = "textBoxBackColor";
			this.textBoxBackColor.Size = new System.Drawing.Size(34, 34);
			this.textBoxBackColor.TabIndex = 9;
			this.textBoxBackColor.TextChanged += new System.EventHandler(this.textBoxBackColor_TextChanged);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 460);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBoxBackColor);
			this.panel1.Controls.Add(this.textBoxUnselectedColor);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBoxSelectedColor);
			this.panel1.Dock = Wisej.Web.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(16, 168);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(618, 52);
			this.panel1.TabIndex = 20;
			// 
			// TabBar
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.AutoScroll = true;
			this.AutoScrollMinSize = new System.Drawing.Size(0, 20);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.flowLayoutPanelItems);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.checkBoxVisible);
			this.Name = "TabBar";
			this.Size = new System.Drawing.Size(650, 532);
			this.Appear += new System.EventHandler(this.TabBar_Appear);
			this.Disappear += new System.EventHandler(this.TabBar_Disappear);
			this.Controls.SetChildIndex(this.checkBoxVisible, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.flowLayoutPanelItems, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.flowLayoutPanelItems.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.CheckBox checkBoxVisible;
		private Web.TextBox textBoxSelectedColor;
		private Web.Label label1;
		private BarButton barButton1;
		private Web.FlowLayoutPanel flowLayoutPanelItems;
		private BarButton barButton4;
		private BarButton barButton3;
		private BarButton barButton2;
		private Web.Button buttonUpdate;
		private Web.TextBox textBoxUnselectedColor;
		private Web.TextBox textBoxBackColor;
		private Web.Spacer spacer1;
		private Web.Panel panel1;
	}
}
