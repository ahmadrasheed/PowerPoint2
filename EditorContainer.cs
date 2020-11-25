using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPoint
{
    public partial class EditorContainer : UserControl
    {
        public EditorContainer()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //panel2.BackColor = Color.White;
        }

        private void EditorContainer_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("delete pressed");
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
                MessageBox.Show("delete pressed");
                //e.Handled = true;
            }
        }

        private void EditorContainer_MouseClick(object sender, MouseEventArgs e)
        {
           // MessageBox.Show("clicked EditoContainer pressed");
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            
        }

      

       

        private void button2_Click(object sender, EventArgs e)
        {
            //panel2.Controls.Clear();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
