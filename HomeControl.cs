using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

// ahmad rasheed algeboory 07725869606
namespace PowerPoint
{
    public partial class HomeControl : UserControl
    {
        public  int xLocation = 250;
        public  int yLocation = 50;
        public  HomeControl()
        {
            InitializeComponent();
       
            pictureBox1.Controls.Add(insertTextBoxLBL);
            pictureBox1.Controls.Add(leftLBL);
            pictureBox1.Controls.Add(centerLBL);
            pictureBox1.Controls.Add(rightLBL);
            pictureBox1.Controls.Add(rightToLeftLBL);
            pictureBox1.Controls.Add(leftToRightLBL);
            pictureBox1.Controls.Add(shpareBulletLBL);
            pictureBox1.Controls.Add(numberBulletLBL);
            pictureBox1.Controls.Add(lineSpaceLBL);
            pictureBox1.Controls.Add(shapeColorFillLBL);
            pictureBox1.Controls.Add(shapeOutlineColorLBL);

            if (Selected.selectedPanel==null)
            {
                newSlide(); // حتى لا يضيف اكثر من بانل عند تحديث فورم التابات
            }
            

            //TransparetBackground(insertTextBoxLbl);


        }

        public void newSlide() {
            Panel p = new Panel();
            p.Dock = DockStyle.Fill;
            p.BackColor = Color.White;
            p.Size = new Size(200, 300);
            
            p.Click += P_Click;
            


            int rowCount = MainForm.Instance.editorContainer.tableLayoutSlides.RowCount;
            p.Tag = rowCount;
            MainForm.Instance.editorContainer.Controls.Add(p);
            Selected.selectedPanel = p;
            MainForm.Instance.editorContainer.Controls.SetChildIndex(Selected.selectedPanel, 0);



            PictureBox b = new PictureBox();
            b.Size = new Size(150, 120);
            b.BackColor = Color.Red;
            b.BorderStyle = BorderStyle.Fixed3D;
            b.SizeMode = PictureBoxSizeMode.StretchImage;
            b.ContextMenuStrip = contextMenuStrip2;

            Bitmap bb = new Bitmap(Selected.selectedPanel.Width, Selected.selectedPanel.Height);
            Selected.selectedPanel.DrawToBitmap(bb, new Rectangle(0, 0, bb.Width, bb.Height));
            b.Image = bb;

            TableLayoutPanel Table = MainForm.Instance.editorContainer.tableLayoutSlides;
            Table.RowCount = Table.RowCount + 1;
            //b.Text = Table.RowCount.ToString();


            Selected.selectedSlidePictureBox = b;


            b.Tag = rowCount; // ASSIGN a number to be used to selected this control which will be the same for panel
            b.Click += B_Click;
            //b.MinimumSize = new Size(150, 130);
            
            Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            Table.Controls.Add(b, 0, Table.RowCount - 1);
            
            Table.RowStyles[rowCount - 1].Height = 150;
            //Table.MaximumSize = new Size(Table.Width,Table.Height+150);

            
        }
        public void B_Click(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            Selected.selectedSlidePictureBox = b;

            int tag = (int)b.Tag;
            foreach (Control c in MainForm.Instance.editorContainer.Controls)
            {
                if (c is Panel && c.Tag != null)
                {
                    c.Visible = false;
                    if ((int)c.Tag == tag)
                    {
                        //c.Dispose();
                        //b.Dispose();
                        c.Visible = true;

                        Selected.selectedPanel = (Panel)c;
                       

                    }

                }

            }
        }

        private void P_Click(object sender, EventArgs e)
        {
            //Panel c = sender as Panel;
            if (screenShotControl(Selected.selectedPanel) != null) 
            
            {
                Selected.selectedSlidePictureBox.Image = screenShotControl(Selected.selectedPanel);


            }

        }

        private static Bitmap screenShotControl(Panel c)
        {
            Bitmap b;
            

            try
            {
                b = new Bitmap(c.Width, c.Height);

                c.DrawToBitmap(b, new Rectangle(0, 0, b.Width, b.Height));

                //Selected.selectedSlidePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                //Selected.selectedSlidePictureBox.Image = b;

                return b;
            }
            catch (Exception)
            {
               // b = new Bitmap(400, 400);
               // MessageBox.Show("عذراً، حدث خطأ يرجى اعادة تشغيل البرنامج");

               // screenShotControl(new Panel());
                return null;
            }

           
          
           
        }

