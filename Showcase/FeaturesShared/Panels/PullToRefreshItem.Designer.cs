namespace FeaturesShared.Panels
{
	partial class PullToRefreshItem
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
			this.pictureBox1 = new Wisej.Web.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.pictureBox1.CssStyle = "border-radius: 100px;\r\nborder-width: 4px;";
			this.pictureBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(20, 20);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 120);
			this.pictureBox1.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// PullToRefreshItem
			// 
			this.BackColor = System.Drawing.Color.FromName("@toolbar");
			this.Controls.Add(this.pictureBox1);
			this.CssStyle = "border-radius: 8px;\r\nbox-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;";
			this.Margin = new Wisej.Web.Padding(10);
			this.Name = "PullToRefreshItem";
			this.Padding = new Wisej.Web.Padding(20);
			this.Size = new System.Drawing.Size(160, 160);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.PictureBox pictureBox1;
	}
}
