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
            this.openAhmadInsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.newSlidePictureBox = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorPictureBox = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSlideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newSlidePictureBox)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 124);
            this.button1.TabIndex = 10;
            this.button1.Text = "Paste";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Clipboard";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(153, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 152);
            this.panel1.TabIndex = 15;
            // 
            // fontFamilyCB
            // 
            this.fontFamilyCB.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.fontFamilyCB.Location = new System.Drawing.Point(263, 27);
            this.fontFamilyCB.Margin = new System.Windows.Forms.Padding(5);
            this.fontFamilyCB.Name = "fontFamilyCB";
            this.fontFamilyCB.Size = new System.Drawing.Size(166, 36);
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
            this.fontSizeCB.Location = new System.Drawing.Point(432, 27);
            this.fontSizeCB.Margin = new System.Windows.Forms.Padding(5);
            this.fontSizeCB.Name = "fontSizeCB";
            this.fontSizeCB.Size = new System.Drawing.Size(66, 36);
            this.fontSizeCB.TabIndex = 17;
            this.fontSizeCB.Text = "10";
            this.fontSizeCB.SelectedIndexChanged += new System.EventHandler(this.fontSizeCB_SelectedIndexChanged);
            // 
            // boldBtn
            // 
            this.boldBtn.FlatAppearance.BorderSize = 0;
            this.boldBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boldBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldBtn.Location = new System.Drawing.Point(263, 84);
            this.boldBtn.Margin = new System.Windows.Forms.Padding(5);
            this.boldBtn.Name = "boldBtn";
            this.boldBtn.Size = new System.Drawing.Size(55, 41);
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
            this.italicBtn.Location = new System.Drawing.Point(300, 84);
            this.italicBtn.Margin = new System.Windows.Forms.Padding(5);
            this.italicBtn.Name = "italicBtn";
            this.italicBtn.Size = new System.Drawing.Size(55, 42);
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
            this.underlineBtn.Location = new System.Drawing.Point(346, 84);
            this.underlineBtn.Margin = new System.Windows.Forms.Padding(5);
            this.underlineBtn.Name = "underlineBtn";
            this.underlineBtn.Size = new System.Drawing.Size(52, 42);
            this.underlineBtn.TabIndex = 20;
            this.underlineBtn.Text = "U";
            this.underlineBtn.UseVisualStyleBackColor = true;
            this.underlineBtn.Click += new System.EventHandler(this.underlineBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(322, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "Font";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(508, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 233);
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
            this.openAhmadInsertToolStripMenuItem,
            this.paste,
            this.toolStripSeparator2,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(210, 110);
            // 
            // openAhmadInsertToolStripMenuItem
            // 
            this.openAhmadInsertToolStripMenuItem.Name = "openAhmadInsertToolStripMenuItem";
            this.openAhmadInsertToolStripMenuItem.Size = new System.Drawing.Size(171, 44);
            this.openAhmadInsertToolStripMenuItem.Text = "copy";
            this.openAhmadInsertToolStripMenuItem.Click += new System.EventHandler(this.openAhmadInsertToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(206, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(171, 44);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.newSlidePictureBox);
            this.panel3.Location = new System.Drawing.Point(156, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(99, 144);
            this.panel3.TabIndex = 38;
            // 
            // newSlidePictureBox
            // 
            this.newSlidePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.newSlidePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newSlidePictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newSlidePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newSlidePictureBox.Image = global::PowerPoint.Properties.Resources.newSlide;
            this.newSlidePictureBox.Location = new System.Drawing.Point(0, 0);
            this.newSlidePictureBox.Name = "newSlidePictureBox";
            this.newSlidePictureBox.Size = new System.Drawing.Size(99, 144);
            this.newSlidePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.newSlidePictureBox.TabIndex = 31;
            this.newSlidePictureBox.TabStop = false;
            this.newSlidePictureBox.Click += new System.EventHandler(this.newSlidePictureBox_Click);
            this.newSlidePictureBox.MouseLeave += new System.EventHandler(this.newSlidePictureBox_MouseLeave);
            this.newSlidePictureBox.MouseHover += new System.EventHandler(this.newSlidePictureBox_MouseHover);
            // 
            // panel4
            // 
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
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(561, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1764, 231);
            this.panel4.TabIndex = 39;
            // 
            // shapeOutlineColorLBL
            // 
            this.shapeOutlineColorLBL.BackColor = System.Drawing.Color.Transparent;
            this.shapeOutlineColorLBL.Location = new System.Drawing.Point(1357, 68);
            this.shapeOutlineColorLBL.Name = "shapeOutlineColorLBL";
            this.shapeOutlineColorLBL.Size = new System.Drawing.Size(200, 53);
            this.shapeOutlineColorLBL.TabIndex = 40;
            this.shapeOutlineColorLBL.Click += new System.EventHandler(this.shapeOutlineColorLBL_Click);
            // 
            // shapeColorFillLBL
            // 
            this.shapeColorFillLBL.BackColor = System.Drawing.Color.Transparent;
            this.shapeColorFillLBL.Location = new System.Drawing.Point(1357, 8);
            this.shapeColorFillLBL.Name = "shapeColorFillLBL";
            this.shapeColorFillLBL.Size = new System.Drawing.Size(158, 53);
            this.shapeColorFillLBL.TabIndex = 39;
            this.shapeColorFillLBL.Click += new System.EventHandler(this.shapeColorFillLBL_Click);
            // 
            // numberBulletLBL
            // 
            this.numberBulletLBL.BackColor = System.Drawing.Color.Transparent;
            this.numberBulletLBL.Location = new System.Drawing.Point(64, 31);
            this.numberBulletLBL.Name = "numberBulletLBL";
            this.numberBulletLBL.Size = new System.Drawing.Size(62, 53);
            this.numberBulletLBL.TabIndex = 38;
            this.numberBulletLBL.Click += new System.EventHandler(this.numberBulletLBL_Click);
            // 
            // shpareBulletLBL
            // 
            this.shpareBulletLBL.BackColor = System.Drawing.Color.Transparent;
            this.shpareBulletLBL.Location = new System.Drawing.Point(9, 29);
            this.shpareBulletLBL.Name = "shpareBulletLBL";
            this.shpareBulletLBL.Size = new System.Drawing.Size(62, 53);
            this.shpareBulletLBL.TabIndex = 37;
            this.shpareBulletLBL.Click += new System.EventHandler(this.shpareBulletLBL_Click);
            // 
            // lineSpaceLBL
            // 
            this.lineSpaceLBL.BackColor = System.Drawing.Color.Transparent;
            this.lineSpaceLBL.Location = new System.Drawing.Point(274, 33);
            this.lineSpaceLBL.Name = "lineSpaceLBL";
            this.lineSpaceLBL.Size = new System.Drawing.Size(62, 53);
            this.lineSpaceLBL.TabIndex = 36;
            this.lineSpaceLBL.Click += new System.EventHandler(this.lineSpaceLBL_Click);
            // 
            // leftToRightLBL
            // 
            this.leftToRightLBL.BackColor = System.Drawing.Color.Transparent;
            this.leftToRightLBL.Location = new System.Drawing.Point(274, 114);
            this.leftToRightLBL.Name = "leftToRightLBL";
            this.leftToRightLBL.Size = new System.Drawing.Size(62, 53);
            this.leftToRightLBL.TabIndex = 35;
            this.leftToRightLBL.Click += new System.EventHandler(this.leftToRightLBL_Click);
            // 
            // rightToLeftLBL
            // 
            this.rightToLeftLBL.BackColor = System.Drawing.Color.Transparent;
            this.rightToLeftLBL.Location = new System.Drawing.Point(354, 117);
            this.rightToLeftLBL.Name = "rightToLeftLBL";
            this.rightToLeftLBL.Size = new System.Drawing.Size(43, 44);
            this.rightToLeftLBL.TabIndex = 34;
            this.rightToLeftLBL.Click += new System.EventHandler(this.rightToLeftLBL_Click);
            // 
            // leftLBL
            // 
            this.leftLBL.BackColor = System.Drawing.Color.Transparent;
            this.leftLBL.Location = new System.Drawing.Point(7, 114);
            this.leftLBL.Name = "leftLBL";
            this.leftLBL.Size = new System.Drawing.Size(64, 53);
            this.leftLBL.TabIndex = 33;
            this.leftLBL.Click += new System.EventHandler(this.leftLBL_Click);
            // 
            // centerLBL
            // 
            this.centerLBL.BackColor = System.Drawing.Color.Transparent;
            this.centerLBL.Location = new System.Drawing.Point(81, 116);
            this.centerLBL.Name = "centerLBL";
            this.centerLBL.Size = new System.Drawing.Size(43, 44);
            this.centerLBL.TabIndex = 32;
            this.centerLBL.Click += new System.EventHandler(this.centerLBL_Click);
            // 
            // rightLBL
            // 
            this.rightLBL.BackColor = System.Drawing.Color.Transparent;
            this.rightLBL.Location = new System.Drawing.Point(144, 117);
            this.rightLBL.Name = "rightLBL";
            this.rightLBL.Size = new System.Drawing.Size(43, 44);
            this.rightLBL.TabIndex = 31;
            this.rightLBL.Click += new System.EventHandler(this.rightLBL_Click);
            // 
            // insertTextBoxLBL
            // 
            this.insertTextBoxLBL.BackColor = System.Drawing.Color.Transparent;
            this.insertTextBoxLBL.Location = new System.Drawing.Point(781, 39);
            this.insertTextBoxLBL.Name = "insertTextBoxLBL";
            this.insertTextBoxLBL.Size = new System.Drawing.Size(49, 47);
            this.insertTextBoxLBL.TabIndex = 30;
            this.insertTextBoxLBL.Click += new System.EventHandler(this.insertTextBoxLBL_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::PowerPoint.Properties.Resources.HomeSmaller1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PowerPoint.Properties.Resources.Home21;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1764, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // colorPictureBox
            // 
            this.colorPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.colorPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.colorPictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.colorPictureBox.Image = global::PowerPoint.Properties.Resources.icons8_text_color_48;
            this.colorPictureBox.Location = new System.Drawing.Point(406, 86);
            this.colorPictureBox.Name = "colorPictureBox";
            this.colorPictureBox.Size = new System.Drawing.Size(39, 39);
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
            this.button4.Location = new System.Drawing.Point(100, 106);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(43, 43);
            this.button4.TabIndex = 14;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::PowerPoint.Properties.Resources.copy;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(100, 57);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(43, 44);
            this.button3.TabIndex = 13;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::PowerPoint.Properties.Resources.cut;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(100, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(43, 44);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSlideToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(192, 40);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // deleteSlideToolStripMenuItem
            // 
            this.deleteSlideToolStripMenuItem.Name = "deleteSlideToolStripMenuItem";
            this.deleteSlideToolStripMenuItem.Size = new System.Drawing.Size(191, 36);
            this.deleteSlideToolStripMenuItem.Text = "delete slide";
            this.deleteSlideToolStripMenuItem.Click += new System.EventHandler(this.deleteSlideToolStripMenuItem_Click);
            // 
            // paste
            // 
            this.paste.Name = "paste";
            this.paste.Size = new System.Drawing.Size(270, 44);
            this.paste.Text = "paste";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
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
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(2325, 231);
            this.Load += new System.EventHandler(this.HomeControl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newSlidePictureBox)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPictureBox)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private MyLabel rightToLeftLBL;
        private MyLabel shapeColorFillLBL;
        private MyLabel shapeOutlineColorLBL;
        private MyLabel numberBulletLBL;
        private MyLabel shpareBulletLBL;
        private MyLabel lineSpaceLBL;
        private MyLabel leftToRightLBL;
        private MyLabel leftLBL;
        private MyLabel centerLBL;
        private MyLabel rightLBL;
        private MyLabel insertTextBoxLBL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteSlideToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paste;
    }
}
