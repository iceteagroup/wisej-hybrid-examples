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
			this.flowLayoutPanel1 = new Wisej.Web.FlowLayoutPanel();
			this.buttonSelectVideo = new Wisej.Web.Button();
			this.buttonTakeVideo = new Wisej.Web.Button();
			this.pictureBox1 = new Wisej.Web.PictureBox();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonSelectPicture
			// 
			this.flowLayoutPanel1.SetFillWeight(this.buttonSelectPicture, 1);
			this.buttonSelectPicture.Location = new System.Drawing.Point(3, 3);
			this.buttonSelectPicture.Name = "buttonSelectPicture";
			this.buttonSelectPicture.Size = new System.Drawing.Size(303, 37);
			this.buttonSelectPicture.TabIndex = 19;
			this.buttonSelectPicture.Text = "Select Picture";
			this.buttonSelectPicture.Click += new System.EventHandler(this.buttonSelectPicture_Click);
			// 
			// buttonTakePicture
			// 
			this.flowLayoutPanel1.SetFillWeight(this.buttonTakePicture, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.buttonTakePicture, true);
			this.buttonTakePicture.Location = new System.Drawing.Point(312, 3);
			this.buttonTakePicture.Name = "buttonTakePicture";
			this.buttonTakePicture.Size = new System.Drawing.Size(303, 37);
			this.buttonTakePicture.TabIndex = 20;
			this.buttonTakePicture.Text = "Take Picture";
			this.buttonTakePicture.Click += new System.EventHandler(this.buttonTakePicture_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.buttonSelectPicture);
			this.flowLayoutPanel1.Controls.Add(this.buttonTakePicture);
			this.flowLayoutPanel1.Controls.Add(this.buttonSelectVideo);
			this.flowLayoutPanel1.Controls.Add(this.buttonTakeVideo);
			this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
			this.flowLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 128);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(618, 350);
			this.flowLayoutPanel1.TabIndex = 21;
			// 
			// buttonSelectVideo
			// 
			this.flowLayoutPanel1.SetFillWeight(this.buttonSelectVideo, 1);
			this.buttonSelectVideo.Location = new System.Drawing.Point(3, 46);
			this.buttonSelectVideo.Name = "buttonSelectVideo";
			this.buttonSelectVideo.Size = new System.Drawing.Size(303, 37);
			this.buttonSelectVideo.TabIndex = 21;
			this.buttonSelectVideo.Text = "Select Video";
			this.buttonSelectVideo.Click += new System.EventHandler(this.buttonSelectVideo_Click);
			// 
			// buttonTakeVideo
			// 
			this.flowLayoutPanel1.SetFillWeight(this.buttonTakeVideo, 1);
			this.flowLayoutPanel1.SetFlowBreak(this.buttonTakeVideo, true);
			this.buttonTakeVideo.Location = new System.Drawing.Point(312, 46);
			this.buttonTakeVideo.Name = "buttonTakeVideo";
			this.buttonTakeVideo.Size = new System.Drawing.Size(303, 37);
			this.buttonTakeVideo.TabIndex = 22;
			this.buttonTakeVideo.Text = "Take Video";
			this.buttonTakeVideo.Click += new System.EventHandler(this.buttonTakeVideo_Click);
			// 
			// pictureBox1
			// 
			this.flowLayoutPanel1.SetFillWeight(this.pictureBox1, 1);
			this.pictureBox1.Location = new System.Drawing.Point(3, 89);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(612, 258);
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
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "Media";
			this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
			this.flowLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Web.Button buttonSelectPicture;
        private Web.FlowLayoutPanel flowLayoutPanel1;
        private Web.Button buttonTakePicture;
        private Web.Button buttonSelectVideo;
        private Web.Button buttonTakeVideo;
        private Web.PictureBox pictureBox1;
    }
}
