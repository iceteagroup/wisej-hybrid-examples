namespace HybridOffline.Views
{
	partial class AddUserForm
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
			this.components = new System.ComponentModel.Container();
			Wisej.Web.RequiredValidationRule requiredValidationRule2 = new Wisej.Web.RequiredValidationRule();
			Wisej.Web.RequiredValidationRule requiredValidationRule1 = new Wisej.Web.RequiredValidationRule();
			this.errorProvider1 = new Wisej.Web.ErrorProvider(this.components);
			this.textBoxFirst = new Wisej.Web.TextBox();
			this.textBoxLast = new Wisej.Web.TextBox();
			this.buttonAdd = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.checkBoxIsRegistered = new Wisej.Web.CheckBox();
			this.dateTimePickerStart = new Wisej.Web.DateTimePicker();
			this.validation1 = new Wisej.Web.Validation(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// errorProvider1
			// 
			this.errorProvider1.BlinkRate = 500;
			this.errorProvider1.ContainerControl = this;
			// 
			// textBoxFirst
			// 
			this.textBoxFirst.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.errorProvider1.SetError(this.textBoxFirst, null);
			this.textBoxFirst.LabelText = "First Name";
			this.textBoxFirst.Location = new System.Drawing.Point(35, 22);
			this.textBoxFirst.Name = "textBoxFirst";
			this.textBoxFirst.Size = new System.Drawing.Size(291, 53);
			this.textBoxFirst.TabIndex = 2;
			requiredValidationRule2.ErrorProvider = this.errorProvider1;
			requiredValidationRule2.InvalidMessage = "First name must be at least 1 character.";
			requiredValidationRule2.MinimumLength = 1;
			this.validation1.SetValidationRules(this.textBoxFirst, new Wisej.Web.ValidationRule[] {
            ((Wisej.Web.ValidationRule)(requiredValidationRule2))});
			// 
			// textBoxLast
			// 
			this.textBoxLast.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.errorProvider1.SetError(this.textBoxLast, null);
			this.textBoxLast.LabelText = "Last Name";
			this.textBoxLast.Location = new System.Drawing.Point(35, 103);
			this.textBoxLast.Name = "textBoxLast";
			this.textBoxLast.Size = new System.Drawing.Size(291, 53);
			this.textBoxLast.TabIndex = 3;
			requiredValidationRule1.ErrorProvider = this.errorProvider1;
			requiredValidationRule1.InvalidMessage = "Last name must be at least 1 character.";
			requiredValidationRule1.MinimumLength = 1;
			this.validation1.SetValidationRules(this.textBoxLast, new Wisej.Web.ValidationRule[] {
            ((Wisej.Web.ValidationRule)(requiredValidationRule1))});
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonAdd.DialogResult = Wisej.Web.DialogResult.OK;
			this.buttonAdd.Location = new System.Drawing.Point(191, 294);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(135, 37);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(35, 293);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(102, 37);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
			// 
			// checkBoxIsRegistered
			// 
			this.checkBoxIsRegistered.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.checkBoxIsRegistered.AutoSize = false;
			this.checkBoxIsRegistered.Location = new System.Drawing.Point(35, 184);
			this.checkBoxIsRegistered.Name = "checkBoxIsRegistered";
			this.checkBoxIsRegistered.Size = new System.Drawing.Size(291, 23);
			this.checkBoxIsRegistered.TabIndex = 4;
			this.checkBoxIsRegistered.Text = "Is Registered";
			// 
			// dateTimePickerStart
			// 
			this.dateTimePickerStart.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dateTimePickerStart.Location = new System.Drawing.Point(35, 235);
			this.dateTimePickerStart.Name = "dateTimePickerStart";
			this.dateTimePickerStart.Size = new System.Drawing.Size(291, 30);
			this.dateTimePickerStart.TabIndex = 5;
			// 
			// AddUserForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.AutoValidate = Wisej.Web.AutoValidate.Disable;
			this.ClientSize = new System.Drawing.Size(360, 350);
			this.CloseBox = false;
			this.Controls.Add(this.dateTimePickerStart);
			this.Controls.Add(this.checkBoxIsRegistered);
			this.Controls.Add(this.textBoxLast);
			this.Controls.Add(this.textBoxFirst);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonAdd);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddUserForm";
			this.Text = "Add User";
			this.WindowState = Wisej.Web.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Button buttonAdd;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.TextBox textBoxFirst;
		private Wisej.Web.TextBox textBoxLast;
		private Wisej.Web.CheckBox checkBoxIsRegistered;
		private Wisej.Web.DateTimePicker dateTimePickerStart;
		private Wisej.Web.Validation validation1;
		private Wisej.Web.ErrorProvider errorProvider1;
	}
}