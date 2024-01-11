namespace Wisej.Hybrid.Features.Panels
{
	partial class DeviceInfo
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
			this.propertyGridInfo = new Wisej.Web.PropertyGrid();
			this.SuspendLayout();
			// 
			// propertyGridInfo
			// 
			this.propertyGridInfo.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.propertyGridInfo.EditOnEnter = false;
			this.propertyGridInfo.HelpVisible = false;
			this.propertyGridInfo.Location = new System.Drawing.Point(19, 74);
			this.propertyGridInfo.Name = "propertyGridInfo";
			this.propertyGridInfo.PropertySort = Wisej.Web.PropertySort.Alphabetical;
			this.propertyGridInfo.ReadOnly = true;
			this.propertyGridInfo.RowHeadersVisible = false;
			this.propertyGridInfo.Size = new System.Drawing.Size(612, 331);
			this.propertyGridInfo.TabIndex = 0;
			// 
			// 
			// 
			this.propertyGridInfo.ToolBar.Enabled = true;
			// 
			// DeviceInfo
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.propertyGridInfo);
			this.Hint = "Read device-specific information.";
			this.Name = "DeviceInfo";
			this.Controls.SetChildIndex(this.propertyGridInfo, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.PropertyGrid propertyGridInfo;
	}
}
