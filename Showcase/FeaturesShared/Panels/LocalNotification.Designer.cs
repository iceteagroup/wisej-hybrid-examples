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
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.textBoxDescription = new Wisej.Web.TextBox();
			this.numericUpDownBadge = new Wisej.Web.NumericUpDown();
			this.button5s = new Wisej.Web.Button();
			this.buttonTomorrow = new Wisej.Web.Button();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBadge)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxTitle
			// 
			this.flowLayoutPanel1.SetFillWeight(this.textBoxTitle, 1);
			this.textBoxTitle.LabelText = "Title";
			this.textBoxTitle.Location = new System.Drawing.Point(3, 3);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(301, 55);
			this.textBoxTitle.TabIndex = 0;
			this.textBoxTitle.Text = "Wisej.NET Notification";
			// 
			// textBoxDescription
			// 
			this.flowLayoutPanel1.SetFillWeight(this.textBoxDescription, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.textBoxDescription, true);
			this.textBoxDescription.LabelText = "Description";
			this.textBoxDescription.Location = new System.Drawing.Point(3, 64);
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(609, 55);
			this.textBoxDescription.TabIndex = 1;
			this.textBoxDescription.Text = "This is a notification from Wisej.NET Hybrid";
			// 
			// numericUpDownBadge
			// 
			this.flowLayoutPanel1.SetFillWeight(this.numericUpDownBadge, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.numericUpDownBadge, true);
			this.numericUpDownBadge.LabelText = "Badge Number";
			this.numericUpDownBadge.Location = new System.Drawing.Point(310, 3);
			this.numericUpDownBadge.Name = "numericUpDownBadge";
			this.numericUpDownBadge.Size = new System.Drawing.Size(302, 55);
			this.numericUpDownBadge.TabIndex = 6;
			this.numericUpDownBadge.Value = new decimal(1);
			// 
			// button5s
			// 
			this.flowLayoutPanel1.SetFillWeight(this.button5s, 1);
			this.button5s.Location = new System.Drawing.Point(3, 125);
			this.button5s.Name = "button5s";
			this.button5s.Size = new System.Drawing.Size(301, 37);
			this.button5s.TabIndex = 4;
			this.button5s.Text = "Schedule in 5s";
			this.button5s.Click += new System.EventHandler(this.button5s_Click);
			// 
			// buttonTomorrow
			// 
			this.flowLayoutPanel1.SetFillWeight(this.buttonTomorrow, 1);
			this.buttonTomorrow.Location = new System.Drawing.Point(310, 125);
			this.buttonTomorrow.Name = "buttonTomorrow";
			this.buttonTomorrow.Size = new System.Drawing.Size(302, 37);
			this.buttonTomorrow.TabIndex = 5;
			this.buttonTomorrow.Text = "Schedule Tomorrow";
			this.buttonTomorrow.Click += new System.EventHandler(this.buttonTomorrow_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanel1.Controls.Add(this.textBoxTitle);
			this.flowLayoutPanel1.Controls.Add(this.numericUpDownBadge);
			this.flowLayoutPanel1.Controls.Add(this.textBoxDescription);
			this.flowLayoutPanel1.Controls.Add(this.button5s);
			this.flowLayoutPanel1.Controls.Add(this.buttonTomorrow);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 74);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(615, 331);
			this.flowLayoutPanel1.TabIndex = 21;
			// 
			// LocalNotification
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Hint = "Schedule local push notifications with a timestamp.";
			this.Name = "LocalNotification";
			this.Size = new System.Drawing.Size(650, 495);
			this.Load += new System.EventHandler(this.LocalNotification_Load);
			this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownBadge)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private Wisej.Web.TextBox textBoxTitle;
		private Wisej.Web.TextBox textBoxDescription;
		private Wisej.Web.Button button5s;
		private Wisej.Web.Button buttonTomorrow;
		private Wisej.Web.NumericUpDown numericUpDownBadge;
		private Wisej.Web.FlowLayoutPanel flowLayoutPanel1;
	}
}
