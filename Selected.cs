using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPoint
{
    class Selected:Control
    {

        public static Control selectedControl = null;

        public static RichTextBoxEx selectedRichTextBox = null;
        public static PictureBox selectedPictureBox = null;

        public static Panel selectedPanel = null;

        public static PictureBox selectedSlidePictureBox = null;
        public static Button selectedSlideButton = null;



        // copy and paste
        public static bool copyTextBoxFlag = false;
        public static bool copyPictureBoxFlag = false;
        public static bool cutTextBoxFlag = false;
        public static bool cutPictureBoxFlag = false;


    }
}
