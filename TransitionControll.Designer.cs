
using BunifuAnimatorNS;

namespace PowerPoint
{
    partial class TransitionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransitionControl));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.previewLBL = new PowerPoint.MyLabel();
            this.noneLBL = new PowerPoint.MyLabel();
            this.drapeLBL = new PowerPoint.MyLabel();
            this.fallOverLBL = new PowerPoint.MyLabel();
            this.flashLBL = new PowerPoint.MyLabel();
            this.coverLBL = new PowerPoint.MyLabel();
            this.uncoverLBL = new PowerPoint.MyLabel();
            this.shapeLBL = new PowerPoint.MyLabel();
            this.randomBarLBL = new PowerPoint.MyLabel();
            this.revealLBL = new PowerPoint.MyLabel();
            this.splitLBL = new PowerPoint.MyLabel();
            this.FadeLBL = new PowerPoint.MyLabel();
            this.wipeTransitionLBL = new PowerPoint.MyLabel();
            this.cutTransitionLBL = new PowerPoint.MyLabel();
            this.pushTransitionLBL = new PowerPoint.MyLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.noneLBL);
            this.panel1.Controls.Add(this.drapeLBL);
            this.panel1.Controls.Add(this.fallOverLBL);
            this.panel1.Controls.Add(this.flashLBL);
            this.panel1.Controls.Add(this.coverLBL);
            this.panel1.Controls.Add(this.uncoverLBL);
            this.panel1.Controls.Add(this.shapeLBL);
            this.panel1.Controls.Add(this.randomBarLBL);
            this.panel1.Controls.Add(this.revealLBL);
            this.panel1.Controls.Add(this.splitLBL);
            this.panel1.Controls.Add(this.FadeLBL);
            this.panel1.Controls.Add(this.wipeTransitionLBL);
            this.panel1.Controls.Add(this.cutTransitionLBL);
            this.panel1.Controls.Add(this.pushTransitionLBL);
            this.panel1.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 125);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PowerPoint.Properties.Resources.Transition;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1174, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.bunifuTransition2.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(50);
            animation1.RotateCoeff = 1F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition2.DefaultAnimation = animation1;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // previewLBL
            // 
            this.previewLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.previewLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.previewLBL, BunifuAnimatorNS.DecorationType.None);
            this.previewLBL.Location = new System.Drawing.Point(2, 11);
            this.previewLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.previewLBL.Name = "previewLBL";
            this.previewLBL.Size = new System.Drawing.Size(56, 72);
            this.previewLBL.TabIndex = 4;
            this.previewLBL.Click += new System.EventHandler(this.previewLBL_Click);
            // 
            // noneLBL
            // 
            this.noneLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.noneLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.noneLBL, BunifuAnimatorNS.DecorationType.None);
            this.noneLBL.Location = new System.Drawing.Point(67, 18);
            this.noneLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.noneLBL.Name = "noneLBL";
            this.noneLBL.Size = new System.Drawing.Size(56, 57);
            this.noneLBL.TabIndex = 14;
            this.noneLBL.Click += new System.EventHandler(this.noneLBL_Click);
            // 
            // drapeLBL
            // 
            this.drapeLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.drapeLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.drapeLBL, BunifuAnimatorNS.DecorationType.None);
            this.drapeLBL.Location = new System.Drawing.Point(1024, 18);
            this.drapeLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drapeLBL.Name = "drapeLBL";
            this.drapeLBL.Size = new System.Drawing.Size(56, 57);
            this.drapeLBL.TabIndex = 13;
            this.drapeLBL.Click += new System.EventHandler(this.drapeLBL_Click);
            // 
            // fallOverLBL
            // 
            this.fallOverLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.fallOverLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.fallOverLBL, BunifuAnimatorNS.DecorationType.None);
            this.fallOverLBL.Location = new System.Drawing.Point(953, 18);
            this.fallOverLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fallOverLBL.Name = "fallOverLBL";
            this.fallOverLBL.Size = new System.Drawing.Size(56, 57);
            this.fallOverLBL.TabIndex = 12;
            this.fallOverLBL.Click += new System.EventHandler(this.fallOverLBL_Click);
            // 
            // flashLBL
            // 
            this.flashLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.flashLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.flashLBL, BunifuAnimatorNS.DecorationType.None);
            this.flashLBL.Location = new System.Drawing.Point(874, 18);
            this.flashLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.flashLBL.Name = "flashLBL";
            this.flashLBL.Size = new System.Drawing.Size(56, 57);
            this.flashLBL.TabIndex = 11;
            this.flashLBL.Click += new System.EventHandler(this.flashLBL_Click);
            // 
            // coverLBL
            // 
            this.coverLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.coverLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.coverLBL, BunifuAnimatorNS.DecorationType.None);
            this.coverLBL.Location = new System.Drawing.Point(809, 18);
            this.coverLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.coverLBL.Name = "coverLBL";
            this.coverLBL.Size = new System.Drawing.Size(56, 57);
            this.coverLBL.TabIndex = 10;
            this.coverLBL.Click += new System.EventHandler(this.coverLBL_Click);
            // 
            // uncoverLBL
            // 
            this.uncoverLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.uncoverLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.uncoverLBL, BunifuAnimatorNS.DecorationType.None);
            this.uncoverLBL.Location = new System.Drawing.Point(733, 18);
            this.uncoverLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uncoverLBL.Name = "uncoverLBL";
            this.uncoverLBL.Size = new System.Drawing.Size(56, 57);
            this.uncoverLBL.TabIndex = 9;
            this.uncoverLBL.Click += new System.EventHandler(this.uncoverLBL_Click);
            // 
            // shapeLBL
            // 
            this.shapeLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.shapeLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.shapeLBL, BunifuAnimatorNS.DecorationType.None);
            this.shapeLBL.Location = new System.Drawing.Point(655, 18);
            this.shapeLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shapeLBL.Name = "shapeLBL";
            this.shapeLBL.Size = new System.Drawing.Size(56, 57);
            this.shapeLBL.TabIndex = 8;
            this.shapeLBL.Click += new System.EventHandler(this.shapeLBL_Click);
            // 
            // randomBarLBL
            // 
            this.randomBarLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.randomBarLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.randomBarLBL, BunifuAnimatorNS.DecorationType.None);
            this.randomBarLBL.Location = new System.Drawing.Point(570, 18);
            this.randomBarLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.randomBarLBL.Name = "randomBarLBL";
            this.randomBarLBL.Size = new System.Drawing.Size(69, 57);
            this.randomBarLBL.TabIndex = 7;
            this.randomBarLBL.Click += new System.EventHandler(this.randomBarLBL_Click);
            // 
            // revealLBL
            // 
            this.revealLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.revealLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.revealLBL, BunifuAnimatorNS.DecorationType.None);
            this.revealLBL.Location = new System.Drawing.Point(510, 18);
            this.revealLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.revealLBL.Name = "revealLBL";
            this.revealLBL.Size = new System.Drawing.Size(56, 57);
            this.revealLBL.TabIndex = 6;
            this.revealLBL.Click += new System.EventHandler(this.revealLBL_Click);
            // 
            // splitLBL
            // 
            this.splitLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.splitLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.splitLBL, BunifuAnimatorNS.DecorationType.None);
            this.splitLBL.Location = new System.Drawing.Point(436, 18);
            this.splitLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.splitLBL.Name = "splitLBL";
            this.splitLBL.Size = new System.Drawing.Size(56, 57);
            this.splitLBL.TabIndex = 5;
            this.splitLBL.Click += new System.EventHandler(this.splitLBL_Click);
            // 
            // FadeLBL
            // 
            this.FadeLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.FadeLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.FadeLBL, BunifuAnimatorNS.DecorationType.None);
            this.FadeLBL.Location = new System.Drawing.Point(211, 18);
            this.FadeLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FadeLBL.Name = "FadeLBL";
            this.FadeLBL.Size = new System.Drawing.Size(56, 57);
            this.FadeLBL.TabIndex = 4;
            this.FadeLBL.Click += new System.EventHandler(this.FadeLBL_Click);
            // 
            // wipeTransitionLBL
            // 
            this.wipeTransitionLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.wipeTransitionLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.wipeTransitionLBL, BunifuAnimatorNS.DecorationType.None);
            this.wipeTransitionLBL.Location = new System.Drawing.Point(364, 18);
            this.wipeTransitionLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.wipeTransitionLBL.Name = "wipeTransitionLBL";
            this.wipeTransitionLBL.Size = new System.Drawing.Size(56, 57);
            this.wipeTransitionLBL.TabIndex = 3;
            this.wipeTransitionLBL.Click += new System.EventHandler(this.myLabel2_Click);
            // 
            // cutTransitionLBL
            // 
            this.cutTransitionLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.cutTransitionLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.cutTransitionLBL, BunifuAnimatorNS.DecorationType.None);
            this.cutTransitionLBL.Location = new System.Drawing.Point(145, 18);
            this.cutTransitionLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cutTransitionLBL.Name = "cutTransitionLBL";
            this.cutTransitionLBL.Size = new System.Drawing.Size(56, 57);
            this.cutTransitionLBL.TabIndex = 2;
            this.cutTransitionLBL.Click += new System.EventHandler(this.myLabel1_Click);
            // 
            // pushTransitionLBL
            // 
            this.pushTransitionLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition2.SetDecoration(this.pushTransitionLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.pushTransitionLBL, BunifuAnimatorNS.DecorationType.None);
            this.pushTransitionLBL.Location = new System.Drawing.Point(287, 18);
            this.pushTransitionLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pushTransitionLBL.Name = "pushTransitionLBL";
            this.pushTransitionLBL.Size = new System.Drawing.Size(56, 57);
            this.pushTransitionLBL.TabIndex = 1;
            this.pushTransitionLBL.Click += new System.EventHandler(this.pushTransitionLBL_Click);
            // 
            // TransitionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.previewLBL);
            this.Controls.Add(this.panel1);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TransitionControl";
            this.Size = new System.Drawing.Size(1193, 129);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MyLabel pushTransitionLBL;
        private MyLabel wipeTransitionLBL;
        private MyLabel cutTransitionLBL;
       // private Zeroit.Framework.Transitions.AnimatorWithEditor.ZeroitAnimatorEdit zeroitAnimatorEdit1;
        private BunifuTransition bunifuTransition2;
       // private Zeroit.Framework.Transitions.ZeroitOJAnim zeroitOJAnim1;
        private MyLabel previewLBL;
        public BunifuTransition bunifuTransition1;
        private MyLabel revealLBL;
        private MyLabel splitLBL;
        private MyLabel FadeLBL;
        private MyLabel noneLBL;
        private MyLabel drapeLBL;
        private MyLabel fallOverLBL;
        private MyLabel flashLBL;
        private MyLabel coverLBL;
        private MyLabel uncoverLBL;
        private MyLabel shapeLBL;
        private MyLabel randomBarLBL;
    }
}
