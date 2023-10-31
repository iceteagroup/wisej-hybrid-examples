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
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.button1 = new Wisej.Web.Button();
			this.flexLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxContents
			// 
			this.textBoxContents.AutoSize = false;
			this.textBoxContents.Label.Size = 40;
			this.textBoxContents.Label.SizeType = Wisej.Web.SizeType.Absolute;
			this.textBoxContents.LabelText = "File Contents";
			this.textBoxContents.Location = new System.Drawing.Point(3, 3);
			this.textBoxContents.Multiline = true;
			this.textBoxContents.Name = "textBoxContents";
			this.textBoxContents.Size = new System.Drawing.Size(612, 228);
			this.textBoxContents.TabIndex = 20;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(3, 247);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(612, 37);
			this.buttonSave.TabIndex = 21;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Controls.Add(this.textBoxContents);
			this.flexLayoutPanel1.Controls.Add(this.buttonSave);
			this.flexLayoutPanel1.Controls.Add(this.button1);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(16, 128);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(618, 350);
			this.flexLayoutPanel1.TabIndex = 22;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 300);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(612, 37);
			this.button1.TabIndex = 22;
			this.button1.Text = "Clear File Contents";
			this.button1.Click += new System.EventHandler(this.buttonClear_Click);
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
			this.Controls.Add(this.flexLayoutPanel1);
			this.Name = "Storage";
			this.Appear += new System.EventHandler(this.Storage_Appear);
			this.Controls.SetChildIndex(this.flexLayoutPanel1, 0);
			this.flexLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Web.TextBox textBoxContents;
		private Web.Button buttonSave;
		private Web.FlexLayoutPanel flexLayoutPanel1;
		private Web.Button button1;
	}
}
