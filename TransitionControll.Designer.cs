
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
            Zeroit.Framework.Transitions.AnimatorWithEditor.ZeroitAnimate_Animation zeroitAnimate_Animation1 = new Zeroit.Framework.Transitions.AnimatorWithEditor.ZeroitAnimate_Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransitionControl));
            this.panel1 = new System.Windows.Forms.Panel();
            this.wipeTransitionLBL = new PowerPoint.MyLabel();
            this.cutTransitionLBL = new PowerPoint.MyLabel();
            this.pushTransitionLBL = new PowerPoint.MyLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zeroitAnimatorEdit1 = new Zeroit.Framework.Transitions.AnimatorWithEditor.ZeroitAnimatorEdit(this.components);
            this.zeroitOJAnim1 = new Zeroit.Framework.Transitions.ZeroitOJAnim();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wipeTransitionLBL);
            this.panel1.Controls.Add(this.cutTransitionLBL);
            this.panel1.Controls.Add(this.pushTransitionLBL);
            this.panel1.Controls.Add(this.pictureBox1);
            this.zeroitAnimatorEdit1.SetDecoration(this.panel1, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1956, 222);
            this.panel1.TabIndex = 0;
            // 
            // wipeTransitionLBL
            // 
            this.wipeTransitionLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.wipeTransitionLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.wipeTransitionLBL, BunifuAnimatorNS.DecorationType.None);
            this.zeroitAnimatorEdit1.SetDecoration(this.wipeTransitionLBL, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.wipeTransitionLBL.Location = new System.Drawing.Point(606, 32);
            this.wipeTransitionLBL.Name = "wipeTransitionLBL";
            this.wipeTransitionLBL.Size = new System.Drawing.Size(93, 100);
            this.wipeTransitionLBL.TabIndex = 3;
            this.wipeTransitionLBL.Click += new System.EventHandler(this.myLabel2_Click);
            // 
            // cutTransitionLBL
            // 
            this.cutTransitionLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.cutTransitionLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.cutTransitionLBL, BunifuAnimatorNS.DecorationType.None);
            this.zeroitAnimatorEdit1.SetDecoration(this.cutTransitionLBL, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.cutTransitionLBL.Location = new System.Drawing.Point(234, 32);
            this.cutTransitionLBL.Name = "cutTransitionLBL";
            this.cutTransitionLBL.Size = new System.Drawing.Size(93, 100);
            this.cutTransitionLBL.TabIndex = 2;
            this.cutTransitionLBL.Click += new System.EventHandler(this.myLabel1_Click);
            // 
            // pushTransitionLBL
            // 
            this.pushTransitionLBL.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.pushTransitionLBL, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pushTransitionLBL, BunifuAnimatorNS.DecorationType.None);
            this.zeroitAnimatorEdit1.SetDecoration(this.pushTransitionLBL, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.pushTransitionLBL.Location = new System.Drawing.Point(478, 32);
            this.pushTransitionLBL.Name = "pushTransitionLBL";
            this.pushTransitionLBL.Size = new System.Drawing.Size(93, 100);
            this.pushTransitionLBL.TabIndex = 1;
            this.pushTransitionLBL.Click += new System.EventHandler(this.pushTransitionLBL_Click);
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.zeroitAnimatorEdit1.SetDecoration(this.pictureBox1, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PowerPoint.Properties.Resources.Transition;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1956, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // zeroitAnimatorEdit1
            // 
            this.zeroitAnimatorEdit1.AnimationType = Zeroit.Framework.Transitions.AnimatorWithEditor.AnimationType.Mosaic;
            this.zeroitAnimatorEdit1.Cursor = null;
            zeroitAnimate_Animation1.AnimateOnlyDifferences = true;
            zeroitAnimate_Animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.BlindCoeff")));
            zeroitAnimate_Animation1.LeafCoeff = 0F;
            zeroitAnimate_Animation1.MaxTime = 1F;
            zeroitAnimate_Animation1.MinTime = 0F;
            zeroitAnimate_Animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.MosaicCoeff")));
            zeroitAnimate_Animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.MosaicShift")));
            zeroitAnimate_Animation1.MosaicSize = 20;
            zeroitAnimate_Animation1.Padding = new System.Windows.Forms.Padding(30);
            zeroitAnimate_Animation1.RotateCoeff = 0F;
            zeroitAnimate_Animation1.RotateLimit = 0F;
            zeroitAnimate_Animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.ScaleCoeff")));
            zeroitAnimate_Animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("zeroitAnimate_Animation1.SlideCoeff")));
            zeroitAnimate_Animation1.TimeCoeff = 0F;
            zeroitAnimate_Animation1.TransparencyCoeff = 0F;
            this.zeroitAnimatorEdit1.DefaultAnimation = zeroitAnimate_Animation1;
            this.zeroitAnimatorEdit1.Interval = 1;
            this.zeroitAnimatorEdit1.MaxAnimationTime = 4000;
            this.zeroitAnimatorEdit1.TargetHeight = 600;
            this.zeroitAnimatorEdit1.TargetWidth = 600;
            // 
            // zeroitOJAnim1
            // 
            this.zeroitOJAnim1.AnimationMode = Zeroit.Framework.Transitions.ZeroitOJAnim.ZeroitObjectAnimationMode.StandardAnimation;
            this.zeroitOJAnim1.AnimationSpeed = 1;
            this.zeroitOJAnim1.ColorAnimation = Zeroit.Framework.Transitions.ZeroitOJAnim.ZeroitObjectColorAnimation.FillEllipse;
            this.zeroitOJAnim1.ColorAnimationDelay = 10;
            this.zeroitOJAnim1.ColorToAnimate = System.Drawing.Color.Orange;
            this.zeroitOJAnim1.Delay = 200;
            this.zeroitOJAnim1.FormAnimation = Zeroit.Framework.Transitions.ZeroitOJAnim.ZeroitObjectFormAnimation.FadeIn;
            this.zeroitOJAnim1.FormAnimationDelay = 50;
            this.zeroitOJAnim1.KeepColor = true;
            this.zeroitOJAnim1.LowerSpeedLimit = 1;
            this.zeroitOJAnim1.StandardAnimation = Zeroit.Framework.Transitions.ZeroitOJAnim.ZeroitObjectStandardAnimation.ShootRight;
            this.zeroitOJAnim1.StandardHopDelay = 100;
            this.zeroitOJAnim1.StandardShootDelay = 50;
            this.zeroitOJAnim1.StandardSlideDelay = 40;
            this.zeroitOJAnim1.StandardSlugDelay = new int[] {
        100,
        50};
            this.zeroitOJAnim1.UpperSpeedLimit = 10;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.bunifuTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(50);
            animation2.RotateCoeff = 1F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.bunifuTransition2.DefaultAnimation = animation2;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Rotate;
            this.bunifuTransition1.Cursor = null;
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
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // TransitionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.zeroitAnimatorEdit1.SetDecoration(this, Zeroit.Framework.Transitions.AnimatorWithEditor.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "TransitionControl";
            this.Size = new System.Drawing.Size(1989, 229);
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
        private Zeroit.Framework.Transitions.AnimatorWithEditor.ZeroitAnimatorEdit zeroitAnimatorEdit1;
        private BunifuTransition bunifuTransition1;
        private BunifuTransition bunifuTransition2;
        private Zeroit.Framework.Transitions.ZeroitOJAnim zeroitOJAnim1;
    }
}
