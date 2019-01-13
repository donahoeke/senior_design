using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;

namespace viewerGui
{
    public partial class Form1 : Form
    {
       
        //String selectedFile;
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
            RIGHTpictureBox.Hide();
            LEFTpictureBox.Show();
            splitContainer1.Panel2Collapsed = true;       
        }

        private void both_button_Click(object sender, EventArgs e)
        {
            LEFTpictureBox.Show();
            RIGHTpictureBox.Show();
            splitContainer1.Panel1Collapsed = false;
            splitContainer1.Panel2Collapsed = false;
        }

        private void right_button_Click(object sender, EventArgs e)
        {
            RIGHTpictureBox.Show();
            LEFTpictureBox.Hide();
            splitContainer1.Panel1Collapsed = true;
        }

        //3D TAB
        private void save3d_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                threeD_pictureBox.Image.Save(sfd.FileName);
            }
        }

        private void threeD_button_Click(object sender, EventArgs e)
        {
            AForge.Imaging.Filters.StereoAnaglyph filter = new AForge.Imaging.Filters.StereoAnaglyph();
            Bitmap rightImage = new Bitmap(@"C:\Users\ramirezgb\Desktop\right.bmp");
            Bitmap leftImage = new Bitmap(@"C:\Users\ramirezgb\Desktop\left.bmp");
            filter.OverlayImage = rightImage;
            Bitmap resultImage = filter.Apply(leftImage);
            threeD_pictureBox.Image = resultImage;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                LEFTpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                LEFTpictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                RIGHTpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                RIGHTpictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void leftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                LEFTpictureBox.Image.Save(sfd.FileName);
            }
        }

        private void rightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                RIGHTpictureBox.Image.Save(sfd.FileName);
            }
        }
    
        private void right_pictureBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                RIGHTpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                RIGHTpictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void left_pictureBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                LEFTpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                LEFTpictureBox.Image = Image.FromFile(ofd.FileName);
            }
        }
        
        private void RIGHTpictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
