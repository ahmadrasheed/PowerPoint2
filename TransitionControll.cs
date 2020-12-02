using BunifuAnimatorNS;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPoint
{
    public partial class TransitionControl : UserControl
    {
        public bool transitionStarted = false;


        public TransitionControl()
        {
            InitializeComponent();
            pictureBox1.Controls.Add(pushTransitionLBL);
            pictureBox1.Controls.Add(cutTransitionLBL);
            pictureBox1.Controls.Add(wipeTransitionLBL);
            pictureBox1.Controls.Add(previewLBL);
            pictureBox1.Controls.Add(coverLBL);
            pictureBox1.Controls.Add(drapeLBL);
            pictureBox1.Controls.Add(FadeLBL);
            pictureBox1.Controls.Add(fallOverLBL);
            pictureBox1.Controls.Add(noneLBL);
            pictureBox1.Controls.Add(randomBarLBL);
            pictureBox1.Controls.Add(revealLBL);
            pictureBox1.Controls.Add(shapeLBL);
            pictureBox1.Controls.Add(splitLBL);
            pictureBox1.Controls.Add(uncoverLBL);

            pictureBox1.Controls.Add(flashLBL);



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void myLabel1_Click(object sender, EventArgs e)
        {
            MainForm.Instance.wordTabControl.Hide();
            MainForm.Instance.TopPanel.Hide();
            MainForm.Instance.editorContainer.tableLayoutSlides.Hide();
            MainForm.Instance.editorContainer.splitter1.Hide();
            MainForm.Instance.wordTabControl.Hide();

            foreach (Control c in MainForm.Instance.editorContainer.Controls)
            {
                if (c is Panel && c.Tag != null)
                {
                    c.Visible = true;
                    BunifuTransition transition = new BunifuTransition();
                    transition.HideSync(c, false, BunifuAnimatorNS.Animation.Mosaic);
                    transition.ShowSync(c, false, BunifuAnimatorNS.Animation.Mosaic);

                    Task.Delay(2000).Wait();
                    //MessageBox.Show("loop 1 ");

                    c.Visible = false;


                    // c.Visible = false;   (int)c.Tag == tag
                    if (false)
                    {
                        //c.Dispose();
                    }
                }
            }




           

            


            MainForm.Instance.transitionCtrl.transitionStarted = true;




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
            transition.HideSync(Selected.selectedPanel, false, BunifuAnimatorNS.Animation.HorizSlideAndRotate);
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

            //zeroitAnimatorEdit1.Target = Selected.selectedPanel;
            //zeroitAnimatorEdit1.TargetHeight = Selected.selectedPanel.Height;
            //zeroitAnimatorEdit1.TargetWidth = Selected.selectedPanel.Width;
            //zeroitAnimatorEdit1.Activate();
        }

        private void previewLBL_Click(object sender, EventArgs e)
        {
            Preview pre = new Preview();
            pre.Show();
        }

        private void revealLBL_Click(object sender, EventArgs e)
        {

        }

        private void FadeLBL_Click(object sender, EventArgs e)
        {
            MainForm.Instance.wordTabControl.Hide();
            MainForm.Instance.TopPanel.Hide();
            MainForm.Instance.editorContainer.tableLayoutSlides.Hide();
            MainForm.Instance.editorContainer.splitter1.Hide();
            MainForm.Instance.wordTabControl.Hide();

            foreach (Control c in MainForm.Instance.editorContainer.Controls)
            {
                if (c is Panel && c.Tag != null)
                {
                    c.Visible = true;
                    BunifuTransition transition = new BunifuTransition();
                    transition.HideSync(c, false, BunifuAnimatorNS.Animation.Transparent);
                    transition.ShowSync(c, false, BunifuAnimatorNS.Animation.Transparent);

                    Task.Delay(2000).Wait();
                    //MessageBox.Show("loop 1 ");

                    c.Visible = false;


                    // c.Visible = false;   (int)c.Tag == tag
                    if (false)
                    {
                        //c.Dispose();
                    }
                }
            }// end Foreach

            MainForm.Instance.transitionCtrl.transitionStarted = true;

        }
    }
}
