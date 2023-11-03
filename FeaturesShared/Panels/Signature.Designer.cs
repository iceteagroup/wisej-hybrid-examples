namespace FeaturesShared.Panels
{
	partial class Signature
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
			this.signature1 = new Wisej.Web.Ext.Signature.Signature();
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.buttonClear = new Wisej.Web.Button();
			this.buttonSave = new Wisej.Web.Button();
			this.textBoxColor = new Wisej.Web.TextBox();
			this.numericUpDownWidth = new Wisej.Web.NumericUpDown();
			this.buttonUndo = new Wisej.Web.Button();
			this.buttonRedo = new Wisej.Web.Button();
			this.flexLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
			this.SuspendLayout();
			// 
			// signature1
			// 
			this.signature1.Dock = Wisej.Web.DockStyle.Fill;
			this.signature1.LineColor = System.Drawing.Color.Red;
			this.signature1.LineWidth = 2;
			this.signature1.Location = new System.Drawing.Point(16, 168);
			this.signature1.Name = "signature1";
			this.signature1.Size = new System.Drawing.Size(618, 310);
			this.signature1.TabIndex = 20;
			this.signature1.Text = "signature1";
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Controls.Add(this.buttonClear);
			this.flexLayoutPanel1.Controls.Add(this.buttonSave);
			this.flexLayoutPanel1.Controls.Add(this.buttonUndo);
			this.flexLayoutPanel1.Controls.Add(this.buttonRedo);
			this.flexLayoutPanel1.Controls.Add(this.textBoxColor);
			this.flexLayoutPanel1.Controls.Add(this.numericUpDownWidth);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Top;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(16, 128);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(618, 40);
			this.flexLayoutPanel1.Spacing = 4;
			this.flexLayoutPanel1.TabIndex = 21;
			// 
			// buttonClear
			// 
			this.buttonClear.ImageSource = "icon-new";
			this.buttonClear.Location = new System.Drawing.Point(3, 3);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(40, 34);
			this.buttonClear.TabIndex = 0;
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			// 
			// buttonSave
			// 
			this.buttonSave.Enabled = false;
			this.buttonSave.ImageSource = "icon-save";
			this.buttonSave.Location = new System.Drawing.Point(53, 3);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(40, 34);
			this.buttonSave.TabIndex = 1;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// textBoxColor
			// 
			this.textBoxColor.InputType.Type = Wisej.Web.TextBoxType.Color;
			this.textBoxColor.Location = new System.Drawing.Point(203, 3);
			this.textBoxColor.Name = "textBoxColor";
			this.textBoxColor.Size = new System.Drawing.Size(40, 34);
			this.textBoxColor.TabIndex = 2;
			this.textBoxColor.Text = "#FF0000";
			this.textBoxColor.TextChanged += new System.EventHandler(this.textBoxColor_TextChanged);
			// 
			// numericUpDownWidth
			// 
			this.numericUpDownWidth.Location = new System.Drawing.Point(253, 3);
			this.numericUpDownWidth.Maximum = new decimal(10);
			this.numericUpDownWidth.Minimum = new decimal(1);
			this.numericUpDownWidth.Name = "numericUpDownWidth";
			this.numericUpDownWidth.Size = new System.Drawing.Size(70, 34);
			this.numericUpDownWidth.TabIndex = 3;
			this.numericUpDownWidth.Value = new decimal(2);
			this.numericUpDownWidth.ValueChanged += new System.EventHandler(this.numericUpDownWidth_ValueChanged);
			// 
			// buttonUndo
			// 
			this.buttonUndo.ImageSource = "icon-undo";
			this.buttonUndo.Location = new System.Drawing.Point(103, 3);
			this.buttonUndo.Name = "buttonUndo";
			this.buttonUndo.Size = new System.Drawing.Size(40, 34);
			this.buttonUndo.TabIndex = 4;
			this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
			// 
			// buttonRedo
			// 
			this.buttonRedo.ImageSource = "icon-redo";
			this.buttonRedo.Location = new System.Drawing.Point(153, 3);
			this.buttonRedo.Name = "buttonRedo";
			this.buttonRedo.Size = new System.Drawing.Size(40, 34);
			this.buttonRedo.TabIndex = 5;
			this.buttonRedo.Click += new System.EventHandler(this.buttonRedo_Click);
			// 
			// Signature
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.signature1);
			this.Controls.Add(this.flexLayoutPanel1);
			this.Name = "Signature";
			this.Controls.SetChildIndex(this.flexLayoutPanel1, 0);
			this.Controls.SetChildIndex(this.signature1, 0);
			this.flexLayoutPanel1.ResumeLayout(false);
			this.flexLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Ext.Signature.Signature signature1;
		private Wisej.Web.FlexLayoutPanel flexLayoutPanel1;
		private Wisej.Web.Button buttonClear;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.TextBox textBoxColor;
		private Wisej.Web.NumericUpDown numericUpDownWidth;
		private Wisej.Web.Button buttonUndo;
		private Wisej.Web.Button buttonRedo;
	}
}
