namespace HybridLocal.Views
{
	partial class HomeView
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
			this.labelWelcome = new Wisej.Web.Label();
			this.buttonLogin = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// labelWelcome
			// 
			this.labelWelcome.AutoSize = true;
			this.labelWelcome.Dock = Wisej.Web.DockStyle.Top;
			this.labelWelcome.Location = new System.Drawing.Point(16, 75);
			this.labelWelcome.Name = "labelWelcome";
			this.labelWelcome.Padding = new Wisej.Web.Padding(0, 0, 0, 16);
			this.labelWelcome.Size = new System.Drawing.Size(368, 34);
			this.labelWelcome.TabIndex = 1;
			this.labelWelcome.Text = "Welcome, ...";
			// 
			// buttonLogin
			// 
			this.buttonLogin.Dock = Wisej.Web.DockStyle.Top;
			this.buttonLogin.Location = new System.Drawing.Point(16, 109);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(368, 37);
			this.buttonLogin.TabIndex = 2;
			this.buttonLogin.Text = "Return to Login";
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// HomeView
			// 
			this.Controls.Add(this.buttonLogin);
			this.Controls.Add(this.labelWelcome);
			this.Name = "HomeView";
			this.Title = "Home";
			this.Load += new System.EventHandler(this.HomeView_Load);
			this.Controls.SetChildIndex(this.labelWelcome, 0);
			this.Controls.SetChildIndex(this.buttonLogin, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label labelWelcome;
		private Wisej.Web.Button buttonLogin;
	}
}
