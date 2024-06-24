namespace HybridLocal.Views
{
	partial class ViewBase
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
			this.components = new System.ComponentModel.Container();
			this.labelTitle = new Wisej.Web.Label();
			this.animationPushAppear = new Wisej.Web.Animation(this.components);
			this.animationPushDisappear = new Wisej.Web.Animation(this.components);
			this.animationPopAppear = new Wisej.Web.Animation(this.components);
			this.animationPopDisappear = new Wisej.Web.Animation(this.components);
			this.SuspendLayout();
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Dock = Wisej.Web.DockStyle.Top;
			this.labelTitle.Font = new System.Drawing.Font("@viewTitle", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelTitle.Location = new System.Drawing.Point(16, 16);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Padding = new Wisej.Web.Padding(0, 0, 0, 16);
			this.labelTitle.Size = new System.Drawing.Size(368, 59);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "View Title";
			// 
			// animationPushDisappear
			// 
			this.animationPushDisappear.End += new Wisej.Web.AnimationEventHandler(this.animationPushDisappear_End);
			// 
			// animationPopAppear
			// 
			this.animationPopAppear.End += new Wisej.Web.AnimationEventHandler(this.animationPopAppear_End);
			// 
			// animationPopDisappear
			// 
			this.animationPopDisappear.End += new Wisej.Web.AnimationEventHandler(this.animationPopDisappear_End);
			// 
			// ViewBase
			// 
			this.animationPushDisappear.GetAnimation(this).Duration = 1000;
			this.animationPushDisappear.GetAnimation(this).Name = "slideLeftOut";
			this.animationPopDisappear.GetAnimation(this).Duration = 500;
			this.animationPopDisappear.GetAnimation(this).Name = "slideRightOut";
			this.animationPushAppear.GetAnimation(this).Duration = 300;
			this.animationPushAppear.GetAnimation(this).Name = "slideRightIn";
			this.animationPushAppear.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.EaseOut;
			this.animationPopAppear.GetAnimation(this).Duration = 250;
			this.animationPopAppear.GetAnimation(this).Name = "slideLeftIn";
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.labelTitle);
			this.Name = "ViewBase";
			this.Padding = new Wisej.Web.Padding(16);
			this.Size = new System.Drawing.Size(400, 700);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label labelTitle;
		private Wisej.Web.Animation animationPushAppear;
		private Wisej.Web.Animation animationPushDisappear;
		private Wisej.Web.Animation animationPopAppear;
		private Wisej.Web.Animation animationPopDisappear;
	}
}
