using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rogersempier
{
    public partial class FormMain : Form
    {
        //declare variables
        
        public FormMain()
        {// will take you to the ulr page automatically
            InitializeComponent();
            textboxUrl.Text = "google.com";
            //nagative to the URL that is our textbox
            //display what is in our web page control.
            webBrowserControl.Navigate(textboxUrl.Text);
            //will stop javaScript errors from displaying
            webBrowserControl.ScriptErrorsSuppressed = true;
        }

        private void goButton_Click(object sender, EventArgs e)
        {//nagative to the URL that is our textbox
            //display what is in our web page control.
            webBrowserControl.Navigate(textboxUrl.Text);
            //will stop javaScript errors from displaying
            webBrowserControl.ScriptErrorsSuppressed = true;
        }

        private void textboxUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void monthCalendarMarch_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
        // declaring int for image list arrays
        int intImgNum = 0;
        int motherImgNum = 0;
        int wifeImgNum = 0;
        int careerImgNum=0;
        int strengthImgNum = 0;
       
       

        public object ListFile { get; private set; }

        private void timerChangeImage_Tick(object sender, EventArgs e)
        {//setting the first image for the picture box collection
            pictureBoxArt.Image = imageListWorkofArt.Images[intImgNum];
            if (intImgNum == imageListWorkofArt.Images.Count - 1)
            {
                intImgNum = 0;
            }
            else
            {
                intImgNum++;
            }

        }

        private void webBrowserControl_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        

        

        private void WindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxArt_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxFamily_Click(object sender, EventArgs e)
        {

        }

        private void timerMother_Tick(object sender, EventArgs e)
        {//setting the timer for the image to display
            pictureBoxFamily.Image = imageListMother.Images[motherImgNum];
            if (motherImgNum == imageListMother.Images.Count-1)
            {
                motherImgNum = 0;
            }
            else
            {
                motherImgNum++;
            }
        }

        private void timerWife_Tick(object sender, EventArgs e)
        {

            pictureBoxWife.Image = imageListWife.Images[wifeImgNum];
            if (wifeImgNum == imageListWife.Images.Count-1)
            {
                wifeImgNum = 0;
            }
            else
            {
                wifeImgNum++;
            }
        }

        private void timerCareer_Tick(object sender, EventArgs e)
        {
            pictureBoxJob.Image = imageListCareer.Images[careerImgNum];
            if (careerImgNum == imageListCareer.Images.Count-1)
            {
                careerImgNum = 0;
            }
            else
            {
                careerImgNum++;
            }
        }

        private void timerstrength_Tick(object sender, EventArgs e)
        {
            pictureBoxPower.Image = imageListStrength.Images[strengthImgNum];
            if (strengthImgNum == imageListStrength.Images.Count-1)
            {
                strengthImgNum = 0;
            }
            else
            {
                strengthImgNum++;
            }
        }

        private void textBoxMessage_TextChanged(object sender, EventArgs e)
        {
            textBoxMessage.Text = textBoxMessage.Text.Trim();
        }

        private void tabPagevideo_Click(object sender, EventArgs e)
        {

        }
    }
}
