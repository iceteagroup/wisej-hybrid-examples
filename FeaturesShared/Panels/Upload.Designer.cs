namespace Wisej.Hybrid.Features.Panels
{
	partial class UploadMedia
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
			this.upload1 = new Wisej.Web.Upload();
			this.SuspendLayout();
			// 
			// upload1
			// 
			this.upload1.Anchor = Wisej.Web.AnchorStyles.None;
			this.upload1.Location = new System.Drawing.Point(187, 205);
			this.upload1.Name = "upload1";
			this.upload1.Size = new System.Drawing.Size(276, 68);
			this.upload1.TabIndex = 20;
			this.upload1.Text = "Select Media";
			// 
			// UploadMedia
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.upload1);
			this.Name = "UploadMedia";
			this.Controls.SetChildIndex(this.upload1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Upload upload1;
	}
}
