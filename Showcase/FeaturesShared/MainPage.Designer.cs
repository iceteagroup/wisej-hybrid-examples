namespace Wisej.Hybrid.Features
{
	partial class MainPage
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
			this.components = new System.ComponentModel.Container();
			this.imageList1 = new Wisej.Web.ImageList(this.components);
			this.animation1 = new Wisej.Web.Animation(this.components);
			this.animation2 = new Wisej.Web.Animation(this.components);
			this.panelContainer = new Wisej.Web.Panel();
			this.panelHeader = new Wisej.Web.Panel();
			this.buttonNetwork = new Wisej.Web.Button();
			this.buttonTheme = new Wisej.Web.Button();
			this.buttonBack = new Wisej.Web.Button();
			this.panelHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ImageSize = new System.Drawing.Size(24, 24);
			// 
			// panelContainer
			// 
			this.panelContainer.CssStyle = "transition: left 150ms, width 150ms";
			this.panelContainer.Dock = Wisej.Web.DockStyle.Fill;
			this.panelContainer.Location = new System.Drawing.Point(0, 45);
			this.panelContainer.Name = "panelContainer";
			this.panelContainer.Size = new System.Drawing.Size(1868, 739);
			this.panelContainer.TabIndex = 4;
			this.panelContainer.TabStop = true;
			// 
			// panelHeader
			// 
			this.panelHeader.Controls.Add(this.buttonNetwork);
			this.panelHeader.Controls.Add(this.buttonTheme);
			this.panelHeader.Controls.Add(this.buttonBack);
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1868, 45);
			this.panelHeader.TabIndex = 0;
			this.panelHeader.TabStop = true;
			// 
			// buttonNetwork
			// 
			this.buttonNetwork.BackColor = System.Drawing.Color.Transparent;
			this.buttonNetwork.BorderStyle = Wisej.Web.BorderStyle.Dotted;
			this.buttonNetwork.Dock = Wisej.Web.DockStyle.Right;
			this.buttonNetwork.Focusable = false;
			this.buttonNetwork.Font = new System.Drawing.Font("@default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.buttonNetwork.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/cloud-off.svg";
			this.buttonNetwork.Location = new System.Drawing.Point(1715, 0);
			this.buttonNetwork.Name = "buttonNetwork";
			this.buttonNetwork.Size = new System.Drawing.Size(106, 45);
			this.buttonNetwork.TabIndex = 8;
			this.buttonNetwork.Text = "Offline";
			this.buttonNetwork.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
			this.buttonNetwork.Click += new System.EventHandler(this.buttonNetwork_Click);
			// 
			// buttonTheme
			// 
			this.buttonTheme.BackColor = System.Drawing.Color.Transparent;
			this.buttonTheme.CssStyle = "box-shadow: none !important;";
			this.buttonTheme.Dock = Wisej.Web.DockStyle.Right;
			this.buttonTheme.ImageSource = "resource.wx/theme.svg";
			this.buttonTheme.Location = new System.Drawing.Point(1821, 0);
			this.buttonTheme.Name = "buttonTheme";
			this.buttonTheme.Size = new System.Drawing.Size(47, 45);
			this.buttonTheme.TabIndex = 7;
			this.buttonTheme.Click += new System.EventHandler(this.buttonTheme_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.BackColor = System.Drawing.Color.Transparent;
			this.buttonBack.BorderStyle = Wisej.Web.BorderStyle.None;
			this.buttonBack.Dock = Wisej.Web.DockStyle.Left;
			this.buttonBack.Focusable = false;
			this.buttonBack.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/go-back-left-arrow.svg";
			this.buttonBack.Location = new System.Drawing.Point(0, 0);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(151, 45);
			this.buttonBack.TabIndex = 6;
			this.buttonBack.Text = "Return to Apps";
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.panelContainer);
			this.Controls.Add(this.panelHeader);
			this.Name = "MainPage";
			this.Size = new System.Drawing.Size(1868, 784);
			this.Text = "Page1";
			this.Load += new System.EventHandler(this.MainPage_Load);
			this.Appear += new System.EventHandler(this.MainPage_Appear);
			this.panelHeader.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private Web.Animation animation1;
		private Web.Animation animation2;
		private Web.Panel panelContainer;
		private Web.ImageList imageList1;
		private Web.Panel panelHeader;
		private Web.Button buttonBack;
		private Web.Button buttonTheme;
		private Web.Button buttonNetwork;
	}
}

