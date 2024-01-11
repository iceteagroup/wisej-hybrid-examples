namespace Wisej.Mobile.Features.Panels
{
	partial class HapticFeedback
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
			this.buttonExecute = new Wisej.Web.Button();
			this.comboBoxHapticType = new Wisej.Web.ComboBox();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonExecute
			// 
			this.buttonExecute.Dock = Wisej.Web.DockStyle.Top;
			this.buttonExecute.Location = new System.Drawing.Point(16, 139);
			this.buttonExecute.Name = "buttonExecute";
			this.buttonExecute.Size = new System.Drawing.Size(618, 40);
			this.buttonExecute.TabIndex = 1;
			this.buttonExecute.Text = "Execute";
			this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
			// 
			// comboBoxHapticType
			// 
			this.comboBoxHapticType.Dock = Wisej.Web.DockStyle.Top;
			this.comboBoxHapticType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxHapticType.Items.AddRange(new object[] {
            "Click",
            "LongPress"});
			this.comboBoxHapticType.LabelText = "Haptic Feedback";
			this.comboBoxHapticType.Location = new System.Drawing.Point(16, 68);
			this.comboBoxHapticType.Name = "comboBoxHapticType";
			this.comboBoxHapticType.Size = new System.Drawing.Size(618, 55);
			this.comboBoxHapticType.TabIndex = 4;
			this.comboBoxHapticType.Tag = "";
			this.comboBoxHapticType.Text = "Click";
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 123);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 16);
			// 
			// HapticFeedback
			// 
			this.animation1.GetAnimation(this).Duration = 350;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 350;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonExecute);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.comboBoxHapticType);
			this.Hint = "Trigger haptic feedback on the device.";
			this.Name = "HapticFeedback";
			this.Controls.SetChildIndex(this.comboBoxHapticType, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonExecute, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.Button buttonExecute;
		private Web.ComboBox comboBoxHapticType;
		private Web.Spacer spacer1;
	}
}
