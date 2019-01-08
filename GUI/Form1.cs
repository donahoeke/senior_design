﻿using System;
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
        AForge.Imaging.Filters.GaussianBlur blurFilter = new AForge.Imaging.Filters.GaussianBlur(4,11);
        AForge.Imaging.Filters.GaussianSharpen sharpFilter = new AForge.Imaging.Filters.GaussianSharpen(4,11);
        AForge.Imaging.Filters.Blur quickBlurFilter = new AForge.Imaging.Filters.Blur();
        AForge.Imaging.Filters.Sharpen quickSharpFilter = new AForge.Imaging.Filters.Sharpen();


        //AForge.Video.FFMPEG.VideoFileReader reader = new AForge.Video.FFMPEG.VideoFileReader();
        static Bitmap origRightImage = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\right.bmp");
        static Bitmap origLeftimage = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\left.bmp");
        Bitmap filtered_left = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\left.bmp");
        Bitmap filtered_right = new Bitmap(@"C:\Users\donahoeke\Desktop\Senior Design\right.bmp");
        
        AForge.Imaging.ImageStatistics leftStats = new AForge.Imaging.ImageStatistics(origLeftimage);
        AForge.Imaging.ImageStatistics rightStats = new AForge.Imaging.ImageStatistics(origRightImage);
        
        
        public Form1()
        {
           InitializeComponent();
            left_pictureBox.Image = origLeftimage;
            right_pictureBox.Image = origRightImage;
            apply3D(origLeftimage, origRightImage, "color");
            color_radioButton.Checked = true;
        }


        private void color_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            apply3D(origLeftimage,origRightImage, "color");
        }

        private void true_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            apply3D(origLeftimage, origRightImage, "true");
        }

        private void grey_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            apply3D(origLeftimage, origRightImage, "grey");
        }

        private void half_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            apply3D(origLeftimage, origRightImage, "half");
        }

        private void optimized_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            apply3D(origLeftimage, origRightImage, "opt");
        }

        /*
         * apply3D
         * purpose: displays a specified anaglyph image to the user interface given two stereo input images
         * inputs:
         *  Bitmap origLeftimage: left stereo image to be applied to the filter
         *  Bitmap origRightImage: right stereo image; considered the overlay image of the filter
         *  string anaglyph_type: specifies 1 of 5 different anaglyph output types
         */
        private void apply3D(Bitmap origLeftimage, Bitmap origRightImage, string anaglyph_type)
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
                  
            filter.OverlayImage = origRightImage;
            Bitmap resultImage = filter.Apply(origLeftimage);
            threeD_pictureBox.Image = resultImage;
        }


        private void greyscale_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(greyscale_radioButton.Checked)
            {
                applyGreyscaleFilter(origLeftimage,origRightImage);
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
            if(sepia_radioButton.Checked)
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

        private void rotate_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(rotate_radioButton.Checked)
            {
                applyRotateFilter(origLeftimage, origRightImage);

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
            if(invert_radioButton.Checked)
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
                applyHueFilter(origLeftimage,origRightImage);

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
                if(invert_radioButton.Checked)
                {
                    applyInvertFilter(filtered_left, filtered_right);
                }
                if (rotate_radioButton.Checked)
                {
                    applyRotateFilter(filtered_left, filtered_right);
                }
                displayImages();
            }
            catch(Exception Ex){}
            
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
                if(hue_trackBar.Value != 0)
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
                if (rotate_radioButton.Checked)
                {
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
                if (rotate_radioButton.Checked)
                {
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
                if (rotate_radioButton.Checked)
                {
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
                applySharpenFilter(origLeftimage,origRightImage);
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
                if (rotate_radioButton.Checked)
                {
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
                applyBlurFilter(origLeftimage,origRightImage);

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
                if (rotate_radioButton.Checked)
                {
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

            greyscale_radioButton.Checked = false;
            invert_radioButton.Checked = false;
            rotate_radioButton.Checked = false;
            sepia_radioButton.Checked = false;
        }


        private void applyGreyscaleFilter(Bitmap leftImage, Bitmap rightImage)
        {
            filtered_left = grayscaleFilter.Apply(leftImage);
            filtered_right = grayscaleFilter.Apply(rightImage);
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
            displayImages();
        }
        private void applyQuickBlurFilter()
        {
            filtered_left = quickBlurFilter.Apply(filtered_left);
            filtered_right = quickBlurFilter.Apply(filtered_right);
            displayImages();
        }

        private void revertOriginal()
        {
            filtered_left = origLeftimage;
            filtered_right = origRightImage;
            displayImages();
        }

        private void displayImages()
        {
            left_pictureBox.Image = filtered_left;
            right_pictureBox.Image = filtered_right;
        }

       
    }
}