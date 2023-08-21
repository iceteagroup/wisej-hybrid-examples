namespace FeaturesShared.Panels
{
	partial class LocalNotification
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
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.textBoxDescription = new Wisej.Web.TextBox();
			this.numericUpDownBadge = new Wisej.Web.NumericUpDown();
			this.buttonNow = new Wisej.Web.Button();
			this.button5s = new Wisej.Web.Button();
			this.buttonTomorrow = new Wisej.Web.Button();
			this.flexLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBadge)).BeginInit();
			this.SuspendLayout();
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Controls.Add(this.textBoxTitle);
			this.flexLayoutPanel1.Controls.Add(this.textBoxDescription);
			this.flexLayoutPanel1.Controls.Add(this.numericUpDownBadge);
			this.flexLayoutPanel1.Controls.Add(this.buttonNow);
			this.flexLayoutPanel1.Controls.Add(this.button5s);
			this.flexLayoutPanel1.Controls.Add(this.buttonTomorrow);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(16, 128);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(618, 367);
			this.flexLayoutPanel1.TabIndex = 20;
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.LabelText = "Title";
			this.textBoxTitle.Location = new System.Drawing.Point(3, 3);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(612, 55);
			this.textBoxTitle.TabIndex = 0;
			this.textBoxTitle.Text = "Wisej.NET Notification";
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.LabelText = "Description";
			this.textBoxDescription.Location = new System.Drawing.Point(3, 74);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(612, 55);
			this.textBoxDescription.TabIndex = 1;
			this.textBoxDescription.Text = "This is a notification from Wisej.NET Hybrid";
			// 
			// numericUpDownBadge
			// 
			this.numericUpDownBadge.LabelText = "Badge Number";
			this.numericUpDownBadge.Location = new System.Drawing.Point(3, 145);
			this.numericUpDownBadge.Name = "numericUpDownBadge";
			this.numericUpDownBadge.Size = new System.Drawing.Size(612, 55);
			this.numericUpDownBadge.TabIndex = 6;
			this.numericUpDownBadge.Value = new decimal(1);
			// 
			// buttonNow
			// 
			this.buttonNow.Location = new System.Drawing.Point(3, 216);
			this.buttonNow.Name = "buttonNow";
			this.buttonNow.Size = new System.Drawing.Size(612, 37);
			this.buttonNow.TabIndex = 3;
			this.buttonNow.Text = "Schedule Now";
			this.buttonNow.Click += new System.EventHandler(this.buttonNow_Click);
			// 
			// button5s
			// 
			this.button5s.Location = new System.Drawing.Point(3, 269);
			this.button5s.Name = "button5s";
			this.button5s.Size = new System.Drawing.Size(612, 37);
			this.button5s.TabIndex = 4;
			this.button5s.Text = "Schedule in 5s";
			this.button5s.Click += new System.EventHandler(this.button5s_Click);
			// 
			// buttonTomorrow
			// 
			this.buttonTomorrow.Location = new System.Drawing.Point(3, 322);
			this.buttonTomorrow.Name = "buttonTomorrow";
			this.buttonTomorrow.Size = new System.Drawing.Size(612, 37);
			this.buttonTomorrow.TabIndex = 5;
			this.buttonTomorrow.Text = "Schedule Tomorrow";
			this.buttonTomorrow.Click += new System.EventHandler(this.buttonTomorrow_Click);
			// 
			// LocalNotification
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.flexLayoutPanel1);
			this.Name = "LocalNotification";
			this.Size = new System.Drawing.Size(650, 495);
			this.Load += new System.EventHandler(this.LocalNotification_Load);
			this.Controls.SetChildIndex(this.flexLayoutPanel1, 0);
			this.flexLayoutPanel1.ResumeLayout(false);
			this.flexLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBadge)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.FlexLayoutPanel flexLayoutPanel1;
		private Wisej.Web.TextBox textBoxTitle;
		private Wisej.Web.TextBox textBoxDescription;
		private Wisej.Web.Button buttonNow;
		private Wisej.Web.Button button5s;
		private Wisej.Web.Button buttonTomorrow;
		private Wisej.Web.NumericUpDown numericUpDownBadge;
	}
}