        public  void createRTB(Color backcolor,String text="",int x=100,int y=100) {


            RichTextBoxEx t = new RichTextBoxEx();
            t.Text = "اكتب النص هنا  ";
            t.Size = new System.Drawing.Size(300, 200);
            //t.Multiline = true;
            t.WordWrap = true;
            t.Font = new Font("Georgia", 20);
            t.EnableAutoDragDrop = true;
            t.ShortcutsEnabled = true;
            t.Dock = System.Windows.Forms.DockStyle.Fill;
            t.Margin = new System.Windows.Forms.Padding(2);
            t.BackColor = Color.White;
            t.Location = new System.Drawing.Point(x, y);
            t.BorderStyle = BorderStyle.None;
            TableLayoutPanel tableLayoutPanel1 = createPanel();
            tableLayoutPanel1.Size = new Size(300,150);
            tableLayoutPanel1.Controls.Add(t, 0, 0);


            Selected.selectedRichTextBox = t;
           
            Selected.selectedPanel.Controls.Add(tableLayoutPanel1);

            //MessageBox.Show("ok");
            //MainForm.Instance.editorContainer.panel2.Controls.Add(tableLayoutPanel1);

            xLocation += 50; yLocation += 50;  
            if (xLocation > 800)  // حتى لا يعبر حدود الصفحة عند اضافة العديد من مربعات النصوص
            {
                xLocation = 250;
                yLocation = 40;
            }

            t.BorderStyle = BorderStyle.None;
            t.Click += T_Click;
            t.MouseHover += P_Click;
            t.Click += P_Click;
            t.MouseDown += T_MouseDown;
            t.MouseHover += T_MouseHover;
           
            t.MouseLeave += T_MouseLeave;
            //MainForm.Instance.editorContainer.panel2.Controls.Add(t);
           

            t.ContextMenuStrip = contextMenuStrip1;
            //MainForm.Instance.editorContainer.panel2.Controls.Add(tableLayoutPanel1);
            ControlMoverOrResizer.Init(tableLayoutPanel1);
            ControlMoverOrResizer.Init(t);
            ControlMoverOrResizer.Init(t, tableLayoutPanel1);
            //this.Invalidate();
        }
 
        public void copyRTB() {
            RichTextBoxEx t = new RichTextBoxEx();
            t = Selected.selectedRichTextBox;

            //t.Multiline = true;
            t.Rtf = Selected.selectedRichTextBox.Rtf;
            t.Dock = DockStyle.Fill;
            t.Click += T_Click;
            t.MouseDown += T_MouseDown;
            t.MouseHover += T_MouseHover;
            t.MouseLeave += T_MouseLeave;

            //t.BackColor = Color.Green;

            myTableLayoutPanel tableLayoutPanel1 = new myTableLayoutPanel();

            
            tableLayoutPanel1 = Selected.selectedRichTextBox.Parent as myTableLayoutPanel;
            
            Selected.selectedRichTextBox = t;

            t.ContextMenuStrip = contextMenuStrip1;
            Selected.selectedPanel.Controls.Add(tableLayoutPanel1);
            ControlMoverOrResizer.Init(tableLayoutPanel1);
            ControlMoverOrResizer.Init(t);
            ControlMoverOrResizer.Init(t, tableLayoutPanel1);

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
        
        private void testBtn_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Buttn clicked");
        }

        private void boldBtn_Click(object sender, EventArgs e)
        {
            //RichTextBox richTextBox1 = MainForm.Instance.editorContainer.richTextBox;

            if (Selected.selectedRichTextBox != null && Selected.selectedRichTextBox.SelectionFont != null)
            {
                FontStyle fs = Selected.selectedRichTextBox.SelectionFont.Style;
                //Font currentFont = richTextBox1.SelectionFont;
                Font currentFont = Selected.selectedRichTextBox.SelectionFont;

                if (currentFont.Bold == true)
                {
                    fs = fs & (~FontStyle.Bold);
                }
                else
                {
                    fs = fs | FontStyle.Bold;
                }

                Selected.selectedRichTextBox.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   fs
                   );

            }
        }

