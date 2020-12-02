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
            //MessageBox.Show("delete pressed");
            if (e.KeyCode == Keys.Delete || e.KeyCode == Keys.Back)
            {
               // MessageBox.Show("delete pressed");
                //e.Handled = true;
            }
        }

        private void EditorContainer_MouseClick(object sender, MouseEventArgs e)
        {
            if (MainForm.Instance.transitionCtrl.transitionStarted)
            {
                //MessageBox.Show("editor mouse click activated");
                MainForm.Instance.wordTabControl.Show();
                MainForm.Instance.TopPanel.Show();
                MainForm.Instance.editorContainer.tableLayoutSlides.Show();
                MainForm.Instance.editorContainer.splitter1.Show();
                MainForm.Instance.wordTabControl.Show();

                MainForm.Instance.transitionCtrl.transitionStarted = false;


                if (Selected.selectedPanel != null)
                {
                    Selected.selectedPanel.Visible = true;
                    MainForm.Instance.editorContainer.Controls.SetChildIndex(Selected.selectedPanel, 0);
                }

                if (MainForm.Instance.transitionCtrl.transitionStarted)
                {

                   

                }






            }
        }


        private void EditorContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditorContainer_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("EditorContainer just painted");

        
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void PasteStrip_Click(object sender, EventArgs e)
        {
          
        }
    }
}
