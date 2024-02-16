namespace HybridShared
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
			this.buttonMakeAvailableOffline = new Wisej.Web.Button();
			this.labelStartup = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// buttonMakeAvailableOffline
			// 
			this.buttonMakeAvailableOffline.Location = new System.Drawing.Point(48, 44);
			this.buttonMakeAvailableOffline.Name = "buttonMakeAvailableOffline";
			this.buttonMakeAvailableOffline.Size = new System.Drawing.Size(237, 68);
			this.buttonMakeAvailableOffline.TabIndex = 0;
			this.buttonMakeAvailableOffline.Text = "Make Application Available Offline";
			this.buttonMakeAvailableOffline.Click += new System.EventHandler(this.buttonMakeAvailableOffline_Click);
			// 
			// labelStartup
			// 
			this.labelStartup.Font = new System.Drawing.Font("default", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelStartup.Location = new System.Drawing.Point(48, 167);
			this.labelStartup.Name = "labelStartup";
			this.labelStartup.Size = new System.Drawing.Size(237, 53);
			this.labelStartup.TabIndex = 1;
			this.labelStartup.Text = "App is ONLINE";
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.labelStartup);
			this.Controls.Add(this.buttonMakeAvailableOffline);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(2140, 916);
			this.Text = "Page1";
			this.Load += new System.EventHandler(this.Page1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Button buttonMakeAvailableOffline;
		private Wisej.Web.Label labelStartup;
	}
}

