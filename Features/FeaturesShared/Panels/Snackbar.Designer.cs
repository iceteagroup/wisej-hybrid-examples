namespace Wisej.Hybrid.Features.Panels
{
	partial class Snackbar
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
			this.textBoxMessage = new Wisej.Web.TextBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.button1 = new Wisej.Web.Button();
			this.spacer2 = new Wisej.Web.Spacer();
			this.textBoxAction = new Wisej.Web.TextBox();
			this.SuspendLayout();
			// 
			// textBoxMessage
			// 
			this.textBoxMessage.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxMessage.LabelText = "Text";
			this.textBoxMessage.Location = new System.Drawing.Point(16, 128);
			this.textBoxMessage.Name = "textBoxMessage";
			this.textBoxMessage.Size = new System.Drawing.Size(618, 55);
			this.textBoxMessage.TabIndex = 19;
			this.textBoxMessage.Text = "Hello, World!";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 183);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// button1
			// 
			this.button1.Dock = Wisej.Web.DockStyle.Top;
			this.button1.Location = new System.Drawing.Point(16, 278);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(618, 37);
			this.button1.TabIndex = 21;
			this.button1.Text = "Show";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// spacer2
			// 
			this.spacer2.Dock = Wisej.Web.DockStyle.Top;
			this.spacer2.Location = new System.Drawing.Point(16, 258);
			this.spacer2.Name = "spacer2";
			this.spacer2.Size = new System.Drawing.Size(618, 20);
			// 
			// textBoxAction
			// 
			this.textBoxAction.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxAction.LabelText = "Action Text";
			this.textBoxAction.Location = new System.Drawing.Point(16, 203);
			this.textBoxAction.Name = "textBoxAction";
			this.textBoxAction.Size = new System.Drawing.Size(618, 55);
			this.textBoxAction.TabIndex = 24;
			this.textBoxAction.Text = "Close";
			// 
			// Snackbar
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.button1);
			this.Controls.Add(this.spacer2);
			this.Controls.Add(this.textBoxAction);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.textBoxMessage);
			this.Name = "Snackbar";
			this.Controls.SetChildIndex(this.textBoxMessage, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.textBoxAction, 0);
			this.Controls.SetChildIndex(this.spacer2, 0);
			this.Controls.SetChildIndex(this.button1, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.TextBox textBoxMessage;
		private Web.Spacer spacer1;
		private Web.Button button1;
		private Web.Spacer spacer2;
		private Web.TextBox textBoxAction;
	}
}
