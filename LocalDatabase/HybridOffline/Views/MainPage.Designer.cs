namespace HybridOffline
{
	partial class MainPage
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
			this.dataGridView1 = new Wisej.Web.DataGridView();
			this.buttonDeleteRecord = new Wisej.Web.Button();
			this.buttonAddRecord = new Wisej.Web.Button();
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.flexLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.Location = new System.Drawing.Point(3, 3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(1810, 408);
			this.dataGridView1.TabIndex = 0;
			// 
			// buttonDeleteRecord
			// 
			this.buttonDeleteRecord.Location = new System.Drawing.Point(3, 427);
			this.buttonDeleteRecord.Name = "buttonDeleteRecord";
			this.buttonDeleteRecord.Size = new System.Drawing.Size(1810, 40);
			this.buttonDeleteRecord.TabIndex = 0;
			this.buttonDeleteRecord.Text = "Delete Selected Record";
			this.buttonDeleteRecord.ToolTipText = "Delete Selected Record";
			this.buttonDeleteRecord.Click += new System.EventHandler(this.buttonDeleteRecord_Click);
			// 
			// buttonAddRecord
			// 
			this.buttonAddRecord.Location = new System.Drawing.Point(3, 483);
			this.buttonAddRecord.Name = "buttonAddRecord";
			this.buttonAddRecord.Size = new System.Drawing.Size(1810, 40);
			this.buttonAddRecord.TabIndex = 1;
			this.buttonAddRecord.Text = "Add New Record";
			this.buttonAddRecord.ToolTipText = "Add New Record";
			this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Controls.Add(this.dataGridView1);
			this.flexLayoutPanel1.Controls.Add(this.buttonDeleteRecord);
			this.flexLayoutPanel1.Controls.Add(this.buttonAddRecord);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(16, 16);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(1816, 659);
			this.flexLayoutPanel1.TabIndex = 2;
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.flexLayoutPanel1);
			this.Name = "MainPage";
			this.Padding = new Wisej.Web.Padding(16);
			this.Size = new System.Drawing.Size(1848, 691);
			this.Text = "Page1";
			this.Load += new System.EventHandler(this.MainPage_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.flexLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.DataGridView dataGridView1;
		private Wisej.Web.Button buttonDeleteRecord;
		private Wisej.Web.Button buttonAddRecord;
		private Wisej.Web.FlexLayoutPanel flexLayoutPanel1;
	}
}

