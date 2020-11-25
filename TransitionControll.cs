using BunifuAnimatorNS;
using System;
using System.Windows.Forms;

namespace PowerPoint
{
    public partial class TransitionControl : UserControl
    {
        public TransitionControl()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pushTransitionLBL);
            pictureBox1.Controls.Add(cutTransitionLBL);
            pictureBox1.Controls.Add(wipeTransitionLBL);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void myLabel1_Click(object sender, EventArgs e)
        {

            BunifuTransition transition = new BunifuTransition();
            transition.HideSync(Selected.selectedPanel, false, BunifuAnimatorNS.Animation.Leaf);




            //MessageBox.Show("Transitioning");
            //animator1.Hide(
            //.Instance.editorContainer.panel2);
            //animator1.Show(MainForm.Instance.editorContainer.panel2);
            //animator1.HideSync(MainForm.Instance.editorContainer.panel2);
            //animator1.ShowSync(MainForm.Instance.editorContainer.panel2);
            //bunifuTransition2.HideSync(Selected.selectedRichTextBox);
            //bunifuTransition2.ShowSync(Selected.selectedRichTextBox);
            //animator1.WaitAllAnimations();
            //zeroitTransitor1.Target=MainForm.Instance.editorContainer.panel2;

        }

        private void pushTransitionLBL_Click(object sender, EventArgs e)
        {
            BunifuTransition transition = new BunifuTransition();
            transition.ShowSync(Selected.selectedPanel, false, BunifuAnimatorNS.Animation.HorizSlideAndRotate);


            //animator1.BeginUpdate(Selected.selectedRichTextBox);
            //Selected.selectedRichTextBox.BackColor = Color.Green;

            //animator1.EndUpdate(Selected.selectedRichTextBox);

            //animator1.Hide(Selected.selectedRichTextBox);
            //animator1.Show(Selected.selectedRichTextBox);

            // Transition t = new Transition(new TransitionType_EaseInEaseOut(2000));
            //t.add(MainForm.Instance.editorContainer.panel2, "Left", 300);
            //t.add(MainForm.Instance.editorContainer.panel2, "Top", 200);
            //t.run();



        }

        private void myLabel2_Click(object sender, EventArgs e)
        {
            //zeroitOJAnim1.Control = MainForm.Instance.editorContainer.panel2;
            //zeroitOJAnim1.Start();
            //Panel p = MainForm.Instance.editorContainer;
            zeroitAnimatorEdit1.Target = Selected.selectedPanel;
            zeroitAnimatorEdit1.TargetHeight = Selected.selectedPanel.Height;
            zeroitAnimatorEdit1.TargetWidth = Selected.selectedPanel.Width;
            zeroitAnimatorEdit1.Activate();
        }
    }
}
