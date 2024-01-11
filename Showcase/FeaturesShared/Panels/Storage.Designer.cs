namespace Wisej.Hybrid.Features.Panels
{
	partial class Storage
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
			this.textBoxContents = new Wisej.Web.TextBox();
			this.buttonSave = new Wisej.Web.Button();
			this.button1 = new Wisej.Web.Button();
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxContents
			// 
			this.textBoxContents.AutoSize = false;
			this.flowLayoutPanel1.SetFillWeight(this.textBoxContents, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.textBoxContents, true);
			this.textBoxContents.Label.Size = 40;
			this.textBoxContents.Label.SizeType = Wisej.Web.SizeType.Absolute;
			this.textBoxContents.LabelText = "File Contents";
			this.textBoxContents.Location = new System.Drawing.Point(3, 3);
			this.textBoxContents.Multiline = true;
			this.textBoxContents.Name = "textBoxContents";
			this.textBoxContents.Size = new System.Drawing.Size(612, 70);
			this.textBoxContents.TabIndex = 20;
			// 
			// buttonSave
			// 
			this.flowLayoutPanel1.SetFillWeight(this.buttonSave, 1);
			this.buttonSave.Location = new System.Drawing.Point(3, 92);
			this.buttonSave.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(303, 37);
			this.buttonSave.TabIndex = 21;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// button1
			// 
			this.flowLayoutPanel1.SetFillWeight(this.button1, 1);
			this.button1.Location = new System.Drawing.Point(312, 92);
			this.button1.Margin = new Wisej.Web.Padding(3, 16, 3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(303, 37);
			this.button1.TabIndex = 22;
			this.button1.Text = "Clear File Contents";
			this.button1.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.textBoxContents);
			this.flowLayoutPanel1.Controls.Add(this.buttonSave);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 68);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 410);
			this.flowLayoutPanel1.TabIndex = 23;
			// 
			// Storage
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
			this.Name = "Storage";
			this.Appear += new System.EventHandler(this.Storage_Appear);
			this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.TextBox textBoxContents;
		private Web.Button buttonSave;
		private Web.Button button1;
		private Web.FlowLayoutPanel flowLayoutPanel1;
	}
}
