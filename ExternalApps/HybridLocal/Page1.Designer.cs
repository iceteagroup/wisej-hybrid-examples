namespace HybridLocal
{
	partial class Page1
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
			this.buttonLyft = new Wisej.Web.Button();
			this.buttonMaps = new Wisej.Web.Button();
			this.buttonFb = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// buttonLyft
			// 
			this.buttonLyft.Location = new System.Drawing.Point(33, 32);
			this.buttonLyft.Name = "buttonLyft";
			this.buttonLyft.Size = new System.Drawing.Size(174, 37);
			this.buttonLyft.TabIndex = 0;
			this.buttonLyft.Text = "Launch Lyft";
			this.buttonLyft.Click += new System.EventHandler(this.buttonLyft_Click);
			// 
			// buttonMaps
			// 
			this.buttonMaps.Location = new System.Drawing.Point(33, 111);
			this.buttonMaps.Name = "buttonMaps";
			this.buttonMaps.Size = new System.Drawing.Size(174, 37);
			this.buttonMaps.TabIndex = 1;
			this.buttonMaps.Text = "Launch Maps";
			this.buttonMaps.Click += new System.EventHandler(this.buttonMaps_Click);
			// 
			// buttonFb
			// 
			this.buttonFb.Location = new System.Drawing.Point(33, 190);
			this.buttonFb.Name = "buttonFb";
			this.buttonFb.Size = new System.Drawing.Size(174, 37);
			this.buttonFb.TabIndex = 2;
			this.buttonFb.Text = "Launch Facebook";
			this.buttonFb.Click += new System.EventHandler(this.buttonFb_Click);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.buttonFb);
			this.Controls.Add(this.buttonMaps);
			this.Controls.Add(this.buttonLyft);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1818, 882);
			this.Text = "Page1";
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Button buttonLyft;
		private Wisej.Web.Button buttonMaps;
		private Wisej.Web.Button buttonFb;
	}
}

