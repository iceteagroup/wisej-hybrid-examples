﻿namespace Wisej.Hybrid.Features.Panels
{
	partial class Toolbar
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
			this.buttonUpdate = new Wisej.Web.Button();
			this.spacer1 = new Wisej.Web.Spacer();
			this.flowLayoutPanelItems = new Wisej.Web.FlowLayoutPanel();
			this.barButton1 = new Wisej.Hybrid.Features.Panels.BarButton();
			this.barButton2 = new Wisej.Hybrid.Features.Panels.BarButton();
			this.barButton3 = new Wisej.Hybrid.Features.Panels.BarButton();
			this.barButton4 = new Wisej.Hybrid.Features.Panels.BarButton();
			this.panel1 = new Wisej.Web.Panel();
			this.textBoxForeColor = new Wisej.Web.TextBox();
			this.label1 = new Wisej.Web.Label();
			this.checkBoxVisible = new Wisej.Web.CheckBox();
			this.textBoxBackColor = new Wisej.Web.TextBox();
			this.flowLayoutPanelItems.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Dock = Wisej.Web.DockStyle.Top;
			this.buttonUpdate.Location = new System.Drawing.Point(16, 480);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(618, 40);
			this.buttonUpdate.TabIndex = 23;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 460);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
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
			this.flowLayoutPanelItems.TabIndex = 22;
			this.flowLayoutPanelItems.Text = "Buttons";
			// 
			// barButton1
			// 
			this.barButton1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.barButton1, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.barButton1, true);
			this.barButton1.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/home-button.svg";
			this.barButton1.Label = "Home";
			this.barButton1.Location = new System.Drawing.Point(3, 3);
			this.barButton1.Name = "barButton1";
			this.barButton1.Show = true;
			this.barButton1.Size = new System.Drawing.Size(612, 50);
			this.barButton1.TabIndex = 5;
			// 
			// barButton2
			// 
			this.barButton2.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelItems.SetFillWeight(this.barButton2, 1);
			this.flowLayoutPanelItems.SetFlowBreak(this.barButton2, true);
			this.barButton2.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/create-new-pencil-button.svg";
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
			this.barButton3.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/settings-cogwheel-button.svg";
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
			this.barButton4.IconSource = "resource.wx/Wisej.Ext.MaterialDesign/three-dots-more-indicator.svg";
			this.barButton4.Label = "More";
			this.barButton4.Location = new System.Drawing.Point(3, 171);
			this.barButton4.Name = "barButton4";
			this.barButton4.Show = true;
			this.barButton4.Size = new System.Drawing.Size(612, 50);
			this.barButton4.TabIndex = 8;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBoxForeColor);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.textBoxBackColor);
			this.panel1.Dock = Wisej.Web.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(16, 168);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(618, 52);
			this.panel1.TabIndex = 25;
			// 
			// textBoxForeColor
			// 
			this.textBoxForeColor.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.textBoxForeColor.AutoSize = false;
			this.textBoxForeColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxForeColor.Location = new System.Drawing.Point(536, 9);
			this.textBoxForeColor.Name = "textBoxForeColor";
			this.textBoxForeColor.Size = new System.Drawing.Size(34, 34);
			this.textBoxForeColor.TabIndex = 8;
			this.textBoxForeColor.TextChanged += new System.EventHandler(this.foreColor_TextChanged);
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
			// checkBoxVisible
			// 
			this.checkBoxVisible.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxVisible.AutoSize = false;
			this.checkBoxVisible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxVisible.Dock = Wisej.Web.DockStyle.Top;
			this.checkBoxVisible.Location = new System.Drawing.Point(16, 128);
			this.checkBoxVisible.MinimumSize = new System.Drawing.Size(180, 0);
			this.checkBoxVisible.Name = "checkBoxVisible";
			this.checkBoxVisible.Size = new System.Drawing.Size(618, 40);
			this.checkBoxVisible.TabIndex = 21;
			this.checkBoxVisible.Text = "Toolbar Visible";
			this.checkBoxVisible.CheckedChanged += new System.EventHandler(this.checkBoxVisible_CheckedChanged);
			// 
			// textBoxBackColor
			// 
			this.textBoxBackColor.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.textBoxBackColor.AutoSize = false;
			this.textBoxBackColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxBackColor.Location = new System.Drawing.Point(576, 9);
			this.textBoxBackColor.Name = "textBoxBackColor";
			this.textBoxBackColor.Size = new System.Drawing.Size(34, 34);
			this.textBoxBackColor.TabIndex = 3;
			this.textBoxBackColor.TextChanged += new System.EventHandler(this.backColor_TextChanged);
			// 
			// Toolbar
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.flowLayoutPanelItems);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.checkBoxVisible);
			this.Name = "Toolbar";
			this.Size = new System.Drawing.Size(650, 644);
			this.Load += new System.EventHandler(this.Toolbar_Load);
			this.Disposed += new System.EventHandler(this.Toolbar_Disposed);
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

		private Web.Button buttonUpdate;
		private Web.Spacer spacer1;
		private Web.FlowLayoutPanel flowLayoutPanelItems;
		private Panels.BarButton barButton1;
		private Panels.BarButton barButton2;
		private Panels.BarButton barButton3;
		private Panels.BarButton barButton4;
		private Web.Panel panel1;
		private Web.TextBox textBoxForeColor;
		private Web.Label label1;
		private Web.CheckBox checkBoxVisible;
		private Web.TextBox textBoxBackColor;
	}
}
