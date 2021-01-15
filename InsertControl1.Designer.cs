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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteSlideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyPictureBoxStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cutPictureBoxStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePictureBoxStripMenu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newSlideLBL = new PowerPoint.MyLabel();
            this.insertPictureLBL = new PowerPoint.MyLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSlideToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(192, 40);
            // 
            // deleteSlideToolStripMenuItem
            // 
            this.deleteSlideToolStripMenuItem.Name = "deleteSlideToolStripMenuItem";
            this.deleteSlideToolStripMenuItem.Size = new System.Drawing.Size(191, 36);
            this.deleteSlideToolStripMenuItem.Text = "delete slide";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyPictureBoxStripMenuItem1,
            this.toolStripSeparator1,
            this.cutPictureBoxStripMenuItem1,
            this.DeletePictureBoxStripMenu1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 142);
            // 
            // copyPictureBoxStripMenuItem1
            // 
            this.copyPictureBoxStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.copyPictureBoxStripMenuItem1.Name = "copyPictureBoxStripMenuItem1";
            this.copyPictureBoxStripMenuItem1.Size = new System.Drawing.Size(171, 44);
            this.copyPictureBoxStripMenuItem1.Text = "copy";
            this.copyPictureBoxStripMenuItem1.Click += new System.EventHandler(this.copyPictureBoxStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(168, 6);
            // 
            // cutPictureBoxStripMenuItem1
            // 
            this.cutPictureBoxStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cutPictureBoxStripMenuItem1.Name = "cutPictureBoxStripMenuItem1";
            this.cutPictureBoxStripMenuItem1.Size = new System.Drawing.Size(171, 44);
            this.cutPictureBoxStripMenuItem1.Text = "cut";
            this.cutPictureBoxStripMenuItem1.Click += new System.EventHandler(this.cutPictureBoxStripMenuItem1_Click);
            // 
            // DeletePictureBoxStripMenu1
            // 
            this.DeletePictureBoxStripMenu1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DeletePictureBoxStripMenu1.Name = "DeletePictureBoxStripMenu1";
            this.DeletePictureBoxStripMenu1.Size = new System.Drawing.Size(171, 44);
            this.DeletePictureBoxStripMenu1.Text = "Delete";
            this.DeletePictureBoxStripMenu1.Click += new System.EventHandler(this.DeletePictureBoxStripMenu1_Click);
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
            // insertPictureLBL
            // 
            this.insertPictureLBL.BackColor = System.Drawing.Color.Transparent;
            this.insertPictureLBL.Location = new System.Drawing.Point(205, 0);
            this.insertPictureLBL.Name = "insertPictureLBL";
            this.insertPictureLBL.Size = new System.Drawing.Size(85, 128);
            this.insertPictureLBL.TabIndex = 2;
            this.insertPictureLBL.Click += new System.EventHandler(this.insertPictureLBL_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MyLabel insertPictureLBL;
        private MyLabel newSlideLBL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem deleteSlideToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyPictureBoxStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem DeletePictureBoxStripMenu1;
        private System.Windows.Forms.ToolStripMenuItem cutPictureBoxStripMenuItem1;
    }
}
