namespace Wisej.Hybrid.Features.Panels
{
	partial class Location
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
			this.buttonGetLocation = new Wisej.Web.Button();
			this.propertyGrid1 = new Wisej.Web.PropertyGrid();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonGetLocation
			// 
			this.buttonGetLocation.Dock = Wisej.Web.DockStyle.Top;
			this.buttonGetLocation.Location = new System.Drawing.Point(16, 128);
			this.buttonGetLocation.Name = "buttonGetLocation";
			this.buttonGetLocation.Size = new System.Drawing.Size(618, 45);
			this.buttonGetLocation.TabIndex = 19;
			this.buttonGetLocation.Text = "Get Location";
			this.buttonGetLocation.Click += new System.EventHandler(this.buttonGetLocation_Click);
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Dock = Wisej.Web.DockStyle.Fill;
			this.propertyGrid1.HelpVisible = false;
			this.propertyGrid1.Location = new System.Drawing.Point(16, 193);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.ReadOnly = true;
			this.propertyGrid1.RowHeadersVisible = false;
			this.propertyGrid1.Size = new System.Drawing.Size(618, 285);
			this.propertyGrid1.TabIndex = 23;
			// 
			// 
			// 
			this.propertyGrid1.ToolBar.Enabled = true;
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 173);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 20);
			// 
			// Location
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.propertyGrid1);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.buttonGetLocation);
			this.Name = "Location";
			this.Controls.SetChildIndex(this.buttonGetLocation, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.propertyGrid1, 0);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.Button buttonGetLocation;
		private Web.PropertyGrid propertyGrid1;
		private Web.Spacer spacer1;
	}
}
