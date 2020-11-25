using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPoint
{
    class MyLabel : Label {


        protected override void OnClick(EventArgs e) {

            //you can write your own code to be run when user click it, and you also run the base code of 
            // click event 
            //MessageBox.Show("ahmad rasheed "); 
            base.OnClick(e);
            
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.BorderStyle = BorderStyle.Fixed3D;
            base.OnMouseHover(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.BorderStyle = BorderStyle.None;
            base.OnMouseLeave(e);
        }

        public override bool AutoSize { get => base.AutoSize; set => base.AutoSize = false; }
        public override Color BackColor { get => base.BackColor; set => base.BackColor = Color.Transparent; }
        public override string Text { get => base.Text; set => base.Text = ""; }
    }
}
