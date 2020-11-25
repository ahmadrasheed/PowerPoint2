using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPoint
{
    public partial class SlidePreview : Form
    {
        public SlidePreview()
        {
            InitializeComponent();
        }

        private void SlidePreview_Load(object sender, EventArgs e)
        {
            Form f = new MainForm();
            this.MdiParent = f;
        }
    }
}
