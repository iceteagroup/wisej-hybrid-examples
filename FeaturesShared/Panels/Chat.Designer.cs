namespace FeaturesShared.Panels
{
	partial class Chat
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
			this.chatBox1 = new Wisej.Web.Ext.ChatControl.ChatBox();
			this.SuspendLayout();
			// 
			// chatBox1
			// 
			this.chatBox1.BorderStyle = Wisej.Web.BorderStyle.None;
			this.chatBox1.Dock = Wisej.Web.DockStyle.Fill;
			this.chatBox1.Location = new System.Drawing.Point(16, 128);
			this.chatBox1.Name = "chatBox1";
			this.chatBox1.Padding = new Wisej.Web.Padding(8);
			this.chatBox1.Size = new System.Drawing.Size(618, 350);
			this.chatBox1.TabIndex = 20;
			// 
			// Chat
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.chatBox1);
			this.Name = "Chat";
			this.Appear += new System.EventHandler(this.Chat_Appear);
			this.Disappear += new System.EventHandler(this.Chat_Disappear);
			this.Controls.SetChildIndex(this.chatBox1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Ext.ChatControl.ChatBox chatBox1;
	}
}