        private void italicBtn_Click(object sender, EventArgs e)
        {
            //RichTextBox richTextBox1 = MainForm.Instance.editorContainer.richTextBox;
            
            if (Selected.selectedRichTextBox != null && Selected.selectedRichTextBox.SelectionFont != null)
            {
                FontStyle fs = Selected.selectedRichTextBox.SelectionFont.Style;
                Font currentFont = Selected.selectedRichTextBox.SelectionFont;


                if (Selected.selectedRichTextBox.SelectionFont.Italic == true)
                    {
                        fs = fs & (~FontStyle.Italic);
                    }
                else
                    {
                        fs = fs | FontStyle.Italic;
                    }

                Selected.selectedRichTextBox.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   fs
                   );
            }
        }

        private void underlineBtn_Click(object sender, EventArgs e)
        {
            //RichTextBox richTextBox1 = MainForm.Instance.editorContainer.richTextBox;



            if (Selected.selectedRichTextBox != null && Selected.selectedRichTextBox.SelectionFont != null)
            {
                FontStyle fs = Selected.selectedRichTextBox.SelectionFont.Style;
                Font currentFont = Selected.selectedRichTextBox.SelectionFont;


                if (Selected.selectedRichTextBox.SelectionFont.Underline == true)
                {
                    fs = fs & (~FontStyle.Underline);
                }
                else
                {
                    fs = fs | FontStyle.Underline;
                }

                Selected.selectedRichTextBox.SelectionFont = new Font(
                   currentFont.FontFamily,
                   currentFont.Size,
                   fs
                   );
            }
        }

        private void fontSizeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            //Selected.selectedRichTextBox.SelectAll();
            if (Selected.selectedRichTextBox!= null)
                if (Selected.selectedRichTextBox.SelectionFont != null)
                {
                    Font currentFont = Selected.selectedRichTextBox.SelectionFont;

                    Selected.selectedRichTextBox.SelectionFont = new Font(currentFont.FontFamily, Convert.ToInt32(fontSizeCB.SelectedItem), currentFont.Style);
                }
        
        }

        private void fontFamilyCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                //MessageBox.Show("yes is here");
                if (Selected.selectedRichTextBox !=null && Selected.selectedRichTextBox.SelectionFont != null)
                {
                    
                    Font currentFont = Selected.selectedRichTextBox.SelectionFont;
                    Selected.selectedRichTextBox.SelectionFont = new Font(fontFamilyCB.SelectedItem.ToString(), currentFont.Size, currentFont.Style);
                }
                
            
    }

        private void colorPictureBox_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK && Selected.selectedRichTextBox != null && Selected.selectedRichTextBox.SelectionFont != null)
            {
                Selected.selectedRichTextBox.SelectionColor = colorDialog1.Color;
            }
        }

        private void colorPictureBox_MouseLeave(object sender, EventArgs e)
        {
            colorPictureBox.BorderStyle = BorderStyle.None;


        }

       

        private void colorPictureBox_MouseHover(object sender, EventArgs e)
        {
            
                colorPictureBox.BorderStyle = BorderStyle.Fixed3D;
            
        }

        private void newSlidePictureBox_MouseHover(object sender, EventArgs e)
        {
            
            newSlidePictureBox.BorderStyle = BorderStyle.Fixed3D;
        }

        private void newSlidePictureBox_MouseLeave(object sender, EventArgs e)
        {
            newSlidePictureBox.BorderStyle = BorderStyle.None;
        }

           

        private void T_MouseDown(object sender, MouseEventArgs e)
        {
            Selected.selectedRichTextBox = (RichTextBoxEx)sender;
            Selected.selectedControl = (Control)sender;
        }

        private void T_MouseLeave(object sender, EventArgs e)
        {
            RichTextBox t = (RichTextBox)sender;
            t.BorderStyle = BorderStyle.None;

            t.Parent.Padding = new System.Windows.Forms.Padding(0);

            t.Tag = "";

        }

        private void T_MouseHover(object sender, EventArgs e)
        {
            RichTextBox t = (RichTextBox)sender;
            t.BorderStyle = BorderStyle.FixedSingle;
            t.Parent.Padding = new System.Windows.Forms.Padding(2);
        }

        private void T_Click(object sender, EventArgs e)
        {
            RichTextBoxEx t = (RichTextBoxEx)sender;
            t.BorderStyle = BorderStyle.FixedSingle;
            t.Tag = "selected";
            
            Selected.selectedRichTextBox.Invalidate();
            Selected.selectedRichTextBox = (RichTextBoxEx)sender;
            Selected.selectedControl = (Control)sender;

            //MainForm.Instance.editorContainer.se.Controls.SetChildIndex(Selected.selectedRichTextBox.Parent, 0);
            Selected.selectedPanel.Controls.SetChildIndex(Selected.selectedRichTextBox.Parent,0);

        }

  
        public static void nonLableBorderStyle( object sender) {
            Label l = (Label)sender;
            l.BorderStyle = BorderStyle.None;
        
        }
        public static void fixed3DLableBorderStyle(Object sender)
        {
            Label l = (Label)sender;
            l.BorderStyle = BorderStyle.Fixed3D;

        }

      
        private void insertTextBoxLBL_Click(object sender, EventArgs e)
        {
            createRTB(Color.White, "اكتب النص هنا");
            /*
            RichTextBoxEx t = new RichTextBoxEx();
            t.Text = "اكتب النص هنا  ";
            t.Size = new System.Drawing.Size(300, 200);
            //t.Multiline = true;
            t.WordWrap = true;
            t.Font = new Font("Georgia", 20);
            t.EnableAutoDragDrop = true;
            t.ShortcutsEnabled = true;
            t.Dock= System.Windows.Forms.DockStyle.Fill;
            t.Margin = new System.Windows.Forms.Padding(2);
            t.BackColor = Color.White;
            t.Location = new System.Drawing.Point(xLocation, yLocation);
            t.BorderStyle = BorderStyle.None;
            TableLayoutPanel tableLayoutPanel1 = new myTableLayoutPanel();


           tableLayoutPanel1.BackColor = System.Drawing.Color.White;
           tableLayoutPanel1.ColumnCount = 1;
           tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2463F));
           tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7537F));
           tableLayoutPanel1.Controls.Add(t, 0, 0);
           tableLayoutPanel1.Location = new System.Drawing.Point(xLocation, yLocation);
           tableLayoutPanel1.Name = "tableLayoutPanel1";
           tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(1);
           tableLayoutPanel1.RowCount = 1;
           tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.91358F));
           tableLayoutPanel1.Size = new System.Drawing.Size(300, 200);
           tableLayoutPanel1.TabIndex = 40;


            MainForm.Instance.editorContainer.panel2.Controls.Add(tableLayoutPanel1);

            xLocation += 50; yLocation += 50;
            
            t.BorderStyle = BorderStyle.None;
            t.Click += T_Click;
            t.MouseDown += T_MouseDown;
            t.MouseHover += T_MouseHover;
            t.MouseLeave += T_MouseLeave;
            //MainForm.Instance.editorContainer.panel2.Controls.Add(t);
            Selected.selectedRichTextBox = t;

            t.ContextMenuStrip = contextMenuStrip1;
            MainForm.Instance.editorContainer.panel2.Controls.Add(tableLayoutPanel1);
            ControlMoverOrResizer.Init(tableLayoutPanel1);
            ControlMoverOrResizer.Init(t);
            ControlMoverOrResizer.Init(t,tableLayoutPanel1);
             */
        }

        private void rightLBL_Click(object sender, EventArgs e)
        {
            if (Selected.selectedRichTextBox != null && Selected.selectedRichTextBox.SelectionFont != null)
            {
                Selected.selectedRichTextBox.SelectionAlignment = HorizontalAlignment.Right;
            }
        }

        private void centerLBL_Click(object sender, EventArgs e)
        {
            if (Selected.selectedRichTextBox != null && Selected.selectedRichTextBox.SelectionFont != null)
            {
                Selected.selectedRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            }
        }

        private void leftLBL_Click(object sender, EventArgs e)
        {

            if (Selected.selectedRichTextBox != null && Selected.selectedRichTextBox.SelectionFont != null)
            {
                Selected.selectedRichTextBox.SelectionAlignment = HorizontalAlignment.Left;
            }
        }

   
        private void rightToLeftLBL_Click(object sender, EventArgs e)
        {
            RichTextBox temp = new RichTextBox();


            if (Selected.selectedRichTextBox != null && Selected.selectedRichTextBox.SelectionFont != null)
            {
                temp.Rtf = Selected.selectedRichTextBox.Rtf;
                FontStyle fs = temp.SelectionFont.Style;
                Font currentFont = temp.SelectionFont;
                Color c = Selected.selectedRichTextBox.SelectionColor;
                Selected.selectedRichTextBox.RightToLeft = RightToLeft.Yes;
                Selected.selectedRichTextBox.SelectAll();
                Selected.selectedRichTextBox.SelectionFont = temp.SelectionFont;
                Selected.selectedRichTextBox.SelectionColor = c;
           
            }
            temp.Dispose();

        }

        private void leftToRightLBL_Click(object sender, EventArgs e)
        {
            RichTextBox temp = new RichTextBox();
            
            
            if (Selected.selectedRichTextBox != null && Selected.selectedRichTextBox.SelectionFont != null)
            {
                temp.Rtf = Selected.selectedRichTextBox.Rtf;
                FontStyle fs = temp.SelectionFont.Style;
                Font currentFont = temp.SelectionFont;
                Color c = Selected.selectedRichTextBox.SelectionColor;
                Selected.selectedRichTextBox.RightToLeft = RightToLeft.No;
                Selected.selectedRichTextBox.SelectAll();
                Selected.selectedRichTextBox.SelectionFont = temp.SelectionFont;
                Selected.selectedRichTextBox.SelectionColor = c;
        
            }
            temp.Dispose();

        
        }

        private void lineSpaceLBL_Click(object sender, EventArgs e)
        {
            //Selected.selectedRichTextBox
        

        }

        private void shpareBulletLBL_Click(object sender, EventArgs e)
        {
           
            if (Selected.selectedRichTextBox != null && Selected.selectedRichTextBox.SelectionFont != null)
            {

                Selected.selectedRichTextBox.BulletIndent = 5;
                Selected.selectedRichTextBox.SelectionIndent = 15;
                Selected.selectedRichTextBox.SelectionBullet = true;
        
            }
        }

        private void numberBulletLBL_Click(object sender, EventArgs e)
        {
            if (Selected.selectedRichTextBox != null && Selected.selectedRichTextBox.SelectionFont != null)
            {

                Selected.selectedRichTextBox.BulletIndent = 5;
                Selected.selectedRichTextBox.SelectionIndent = 15;
                Selected.selectedRichTextBox.BulletType = PowerPoint.RichTextBoxEx.AdvRichTextBulletType.Number;
               
            }
        }

        

        private void openAhmadInsertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            RichTextBoxEx t= RichTextBoxEx.copyRTBX(Selected.selectedRichTextBox);
            myTableLayoutPanel tableLayoutPanel1 = createPanel();
            
            //MessageBox.Show("t :"+t.Size.ToString());
            tableLayoutPanel1.Size = Selected.selectedRichTextBox.Size;
            tableLayoutPanel1.Controls.Add(t, 0, 0);
            tableLayoutPanel1.BackColor = t.Parent.BackColor;
            //copyRTB();
            /*
            RichTextBoxEx t = new RichTextBoxEx();
            //t.Multiline = true;
            t.Text = Selected.selectedRichTextBox.Text;
            t.Size = Selected.selectedRichTextBox.Size;
            //t.Multiline = true;
            t.WordWrap = true;
            t.Font = Selected.selectedRichTextBox.SelectionFont;
            t.EnableAutoDragDrop = true;
            t.WordWrap = true;
            t.Font = new Font("Georgia", 20);
            t.EnableAutoDragDrop = true;
            t.ShortcutsEnabled = true;
            t.Dock = System.Windows.Forms.DockStyle.Fill;
            t.Margin = new System.Windows.Forms.Padding(40);
            t.BackColor = Color.Red;
            t.Location = new System.Drawing.Point(xLocation, yLocation);
            t.BorderStyle = BorderStyle.None;
            */
            t.Click += T_Click;
            t.MouseDown += T_MouseDown;
            t.MouseHover += T_MouseHover;
            t.MouseLeave += T_MouseLeave;


            Selected.selectedPanel.Controls.Add(tableLayoutPanel1);
            //MainForm.Instance.editorContainer.panel2.Controls.Add(t);

            // send this tableLayoutpanel1 to front.
            //MainForm.Instance.editorContainer.panel2.Controls.SetChildIndex(tableLayoutPanel1, 0);

            Selected.selectedRichTextBox = t;



            t.ContextMenuStrip = contextMenuStrip1;
            //MainForm.Instance.editorContainer.panel2.Controls.Add(tableLayoutPanel1);
            ControlMoverOrResizer.Init(tableLayoutPanel1);
            ControlMoverOrResizer.Init(t);
            ControlMoverOrResizer.Init(t, tableLayoutPanel1);
            
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {


            
                Selected.selectedControl.Parent.Dispose();
                Selected.selectedControl.Dispose();

          
                
            
        }

        private void shapeColorFillLBL_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK && Selected.selectedRichTextBox != null && Selected.selectedRichTextBox.SelectionFont != null)
            {
                Selected.selectedRichTextBox.BackColor = colorDialog1.Color;
            }
        }

        private void shapeOutlineColorLBL_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK && Selected.selectedRichTextBox != null && Selected.selectedRichTextBox.SelectionFont != null)
            {
                Selected.selectedRichTextBox.Parent.BackColor = colorDialog1.Color;
            }
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {

        }

        private void newSlidePictureBox_Click(object sender, EventArgs e)
        {
            newSlide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void copySlideToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
        }

        private void deleteSlideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox b = Selected.selectedSlidePictureBox;
            int tag = (int)b.Tag;
            foreach (Control c in MainForm.Instance.editorContainer.Controls)
            {
                if (c is Panel && c.Tag != null)
                {
                    // c.Visible = false;
                    if ((int)c.Tag == tag)
                    {
                        c.Dispose();
                    }
                }
            }

            int RowCount = MainForm.Instance.editorContainer.tableLayoutSlides.RowCount;
            int Rowindex= MainForm.Instance.editorContainer.tableLayoutSlides.GetPositionFromControl(b).Row;

            if (Rowindex >= RowCount)
            {
                return; //get out 
            }
           
                var control = MainForm.Instance.editorContainer.tableLayoutSlides.GetControlFromPosition(0, Rowindex);
                MainForm.Instance.editorContainer.tableLayoutSlides.Controls.Remove(control);

            if (Rowindex<RowCount-1) 
            {
                for (int i = Rowindex + 1; i < RowCount; i++)
                {
                    var cc = MainForm.Instance.editorContainer.tableLayoutSlides.GetControlFromPosition(0, i);
                    if (cc != null)
                    {
                        MainForm.Instance.editorContainer.tableLayoutSlides.SetRow(cc, i - 1);
                    }
                }

            }

            if (Rowindex == RowCount - 1)
            {
                Rowindex--;
            }
                
            MainForm.Instance.editorContainer.tableLayoutSlides.RowStyles.RemoveAt(RowCount - 1);

                if (RowCount > 2)
                {
                    Selected.selectedSlidePictureBox = (PictureBox)MainForm.Instance.editorContainer.tableLayoutSlides.GetControlFromPosition(0, Rowindex);
                    tag = (int)Selected.selectedSlidePictureBox.Tag;
                    foreach (Control c in MainForm.Instance.editorContainer.Controls)
                    {
                        if (c is Panel && c.Tag != null)
                        {
                            // c.Visible = false;
                            if ((int)c.Tag == tag)
                            {
                                //c.Dispose();
                                //b.Dispose();
                                c.Visible = true;
                                Selected.selectedPanel = (Panel)c;
                                MainForm.Instance.editorContainer.Controls.SetChildIndex(Selected.selectedPanel, 0);
                            }
                        }
                    }
                }

            MainForm.Instance.editorContainer.tableLayoutSlides.RowCount--;
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}

/*
this.rEx.BulletIndent = 5;
this.rEx.BulletStyle = PowerPoint.RichTextBoxEx.AdvRichTextBulletStyle.Period;
this.rEx.BulletType = PowerPoint.RichTextBoxEx.AdvRichTextBulletType.Number;
this.rEx.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
this.rEx.Location = new System.Drawing.Point(300, 147);
this.rEx.Name = "rEx";
this.rEx.PrintDocument = null;
this.rEx.Size = new System.Drawing.Size(363, 176);
this.rEx.TabIndex = 38;
this.rEx.Text = "";
*/