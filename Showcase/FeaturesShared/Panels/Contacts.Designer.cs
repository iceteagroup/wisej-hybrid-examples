namespace Wisej.Hybrid.Features.Panels
{
    partial class Contacts
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
			this.buttonPickContact = new Wisej.Web.Button();
			this.buttonGetAllContacts = new Wisej.Web.Button();
			this.spacer1 = new Wisej.Web.Spacer();
			this.SuspendLayout();
			// 
			// buttonPickContact
			// 
			this.buttonPickContact.Dock = Wisej.Web.DockStyle.Top;
			this.buttonPickContact.Location = new System.Drawing.Point(16, 68);
			this.buttonPickContact.Name = "buttonPickContact";
			this.buttonPickContact.Size = new System.Drawing.Size(618, 37);
			this.buttonPickContact.TabIndex = 19;
			this.buttonPickContact.Text = "Pick Contact";
			this.buttonPickContact.Click += new System.EventHandler(this.buttonPickContact_Click);
			// 
			// buttonGetAllContacts
			// 
			this.buttonGetAllContacts.Dock = Wisej.Web.DockStyle.Top;
			this.buttonGetAllContacts.Location = new System.Drawing.Point(16, 121);
			this.buttonGetAllContacts.Name = "buttonGetAllContacts";
			this.buttonGetAllContacts.Size = new System.Drawing.Size(618, 37);
			this.buttonGetAllContacts.TabIndex = 20;
			this.buttonGetAllContacts.Text = "Get All Contacts";
			this.buttonGetAllContacts.Click += new System.EventHandler(this.buttonGetAllContacts_Click);
			// 
			// spacer1
			// 
			this.spacer1.Dock = Wisej.Web.DockStyle.Top;
			this.spacer1.Location = new System.Drawing.Point(16, 105);
			this.spacer1.Name = "spacer1";
			this.spacer1.Size = new System.Drawing.Size(618, 16);
			// 
			// Contacts
			// 
			this.animation1.GetAnimation(this).Duration = 300;
			this.animation1.GetAnimation(this).Event = "appear";
			this.animation1.GetAnimation(this).Name = "slideRightIn";
			this.animation1.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.animation2.GetAnimation(this).Duration = 300;
			this.animation2.GetAnimation(this).Event = "disappear";
			this.animation2.GetAnimation(this).Name = "slideRightOut";
			this.animation2.GetAnimation(this).Timing = Wisej.Web.AnimationTiming.Ease;
			this.Controls.Add(this.buttonGetAllContacts);
			this.Controls.Add(this.spacer1);
			this.Controls.Add(this.buttonPickContact);
			this.Hint = "Select a contact from the device and receive the data in JSON format.";
			this.Name = "Contacts";
			this.Controls.SetChildIndex(this.buttonPickContact, 0);
			this.Controls.SetChildIndex(this.spacer1, 0);
			this.Controls.SetChildIndex(this.buttonGetAllContacts, 0);
			this.ResumeLayout(false);

        }

        #endregion

        private Web.Button buttonPickContact;
        private Web.Button buttonGetAllContacts;
        private Web.Spacer spacer1;
    }
}
