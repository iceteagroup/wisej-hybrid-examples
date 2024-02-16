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
			this.buttonSet = new Wisej.Web.Button();
			this.buttonClear = new Wisej.Web.Button();
			this.buttonGet = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// buttonSet
			// 
			this.buttonSet.Location = new System.Drawing.Point(40, 46);
			this.buttonSet.Name = "buttonSet";
			this.buttonSet.Size = new System.Drawing.Size(233, 37);
			this.buttonSet.TabIndex = 0;
			this.buttonSet.Text = "Set Shortcuts";
			this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
			// 
			// buttonClear
			// 
			this.buttonClear.Location = new System.Drawing.Point(40, 129);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(233, 37);
			this.buttonClear.TabIndex = 1;
			this.buttonClear.Text = "Clear Shortcuts";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonGet
			// 
			this.buttonGet.Location = new System.Drawing.Point(40, 214);
			this.buttonGet.Name = "buttonGet";
			this.buttonGet.Size = new System.Drawing.Size(233, 37);
			this.buttonGet.TabIndex = 2;
			this.buttonGet.Text = "Get Shortcuts";
			this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.buttonGet);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonSet);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1814, 928);
			this.Text = "Page1";
			this.Load += new System.EventHandler(this.Page1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Button buttonSet;
		private Wisej.Web.Button buttonClear;
		private Wisej.Web.Button buttonGet;
	}
}

