using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using viewerGui;
using AForge;

namespace viewerGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //2D TAB
        private void open_button_Click(object sender, EventArgs e)
        {

        }

        private void save2d_button_Click(object sender, EventArgs e)
        {

        }

        private void left_button_Click(object sender, EventArgs e)
        {

        }

        private void both_button_Click(object sender, EventArgs e)
        {

        }

        private void right_button_Click(object sender, EventArgs e)
        {

        }

        private void left_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void right_pictureBox_Click(object sender, EventArgs e)
        {

        }

        //3D TAB
        private void save3d_button_Click(object sender, EventArgs e)
        {

        }

        private void make3D_Click(object sender, EventArgs e)
        {
            AForge.Imaging.Filters.StereoAnaglyph filter = new AForge.Imaging.Filters.StereoAnaglyph();
            // set right image as overlay
            Bitmap rightImage = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\right.bmp");
            Bitmap leftImage = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\left.bmp");
            filter.OverlayImage = rightImage;
            // apply the filter
            Bitmap resultImage = filter.Apply(leftImage);
            threeD_pictureBox.Image = resultImage;
        }
    }
}
