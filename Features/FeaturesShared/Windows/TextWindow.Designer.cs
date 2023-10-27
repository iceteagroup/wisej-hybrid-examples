namespace FeaturesShared
{
	partial class TextWindow
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
			this.components = new System.ComponentModel.Container();
			this.camera1 = new Wisej.Web.Ext.Camera.Camera();
			this.textScanner1 = new Wisej.Hybrid.MLKit.TextScanner(this.components);
			this.textBoxRecent = new Wisej.Web.TextBox();
			this.SuspendLayout();
			// 
			// camera1
			// 
			this.camera1.Dock = Wisej.Web.DockStyle.Fill;
			this.camera1.FacingMode = Wisej.Web.Ext.Camera.Camera.VideoFacingMode.Environment;
			this.camera1.Name = "camera1";
			this.camera1.Size = new System.Drawing.Size(300, 300);
			this.camera1.TabIndex = 0;
			this.camera1.Text = "camera1";
			// 
			// textScanner1
			// 
			this.textScanner1.Camera = this.camera1;
			this.textScanner1.Enabled = true;
			this.textScanner1.RectangleColor = System.Drawing.Color.Green;
			this.textScanner1.UniqueCaptures = false;
			this.textScanner1.Whitelist = new string[0];
			this.textScanner1.Recognized += new System.EventHandler<Wisej.Hybrid.MLKit.TextRecognizedEventArgs>(this.textScanner1_Recognized);
			// 
			// textBoxRecent
			// 
			this.textBoxRecent.AcceptsReturn = true;
			this.textBoxRecent.AcceptsTab = true;
			this.textBoxRecent.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.textBoxRecent.AutoSize = false;
			this.textBoxRecent.BackColor = System.Drawing.Color.FromArgb(80, 255, 255, 255);
			this.textBoxRecent.Location = new System.Drawing.Point(151, 3);
			this.textBoxRecent.Multiline = true;
			this.textBoxRecent.Name = "textBoxRecent";
			this.textBoxRecent.ScrollBars = Wisej.Web.ScrollBars.Hidden;
			this.textBoxRecent.Size = new System.Drawing.Size(146, 177);
			this.textBoxRecent.TabIndex = 2;
			// 
			// TextWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.textBoxRecent);
			this.Controls.Add(this.camera1);
			this.KeepCentered = true;
			this.KeepOnScreen = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TextWindow";
			this.Text = "Text";
			this.WindowState = Wisej.Web.FormWindowState.Maximized;
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Ext.Camera.Camera camera1;
		private Wisej.Hybrid.MLKit.TextScanner textScanner1;
		private Wisej.Web.TextBox textBoxRecent;
	}
}