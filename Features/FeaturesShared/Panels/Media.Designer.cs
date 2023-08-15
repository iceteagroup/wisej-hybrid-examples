namespace Wisej.Hybrid.Features.Panels
{
    partial class Media
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
			this.buttonSelectPicture = new Wisej.Web.Button();
			this.buttonTakePicture = new Wisej.Web.Button();
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.buttonSelectVideo = new Wisej.Web.Button();
			this.buttonTakeVideo = new Wisej.Web.Button();
			this.flexLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonSelectPicture
			// 
			this.buttonSelectPicture.Location = new System.Drawing.Point(3, 3);
			this.buttonSelectPicture.Name = "buttonSelectPicture";
			this.buttonSelectPicture.Size = new System.Drawing.Size(612, 37);
			this.buttonSelectPicture.TabIndex = 19;
			this.buttonSelectPicture.Text = "Select Picture";
			this.buttonSelectPicture.Click += new System.EventHandler(this.buttonSelectPicture_Click);
			// 
			// buttonTakePicture
			// 
			this.buttonTakePicture.Location = new System.Drawing.Point(3, 56);
			this.buttonTakePicture.Name = "buttonTakePicture";
			this.buttonTakePicture.Size = new System.Drawing.Size(612, 37);
			this.buttonTakePicture.TabIndex = 20;
			this.buttonTakePicture.Text = "Take Picture";
			this.buttonTakePicture.Click += new System.EventHandler(this.buttonTakePicture_Click);
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Controls.Add(this.buttonSelectPicture);
			this.flexLayoutPanel1.Controls.Add(this.buttonTakePicture);
			this.flexLayoutPanel1.Controls.Add(this.buttonSelectVideo);
			this.flexLayoutPanel1.Controls.Add(this.buttonTakeVideo);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(16, 128);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(618, 350);
			this.flexLayoutPanel1.TabIndex = 21;
			// 
			// buttonSelectVideo
			// 
			this.buttonSelectVideo.Location = new System.Drawing.Point(3, 109);
			this.buttonSelectVideo.Name = "buttonSelectVideo";
			this.buttonSelectVideo.Size = new System.Drawing.Size(612, 37);
			this.buttonSelectVideo.TabIndex = 21;
			this.buttonSelectVideo.Text = "Select Video";
			this.buttonSelectVideo.Click += new System.EventHandler(this.buttonSelectVideo_Click);
			// 
			// buttonTakeVideo
			// 
			this.buttonTakeVideo.Location = new System.Drawing.Point(3, 162);
			this.buttonTakeVideo.Name = "buttonTakeVideo";
			this.buttonTakeVideo.Size = new System.Drawing.Size(612, 37);
			this.buttonTakeVideo.TabIndex = 22;
			this.buttonTakeVideo.Text = "Take Video";
			this.buttonTakeVideo.Click += new System.EventHandler(this.buttonTakeVideo_Click);
			// 
			// Media
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
			this.Name = "Media";
			this.Controls.SetChildIndex(this.flexLayoutPanel1, 0);
			this.flexLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private Web.Button buttonSelectPicture;
        private Web.FlexLayoutPanel flexLayoutPanel1;
        private Web.Button buttonTakePicture;
        private Web.Button buttonSelectVideo;
        private Web.Button buttonTakeVideo;
    }
}
