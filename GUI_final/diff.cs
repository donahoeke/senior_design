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
    public partial class diff : Form
    {
        public diff()
        {
            InitializeComponent();
        }
        private Form1 mainForm = null;
        public diff(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();

             Bitmap resultImage = this.mainForm.getDiffImage();
             big_pictureBox.Image = resultImage;
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            sfd.FileName = "Difference";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                big_pictureBox.Image.Save(sfd.FileName);
            }
        }
    }

}
