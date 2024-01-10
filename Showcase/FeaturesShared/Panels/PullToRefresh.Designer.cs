namespace FeaturesShared.Panels
{
	partial class PullToRefresh
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
			this.flowLayoutPanelData = new Wisej.Web.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// flowLayoutPanelData
			// 
			this.flowLayoutPanelData.AutoScroll = true;
			this.flowLayoutPanelData.AutoScrollMargin = new System.Drawing.Size(0, 20);
			this.flowLayoutPanelData.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanelData.Location = new System.Drawing.Point(16, 128);
			this.flowLayoutPanelData.Name = "flowLayoutPanel1";
			this.flowLayoutPanelData.ScrollBars = Wisej.Web.ScrollBars.Hidden;
			this.flowLayoutPanelData.Size = new System.Drawing.Size(618, 350);
			this.flowLayoutPanelData.TabIndex = 20;
			// 
			// PullToRefresh
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.flowLayoutPanelData);
			this.Name = "PullToRefresh";
			this.Load += new System.EventHandler(this.PullToRefresh_Load);
			this.Controls.SetChildIndex(this.flowLayoutPanelData, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.FlowLayoutPanel flowLayoutPanelData;
	}
}
