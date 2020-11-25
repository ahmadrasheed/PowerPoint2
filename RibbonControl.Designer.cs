namespace PowerPoint
{
    partial class RibbonControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPanel = new PowerPoint.TabPanel();
            this.ViewButton = new PowerPoint.TabButton();
            this.ReviewButton = new PowerPoint.TabButton();
            this.SlideShowButton = new PowerPoint.TabButton();
            this.AnimationsButton = new PowerPoint.TabButton();
            this.TransitionsButton = new PowerPoint.TabButton();
            this.DesignButton = new PowerPoint.TabButton();
            this.InsertButton = new PowerPoint.TabButton();
            this.FileButton = new PowerPoint.ButtonZ();
            this.HomeButton = new PowerPoint.TabButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.panel1.Controls.Add(this.ViewButton);
            this.panel1.Controls.Add(this.ReviewButton);
            this.panel1.Controls.Add(this.SlideShowButton);
            this.panel1.Controls.Add(this.AnimationsButton);
            this.panel1.Controls.Add(this.TransitionsButton);
            this.panel1.Controls.Add(this.DesignButton);
            this.panel1.Controls.Add(this.InsertButton);
            this.panel1.Controls.Add(this.FileButton);
            this.panel1.Controls.Add(this.HomeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2065, 62);
            this.panel1.TabIndex = 2;
            // 
            // tabPanel
            // 
            this.tabPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.tabPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPanel.Location = new System.Drawing.Point(0, 62);
            this.tabPanel.Margin = new System.Windows.Forms.Padding(5);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(2065, 259);
            this.tabPanel.SkipXRange = new System.Drawing.Point(61, 0);
            this.tabPanel.TabIndex = 3;
            this.tabPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tabPanel_Paint);
            // 
            // ViewButton
            // 
            this.ViewButton.BackColorTB = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ViewButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.ViewButton.ChangeColorMouseHC = true;
            this.ViewButton.DisplayText = "VIEW";
            this.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.ViewButton.Location = new System.Drawing.Point(1063, 12);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(5);
            this.ViewButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.ShowBorder = true;
            this.ViewButton.Size = new System.Drawing.Size(92, 44);
            this.ViewButton.TabIndex = 7;
            this.ViewButton.Text = "VIEW";
            this.ViewButton.TextLocation_X = 10;
            this.ViewButton.TextLocation_Y = 4;
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // ReviewButton
            // 
            this.ReviewButton.BackColorTB = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ReviewButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.ReviewButton.ChangeColorMouseHC = true;
            this.ReviewButton.DisplayText = "REVIEW";
            this.ReviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReviewButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.ReviewButton.Location = new System.Drawing.Point(945, 12);
            this.ReviewButton.Margin = new System.Windows.Forms.Padding(5);
            this.ReviewButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.ReviewButton.Name = "ReviewButton";
            this.ReviewButton.ShowBorder = true;
            this.ReviewButton.Size = new System.Drawing.Size(108, 44);
            this.ReviewButton.TabIndex = 6;
            this.ReviewButton.Text = "REVIEW";
            this.ReviewButton.TextLocation_X = 10;
            this.ReviewButton.TextLocation_Y = 4;
            this.ReviewButton.UseVisualStyleBackColor = true;
            this.ReviewButton.Click += new System.EventHandler(this.ReviewButton_Click);
            // 
            // SlideShowButton
            // 
            this.SlideShowButton.BackColorTB = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.SlideShowButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.SlideShowButton.ChangeColorMouseHC = true;
            this.SlideShowButton.DisplayText = "SLIDE SHOW";
            this.SlideShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlideShowButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SlideShowButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.SlideShowButton.Location = new System.Drawing.Point(793, 12);
            this.SlideShowButton.Margin = new System.Windows.Forms.Padding(5);
            this.SlideShowButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.SlideShowButton.Name = "SlideShowButton";
            this.SlideShowButton.ShowBorder = true;
            this.SlideShowButton.Size = new System.Drawing.Size(142, 44);
            this.SlideShowButton.TabIndex = 5;
            this.SlideShowButton.Text = "SLIDE SHOW";
            this.SlideShowButton.TextLocation_X = 8;
            this.SlideShowButton.TextLocation_Y = 4;
            this.SlideShowButton.UseVisualStyleBackColor = true;
            this.SlideShowButton.Click += new System.EventHandler(this.SlideShowButton_Click);
            // 
            // AnimationsButton
            // 
            this.AnimationsButton.BackColorTB = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.AnimationsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.AnimationsButton.ChangeColorMouseHC = true;
            this.AnimationsButton.DisplayText = "ANIMATIONS";
            this.AnimationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnimationsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnimationsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.AnimationsButton.Location = new System.Drawing.Point(633, 12);
            this.AnimationsButton.Margin = new System.Windows.Forms.Padding(5);
            this.AnimationsButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.AnimationsButton.Name = "AnimationsButton";
            this.AnimationsButton.ShowBorder = true;
            this.AnimationsButton.Size = new System.Drawing.Size(150, 44);
            this.AnimationsButton.TabIndex = 4;
            this.AnimationsButton.Text = "ANIMATIONS";
            this.AnimationsButton.TextLocation_X = 8;
            this.AnimationsButton.TextLocation_Y = 4;
            this.AnimationsButton.UseVisualStyleBackColor = true;
            this.AnimationsButton.Click += new System.EventHandler(this.AnimationsButton_Click);
            // 
            // TransitionsButton
            // 
            this.TransitionsButton.BackColorTB = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.TransitionsButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.TransitionsButton.ChangeColorMouseHC = true;
            this.TransitionsButton.DisplayText = "TRANSITIONS";
            this.TransitionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransitionsButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransitionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.TransitionsButton.Location = new System.Drawing.Point(457, 12);
            this.TransitionsButton.Margin = new System.Windows.Forms.Padding(5);
            this.TransitionsButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.TransitionsButton.Name = "TransitionsButton";
            this.TransitionsButton.ShowBorder = true;
            this.TransitionsButton.Size = new System.Drawing.Size(167, 44);
            this.TransitionsButton.TabIndex = 3;
            this.TransitionsButton.Text = "TRANSITIONS";
            this.TransitionsButton.TextLocation_X = 10;
            this.TransitionsButton.TextLocation_Y = 4;
            this.TransitionsButton.UseVisualStyleBackColor = true;
            this.TransitionsButton.Click += new System.EventHandler(this.TransitionsButton_Click);
            // 
            // DesignButton
            // 
            this.DesignButton.BackColorTB = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.DesignButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.DesignButton.ChangeColorMouseHC = true;
            this.DesignButton.DisplayText = "DESIGN";
            this.DesignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DesignButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesignButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.DesignButton.Location = new System.Drawing.Point(338, 12);
            this.DesignButton.Margin = new System.Windows.Forms.Padding(5);
            this.DesignButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.DesignButton.Name = "DesignButton";
            this.DesignButton.ShowBorder = true;
            this.DesignButton.Size = new System.Drawing.Size(108, 44);
            this.DesignButton.TabIndex = 2;
            this.DesignButton.Text = "DESIGN";
            this.DesignButton.TextLocation_X = 10;
            this.DesignButton.TextLocation_Y = 4;
            this.DesignButton.UseVisualStyleBackColor = true;
            this.DesignButton.Click += new System.EventHandler(this.DesignButton_Click);
            // 
            // InsertButton
            // 
            this.InsertButton.BackColorTB = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.InsertButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.InsertButton.ChangeColorMouseHC = true;
            this.InsertButton.DisplayText = "INSERT";
            this.InsertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.InsertButton.Location = new System.Drawing.Point(220, 12);
            this.InsertButton.Margin = new System.Windows.Forms.Padding(5);
            this.InsertButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.ShowBorder = true;
            this.InsertButton.Size = new System.Drawing.Size(108, 44);
            this.InsertButton.TabIndex = 2;
            this.InsertButton.Text = "INSERT";
            this.InsertButton.TextLocation_X = 12;
            this.InsertButton.TextLocation_Y = 4;
            this.InsertButton.UseVisualStyleBackColor = true;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // FileButton
            // 
            this.FileButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.FileButton.DisplayText = "FILE";
            this.FileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileButton.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileButton.ForeColor = System.Drawing.Color.White;
            this.FileButton.Location = new System.Drawing.Point(0, 12);
            this.FileButton.Margin = new System.Windows.Forms.Padding(5);
            this.FileButton.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.FileButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.FileButton.Name = "FileButton";
            this.FileButton.Size = new System.Drawing.Size(92, 44);
            this.FileButton.TabIndex = 0;
            this.FileButton.Text = "FILE";
            this.FileButton.TextLocation_X = 12;
            this.FileButton.TextLocation_Y = 2;
            this.FileButton.UseVisualStyleBackColor = true;
            this.FileButton.Click += new System.EventHandler(this.FileButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackColorTB = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.HomeButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.HomeButton.ChangeColorMouseHC = true;
            this.HomeButton.DisplayText = "HOME";
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.HomeButton.Location = new System.Drawing.Point(102, 12);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(5);
            this.HomeButton.MouseHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.ShowBorder = true;
            this.HomeButton.Size = new System.Drawing.Size(108, 44);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "HOME";
            this.HomeButton.TextLocation_X = 12;
            this.HomeButton.TextLocation_Y = 4;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // RibbonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RibbonControl";
            this.Size = new System.Drawing.Size(2065, 321);
            this.Load += new System.EventHandler(this.WordabControl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public ButtonZ FileButton;
        public TabPanel tabPanel;
        public TabButton HomeButton;
        public TabButton InsertButton;
        public TabButton DesignButton;
        public TabButton ViewButton;
        public TabButton ReviewButton;
        public TabButton SlideShowButton;
        public TabButton AnimationsButton;
        public TabButton TransitionsButton;
        private System.Windows.Forms.Panel panel1;

    }
}
