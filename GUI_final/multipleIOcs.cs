using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace viewerGui
{
    public partial class multipleIOcs : Form
    {
        public multipleIOcs()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;
        public multipleIOcs(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();

            dataGridView1.Columns[0].Width = 103;
            dataGridView1.Columns[1].Width = 103;
            dataGridView1.Columns[2].Width = 103;
            dataGridView1.Columns[3].Width = 103;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            color_comboBox.Items.Add("Color");
            color_comboBox.Items.Add("Half");
            color_comboBox.Items.Add("True");
            color_comboBox.Items.Add("Optimized");
            color_comboBox.Items.Add("Gray");

            color_comboBox.SelectedIndex = 0;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        Bitmap[,] a = new Bitmap[20,3];

    

        private void save3D_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png|avi (*.avi)|*.avi";


            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                try
                {
                    if (row.Cells[3].Value.ToString() == "Video")
                    {
                        sfd.FileName = "Anaglyph_video";
                        AForge.Video.FFMPEG.VideoFileReader reader_left = new AForge.Video.FFMPEG.VideoFileReader();
                        AForge.Video.FFMPEG.VideoFileReader reader_right = new AForge.Video.FFMPEG.VideoFileReader();
                        reader_left.Open(row.Cells[0].Value.ToString());
                        reader_right.Open(row.Cells[1].Value.ToString());

                        int width = reader_left.Width;
                        int height = reader_left.Height;
                        int frameRate = reader_left.FrameRate;
                        long frameCount = reader_left.FrameCount;
                        string codecName = reader_left.CodecName;

                        AForge.Video.FFMPEG.VideoFileWriter writer = new AForge.Video.FFMPEG.VideoFileWriter();

                        if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
                        {
                            string fileName = sfd.FileName;
                            writer.Open(fileName, width, height, frameRate, AForge.Video.FFMPEG.VideoCodec.Default, 30);

                            Bitmap image = new Bitmap(width, height, PixelFormat.Format24bppRgb);
                            // write 1000 video frames
                            for (int i = 0; i < (int)frameCount; i++)
                            {
                                try
                                {
                                    Bitmap videoFrame_left = reader_left.ReadVideoFrame();
                                    Bitmap videoFrame_right = reader_left.ReadVideoFrame();
                                    Bitmap anaglyph_vid = mainForm.apply3D2(videoFrame_left, videoFrame_right, row.Cells[2].Value.ToString());
                                    writer.WriteVideoFrame(anaglyph_vid);
                                }
                                catch (Exception ex) { }
                            }

                            writer.Close();
                        }
                    }
                    else
                    {
                        sfd.FileName = "Anaglyph_image";
                        string left = row.Cells[0].Value.ToString();
                        Bitmap left_save = new Bitmap(left);
                        string right = row.Cells[1].Value.ToString();
                        Bitmap right_save = new Bitmap(right);
                        string type = row.Cells[2].Value.ToString();
                        Bitmap ana_save = mainForm.apply3D2(left_save, right_save, row.Cells[2].Value.ToString());

                        if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
                        {
                            ana_save.Save(sfd.FileName);
                        }
                    }
                   
                    
                }
                catch(Exception ex) { }
                
            }
        }

        Bitmap leftImage;
        string leftpath;
        Bitmap rightImage;
        string rightpath;
        Bitmap anaglyphImage;
        string color;
        string datatype;
        private void left_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png|avi (*.avi)|*.avi";
            AForge.Video.FFMPEG.VideoFileReader reader = new AForge.Video.FFMPEG.VideoFileReader();
            AForge.Video.FFMPEG.VideoFileWriter writer = new AForge.Video.FFMPEG.VideoFileWriter();

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                string ext = Path.GetExtension(ofd.FileName);

                if (ext == ".avi")
                {
                    reader.Open(ofd.FileName);

                    try
                    {
                        Bitmap videoFrame = reader.ReadVideoFrame();
                        left_pictureBox.Image = videoFrame;
                        leftImage = videoFrame;
                        leftpath = ofd.FileName.ToString();
                        datatype = "Video";
                    }
                    catch (Exception ex) { }
                }
                else
                {
                    left_pictureBox.Image = Image.FromFile(ofd.FileName);
                    leftImage = (Bitmap)Image.FromFile(ofd.FileName);
                    leftpath = ofd.FileName.ToString();
                    datatype = "Image";
                }
                left_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;


                try
                {
                    anaglyphImage = this.mainForm.apply3D2(leftImage, rightImage, color);
                    anaglyph_pictureBox.Image = anaglyphImage;
                }
                catch (Exception ex) { }
            }

        }

        private void right_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png|avi (*.avi)|*.avi";
            AForge.Video.FFMPEG.VideoFileReader reader = new AForge.Video.FFMPEG.VideoFileReader();
            //AForge.Video.FFMPEG.VideoFileWriter writer = new AForge.Video.FFMPEG.VideoFileWriter();

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                string ext = Path.GetExtension(ofd.FileName);

                if(ext == ".avi")
                {
                    reader.Open(ofd.FileName);

                 
                        try
                        {
                            Bitmap videoFrame = reader.ReadVideoFrame();
                            right_pictureBox.Image = videoFrame;
                            rightImage = videoFrame;
                            rightpath = ofd.FileName.ToString();
                            datatype = "Video";
                        }
                        catch (Exception ex) { }
                 }
                else
                {
                    right_pictureBox.Image = Image.FromFile(ofd.FileName);
                    rightImage = (Bitmap)Image.FromFile(ofd.FileName);
                    rightpath = ofd.FileName.ToString();
                    datatype = "Image";
                }
                right_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
               

                try
                {
                    anaglyphImage = this.mainForm.apply3D2(leftImage, rightImage,color);
                    anaglyph_pictureBox.Image = anaglyphImage;
                }
                catch (Exception ex) { }
            }
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(leftpath,rightpath,color,datatype);

            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.Selected = false;

                if(row == dataGridView1.Rows[dataGridView1.Rows.Count-1])
                {
                    row.Selected = true;
                }
            }
            
        }

        private void color_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            color = color_comboBox.Items[color_comboBox.SelectedIndex].ToString();
            try
            {
                anaglyphImage = this.mainForm.apply3D2(leftImage, rightImage, color);
                anaglyph_pictureBox.Image = anaglyphImage;
            }
            catch (Exception ex) { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()=="Video")
                {
                    AForge.Video.FFMPEG.VideoFileReader reader = new AForge.Video.FFMPEG.VideoFileReader();
                    reader.Open(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

                    Bitmap videoFrame_left;
                    Bitmap videoFrame_right;
                    videoFrame_left = reader.ReadVideoFrame();
                    left_pictureBox.Image = videoFrame_left;
                 
                    reader.Open(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());

                    videoFrame_right = reader.ReadVideoFrame();
                    right_pictureBox.Image = videoFrame_right;

                    anaglyphImage = this.mainForm.apply3D2(videoFrame_left, videoFrame_right, color);
                    anaglyph_pictureBox.Image = anaglyphImage;
                }
                else
                {
                    left_pictureBox.Image = (Bitmap)Image.FromFile(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    right_pictureBox.Image = (Bitmap)Image.FromFile(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    anaglyph_pictureBox.Image = this.mainForm.apply3D2((Bitmap)Image.FromFile(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()), (Bitmap)Image.FromFile(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());

                }
            }
            catch (Exception ex) { }
        }

        
        private void import_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                StreamReader readFile = new StreamReader(@"C:\Users\donahoeke\Desktop\Senior Design\Sheet1.csv");
                string line;
                string[] row;
                readFile.ReadLine();
                while ((line = readFile.ReadLine()) != null)
                {
                    row = line.Split(',');
                    string l_path = row[0];
                    string r_path = row[1];
                    string color_path = "Color";
                    try
                    {
                        color_path = row[2];
                    }
                    catch (Exception ex)
                    {
                        color_path = "Color";
                    }

                    try
                    {
                        dataGridView1.Rows.Add(l_path, r_path, color_path);
                    }
                    catch (Exception ex) { }
                }
                readFile.Close();
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
        }

        private void anaglyph_pictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                threeD threeDform = new threeD(this);
                threeDform.Show();
            }
            catch (Exception Ex)
            { }
        }
    }
}
