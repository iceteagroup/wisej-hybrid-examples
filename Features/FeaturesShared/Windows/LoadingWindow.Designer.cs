namespace FeaturesShared.Windows
{
	partial class LoadingWindow
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
			this.label1 = new Wisej.Web.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = Wisej.Web.AnchorStyles.None;
			this.pictureBox1.ImageSource = "resource.wx/loader.svg";
			this.pictureBox1.Location = new System.Drawing.Point(114, 107);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(75, 75);
			// 
			// label1
			// 
			this.label1.Anchor = Wisej.Web.AnchorStyles.None;
			this.label1.Font = new System.Drawing.Font("@defaultBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.label1.Location = new System.Drawing.Point(59, 204);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Loading Samples...";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoadingWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(302, 349);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
			this.KeepCentered = true;
			this.KeepOnScreen = true;
			this.Name = "LoadingWindow";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "LoadingWindow";
			this.WindowState = Wisej.Web.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.PictureBox pictureBox1;
		private Wisej.Web.Label label1;
	}
}