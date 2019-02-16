using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewerGui
{
    public partial class sobel : Form
    {
        public sobel()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;
        public sobel(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();

            Bitmap resultImage_left = this.mainForm.getSobelImageLeft();
            Bitmap resultImage_right = this.mainForm.getSobelImageRight();
            big_pictureBox.Image = resultImage_left;
            big_pictureBox2.Image = resultImage_right;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            sfd.FileName = "Left_Sobel";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                big_pictureBox.Image.Save(sfd.FileName);
            }
        }

        private void big_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void save3d_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            sfd.FileName = "Right_Sobel";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                big_pictureBox2.Image.Save(sfd.FileName);
            }
        }
    }
}
