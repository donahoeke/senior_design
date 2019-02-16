using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        AForge.Video.FFMPEG.VideoFileReader reader = new AForge.Video.FFMPEG.VideoFileReader();
        AForge.Video.FFMPEG.VideoFileWriter writer = new AForge.Video.FFMPEG.VideoFileWriter();

        Bitmap origRightImage = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\right_image.png");
        Bitmap origLeftimage = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\left_image.png");
        Bitmap filtered_left = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\left_image.png");
        Bitmap filtered_right = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\right_image.png");
        Bitmap left_stats = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\transparent.bmp");
        Bitmap right_stats = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\transparent.bmp");
        Bitmap resultImage = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\transparent.bmp");
        Bitmap diffImage = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\transparent.bmp");
        Bitmap sobelImageLeft = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\right_image.png");
        Bitmap sobelImageRight = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\transparent.bmp");

        AForge.Imaging.Filters.StereoAnaglyph filter = new AForge.Imaging.Filters.StereoAnaglyph();
        AForge.Imaging.Filters.Grayscale grayscaleFilter = new AForge.Imaging.Filters.Grayscale(0.2125, 0.7154, 0.0721);
        AForge.Imaging.Filters.Sepia sepiaFilter = new AForge.Imaging.Filters.Sepia();
        AForge.Imaging.Filters.HueModifier hueFilter = new AForge.Imaging.Filters.HueModifier(180);
        AForge.Imaging.Filters.RotateChannels rotateFilter = new AForge.Imaging.Filters.RotateChannels();
        AForge.Imaging.Filters.Invert invFilter = new AForge.Imaging.Filters.Invert();
        AForge.Imaging.Filters.BrightnessCorrection brtCorrection = new AForge.Imaging.Filters.BrightnessCorrection(-50);
        AForge.Imaging.Filters.BrightnessCorrection brtCorrection2 = new AForge.Imaging.Filters.BrightnessCorrection(-50);

        AForge.Imaging.Filters.ContrastCorrection contrastCorrection = new AForge.Imaging.Filters.ContrastCorrection(15);
        AForge.Imaging.Filters.SaturationCorrection satCorrection = new AForge.Imaging.Filters.SaturationCorrection(1);
        AForge.Imaging.Filters.GaussianBlur blurFilter = new AForge.Imaging.Filters.GaussianBlur(4, 11);
        AForge.Imaging.Filters.GaussianSharpen sharpFilter = new AForge.Imaging.Filters.GaussianSharpen(4, 11);
        AForge.Imaging.Filters.Blur quickBlurFilter = new AForge.Imaging.Filters.Blur();
        AForge.Imaging.Filters.Sharpen quickSharpFilter = new AForge.Imaging.Filters.Sharpen();
       // AForge.Imaging.Filters.Difference diffFilter = new AForge.Imaging.Filters.Difference(origLeftimage);
        AForge.Imaging.Filters.SobelEdgeDetector sobelFilter = new AForge.Imaging.Filters.SobelEdgeDetector();
        AForge.Imaging.Filters.GammaCorrection gammaFilter = new AForge.Imaging.Filters.GammaCorrection(0);

        Boolean brtFlag = false;

        //   AForge.Imaging.ImageStatistics leftStats = new AForge.Imaging.ImageStatistics(origLeftimage);
        //   AForge.Imaging.ImageStatistics rightStats = new AForge.Imaging.ImageStatistics(origRightImage);

        public Form1()
        {
            InitializeComponent();
            left_pictureBox.Image = origLeftimage;
            right_pictureBox.Image = origRightImage;

            update(origLeftimage, origRightImage);     
            setUpToolTips();
        }

        private void update(Bitmap leftImage, Bitmap rightImage)
        {
            apply3D(leftImage, rightImage,"color");
            statistics(leftImage, rightImage);
            displayDiff(leftImage, rightImage);
            displaySobel(leftImage, rightImage);
            orig_pictureBox.Image = origLeftimage;
        }
        private void displayDiff(Bitmap leftImage, Bitmap rightImage)
        {
            AForge.Imaging.Filters.Difference diffFilter = new AForge.Imaging.Filters.Difference(leftImage);
            diffImage = diffFilter.Apply(rightImage);
            diff_pictureBox.Image = diffImage;
        }

        private void displaySobel(Bitmap leftImage, Bitmap rightImage)
        {
            try
            {
                Bitmap left_resultImage = sobelFilter.Apply(grayscaleFilter.Apply(leftImage));
                Bitmap right_resultImage = sobelFilter.Apply(grayscaleFilter.Apply(rightImage));

                sobel_left_pictureBox.Image = left_resultImage;
                sobelImageLeft = left_resultImage;
                sobelImageRight = right_resultImage;
            }
            catch(Exception e)
            {
                Bitmap left_resultImage = sobelFilter.Apply(grayscaleFilter.Apply(origLeftimage));
                Bitmap right_resultImage = sobelFilter.Apply(grayscaleFilter.Apply(origRightImage));

                sobel_left_pictureBox.Image = left_resultImage;
                sobelImageLeft = left_resultImage;
                sobelImageRight = right_resultImage;
            }
           
            
            // sobel_right_pictureBox.Image = right_resultImage;
        }
        private void statistics(Bitmap leftImage, Bitmap rightImage)
        {
            try
            {

                // this.WindowState = FormWindowState.Maximized;

                AForge.Imaging.ImageStatistics leftStats = new AForge.Imaging.ImageStatistics(leftImage);
                AForge.Imaging.ImageStatistics rightStats = new AForge.Imaging.ImageStatistics(rightImage);
                
                AForge.Math.Histogram histogram_rl = leftStats.Red;
                AForge.Math.Histogram histogram_gl = leftStats.Green;
                AForge.Math.Histogram histogram_bl = leftStats.Blue;
                AForge.Math.Histogram histogram_rr = rightStats.Red;
                AForge.Math.Histogram histogram_gr = rightStats.Green;
                AForge.Math.Histogram histogram_br = rightStats.Blue;


                try
                {
                    lstats_dataGridView.Rows.RemoveAt(2);
                    lstats_dataGridView.Rows.RemoveAt(1);
                    lstats_dataGridView.Rows.RemoveAt(0);
                    rstats_dataGridView.Rows.RemoveAt(2);
                    rstats_dataGridView.Rows.RemoveAt(1);
                    rstats_dataGridView.Rows.RemoveAt(0);
                }
                catch (Exception Ex) {
                }
                string[] rowl0 = new string[] { histogram_rl.Mean.ToString(), histogram_rl.Median.ToString(), histogram_rl.StdDev.ToString() };
                lstats_dataGridView.Rows.Add(rowl0);
                string[] rowl1 = new string[] { histogram_gl.Mean.ToString(), histogram_gl.Median.ToString(), histogram_gl.StdDev.ToString() };
                lstats_dataGridView.Rows.Add(rowl1);
                string[] rowl2 = new string[] { histogram_bl.Mean.ToString(), histogram_bl.Median.ToString(), histogram_bl.StdDev.ToString() };
                lstats_dataGridView.Rows.Add(rowl2);

                string[] rowr0 = new string[] { histogram_rr.Mean.ToString(), histogram_rr.Median.ToString(), histogram_rr.StdDev.ToString() };
                rstats_dataGridView.Rows.Add(rowr0);
                string[] rowr1 = new string[] { histogram_gr.Mean.ToString(), histogram_gr.Median.ToString(), histogram_gr.StdDev.ToString() };
                rstats_dataGridView.Rows.Add(rowr1);
                string[] rowr2 = new string[] { histogram_br.Mean.ToString(), histogram_br.Median.ToString(), histogram_br.StdDev.ToString() };
                rstats_dataGridView.Rows.Add(rowr2);

                foreach (DataGridViewRow row in lstats_dataGridView.Rows)
                {
                    if (row.Index == 2)
                    {
                        row.DefaultCellStyle.BackColor = Color.RoyalBlue;
                    }
                    if (row.Index == 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.SeaGreen;
                    }
                    if (row.Index == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
                foreach (DataGridViewRow row in rstats_dataGridView.Rows)
                {
                    if (row.Index == 2)
                    {
                        row.DefaultCellStyle.BackColor = Color.RoyalBlue;
                    }
                    if (row.Index == 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.SeaGreen;
                    }
                    if (row.Index == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }

                int histHeight = 128;
                int histWidth = 256;

                Bitmap left_stats = new Bitmap(histWidth, histHeight);
                Bitmap right_stats = new Bitmap(histWidth, histHeight);

                var semiRed = Color.FromArgb(128, Color.Red);
                Pen red = new Pen(semiRed, 1);
                var semiGreen = Color.FromArgb(128, Color.Green);
                Pen green = new Pen(semiGreen, 1);
                var semiBlue = Color.FromArgb(128, Color.Blue);
                Pen blue = new Pen(semiBlue, 1);
                using (Graphics g = Graphics.FromImage(left_stats))
                {
                    for (int i = 1; i < 256; i++)
                    {
                        float pct_r = histogram_rl.Values[i] / histogram_rl.Max;
                        float pct_g = histogram_gl.Values[i] / histogram_gl.Max;
                        float pct_b = histogram_bl.Values[i] / histogram_bl.Max;

                        g.DrawLine(red,
                            new Point(i, left_stats.Height - 5),
                            new Point(i, left_stats.Height - 5 - (int)(pct_r * histHeight))
                            );
                        g.DrawLine(green,
                            new Point(i, left_stats.Height - 5),
                            new Point(i, left_stats.Height - 5 - (int)(pct_g * histHeight))
                            );
                        g.DrawLine(blue,
                            new Point(i, left_stats.Height - 5),
                            new Point(i, left_stats.Height - 5 - (int)(pct_b * histHeight))
                            );
                    }
                }

                using (Graphics g = Graphics.FromImage(right_stats))
                {
                    for (int i = 1; i < 256; i++)
                    {
                        float pct_r = histogram_rr.Values[i] / histogram_rr.Max;
                        float pct_g = histogram_gr.Values[i] / histogram_gr.Max;
                        float pct_b = histogram_br.Values[i] / histogram_br.Max;


                        g.DrawLine(red,
                            new Point(i, left_stats.Height - 5),
                            new Point(i, left_stats.Height - 5 - (int)(pct_r * histHeight))
                            );
                        g.DrawLine(green,
                            new Point(i, left_stats.Height - 5),
                            new Point(i, left_stats.Height - 5 - (int)(pct_g * histHeight))
                            );
                        g.DrawLine(blue,
                            new Point(i, left_stats.Height - 5),
                            new Point(i, left_stats.Height - 5 - (int)(pct_b * histHeight))
                            );
                    }
                }
                lstats_pictureBox.Image = left_stats;
                rstats_pictureBox.Image = right_stats;
            }
            catch (Exception ex)
            {
                try
                {
                    lstats_dataGridView.Rows.RemoveAt(2);
                    lstats_dataGridView.Rows.RemoveAt(1);
                    lstats_dataGridView.Rows.RemoveAt(0);
                    rstats_dataGridView.Rows.RemoveAt(2);
                    rstats_dataGridView.Rows.RemoveAt(1);
                    rstats_dataGridView.Rows.RemoveAt(0);
                }
                catch (Exception Ex)
                {
                }
                string[] rowl0 = new string[] { "0", "0", "0" };
                lstats_dataGridView.Rows.Add(rowl0);
                lstats_dataGridView.Rows.Add(rowl0);
                lstats_dataGridView.Rows.Add(rowl0);
                rstats_dataGridView.Rows.Add(rowl0);
                rstats_dataGridView.Rows.Add(rowl0);
                rstats_dataGridView.Rows.Add(rowl0);


                foreach (DataGridViewRow row in lstats_dataGridView.Rows)
                {
                    if (row.Index == 2)
                    {
                        row.DefaultCellStyle.BackColor = Color.RoyalBlue;
                    }
                    if (row.Index == 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.SeaGreen;
                    }
                    if (row.Index == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }
                foreach (DataGridViewRow row in rstats_dataGridView.Rows)
                {
                    if (row.Index == 2)
                    {
                        row.DefaultCellStyle.BackColor = Color.RoyalBlue;
                    }
                    if (row.Index == 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.SeaGreen;
                    }
                    if (row.Index == 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }

                int histHeight = 128;
                int histWidth = 256;

                Bitmap left_stats = new Bitmap(histWidth, histHeight);
                Bitmap right_stats = new Bitmap(histWidth, histHeight);


                lstats_pictureBox.Image = left_stats;
                rstats_pictureBox.Image = right_stats;
            }
        }



        /*
         * apply3D
         * purpose: displays a specified anaglyph image to the user interface given two stereo input images
         * inputs:
         *  Bitmap origLeftimage: left stereo image to be applied to the filter
         *  Bitmap origRightImage: right stereo image; considered the overlay image of the filter
         *  string anaglyph_type: specifies 1 of 5 different anaglyph output types
         */
        private void apply3D(Bitmap leftImage, Bitmap rightImage, string anaglyph_type)
        {

            string caseSwitch = anaglyph_type;

            switch (caseSwitch)
            {
                case "color":
                    filter.AnaglyphAlgorithm = AForge.Imaging.Filters.StereoAnaglyph.Algorithm.ColorAnaglyph;
                    break;
                case "true":
                    filter.AnaglyphAlgorithm = AForge.Imaging.Filters.StereoAnaglyph.Algorithm.TrueAnaglyph;
                    break;
                case "grey":
                    filter.AnaglyphAlgorithm = AForge.Imaging.Filters.StereoAnaglyph.Algorithm.GrayAnaglyph;
                    break;
                case "half":
                    filter.AnaglyphAlgorithm = AForge.Imaging.Filters.StereoAnaglyph.Algorithm.HalfColorAnaglyph;
                    break;
                case "opt":
                    filter.AnaglyphAlgorithm = AForge.Imaging.Filters.StereoAnaglyph.Algorithm.OptimizedAnaglyph;
                    break;
                default:
                    filter.AnaglyphAlgorithm = AForge.Imaging.Filters.StereoAnaglyph.Algorithm.ColorAnaglyph;
                    break;
            }

            try
            {
                filter.OverlayImage = leftImage;
                resultImage = filter.Apply(rightImage);
                threeD_pictureBox.Image = resultImage;
            }
            catch (Exception ex)
            {

            }
        }

        public Bitmap apply3D2(Bitmap leftImage, Bitmap rightImage, string anaglyph_type)
        {

            string caseSwitch = anaglyph_type;

            switch (caseSwitch)
            {
                case "Color":
                    filter.AnaglyphAlgorithm = AForge.Imaging.Filters.StereoAnaglyph.Algorithm.ColorAnaglyph;
                    break;
                case "True":
                    filter.AnaglyphAlgorithm = AForge.Imaging.Filters.StereoAnaglyph.Algorithm.TrueAnaglyph;
                    break;
                case "Gray":
                    filter.AnaglyphAlgorithm = AForge.Imaging.Filters.StereoAnaglyph.Algorithm.GrayAnaglyph;
                    break;
                case "Half":
                    filter.AnaglyphAlgorithm = AForge.Imaging.Filters.StereoAnaglyph.Algorithm.HalfColorAnaglyph;
                    break;
                case "Optimized":
                    filter.AnaglyphAlgorithm = AForge.Imaging.Filters.StereoAnaglyph.Algorithm.OptimizedAnaglyph;
                    break;
                default:
                    filter.AnaglyphAlgorithm = AForge.Imaging.Filters.StereoAnaglyph.Algorithm.ColorAnaglyph;
                    break;
            }

            //  try
            {
                filter.OverlayImage = leftImage;
                resultImage = filter.Apply(rightImage);
                return resultImage;
            }
            //  catch (Exception ex)
            {

            }
        }
        private void greyscale_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (greyscale_radioButton.Checked)
            {
                applyGreyscaleFilter(origLeftimage, origRightImage);
                if (brightness_trackBar.Value != 50)
                {
                    applyBrtFilter(filtered_left, filtered_right);
                }
                if (saturation_trackBar.Value != 50)
                {
                    applySaturationFilter(filtered_left, filtered_right);
                }
                if (contrast_trackBar.Value != 50)
                {
                    applyContrastFilter(filtered_left, filtered_right);
                }
                if (hue_trackBar.Value != 0)
                {
                    applyHueFilter(filtered_left, filtered_right);
                }

            }
            else
            {
                revertOriginal();
            }
            displayImages();
        }

        private void sepia_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sepia_radioButton.Checked)
            {
                applySepiaFilter(origLeftimage, origRightImage);
                if (brightness_trackBar.Value != 50)
                {
                    applyBrtFilter(filtered_left, filtered_right);
                }
                if (saturation_trackBar.Value != 50)
                {
                    applySaturationFilter(filtered_left, filtered_right);
                }
                if (contrast_trackBar.Value != 50)
                {
                    applyContrastFilter(filtered_left, filtered_right);
                }
                if (hue_trackBar.Value != 0)
                {
                    applyHueFilter(filtered_left, filtered_right);
                }
            }
            else
            {
                revertOriginal();
            }
            displayImages();
        }


        private void invert_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (invert_radioButton.Checked)
            {
                applyInvertFilter(origLeftimage, origRightImage);
                if (brightness_trackBar.Value != 50)
                {
                    applyBrtFilter(filtered_left, filtered_right);
                }
                if (saturation_trackBar.Value != 50)
                {
                    applySaturationFilter(filtered_left, filtered_right);
                }
                if (contrast_trackBar.Value != 50)
                {
                    applyContrastFilter(filtered_left, filtered_right);
                }
                if (hue_trackBar.Value != 0)
                {
                    applyHueFilter(filtered_left, filtered_right);
                }
            }
            else
            {
                revertOriginal();
            }
            displayImages();
        }

        //__________________________________________________________________________________________________________________________

        private void hue_trackBar_Scroll(object sender, EventArgs e)
        {
            hue_textBox.Text = hue_trackBar.Value.ToString();
        }

        private void hue_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                hue_trackBar.Value = Int32.Parse(hue_textBox.Text);
                applyHueFilter(origLeftimage, origRightImage);

                if (contrast_trackBar.Value != 50)
                {
                    applyContrastFilter(filtered_left, filtered_right);
                }
                if (saturation_trackBar.Value != 50)
                {
                    applySaturationFilter(filtered_left, filtered_right);
                }
                if (brightness_trackBar.Value != 50)
                {
                    applyBrtFilter(filtered_left, filtered_right);
                }
                if (sepia_radioButton.Checked)
                {
                    applySepiaFilter(filtered_left, filtered_right);
                }
                if (greyscale_radioButton.Checked)
                {
                    applyGreyscaleFilter(filtered_left, filtered_right);
                }
                if (invert_radioButton.Checked)
                {
                    applyInvertFilter(filtered_left, filtered_right);
                }
                if (gamma_trackBar.Value != 0)
                {
                    applyGammaFilter(filtered_left, filtered_right);
                }
                displayImages();
            }
            catch (Exception Ex) { }

        }

        /*
         * brightness: range: [-100 100]
         * brightness = 2*track_val - 100; where trackval [0 100]
         */
        private void brightness_trackBar_Scroll(object sender, EventArgs e)
        {
            brt_textBox.Text = brightness_trackBar.Value.ToString();
        }

        private void brt_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                brightness_trackBar.Value = Int32.Parse(brt_textBox.Text);
                applyBrtFilter(origLeftimage, origRightImage);

                if (contrast_trackBar.Value != 50)
                {
                    applyContrastFilter(filtered_left, filtered_right);
                }
                if (saturation_trackBar.Value != 50)
                {
                    applySaturationFilter(filtered_left, filtered_right);
                }
                if (hue_trackBar.Value != 0)
                {
                    applyHueFilter(filtered_left, filtered_right);
                }
                if (sepia_radioButton.Checked)
                {
                    applySepiaFilter(filtered_left, filtered_right);
                }
                if (greyscale_radioButton.Checked)
                {
                    applyGreyscaleFilter(filtered_left, filtered_right);
                }
                if (invert_radioButton.Checked)
                {
                    applyInvertFilter(filtered_left, filtered_right);
                }
                if (gamma_trackBar.Value != 0)
                {
                    applyGammaFilter(filtered_left, filtered_right);
                }
                if (rotate == 1)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                }
                if (rotate == 2)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                    applyRotateFilter(filtered_left, filtered_right);
                }
                displayImages();
            }
            catch (Exception Ex) { }
        }

        /*
         * contrast: range: [-100 100]
         * contrast = 2*track_val - 100; where trackval [0 100]
         */
        private void contrast_trackBar_Scroll(object sender, EventArgs e)
        {
            contrast_textBox.Text = contrast_trackBar.Value.ToString();
        }

        private void contrast_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                contrast_trackBar.Value = Int32.Parse(contrast_textBox.Text);
                applyContrastFilter(origLeftimage, origRightImage);

                if (brightness_trackBar.Value != 50)
                {
                    applyBrtFilter(filtered_left, filtered_right);
                }
                if (saturation_trackBar.Value != 50)
                {
                    applySaturationFilter(filtered_left, filtered_right);
                }
                if (hue_trackBar.Value != 0)
                {
                    applyHueFilter(filtered_left, filtered_right);
                }
                if (sepia_radioButton.Checked)
                {
                    applySepiaFilter(filtered_left, filtered_right);
                }
                if (greyscale_radioButton.Checked)
                {
                    applyGreyscaleFilter(filtered_left, filtered_right);
                }
                if (invert_radioButton.Checked)
                {
                    applyInvertFilter(filtered_left, filtered_right);
                }
                if (gamma_trackBar.Value != 0)
                {
                    applyGammaFilter(filtered_left, filtered_right);
                }
                if (rotate == 1)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                }
                if (rotate == 2)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                    applyRotateFilter(filtered_left, filtered_right);
                }
                displayImages();
            }
            catch (Exception Ex) { }
        }

        /*
         * saturation: range: [-1 1]
         * saturation = (2*track_val - 100)/100; where trackval [0 100]
         */
        private void saturation_trackBar_Scroll(object sender, EventArgs e)
        {
            saturation_textBox.Text = saturation_trackBar.Value.ToString();
        }

        private void saturation_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                saturation_trackBar.Value = Int32.Parse(saturation_textBox.Text);
                applySaturationFilter(origLeftimage, origRightImage);

                if (contrast_trackBar.Value != 50)
                {
                    applyContrastFilter(filtered_left, filtered_right);
                }
                if (brightness_trackBar.Value != 50)
                {
                    applyBrtFilter(filtered_left, filtered_right);
                }
                if (hue_trackBar.Value != 0)
                {
                    applyHueFilter(filtered_left, filtered_right);
                }
                if (sepia_radioButton.Checked)
                {
                    applySepiaFilter(filtered_left, filtered_right);
                }
                if (greyscale_radioButton.Checked)
                {
                    applyGreyscaleFilter(filtered_left, filtered_right);
                }
                if (invert_radioButton.Checked)
                {
                    applyInvertFilter(filtered_left, filtered_right);
                }
                if (gamma_trackBar.Value != 0)
                {
                    applyGammaFilter(filtered_left, filtered_right);
                }
                if (rotate == 1)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                }
                if (rotate == 2)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                    applyRotateFilter(filtered_left, filtered_right);
                }
                displayImages();
            }
            catch (Exception Ex) { }
        }

        private void sharpen_trackBar_Scroll(object sender, EventArgs e)
        {
            sharpen_textBox.Text = sharpen_trackBar.Value.ToString();
        }

        private void sharpen_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sharpen_trackBar.Value = Int32.Parse(sharpen_textBox.Text);
                applySharpenFilter(origLeftimage, origRightImage);
                if (brightness_trackBar.Value != 50)
                {
                    applyBrtFilter(filtered_left, filtered_right);
                }
                if (saturation_trackBar.Value != 50)
                {
                    applySaturationFilter(filtered_left, filtered_right);
                }
                if (contrast_trackBar.Value != 50)
                {
                    applyContrastFilter(filtered_left, filtered_right);
                }
                if (hue_trackBar.Value != 0)
                {
                    applyHueFilter(filtered_left, filtered_right);
                }
                if (sepia_radioButton.Checked)
                {
                    applySepiaFilter(filtered_left, filtered_right);
                }
                if (greyscale_radioButton.Checked)
                {
                    applyGreyscaleFilter(filtered_left, filtered_right);
                }
                if (invert_radioButton.Checked)
                {
                    applyInvertFilter(filtered_left, filtered_right);
                }
                if (gamma_trackBar.Value != 0)
                {
                    applyGammaFilter(filtered_left, filtered_right);
                }
                if (rotate == 1)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                }
                if (rotate == 2)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                    applyRotateFilter(filtered_left, filtered_right);
                }
                displayImages();
            }
            catch (Exception Ex) { }
        }

        private void blur_trackBar_Scroll(object sender, EventArgs e)
        {
            blur_textBox.Text = blur_trackBar.Value.ToString();
        }

        private void blur_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                blur_trackBar.Value = Int32.Parse(blur_textBox.Text);
                applyBlurFilter(origLeftimage, origRightImage);

                if (gamma_trackBar.Value != 0)
                {
                    applyGammaFilter(filtered_left, filtered_right);
                }
                if (brightness_trackBar.Value != 50)
                {
                    applyBrtFilter(filtered_left, filtered_right);
                }
                if (saturation_trackBar.Value != 50)
                {
                    applySaturationFilter(filtered_left, filtered_right);
                }
                if (contrast_trackBar.Value != 50)
                {
                    applyContrastFilter(filtered_left, filtered_right);
                }
                if (hue_trackBar.Value != 0)
                {
                    applyHueFilter(filtered_left, filtered_right);
                }
                if (sepia_radioButton.Checked)
                {
                    applySepiaFilter(filtered_left, filtered_right);
                }
                if (greyscale_radioButton.Checked)
                {
                    applyGreyscaleFilter(filtered_left, filtered_right);
                }
                if (invert_radioButton.Checked)
                {
                    applyInvertFilter(filtered_left, filtered_right);
                }
                if (rotate == 1)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                }
                if (rotate == 2)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                    applyRotateFilter(filtered_left, filtered_right);
                }
                displayImages();
            }
            catch (Exception Ex) { }
        }

        private void gamma_trackBar_Scroll(object sender, EventArgs e)
        {
            gamma_textBox.Text = gamma_trackBar.Value.ToString();
        }

        private void gamma_textBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                gamma_trackBar.Value = Int32.Parse(gamma_textBox.Text);
                applyGammaFilter(origLeftimage, origRightImage);

                if (brightness_trackBar.Value != 50)
                {
                    applyBrtFilter(filtered_left, filtered_right);
                }
                if (saturation_trackBar.Value != 50)
                {
                    applySaturationFilter(filtered_left, filtered_right);
                }
                if (contrast_trackBar.Value != 50)
                {
                    applyContrastFilter(filtered_left, filtered_right);
                }
                if (hue_trackBar.Value != 0)
                {
                    applyHueFilter(filtered_left, filtered_right);
                }
                if (sepia_radioButton.Checked)
                {
                    applySepiaFilter(filtered_left, filtered_right);
                }
                if (greyscale_radioButton.Checked)
                {
                    applyGreyscaleFilter(filtered_left, filtered_right);
                }
                if (invert_radioButton.Checked)
                {
                    applyInvertFilter(filtered_left, filtered_right);
                }
                if (rotate == 1)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                }
                if (rotate == 2)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                    applyRotateFilter(filtered_left, filtered_right);
                }

                displayImages();
            }
            catch (Exception Ex) { }
        }

        private void quickSharpen_button_Click(object sender, EventArgs e)
        {
            applyQuickSharpenFilter();
        }

        private void quickBlur_button_Click(object sender, EventArgs e)
        {
            applyQuickBlurFilter();
        }

        private void original_button_Click(object sender, EventArgs e)
        {
            revertOriginal();
            brightness_trackBar.Value = 50;
            gamma_textBox.Text = "0";
            gamma_trackBar.Value = 0;
            hue_textBox.Text = "0";
            hue_trackBar.Value = 0;
            brt_textBox.Text = "50";
            saturation_trackBar.Value = 50;
            saturation_textBox.Text = "50";
            contrast_trackBar.Value = 50;
            contrast_textBox.Text = "50";
            sharpen_trackBar.Value = 0;
            sharpen_textBox.Text = "0";
            blur_trackBar.Value = 0;
            blur_textBox.Text = "0";
            rotate = 0;

            greyscale_radioButton.Checked = false;
            invert_radioButton.Checked = false;
            //rotate_radioButton.Checked = false;
            sepia_radioButton.Checked = false;
        }


        private void applyGreyscaleFilter(Bitmap leftImage, Bitmap rightImage)
        {
            try
            {
                filtered_left = grayscaleFilter.Apply(leftImage);
                filtered_right = grayscaleFilter.Apply(rightImage);
            }
            catch (Exception ex)
            {

            }

        }
        private void applySepiaFilter(Bitmap leftImage, Bitmap rightImage)
        {
            filtered_left = sepiaFilter.Apply(leftImage);
            filtered_right = sepiaFilter.Apply(rightImage);
        }
        private void applyRotateFilter(Bitmap leftImage, Bitmap rightImage)
        {
            filtered_left = rotateFilter.Apply(leftImage);
            filtered_right = rotateFilter.Apply(rightImage);
        }
        private void applyInvertFilter(Bitmap leftImage, Bitmap rightImage)
        {
            filtered_left = invFilter.Apply(leftImage);
            filtered_right = invFilter.Apply(rightImage);
        }
        private void applyHueFilter(Bitmap leftImage, Bitmap rightImage)
        {
            hueFilter = new AForge.Imaging.Filters.HueModifier(35 + 5 * hue_trackBar.Value);

            filtered_left = hueFilter.Apply(leftImage);
            filtered_right = hueFilter.Apply(rightImage);
        }
        private void applyBrtFilter(Bitmap leftImage, Bitmap rightImage)
        {
            brtCorrection = new AForge.Imaging.Filters.BrightnessCorrection(2 * brightness_trackBar.Value - 100);

            filtered_left = brtCorrection.Apply(leftImage);
            filtered_right = brtCorrection.Apply(rightImage);
        }

        private void applyContrastFilter(Bitmap leftImage, Bitmap rightImage)
        {
            contrastCorrection = new AForge.Imaging.Filters.ContrastCorrection(2 * contrast_trackBar.Value - 100);

            filtered_left = contrastCorrection.Apply(leftImage);
            filtered_right = contrastCorrection.Apply(rightImage);
        }

        private void applySaturationFilter(Bitmap leftImage, Bitmap rightImage)
        {
            satCorrection = new AForge.Imaging.Filters.SaturationCorrection(((2 * saturation_trackBar.Value) - 100) / 100f);

            filtered_left = satCorrection.Apply(leftImage);
            filtered_right = satCorrection.Apply(rightImage);
        }
        private void applySharpenFilter(Bitmap leftImage, Bitmap rightImage)
        {
            sharpFilter = new AForge.Imaging.Filters.GaussianSharpen(sharpen_trackBar.Value, 11);

            filtered_left = sharpFilter.Apply(leftImage);
            filtered_right = sharpFilter.Apply(rightImage);
        }
        private void applyBlurFilter(Bitmap leftImage, Bitmap rightImage)
        {
            blurFilter = new AForge.Imaging.Filters.GaussianBlur(blur_trackBar.Value, 11);

            filtered_left = blurFilter.Apply(leftImage);
            filtered_right = blurFilter.Apply(rightImage);
        }
        private void applyQuickSharpenFilter()
        {
            filtered_left = quickSharpFilter.Apply(filtered_left);
            filtered_right = quickSharpFilter.Apply(filtered_right);
            apply3D(filtered_left, filtered_right, "color");
            displayImages();
        }
        private void applyQuickBlurFilter()
        {
            filtered_left = quickBlurFilter.Apply(filtered_left);
            filtered_right = quickBlurFilter.Apply(filtered_right);
            apply3D(filtered_left, filtered_right, "color");
            displayImages();
        }

        private void applyGammaFilter(Bitmap leftImage, Bitmap rightImage)
        {
            int gamma = gamma_trackBar.Value;
            float gammaValue = 1 - (gamma_trackBar.Value / 10f);
            gammaFilter = new AForge.Imaging.Filters.GammaCorrection(gammaValue);


            filtered_left = gammaFilter.Apply(leftImage);
            filtered_right = gammaFilter.Apply(rightImage);
        }
        private void revertOriginal()
        {
            filtered_left = origLeftimage;
            filtered_right = origRightImage;
            apply3D(origLeftimage, origRightImage, "color");
            displayImages();
        }

        private void displayImages()
        {
            left_pictureBox.Image = filtered_left;
            right_pictureBox.Image = filtered_right;
            update(filtered_left, filtered_right);

        }

        private void threeD_pictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                threeD threeDform = new threeD(this);
                threeDform.Show();
            }
            catch (Exception Ex)
            { }
        }

        private void diff_pictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                diff diff = new diff(this);
                diff.Show();
            }
            catch (Exception Ex)
            { }


        }

        private void sobel_left_pictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                sobel sobel = new sobel(this);
                sobel.Show();
            }
            catch (Exception Ex)
            { }
        }

        private void orig_pictureBox_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                original orig = new original(this);
                orig.Show();
            }
            catch (Exception Ex)
            { }
        }

        public Bitmap get3DImage(string type)
        {
            apply3D(filtered_left, filtered_right, type);
            return resultImage;
        }

        public Bitmap getDiffImage()
        {
            return diffImage;
        }

        public Bitmap getSobelImageLeft()
        {
            return sobelImageLeft;
        }

        public Bitmap getSobelImageRight()
        {
            return sobelImageRight;
        }

        public Bitmap getOriginallImageLeft()
        {
            return origLeftimage;
        }
        public Bitmap getOriginallImageRight()
        {
            return origRightImage;
        }
        private void lstats_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            lstats_dataGridView.ClearSelection();
        }
        private void rstats_dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            rstats_dataGridView.ClearSelection();
        }

        private void setUpToolTips()
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

          
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.left_pictureBox, "Double click to upload left image");
            toolTip1.SetToolTip(this.right_pictureBox, "Double click to upload right image");
            toolTip1.SetToolTip(this.orig_pictureBox, "Double click to view the set of original images");
            toolTip1.SetToolTip(this.sobel_left_pictureBox, "Double click to view/save the set of sobel transform edge images");
            toolTip1.SetToolTip(this.diff_pictureBox, "Double click to view/save the difference image of the set of the images");
            toolTip1.SetToolTip(this.threeD_pictureBox, "Double click to view/save the 3-D anaglyph image created from the set of the images");
            toolTip1.SetToolTip(this.lstats_dataGridView, "Mean,Median,Std dev of RGB values of left image");
            toolTip1.SetToolTip(this.rstats_dataGridView, "Mean,Median,Std dev of RGB values of right image");
            //toolTip1.SetToolTip(this.checkBox1, "My checkBox1");
        }

        private void left_button_Click(object sender, EventArgs e)
        {
            right_pictureBox.Hide();
            left_pictureBox.Show();
            splitContainer1.Panel2Collapsed = true;
            splitContainer2.Panel2Collapsed = true;
        }

        private void both_button_Click(object sender, EventArgs e)
        {
            left_pictureBox.Show();
            right_pictureBox.Show();
            splitContainer1.Panel1Collapsed = false;
            splitContainer2.Panel1Collapsed = false;
            splitContainer1.Panel2Collapsed = false;
            splitContainer2.Panel2Collapsed = false;
        }

        private void right_button_Click(object sender, EventArgs e)
        {
            left_pictureBox.Hide();
            right_pictureBox.Show();
            splitContainer1.Panel1Collapsed = true;
            splitContainer2.Panel1Collapsed = true;
        }

        private void rightImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                right_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                right_pictureBox.Image = Image.FromFile(ofd.FileName);
                origRightImage = (Bitmap)Image.FromFile(ofd.FileName);
                filtered_right = (Bitmap)Image.FromFile(ofd.FileName);

                try
                {
                    update(origLeftimage, origRightImage);

                }
                catch(Exception ex)
                {

                }
            }
        }

        private void leftImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                left_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                left_pictureBox.Image = Image.FromFile(ofd.FileName);
                origLeftimage = (Bitmap)Image.FromFile(ofd.FileName);
                filtered_left = (Bitmap)Image.FromFile(ofd.FileName);
                //update(origLeftimage, origRightImage);
            }
        }


       
        private void leftImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            sfd.FileName = "Left";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                left_pictureBox.Image.Save(sfd.FileName);
            }
        }

        private void rightImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            sfd.FileName = "Right";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                right_pictureBox.Image.Save(sfd.FileName);
            }
        }

        private void anaglyphToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            sfd.FileName = "Anaglyph";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                threeD_pictureBox.Image.Save(sfd.FileName);
            }
        }

        private void differenceImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            sfd.FileName = "Difference";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                diff_pictureBox.Image.Save(sfd.FileName);
            }
        }

        private void sobelImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            sfd.FileName = "Sobel";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                sobel_left_pictureBox.Image.Save(sfd.FileName);
            }
        }

        private void allImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            sfd.FileName = "Right";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                right_pictureBox.Image.Save(sfd.FileName);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("3DAD IMAGE VIEWER\n\nThis program allows a user to upload a set of 2-D images, and " +
                "applies processing to yield an anaglyph, a 3-D image comprised of the 2 images." +
                "\n\nThis program utilizes the AForge.NET framework, available at http://www.aforgenet.com/framework/");
        }

        private void orig_pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void left_pictureBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                left_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                left_pictureBox.Image = Image.FromFile(ofd.FileName);
                origLeftimage = (Bitmap)Image.FromFile(ofd.FileName);
                filtered_left = (Bitmap)Image.FromFile(ofd.FileName);


                //update(origLeftimage, origRightImage);
            }
        }
        private void right_pictureBox_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                right_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                right_pictureBox.Image = Image.FromFile(ofd.FileName);
                origRightImage = (Bitmap)Image.FromFile(ofd.FileName);
                filtered_right= (Bitmap)Image.FromFile(ofd.FileName);
                update(origLeftimage, origRightImage);
            }
        }

        private void save3D_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            sfd.FileName = "Anaglyph";
            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                threeD_pictureBox.Image.Save(sfd.FileName);
            }
        }
        int rotate = 0;
        private void rotate_button_Click(object sender, EventArgs e)
        {
            greyscale_radioButton.Checked = false;
            invert_radioButton.Checked = false;
            //rotate_radioButton.Checked = false;
            sepia_radioButton.Checked = false;

            if (rotate == 1 || rotate == 2)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                }
                else
                {
                    applyRotateFilter(origLeftimage, origRightImage);
                }

                if (rotate == 3)
                {
                    rotate = 0;
                }
                rotate++;
                if (brightness_trackBar.Value != 50)
                {
                    applyBrtFilter(filtered_left, filtered_right);
                }
                if (saturation_trackBar.Value != 50)
                {
                    applySaturationFilter(filtered_left, filtered_right);
                }
                if (contrast_trackBar.Value != 50)
                {
                    applyContrastFilter(filtered_left, filtered_right);
                }
                if (hue_trackBar.Value != 0)
                {
                    applyHueFilter(filtered_left, filtered_right);
                }
            displayImages();
        }

        private void multipleIO_button_Click(object sender, EventArgs e)
        {
            try
            {
                multipleIOcs mio = new multipleIOcs(this);
                mio.Show();
            }
            catch (Exception Ex)
            { }
        }

        private void vid_button_Click(object sender, EventArgs e)
        {
            reader.Open(@"C:\Users\donahoeke\Desktop\Senior Design\dolbycanyon.avi");
     
            int width = reader.Width;
            int height = reader.Height;
            int frameRate = reader.FrameRate;
            long frameCount = reader.FrameCount;
            string codecName = reader.CodecName;
            writer.Open("dolbycanyon_test.avi", width, height, frameRate,AForge.Video.FFMPEG.VideoCodec.Default,30);
            MessageBox.Show("Name: bars_100.avi\nWidth: " + width.ToString() + "\nHeight:" + height.ToString() + "\nFrame rate:" + frameRate + "\nFrame count: " + frameCount + "\nCodec Name: " + codecName);
            
            Bitmap image = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            // write 1000 video frames
            for (int i = 0; i < (int)frameCount; i++)
            {
                try
                {
                    Bitmap videoFrame = reader.ReadVideoFrame();
                    AForge.Imaging.Filters.HueModifier hueFilter = new AForge.Imaging.Filters.HueModifier(135);
                    videoFrame = hueFilter.Apply(videoFrame);
                    writer.WriteVideoFrame(videoFrame);
                }
                catch (Exception ex) { }
            }
            System.Threading.Thread.Sleep(200);
            writer.Close();
        }

        private void crop_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                Bitmap origImage = (Bitmap)Image.FromFile(ofd.FileName);
                Rectangle leftRect = new Rectangle(0, 0, origImage.Width / 2, origImage.Height);

                left_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                origLeftimage = (Bitmap)cropImage(origImage, leftRect);
                filtered_left = origLeftimage;

                left_pictureBox.Image = origLeftimage;


                Rectangle rightRect = new Rectangle(origImage.Width / 2, 0, origImage.Width / 2, origImage.Height);
            
                right_pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                origRightImage = (Bitmap)cropImage(origImage, rightRect);
                filtered_right = origRightImage;

                right_pictureBox.Image = origRightImage;

                try
                {
                    update(origLeftimage, origRightImage);

                }
                catch (Exception ex)
                {

                }
            }
        }

        private static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            return bmpImage.Clone(cropArea, bmpImage.PixelFormat);
        }
    }
}

