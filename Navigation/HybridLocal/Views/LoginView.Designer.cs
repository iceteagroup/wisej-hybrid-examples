namespace HybridLocal.Views
{
	partial class LoginView
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
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.textBoxEmail = new Wisej.Web.TextBox();
			this.textBoxPassword = new Wisej.Web.TextBox();
			this.buttonLogin = new Wisej.Web.Button();
			this.flexLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Controls.Add(this.textBoxEmail);
			this.flexLayoutPanel1.Controls.Add(this.textBoxPassword);
			this.flexLayoutPanel1.Controls.Add(this.buttonLogin);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(16, 75);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(368, 609);
			this.flexLayoutPanel1.TabIndex = 1;
			// 
			// textBoxEmail
			// 
			this.textBoxEmail.AutoSize = false;
			this.textBoxEmail.InputType.Type = Wisej.Web.TextBoxType.Email;
			this.textBoxEmail.Label.Size = 30;
			this.textBoxEmail.Label.SizeType = Wisej.Web.SizeType.Absolute;
			this.textBoxEmail.LabelText = "Email";
			this.textBoxEmail.Location = new System.Drawing.Point(3, 3);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(362, 65);
			this.textBoxEmail.TabIndex = 0;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.AutoSize = false;
			this.textBoxPassword.InputType.Type = Wisej.Web.TextBoxType.Password;
			this.textBoxPassword.Label.Size = 30;
			this.textBoxPassword.Label.SizeType = Wisej.Web.SizeType.Absolute;
			this.textBoxPassword.LabelText = "Password";
			this.textBoxPassword.Location = new System.Drawing.Point(3, 84);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.PasswordChar = '*';
			this.textBoxPassword.Size = new System.Drawing.Size(362, 65);
			this.textBoxPassword.TabIndex = 1;
			// 
			// buttonLogin
			// 
			this.buttonLogin.Location = new System.Drawing.Point(3, 165);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(362, 37);
			this.buttonLogin.TabIndex = 2;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// LoginView
			// 
			this.Controls.Add(this.flexLayoutPanel1);
			this.Name = "LoginView";
			this.Title = "Login";
			this.Load += new System.EventHandler(this.LoginView_Load);
			this.Controls.SetChildIndex(this.flexLayoutPanel1, 0);
			this.flexLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.FlexLayoutPanel flexLayoutPanel1;
		private Wisej.Web.TextBox textBoxEmail;
		private Wisej.Web.TextBox textBoxPassword;
		private Wisej.Web.Button buttonLogin;
	}
}
