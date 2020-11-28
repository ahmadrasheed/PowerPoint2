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
    public partial class DesignControl : UserControl
    {
        public DesignControl()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(myLabel1);
            pictureBox1.Controls.Add(myLabel2);
            pictureBox1.Controls.Add(myLabel3);
            pictureBox1.Controls.Add(myLabel4);
            pictureBox1.Controls.Add(myLabel5);
            pictureBox1.Controls.Add(myLabel6);
            pictureBox1.Controls.Add(myLabel7);
            pictureBox1.Controls.Add(myLabel8);

            pictureBox1.Controls.Add(myLabel9);
            pictureBox1.Controls.Add(myLabel10);
            pictureBox1.Controls.Add(myLabel11);




        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void myLabel3_Click(object sender, EventArgs e)
        {
            Selected.selectedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Selected.selectedPanel.BackgroundImage= PowerPoint.Properties.Resources.greenBackground_;
        }

        private void myLabel5_Click(object sender, EventArgs e)
        {
            Selected.selectedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Selected.selectedPanel.BackgroundImage = PowerPoint.Properties.Resources.greenBackground2_;
        }

        private void myLabel6_Click(object sender, EventArgs e)
        {
            Selected.selectedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Selected.selectedPanel.BackgroundImage = PowerPoint.Properties.Resources.maroonBackground;
        }

        private void myLabel7_Click(object sender, EventArgs e)
        {
            Selected.selectedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Selected.selectedPanel.BackgroundImage = PowerPoint.Properties.Resources.woodBackground;
        }

        private void myLabel8_Click(object sender, EventArgs e)
        {
            Selected.selectedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Selected.selectedPanel.BackgroundImage = PowerPoint.Properties.Resources.whiteBackground;
        }

        private void myLabel9_Click(object sender, EventArgs e)
        {
            Selected.selectedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Selected.selectedPanel.BackgroundImage = PowerPoint.Properties.Resources.blueOceanBackground;
        }

        private void myLabel10_Click(object sender, EventArgs e)
        {
            Selected.selectedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Selected.selectedPanel.BackgroundImage = PowerPoint.Properties.Resources.planetBackground;
        }

        private void myLabel11_Click(object sender, EventArgs e)
        {
            Selected.selectedPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Selected.selectedPanel.BackgroundImage = PowerPoint.Properties.Resources.redMovingBackground;
        }
    }
}
