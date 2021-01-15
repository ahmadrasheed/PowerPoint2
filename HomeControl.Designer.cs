namespace PowerPoint
{
    partial class HomeControl
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fontFamilyCB = new System.Windows.Forms.ComboBox();
            this.fontSizeCB = new System.Windows.Forms.ComboBox();
            this.boldBtn = new System.Windows.Forms.Button();
            this.italicBtn = new System.Windows.Forms.Button();
            this.underlineBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAhmadInsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSlideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.newSlidePictureBox = new System.Windows.Forms.PictureBox();
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.shapeOutlineColorLBL = new PowerPoint.MyLabel();
            this.shapeColorFillLBL = new PowerPoint.MyLabel();
            this.numberBulletLBL = new PowerPoint.MyLabel();
            this.shpareBulletLBL = new PowerPoint.MyLabel();
            this.lineSpaceLBL = new PowerPoint.MyLabel();
            this.leftToRightLBL = new PowerPoint.MyLabel();
            this.rightToLeftLBL = new PowerPoint.MyLabel();
            this.leftLBL = new PowerPoint.MyLabel();
            this.centerLBL = new PowerPoint.MyLabel();
            this.rightLBL = new PowerPoint.MyLabel();
            this.insertTextBoxLBL = new PowerPoint.MyLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSlidePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.button1.Location = new System.Drawing.Point(1, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 71);
            this.button1.TabIndex = 10;
            this.button1.Text = "Paste";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.label1.Location = new System.Drawing.Point(3, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "Clipboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(87, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 87);
            this.panel1.TabIndex = 15;
            // 
            // fontFamilyCB
            // 
            this.fontFamilyCB.Font = new System.Drawing.Font("Calibri", 8F);
            this.fontFamilyCB.FormattingEnabled = true;
            this.fontFamilyCB.Items.AddRange(new object[] {
            "خط احمد الجبوري",
            "خط احمد البارودي",
            "Arial",
            "Times New Roman",
            "Verdana",
            "Andalus",
            "Traditional Arabic",
            "Calibri",
            "Sakkal Majalla",
            "Simplified Arabic",
            "Aldhabi",
            "Arabic Typesetting",
            "Microsoft Uighur"});
            this.fontFamilyCB.Location = new System.Drawing.Point(145, 15);
            this.fontFamilyCB.Name = "fontFamilyCB";
            this.fontFamilyCB.Size = new System.Drawing.Size(95, 21);
            this.fontFamilyCB.TabIndex = 16;
            this.fontFamilyCB.Text = "Calibri(Body)";
            this.fontFamilyCB.SelectedIndexChanged += new System.EventHandler(this.fontFamilyCB_SelectedIndexChanged);
            // 
            // fontSizeCB
            // 
            this.fontSizeCB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSizeCB.FormattingEnabled = true;
            this.fontSizeCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "30",
            "33",
            "35",
            "37",
            "40",
            "45",
            "50",
            "53",
            "55",
            "59",
            "60",
            "65",
            "70",
            "75",
            "80",
            "90",
            "95",
            "100"});
            this.fontSizeCB.Location = new System.Drawing.Point(242, 15);
            this.fontSizeCB.Name = "fontSizeCB";
            this.fontSizeCB.Size = new System.Drawing.Size(39, 23);
            this.fontSizeCB.TabIndex = 17;
            this.fontSizeCB.Text = "10";
            this.fontSizeCB.SelectedIndexChanged += new System.EventHandler(this.fontSizeCB_SelectedIndexChanged);
            // 
            // boldBtn
            // 
            this.boldBtn.FlatAppearance.BorderSize = 0;
            this.boldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boldBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldBtn.Location = new System.Drawing.Point(145, 48);
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(31, 23);
            this.boldBtn.TabIndex = 18;
            this.boldBtn.Text = "B";
            this.boldBtn.UseVisualStyleBackColor = true;
            this.boldBtn.Click += new System.EventHandler(this.boldBtn_Click);
            // 
            // italicBtn
            // 
            this.italicBtn.FlatAppearance.BorderSize = 0;
            this.italicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.italicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicBtn.Location = new System.Drawing.Point(166, 48);
            this.italicBtn.Name = "italicBtn";
            this.italicBtn.Size = new System.Drawing.Size(31, 24);
            this.italicBtn.TabIndex = 19;
            this.italicBtn.Text = "I";
            this.italicBtn.UseVisualStyleBackColor = true;
            this.italicBtn.Click += new System.EventHandler(this.italicBtn_Click);
            // 
            // underlineBtn
            // 
            this.underlineBtn.FlatAppearance.BorderSize = 0;
            this.underlineBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.underlineBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlineBtn.Location = new System.Drawing.Point(193, 48);
            this.underlineBtn.Name = "underlineBtn";
            this.underlineBtn.Size = new System.Drawing.Size(30, 24);
            this.underlineBtn.TabIndex = 20;
            this.underlineBtn.Text = "U";
            this.underlineBtn.UseVisualStyleBackColor = true;
            this.underlineBtn.Click += new System.EventHandler(this.underlineBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Font";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(283, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 133);
            this.panel2.TabIndex = 16;
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AutoSize = false;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutStripMenuItem,
            this.openAhmadInsertToolStripMenuItem,
            this.paste,
            this.toolStripSeparator2,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 145);
            // 
            // cutStripMenuItem
            // 
            this.cutStripMenuItem.Name = "cutStripMenuItem";
            this.cutStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.cutStripMenuItem.Text = "cut";
            this.cutStripMenuItem.Click += new System.EventHandler(this.cutStripMenuItem_Click);
            // 
            // openAhmadInsertToolStripMenuItem
            // 
            this.openAhmadInsertToolStripMenuItem.Name = "openAhmadInsertToolStripMenuItem";
            this.openAhmadInsertToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.openAhmadInsertToolStripMenuItem.Text = "copy";
            this.openAhmadInsertToolStripMenuItem.Click += new System.EventHandler(this.openAhmadInsertToolStripMenuItem_Click);
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(122, 26);
            this.paste.Text = "paste";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.newSlidePictureBox);
            this.panel3.Location = new System.Drawing.Point(89, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 82);
            this.panel3.TabIndex = 38;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSlideToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(134, 26);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // deleteSlideToolStripMenuItem
            // 
            this.deleteSlideToolStripMenuItem.Name = "deleteSlideToolStripMenuItem";
            this.deleteSlideToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.deleteSlideToolStripMenuItem.Text = "delete slide";
            this.deleteSlideToolStripMenuItem.Click += new System.EventHandler(this.deleteSlideToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.shapeOutlineColorLBL);
            this.panel4.Controls.Add(this.shapeColorFillLBL);
            this.panel4.Controls.Add(this.numberBulletLBL);
            this.panel4.Controls.Add(this.shpareBulletLBL);
            this.panel4.Controls.Add(this.lineSpaceLBL);
            this.panel4.Controls.Add(this.leftToRightLBL);
            this.panel4.Controls.Add(this.rightToLeftLBL);
            this.panel4.Controls.Add(this.leftLBL);
            this.panel4.Controls.Add(this.centerLBL);
            this.panel4.Controls.Add(this.rightLBL);
            this.panel4.Controls.Add(this.insertTextBoxLBL);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(288, 9);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(762, 127);
            this.panel4.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(699, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Editing";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(477, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Drawing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(125, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Paragraph";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PowerPoint.Properties.Resources.HomeSmaller1;
            this.pictureBox1.Image = global::PowerPoint.Properties.Resources.Home21;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(762, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // newSlidePictureBox
            // 
            this.newSlidePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.newSlidePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newSlidePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newSlidePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newSlidePictureBox.Image = global::PowerPoint.Properties.Resources.newSlide;
            this.newSlidePictureBox.Location = new System.Drawing.Point(0, 0);
            this.newSlidePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.newSlidePictureBox.Name = "newSlidePictureBox";
            this.newSlidePictureBox.Size = new System.Drawing.Size(57, 82);
            this.newSlidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newSlidePictureBox.TabIndex = 31;
            this.newSlidePictureBox.TabStop = false;
            this.newSlidePictureBox.Click += new System.EventHandler(this.newSlidePictureBox_Click);
            this.newSlidePictureBox.MouseLeave += new System.EventHandler(this.newSlidePictureBox_MouseLeave);
            this.newSlidePictureBox.MouseHover += new System.EventHandler(this.newSlidePictureBox_MouseHover);
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.colorPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.colorPictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.colorPictureBox.Image = global::PowerPoint.Properties.Resources.icons8_text_color_48;
            this.colorPictureBox.Location = new System.Drawing.Point(227, 49);
            this.colorPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.Size = new System.Drawing.Size(22, 22);
            this.colorPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorPictureBox.TabIndex = 30;
            this.colorPictureBox.TabStop = false;
            this.colorPictureBox.Click += new System.EventHandler(this.colorPictureBox_Click);
            this.colorPictureBox.MouseLeave += new System.EventHandler(this.colorPictureBox_MouseLeave);
            this.colorPictureBox.MouseHover += new System.EventHandler(this.colorPictureBox_MouseHover);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::PowerPoint.Properties.Resources.paste;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(57, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(25, 25);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::PowerPoint.Properties.Resources.copy;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(57, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(25, 25);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PowerPoint.Properties.Resources.cut;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(57, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 25);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // shapeOutlineColorLBL
            // 
            this.shapeOutlineColorLBL.BackColor = System.Drawing.Color.Transparent;
            this.shapeOutlineColorLBL.Location = new System.Drawing.Point(580, 39);
            this.shapeOutlineColorLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shapeOutlineColorLBL.Name = "shapeOutlineColorLBL";
            this.shapeOutlineColorLBL.Size = new System.Drawing.Size(90, 26);
            this.shapeOutlineColorLBL.TabIndex = 40;
            this.shapeOutlineColorLBL.Click += new System.EventHandler(this.shapeOutlineColorLBL_Click);
            // 
            // shapeColorFillLBL
            // 
            this.shapeColorFillLBL.BackColor = System.Drawing.Color.Transparent;
            this.shapeColorFillLBL.Location = new System.Drawing.Point(578, 6);
            this.shapeColorFillLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shapeColorFillLBL.Name = "shapeColorFillLBL";
            this.shapeColorFillLBL.Size = new System.Drawing.Size(90, 28);
            this.shapeColorFillLBL.TabIndex = 39;
            this.shapeColorFillLBL.Click += new System.EventHandler(this.shapeColorFillLBL_Click);
            // 
            // numberBulletLBL
            // 
            this.numberBulletLBL.BackColor = System.Drawing.Color.Transparent;
            this.numberBulletLBL.Location = new System.Drawing.Point(31, 18);
            this.numberBulletLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numberBulletLBL.Name = "numberBulletLBL";
            this.numberBulletLBL.Size = new System.Drawing.Size(24, 25);
            this.numberBulletLBL.TabIndex = 38;
            this.numberBulletLBL.Click += new System.EventHandler(this.numberBulletLBL_Click);
            // 
            // shpareBulletLBL
            // 
            this.shpareBulletLBL.BackColor = System.Drawing.Color.Transparent;
            this.shpareBulletLBL.Location = new System.Drawing.Point(3, 18);
            this.shpareBulletLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.shpareBulletLBL.Name = "shpareBulletLBL";
            this.shpareBulletLBL.Size = new System.Drawing.Size(25, 25);
            this.shpareBulletLBL.TabIndex = 37;
            this.shpareBulletLBL.Click += new System.EventHandler(this.shpareBulletLBL_Click);
            // 
            // lineSpaceLBL
            // 
            this.lineSpaceLBL.BackColor = System.Drawing.Color.Transparent;
            this.lineSpaceLBL.Location = new System.Drawing.Point(124, 20);
            this.lineSpaceLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lineSpaceLBL.Name = "lineSpaceLBL";
            this.lineSpaceLBL.Size = new System.Drawing.Size(20, 19);
            this.lineSpaceLBL.TabIndex = 36;
            this.lineSpaceLBL.Click += new System.EventHandler(this.lineSpaceLBL_Click);
            // 
            // leftToRightLBL
            // 
            this.leftToRightLBL.BackColor = System.Drawing.Color.Transparent;
            this.leftToRightLBL.Location = new System.Drawing.Point(122, 65);
            this.leftToRightLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leftToRightLBL.Name = "leftToRightLBL";
            this.leftToRightLBL.Size = new System.Drawing.Size(20, 24);
            this.leftToRightLBL.TabIndex = 35;
            this.leftToRightLBL.Click += new System.EventHandler(this.leftToRightLBL_Click);
            // 
            // rightToLeftLBL
            // 
            this.rightToLeftLBL.BackColor = System.Drawing.Color.Transparent;
            this.rightToLeftLBL.Location = new System.Drawing.Point(151, 68);
            this.rightToLeftLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightToLeftLBL.Name = "rightToLeftLBL";
            this.rightToLeftLBL.Size = new System.Drawing.Size(25, 25);
            this.rightToLeftLBL.TabIndex = 34;
            this.rightToLeftLBL.Click += new System.EventHandler(this.rightToLeftLBL_Click);
            // 
            // leftLBL
            // 
            this.leftLBL.BackColor = System.Drawing.Color.Transparent;
            this.leftLBL.Location = new System.Drawing.Point(4, 63);
            this.leftLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leftLBL.Name = "leftLBL";
            this.leftLBL.Size = new System.Drawing.Size(23, 27);
            this.leftLBL.TabIndex = 33;
            this.leftLBL.Click += new System.EventHandler(this.leftLBL_Click);
            // 
            // centerLBL
            // 
            this.centerLBL.BackColor = System.Drawing.Color.Transparent;
            this.centerLBL.Location = new System.Drawing.Point(30, 64);
            this.centerLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.centerLBL.Name = "centerLBL";
            this.centerLBL.Size = new System.Drawing.Size(25, 25);
            this.centerLBL.TabIndex = 32;
            this.centerLBL.Click += new System.EventHandler(this.centerLBL_Click);
            // 
            // rightLBL
            // 
            this.rightLBL.BackColor = System.Drawing.Color.Transparent;
            this.rightLBL.Location = new System.Drawing.Point(59, 64);
            this.rightLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightLBL.Name = "rightLBL";
            this.rightLBL.Size = new System.Drawing.Size(21, 25);
            this.rightLBL.TabIndex = 31;
            this.rightLBL.Click += new System.EventHandler(this.rightLBL_Click);
            // 
            // insertTextBoxLBL
            // 
            this.insertTextBoxLBL.BackColor = System.Drawing.Color.Transparent;
            this.insertTextBoxLBL.Location = new System.Drawing.Point(336, 17);
            this.insertTextBoxLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.insertTextBoxLBL.Name = "insertTextBoxLBL";
            this.insertTextBoxLBL.Size = new System.Drawing.Size(22, 25);
            this.insertTextBoxLBL.TabIndex = 30;
            this.insertTextBoxLBL.Click += new System.EventHandler(this.insertTextBoxLBL_Click);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.colorPictureBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.underlineBtn);
            this.Controls.Add(this.italicBtn);
            this.Controls.Add(this.boldBtn);
            this.Controls.Add(this.fontSizeCB);
            this.Controls.Add(this.fontFamilyCB);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(1024, 134);
            this.Load += new System.EventHandler(this.HomeControl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newSlidePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox fontFamilyCB;
        private System.Windows.Forms.ComboBox fontSizeCB;
        private System.Windows.Forms.Button boldBtn;
        private System.Windows.Forms.Button italicBtn;
        private System.Windows.Forms.Button underlineBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox colorPictureBox;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox newSlidePictureBox;
        private System.Windows.Forms.ToolStripMenuItem openAhmadInsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteSlideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem cutStripMenuItem;
        private MyLabel insertTextBoxLBL;
        private MyLabel rightLBL;
        private MyLabel centerLBL;
        private MyLabel leftLBL;
        private MyLabel rightToLeftLBL;
        private MyLabel leftToRightLBL;
        private MyLabel lineSpaceLBL;
        private MyLabel shpareBulletLBL;
        private MyLabel numberBulletLBL;
        private MyLabel shapeColorFillLBL;
        private MyLabel shapeOutlineColorLBL;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
