namespace PowerPoint
{
    partial class InsertControl1
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openAhmadInsertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.insertPictureLBL = new PowerPoint.MyLabel();
            this.newSlideLBL = new PowerPoint.MyLabel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAhmadInsertToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(207, 76);
            // 
            // openAhmadInsertToolStripMenuItem
            // 
            this.openAhmadInsertToolStripMenuItem.Name = "openAhmadInsertToolStripMenuItem";
            this.openAhmadInsertToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.openAhmadInsertToolStripMenuItem.Text = "copy  ahmad";
            this.openAhmadInsertToolStripMenuItem.Click += new System.EventHandler(this.openAhmadInsertToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(206, 36);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::PowerPoint.Properties.Resources.insert;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2325, 234);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // insertPictureLBL
            // 
            this.insertPictureLBL.BackColor = System.Drawing.Color.Transparent;
            this.insertPictureLBL.Location = new System.Drawing.Point(205, 0);
            this.insertPictureLBL.Name = "insertPictureLBL";
            this.insertPictureLBL.Size = new System.Drawing.Size(85, 128);
            this.insertPictureLBL.TabIndex = 2;
            this.insertPictureLBL.Click += new System.EventHandler(this.insertPictureLBL_Click);
            // 
            // newSlideLBL
            // 
            this.newSlideLBL.BackColor = System.Drawing.Color.Transparent;
            this.newSlideLBL.Location = new System.Drawing.Point(3, 10);
            this.newSlideLBL.Name = "newSlideLBL";
            this.newSlideLBL.Size = new System.Drawing.Size(85, 169);
            this.newSlideLBL.TabIndex = 3;
            this.newSlideLBL.Click += new System.EventHandler(this.newSlideLBL_Click);
            // 
            // InsertControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.newSlideLBL);
            this.Controls.Add(this.insertPictureLBL);
            this.Controls.Add(this.pictureBox1);
            this.Name = "InsertControl1";
            this.Size = new System.Drawing.Size(2325, 234);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openAhmadInsertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MyLabel insertPictureLBL;
        private MyLabel newSlideLBL;
    }
}
