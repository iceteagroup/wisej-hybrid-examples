namespace Wisej.Hybrid.Features
{
	partial class TestBase
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
			this.animation1 = new Wisej.Web.Animation(this.components);
			this.animation2 = new Wisej.Web.Animation(this.components);
			this.labelTitle = new Wisej.Web.Label();
			this.buttonSource = new Wisej.Web.Button();
			this.hint = new FeaturesShared.Controls.Hint();
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.CssStyle = "transition: font-size 0.25s;";
			this.labelTitle.Dock = Wisej.Web.DockStyle.Top;
			this.labelTitle.Font = new System.Drawing.Font("windowTitle", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelTitle.ForeColor = System.Drawing.Color.FromName("@toolbarText");
			this.labelTitle.Location = new System.Drawing.Point(16, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(618, 68);
			this.labelTitle.TabIndex = 18;
			this.labelTitle.Text = "TestBase";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonSource
			// 
			this.buttonSource.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonSource.BackColor = System.Drawing.Color.FromName("@window");
			this.buttonSource.CssStyle = "overflow: visible;\r\nborder-radius: 25px;\r\nz-index: 1000;\r\nbox-shadow: rgba(0, 0, " +
    "0, 0.4) 0px 2px 8px 0px;";
			this.buttonSource.Font = new System.Drawing.Font("@defaultBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.buttonSource.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSource.ImageSource = "resource.wx/Wisej.Ext.MaterialDesign/developer-mode-for-smartphones-and-tablets.s" +
    "vg";
			this.buttonSource.Location = new System.Drawing.Point(581, 355);
			this.buttonSource.Name = "buttonSource";
			this.buttonSource.Size = new System.Drawing.Size(50, 50);
			this.buttonSource.TabIndex = 19;
			this.buttonSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonSource.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
			this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
			// 
			// hint
			// 
			this.hint.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.hint.Location = new System.Drawing.Point(19, 411);
			this.hint.Name = "hint";
			this.hint.Size = new System.Drawing.Size(612, 50);
			this.hint.TabIndex = 20;
			// 
			// TestBase
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.hint);
			this.Controls.Add(this.buttonSource);
			this.Controls.Add(this.labelTitle);
			this.MinimumSize = new System.Drawing.Size(350, 0);
			this.Name = "TestBase";
			this.Padding = new Wisej.Web.Padding(16, 0, 16, 0);
			this.ScrollBars = Wisej.Web.ScrollBars.Hidden;
			this.Size = new System.Drawing.Size(650, 478);
			this.Load += new System.EventHandler(this.TestBase_Load);
			this.VisibleChanged += new System.EventHandler(this.TestBase_VisibleChanged);
			this.ResumeLayout(false);

		}

		#endregion

		public Web.Animation animation1;
		public Web.Animation animation2;
		private Web.Label labelTitle;
		private Web.Button buttonSource;
		private FeaturesShared.Controls.Hint hint;
	}
}
