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
			this.propertyGrid1 = new Wisej.Web.PropertyGrid();
			this.SuspendLayout();
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.HelpVisible = false;
			this.propertyGrid1.Location = new System.Drawing.Point(13, 20);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.ReadOnly = true;
			this.propertyGrid1.Size = new System.Drawing.Size(269, 305);
			this.propertyGrid1.TabIndex = 0;
			// 
			// 
			// 
			this.propertyGrid1.ToolBar.Enabled = true;
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.propertyGrid1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1814, 928);
			this.Text = "Page1";
			this.Load += new System.EventHandler(this.Page1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.PropertyGrid propertyGrid1;
	}
}

