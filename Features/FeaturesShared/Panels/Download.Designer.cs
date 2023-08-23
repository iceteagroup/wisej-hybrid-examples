namespace FeaturesShared.Panels
{
	partial class Download
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

		#region Wisej.NET Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.buttonImage = new Wisej.Web.Button();
			this.buttonPDF = new Wisej.Web.Button();
			this.flexLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Controls.Add(this.buttonImage);
			this.flexLayoutPanel1.Controls.Add(this.buttonPDF);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(16, 128);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(618, 350);
			this.flexLayoutPanel1.TabIndex = 20;
			// 
			// buttonImage
			// 
			this.buttonImage.Location = new System.Drawing.Point(3, 3);
			this.buttonImage.Name = "buttonImage";
			this.buttonImage.Size = new System.Drawing.Size(612, 37);
			this.buttonImage.TabIndex = 0;
			this.buttonImage.Text = "Download Image";
			this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
			// 
			// buttonPDF
			// 
			this.buttonPDF.Location = new System.Drawing.Point(3, 56);
			this.buttonPDF.Name = "buttonPDF";
			this.buttonPDF.Size = new System.Drawing.Size(612, 37);
			this.buttonPDF.TabIndex = 1;
			this.buttonPDF.Text = "Download PDF";
			this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
			// 
			// Download
			// 
   this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.flexLayoutPanel1);
			this.Name = "Download";
			this.Controls.SetChildIndex(this.flexLayoutPanel1, 0);
			this.flexLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.FlexLayoutPanel flexLayoutPanel1;
		private Wisej.Web.Button buttonImage;
		private Wisej.Web.Button buttonPDF;
	}
}
