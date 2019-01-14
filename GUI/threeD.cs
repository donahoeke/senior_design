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
    public partial class threeD : Form
    {
        public threeD()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;
        public threeD(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();

            Bitmap resultImage = this.mainForm.get3DImage("color");
            big_pictureBox.Image = resultImage;
            color_radioButton.Checked = true;
        }


        private void save3d_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            sfd.FileName = "Anaglyph";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                big_pictureBox.Image.Save(sfd.FileName);
            }
        }

        private string getColor()
        {
            if (color_radioButton.Checked == true)
            {
                return "color";
            }
            if (true_radioButton.Checked == true)
            {
                return "true";
            }
            if (grey_RadioButton.Checked == true)
            {
                return "grey";
            }
            if (half_radioButton.Checked == true)
            {
                return "half";
            }
            if (optimized_radioButton.Checked == true)
            {
                return "opt";
            }
            else
            {
                return "color";
            }
        }
        private void color_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap resultImage = this.mainForm.get3DImage("color");
            big_pictureBox.Image = resultImage;
        }

        private void true_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap resultImage = this.mainForm.get3DImage("true");
            big_pictureBox.Image = resultImage;
        }

        private void grey_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap resultImage = this.mainForm.get3DImage("grey");
            big_pictureBox.Image = resultImage;
        }

        private void half_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap resultImage = this.mainForm.get3DImage("half");
            big_pictureBox.Image = resultImage;
        }

        private void optimized_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            Bitmap resultImage = this.mainForm.get3DImage("opt");
            big_pictureBox.Image = resultImage;
        }
        private void threeD_Load(object sender, EventArgs e)
        {

        }
    }
}
