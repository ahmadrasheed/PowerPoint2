using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;

namespace PowerPoint
{
    
    public partial class InsertControl1 : UserControl
    {

        int xLocation = 50, yLocation = 100;


        public InsertControl1()
        {
            InitializeComponent();


            // to make the lable transparant
            pictureBox1.Controls.Add(insertPictureLBL);
         
            

        }


       

     
        private void label2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("just added");
            Selected.selectedRichTextBox.SelectionAlignment = HorizontalAlignment.Right;
            
            //RichTextBox richTextBox1 = MainForm.Instance.editorContainer.richTextBox;

            //foreach (Control c in MainForm.Instance.editorContainer.panel2.Controls)
            //{

            //    MessageBox.Show(MainForm.Instance.editorContainer.panel2.Controls.Count.ToString());
            //    if (c is RichTextBox)
            //    { 
            //        richTextBox1.SelectAll();
            //        richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            //        //MessageBox.Show("hello");
            //    }
            //}
            


            //if (richTextBox1.SelectionFont != null)
            //{
            //    richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
            //    //MessageBox.Show("hello3");
            //}
        }

        private void T_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void T_MouseLeave(object sender, EventArgs e)
        {
           

            if (sender is PictureBox)
            {
                PictureBox pic = (PictureBox)sender;
                pic.BorderStyle = BorderStyle.None;
            }
        }

        private void T_MouseHover(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pic = (PictureBox)sender;
                pic.BorderStyle = BorderStyle.FixedSingle; 
            }
        }

        private void T_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox)
            {
                PictureBox pic = (PictureBox)sender;
                pic.BorderStyle = BorderStyle.FixedSingle;
                Selected.selectedPictureBox = (PictureBox)sender;
                Selected.selectedControl = (Control)sender;

                //MainForm.Instance.editorContainer.panel2.Controls.SetChildIndex(Selected.selectedPictureBox.Parent, 0);


            }



        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            Selected.selectedControl.Dispose();

        }

        private void openAhmadInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private myTableLayoutPanel createPanel()
        {
            myTableLayoutPanel tableLayoutPanel1 = new myTableLayoutPanel();

            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2463F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7537F));
            //tableLayoutPanel1.Controls.Add(t, 0, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(xLocation, yLocation);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding();
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.91358F));


            return tableLayoutPanel1;
        }

        private void newSlideLBL_Click(object sender, EventArgs e)
        {
            Panel p = new Panel();
            p.Dock = DockStyle.Fill;
            //MainForm.Instance.editorContainer.Controls.Add(null);
            //MainForm.Instance.editorContainer.Controls.SetChildIndex(p, 0);

        }

        private void insertPictureLBL_Click(object sender, EventArgs e)
        {

            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                PictureBox pic = new PictureBox();
                pic.Image = new Bitmap(open.FileName);
                // image file path  
                //textBox1.Text = open.FileName;



                //pic.Size = new System.Drawing.Size(600, 600);

                //t.Multiline = true;

            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.Dock = System.Windows.Forms.DockStyle.Fill;
            pic.Margin = new System.Windows.Forms.Padding(5);
            //pic.BackColor = Color.White;
            pic.Location = new System.Drawing.Point(xLocation,yLocation);
            pic.BorderStyle = BorderStyle.None;
            TableLayoutPanel tableLayoutPanel1 = createPanel();
            tableLayoutPanel1.Size = new Size(500, 450);
            tableLayoutPanel1.Controls.Add(pic, 0, 0);


                //MainForm.Instance.editorContainer.panel2.Controls.Add(tableLayoutPanel1);
                Selected.selectedPanel.Controls.Add(tableLayoutPanel1);
                //MainForm.Instance.editorContainer.panel2.Controls.SetChildIndex(tableLayoutPanel1, 0);

                //MainForm.Instance.editorContainer.panel2.Controls.Add(pic);


                xLocation += 50; yLocation += 50;

            pic.BorderStyle = BorderStyle.None;
            pic.Click += T_Click;
            pic.MouseDown += T_MouseDown;
            pic.MouseHover += T_MouseHover;
            pic.MouseLeave += T_MouseLeave;
            //MainForm.Instance.editorContainer.panel2.Controls.Add(t);
            
            Selected.selectedPictureBox = pic;

            pic.ContextMenuStrip = contextMenuStrip1;
            //MainForm.Instance.editorContainer.panel2.Controls.Add(tableLayoutPanel1);
            ControlMoverOrResizer.Init(tableLayoutPanel1);
            ControlMoverOrResizer.Init(pic);
            ControlMoverOrResizer.Init(pic, tableLayoutPanel1);


            }// End if 






        }
    } 
}
