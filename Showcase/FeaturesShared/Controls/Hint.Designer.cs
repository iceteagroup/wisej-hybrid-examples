namespace FeaturesShared.Controls
{
	partial class Hint
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
			this.label1 = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 0;
			// 
			// Hint
			// 
			this.AutoToolTip = true;
			this.BackColor = System.Drawing.Color.FromArgb(112, 0, 210);
			this.Controls.Add(this.label1);
			this.CssStyle = "border-radius: 8px;\r\nbox-shadow: rgba(99, 99, 99, 0.2) 0px 2px 8px 0px;";
			this.Font = new System.Drawing.Font("default", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.ForeColor = System.Drawing.Color.White;
			this.Name = "Hint";
			this.Padding = new Wisej.Web.Padding(8);
			this.Size = new System.Drawing.Size(334, 68);
			this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Label label1;
	}
}
