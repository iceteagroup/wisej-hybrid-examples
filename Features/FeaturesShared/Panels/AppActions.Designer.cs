namespace FeaturesShared.Panels
{
	partial class AppActions
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
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.textBoxShorcut1 = new Wisej.Web.TextBox();
			this.textBoxShortcut2 = new Wisej.Web.TextBox();
			this.textBoxShortcut3 = new Wisej.Web.TextBox();
			this.buttonSetShortcuts = new Wisej.Web.Button();
			this.contextMenu1 = new Wisej.Web.ContextMenu(this.components);
			this.animation3 = new Wisej.Web.Animation(this.components);
			this.flexLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Controls.Add(this.textBoxShorcut1);
			this.flexLayoutPanel1.Controls.Add(this.textBoxShortcut2);
			this.flexLayoutPanel1.Controls.Add(this.textBoxShortcut3);
			this.flexLayoutPanel1.Controls.Add(this.buttonSetShortcuts);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(16, 128);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Padding = new Wisej.Web.Padding(16);
			this.flexLayoutPanel1.Size = new System.Drawing.Size(618, 350);
			this.flexLayoutPanel1.TabIndex = 20;
			// 
			// textBoxShorcut1
			// 
			this.textBoxShorcut1.LabelText = "Shortcut 1";
			this.textBoxShorcut1.Location = new System.Drawing.Point(19, 19);
			this.textBoxShorcut1.Name = "textBoxShorcut1";
			this.textBoxShorcut1.Size = new System.Drawing.Size(580, 55);
			this.textBoxShorcut1.TabIndex = 0;
			this.textBoxShorcut1.Text = "AppAction1";
			// 
			// textBoxShortcut2
			// 
			this.textBoxShortcut2.LabelText = "Shortcut 2";
			this.textBoxShortcut2.Location = new System.Drawing.Point(19, 90);
			this.textBoxShortcut2.Name = "textBoxShortcut2";
			this.textBoxShortcut2.Size = new System.Drawing.Size(580, 55);
			this.textBoxShortcut2.TabIndex = 1;
			this.textBoxShortcut2.Text = "AppAction2";
			// 
			// textBoxShortcut3
			// 
			this.textBoxShortcut3.LabelText = "Shortcut 3";
			this.textBoxShortcut3.Location = new System.Drawing.Point(19, 161);
			this.textBoxShortcut3.Name = "textBoxShortcut3";
			this.textBoxShortcut3.Size = new System.Drawing.Size(580, 55);
			this.textBoxShortcut3.TabIndex = 2;
			this.textBoxShortcut3.Text = "AppAction3";
			// 
			// buttonSetShortcuts
			// 
			this.buttonSetShortcuts.Location = new System.Drawing.Point(19, 232);
			this.buttonSetShortcuts.Name = "buttonSetShortcuts";
			this.buttonSetShortcuts.Size = new System.Drawing.Size(580, 37);
			this.buttonSetShortcuts.TabIndex = 3;
			this.buttonSetShortcuts.Text = "Set Shortcuts";
			this.buttonSetShortcuts.Click += new System.EventHandler(this.buttonSetShortcuts_Click);
			// 
			// contextMenu1
			// 
			this.contextMenu1.Name = "contextMenu1";
			// 
			// AppActions
			// 
   this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.flexLayoutPanel1);
			this.Name = "AppActions";
			this.Controls.SetChildIndex(this.flexLayoutPanel1, 0);
			this.flexLayoutPanel1.ResumeLayout(false);
			this.flexLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.FlexLayoutPanel flexLayoutPanel1;
		private Wisej.Web.TextBox textBoxShorcut1;
		private Wisej.Web.TextBox textBoxShortcut2;
		private Wisej.Web.TextBox textBoxShortcut3;
		private Wisej.Web.ContextMenu contextMenu1;
		private Wisej.Web.Animation animation3;
		private Wisej.Web.Button buttonSetShortcuts;
	}
}
