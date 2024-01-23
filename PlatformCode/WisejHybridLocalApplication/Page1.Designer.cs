namespace WisejHybridLocalApplication
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
			this.buttonModelName = new Wisej.Web.Button();
			this.buttonNativeDialog = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// buttonModelName
			// 
			this.buttonModelName.Location = new System.Drawing.Point(63, 51);
			this.buttonModelName.Name = "buttonModelName";
			this.buttonModelName.Size = new System.Drawing.Size(138, 37);
			this.buttonModelName.TabIndex = 0;
			this.buttonModelName.Text = "Model Name";
			this.buttonModelName.Click += new System.EventHandler(this.buttonModelName_Click);
			// 
			// buttonNativeDialog
			// 
			this.buttonNativeDialog.Location = new System.Drawing.Point(63, 135);
			this.buttonNativeDialog.Name = "buttonNativeDialog";
			this.buttonNativeDialog.Size = new System.Drawing.Size(138, 37);
			this.buttonNativeDialog.TabIndex = 1;
			this.buttonNativeDialog.Text = "Native Dialog";
			this.buttonNativeDialog.Click += new System.EventHandler(this.buttonNativeDialog_Click);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.buttonNativeDialog);
			this.Controls.Add(this.buttonModelName);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1873, 671);
			this.Text = "Page1";
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Button buttonModelName;
		private Wisej.Web.Button buttonNativeDialog;
	}
}

