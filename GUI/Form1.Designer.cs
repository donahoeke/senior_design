namespace viewerGui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabPage3D = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optimized_radioButton = new System.Windows.Forms.RadioButton();
            this.half_radioButton = new System.Windows.Forms.RadioButton();
            this.color_radioButton = new System.Windows.Forms.RadioButton();
            this.grey_RadioButton = new System.Windows.Forms.RadioButton();
            this.true_radioButton = new System.Windows.Forms.RadioButton();
            this.save3d_button = new System.Windows.Forms.Button();
            this.tabPage2D = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.original_button = new System.Windows.Forms.Button();
            this.quickBlur_button = new System.Windows.Forms.Button();
            this.quickSharpen_button = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.blur_textBox = new System.Windows.Forms.TextBox();
            this.blur_trackBar = new System.Windows.Forms.TrackBar();
            this.sharpen_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sharpen_trackBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.hue_trackBar = new System.Windows.Forms.TrackBar();
            this.saturation_textBox = new System.Windows.Forms.TextBox();
            this.greyscale_radioButton = new System.Windows.Forms.RadioButton();
            this.saturation_trackBar = new System.Windows.Forms.TrackBar();
            this.sepia_radioButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.rotate_radioButton = new System.Windows.Forms.RadioButton();
            this.contrast_textBox = new System.Windows.Forms.TextBox();
            this.invert_radioButton = new System.Windows.Forms.RadioButton();
            this.contrast_trackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.brt_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hue_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.brightness_trackBar = new System.Windows.Forms.TrackBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.left_pictureBox = new System.Windows.Forms.PictureBox();
            this.right_pictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.threeD_pictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage3D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabPage2D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blur_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpen_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hue_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturation_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrast_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.left_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_pictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threeD_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage3D
            // 
            this.tabPage3D.BackColor = System.Drawing.Color.Silver;
            this.tabPage3D.Controls.Add(this.pictureBox2);
            this.tabPage3D.Controls.Add(this.label1);
            this.tabPage3D.Controls.Add(this.optimized_radioButton);
            this.tabPage3D.Controls.Add(this.half_radioButton);
            this.tabPage3D.Controls.Add(this.color_radioButton);
            this.tabPage3D.Controls.Add(this.grey_RadioButton);
            this.tabPage3D.Controls.Add(this.true_radioButton);
            this.tabPage3D.Controls.Add(this.threeD_pictureBox);
            this.tabPage3D.Controls.Add(this.save3d_button);
            this.tabPage3D.Location = new System.Drawing.Point(4, 22);
            this.tabPage3D.Name = "tabPage3D";
            this.tabPage3D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3D.Size = new System.Drawing.Size(1085, 513);
            this.tabPage3D.TabIndex = 1;
            this.tabPage3D.Text = "3D";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1011, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(892, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Anaglyph Options";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // optimized_radioButton
            // 
            this.optimized_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optimized_radioButton.AutoSize = true;
            this.optimized_radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.optimized_radioButton.Location = new System.Drawing.Point(907, 106);
            this.optimized_radioButton.Name = "optimized_radioButton";
            this.optimized_radioButton.Size = new System.Drawing.Size(71, 17);
            this.optimized_radioButton.TabIndex = 12;
            this.optimized_radioButton.TabStop = true;
            this.optimized_radioButton.Text = "Optimized";
            this.optimized_radioButton.UseVisualStyleBackColor = true;
            this.optimized_radioButton.Click += new System.EventHandler(this.optimized_radioButton_CheckedChanged);

            // 
            // half_radioButton
            // 
            this.half_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.half_radioButton.AutoSize = true;
            this.half_radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.half_radioButton.Location = new System.Drawing.Point(980, 83);
            this.half_radioButton.Name = "half_radioButton";
            this.half_radioButton.Size = new System.Drawing.Size(71, 17);
            this.half_radioButton.TabIndex = 11;
            this.half_radioButton.TabStop = true;
            this.half_radioButton.Text = "Half Color";
            this.half_radioButton.UseVisualStyleBackColor = true;
            this.half_radioButton.Click += new System.EventHandler(this.half_radioButton_CheckedChanged);

            // 
            // color_radioButton
            // 
            this.color_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.color_radioButton.AutoSize = true;
            this.color_radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.color_radioButton.Location = new System.Drawing.Point(907, 60);
            this.color_radioButton.Name = "color_radioButton";
            this.color_radioButton.Size = new System.Drawing.Size(49, 17);
            this.color_radioButton.TabIndex = 10;
            this.color_radioButton.TabStop = true;
            this.color_radioButton.Text = "Color";
            this.color_radioButton.UseVisualStyleBackColor = true;
            this.color_radioButton.Click += new System.EventHandler(this.color_radioButton_CheckedChanged);
            // 
            // grey_RadioButton
            // 
            this.grey_RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grey_RadioButton.AutoSize = true;
            this.grey_RadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grey_RadioButton.Location = new System.Drawing.Point(980, 60);
            this.grey_RadioButton.Name = "grey_RadioButton";
            this.grey_RadioButton.Size = new System.Drawing.Size(47, 17);
            this.grey_RadioButton.TabIndex = 9;
            this.grey_RadioButton.TabStop = true;
            this.grey_RadioButton.Text = "Grey";
            this.grey_RadioButton.UseVisualStyleBackColor = true;
            this.grey_RadioButton.Click += new System.EventHandler(this.grey_RadioButton_CheckedChanged);
            // 
            // true_radioButton
            // 
            this.true_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.true_radioButton.AutoSize = true;
            this.true_radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.true_radioButton.Location = new System.Drawing.Point(907, 83);
            this.true_radioButton.Name = "true_radioButton";
            this.true_radioButton.Size = new System.Drawing.Size(47, 17);
            this.true_radioButton.TabIndex = 8;
            this.true_radioButton.TabStop = true;
            this.true_radioButton.Text = "True";
            this.true_radioButton.UseVisualStyleBackColor = true;
            this.true_radioButton.Click += new System.EventHandler(this.true_radioButton_CheckedChanged);

            // 
            // save3d_button
            // 
            this.save3d_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save3d_button.BackColor = System.Drawing.Color.DarkGray;
            this.save3d_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.save3d_button.Location = new System.Drawing.Point(903, 129);
            this.save3d_button.Name = "save3d_button";
            this.save3d_button.Size = new System.Drawing.Size(75, 23);
            this.save3d_button.TabIndex = 0;
            this.save3d_button.Text = "Save";
            this.save3d_button.UseVisualStyleBackColor = false;
            // 
            // tabPage2D
            // 
            this.tabPage2D.BackColor = System.Drawing.Color.Silver;
            this.tabPage2D.Controls.Add(this.pictureBox1);
            this.tabPage2D.Controls.Add(this.panel1);
            this.tabPage2D.Controls.Add(this.splitContainer1);
            this.tabPage2D.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tabPage2D.Location = new System.Drawing.Point(4, 22);
            this.tabPage2D.Name = "tabPage2D";
            this.tabPage2D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2D.Size = new System.Drawing.Size(1085, 513);
            this.tabPage2D.TabIndex = 0;
            this.tabPage2D.Text = "2D";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1011, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.original_button);
            this.panel1.Controls.Add(this.quickBlur_button);
            this.panel1.Controls.Add(this.quickSharpen_button);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.blur_textBox);
            this.panel1.Controls.Add(this.blur_trackBar);
            this.panel1.Controls.Add(this.sharpen_textBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.sharpen_trackBar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.hue_trackBar);
            this.panel1.Controls.Add(this.saturation_textBox);
            this.panel1.Controls.Add(this.greyscale_radioButton);
            this.panel1.Controls.Add(this.saturation_trackBar);
            this.panel1.Controls.Add(this.sepia_radioButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rotate_radioButton);
            this.panel1.Controls.Add(this.contrast_textBox);
            this.panel1.Controls.Add(this.invert_radioButton);
            this.panel1.Controls.Add(this.contrast_trackBar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.brt_textBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.hue_textBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.brightness_trackBar);
            this.panel1.Location = new System.Drawing.Point(889, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 443);
            this.panel1.TabIndex = 29;
            // 
            // original_button
            // 
            this.original_button.BackColor = System.Drawing.Color.Gray;
            this.original_button.Location = new System.Drawing.Point(10, 365);
            this.original_button.Name = "original_button";
            this.original_button.Size = new System.Drawing.Size(169, 23);
            this.original_button.TabIndex = 37;
            this.original_button.Text = "Original";
            this.original_button.UseVisualStyleBackColor = false;
            this.original_button.Click += new System.EventHandler(this.original_button_Click);

            // 
            // quickBlur_button
            // 
            this.quickBlur_button.BackColor = System.Drawing.Color.DarkGray;
            this.quickBlur_button.Location = new System.Drawing.Point(102, 339);
            this.quickBlur_button.Name = "quickBlur_button";
            this.quickBlur_button.Size = new System.Drawing.Size(77, 23);
            this.quickBlur_button.TabIndex = 37;
            this.quickBlur_button.Text = "Quick Blur";
            this.quickBlur_button.UseVisualStyleBackColor = false;
            this.quickBlur_button.Click += new System.EventHandler(this.quickBlur_button_Click);

            // 
            // quickSharpen_button
            // 
            this.quickSharpen_button.BackColor = System.Drawing.Color.DarkGray;
            this.quickSharpen_button.Location = new System.Drawing.Point(10, 339);
            this.quickSharpen_button.Name = "quickSharpen_button";
            this.quickSharpen_button.Size = new System.Drawing.Size(89, 23);
            this.quickSharpen_button.TabIndex = 36;
            this.quickSharpen_button.Text = "Quick Sharpen";
            this.quickSharpen_button.UseVisualStyleBackColor = false;
            this.quickSharpen_button.Click += new System.EventHandler(this.quickSharpen_button_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Blur";
            // 
            // blur_textBox
            // 
            this.blur_textBox.Location = new System.Drawing.Point(146, 313);
            this.blur_textBox.Name = "blur_textBox";
            this.blur_textBox.Size = new System.Drawing.Size(36, 20);
            this.blur_textBox.TabIndex = 34;
            this.blur_textBox.Text = "0";
            this.blur_textBox.TextChanged += new System.EventHandler(this.blur_textBox_TextChanged);

            // 
            // blur_trackBar
            // 
            this.blur_trackBar.AutoSize = false;
            this.blur_trackBar.Location = new System.Drawing.Point(7, 313);
            this.blur_trackBar.Maximum = 100;
            this.blur_trackBar.Name = "blur_trackBar";
            this.blur_trackBar.Size = new System.Drawing.Size(130, 20);
            this.blur_trackBar.TabIndex = 33;
            this.blur_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.blur_trackBar.Scroll += new System.EventHandler(this.blur_trackBar_Scroll);

            // 
            // sharpen_textBox
            // 
            this.sharpen_textBox.Location = new System.Drawing.Point(146, 274);
            this.sharpen_textBox.Name = "sharpen_textBox";
            this.sharpen_textBox.Size = new System.Drawing.Size(36, 20);
            this.sharpen_textBox.TabIndex = 32;
            this.sharpen_textBox.Text = "0";
            this.sharpen_textBox.TextChanged += new System.EventHandler(this.sharpen_textBox_TextChanged);

            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(7, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Sharpen";
            // 
            // sharpen_trackBar
            // 
            this.sharpen_trackBar.AutoSize = false;
            this.sharpen_trackBar.Location = new System.Drawing.Point(7, 274);
            this.sharpen_trackBar.Name = "sharpen_trackBar";
            this.sharpen_trackBar.Size = new System.Drawing.Size(130, 20);
            this.sharpen_trackBar.TabIndex = 31;
            this.sharpen_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sharpen_trackBar.Scroll += new System.EventHandler(this.sharpen_trackBar_Scroll);


            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(4, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Convolution Filters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(7, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Re-Coloring Filters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Saturation";
            // 
            // hue_trackBar
            // 
            this.hue_trackBar.AutoSize = false;
            this.hue_trackBar.Location = new System.Drawing.Point(7, 88);
            this.hue_trackBar.Maximum = 100;
            this.hue_trackBar.Name = "hue_trackBar";
            this.hue_trackBar.Size = new System.Drawing.Size(130, 20);
            this.hue_trackBar.TabIndex = 11;
            this.hue_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.hue_trackBar.Scroll += new System.EventHandler(this.hue_trackBar_Scroll);

            // 
            // saturation_textBox
            // 
            this.saturation_textBox.Location = new System.Drawing.Point(146, 218);
            this.saturation_textBox.Name = "saturation_textBox";
            this.saturation_textBox.Size = new System.Drawing.Size(36, 20);
            this.saturation_textBox.TabIndex = 27;
            this.saturation_textBox.Text = "50";
            this.saturation_textBox.TextChanged += new System.EventHandler(this.saturation_textBox_TextChanged);
            // 
            // greyscale_radioButton
            // 
            this.greyscale_radioButton.AutoSize = true;
            this.greyscale_radioButton.BackColor = System.Drawing.Color.Transparent;
            this.greyscale_radioButton.ForeColor = System.Drawing.Color.White;
            this.greyscale_radioButton.Location = new System.Drawing.Point(10, 30);
            this.greyscale_radioButton.Name = "greyscale_radioButton";
            this.greyscale_radioButton.Size = new System.Drawing.Size(72, 17);
            this.greyscale_radioButton.TabIndex = 12;
            this.greyscale_radioButton.TabStop = true;
            this.greyscale_radioButton.Text = "Grayscale";
            this.greyscale_radioButton.UseVisualStyleBackColor = false;
            this.greyscale_radioButton.Click += new System.EventHandler(this.greyscale_radioButton_CheckedChanged);
            // 
            // saturation_trackBar
            // 
            this.saturation_trackBar.AutoSize = false;
            this.saturation_trackBar.Location = new System.Drawing.Point(7, 218);
            this.saturation_trackBar.Maximum = 100;
            this.saturation_trackBar.Name = "saturation_trackBar";
            this.saturation_trackBar.Size = new System.Drawing.Size(130, 20);
            this.saturation_trackBar.TabIndex = 26;
            this.saturation_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.saturation_trackBar.Value = 50;
            this.saturation_trackBar.Scroll += new System.EventHandler(this.saturation_trackBar_Scroll);

            // 
            // sepia_radioButton
            // 
            this.sepia_radioButton.AutoSize = true;
            this.sepia_radioButton.BackColor = System.Drawing.Color.Transparent;
            this.sepia_radioButton.ForeColor = System.Drawing.Color.White;
            this.sepia_radioButton.Location = new System.Drawing.Point(85, 30);
            this.sepia_radioButton.Name = "sepia_radioButton";
            this.sepia_radioButton.Size = new System.Drawing.Size(52, 17);
            this.sepia_radioButton.TabIndex = 13;
            this.sepia_radioButton.TabStop = true;
            this.sepia_radioButton.Text = "Sepia";
            this.sepia_radioButton.UseVisualStyleBackColor = false;
            this.sepia_radioButton.Click += new System.EventHandler(this.sepia_radioButton_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Contrast";
            // 
            // rotate_radioButton
            // 
            this.rotate_radioButton.AutoSize = true;
            this.rotate_radioButton.BackColor = System.Drawing.Color.Transparent;
            this.rotate_radioButton.ForeColor = System.Drawing.Color.White;
            this.rotate_radioButton.Location = new System.Drawing.Point(85, 53);
            this.rotate_radioButton.Name = "rotate_radioButton";
            this.rotate_radioButton.Size = new System.Drawing.Size(104, 17);
            this.rotate_radioButton.TabIndex = 14;
            this.rotate_radioButton.TabStop = true;
            this.rotate_radioButton.Text = "Rotate Channels";
            this.rotate_radioButton.UseVisualStyleBackColor = false;
            this.rotate_radioButton.Click += new System.EventHandler(this.rotate_radioButton_CheckedChanged);

            // 
            // contrast_textBox
            // 
            this.contrast_textBox.Location = new System.Drawing.Point(146, 179);
            this.contrast_textBox.Name = "contrast_textBox";
            this.contrast_textBox.Size = new System.Drawing.Size(36, 20);
            this.contrast_textBox.TabIndex = 24;
            this.contrast_textBox.Text = "50";
            this.contrast_textBox.TextChanged += new System.EventHandler(this.contrast_textBox_TextChanged);

            // 
            // invert_radioButton
            // 
            this.invert_radioButton.AutoSize = true;
            this.invert_radioButton.BackColor = System.Drawing.Color.Transparent;
            this.invert_radioButton.ForeColor = System.Drawing.Color.White;
            this.invert_radioButton.Location = new System.Drawing.Point(10, 52);
            this.invert_radioButton.Name = "invert_radioButton";
            this.invert_radioButton.Size = new System.Drawing.Size(52, 17);
            this.invert_radioButton.TabIndex = 15;
            this.invert_radioButton.TabStop = true;
            this.invert_radioButton.Text = "Invert";
            this.invert_radioButton.UseVisualStyleBackColor = false;
            this.invert_radioButton.Click += new System.EventHandler(this.invert_radioButton_CheckedChanged);

            // 
            // contrast_trackBar
            // 
            this.contrast_trackBar.AutoSize = false;
            this.contrast_trackBar.Location = new System.Drawing.Point(7, 179);
            this.contrast_trackBar.Maximum = 100;
            this.contrast_trackBar.Name = "contrast_trackBar";
            this.contrast_trackBar.Size = new System.Drawing.Size(130, 20);
            this.contrast_trackBar.TabIndex = 23;
            this.contrast_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.contrast_trackBar.Value = 50;
            this.contrast_trackBar.Scroll += new System.EventHandler(this.contrast_trackBar_Scroll);

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Hue";
            // 
            // brt_textBox
            // 
            this.brt_textBox.Location = new System.Drawing.Point(146, 140);
            this.brt_textBox.Name = "brt_textBox";
            this.brt_textBox.Size = new System.Drawing.Size(36, 20);
            this.brt_textBox.TabIndex = 22;
            this.brt_textBox.Text = "50";
            this.brt_textBox.TextChanged += new System.EventHandler(this.brt_textBox_TextChanged);

            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(4, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Linear Color Correction Filters";
            // 
            // hue_textBox
            // 
            this.hue_textBox.Location = new System.Drawing.Point(146, 88);
            this.hue_textBox.Name = "hue_textBox";
            this.hue_textBox.Size = new System.Drawing.Size(36, 20);
            this.hue_textBox.TabIndex = 21;
            this.hue_textBox.Text = "0";
            this.hue_textBox.TextChanged += new System.EventHandler(this.hue_textBox_TextChanged);

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Brightness";
            // 
            // brightness_trackBar
            // 
            this.brightness_trackBar.AutoSize = false;
            this.brightness_trackBar.Location = new System.Drawing.Point(7, 140);
            this.brightness_trackBar.Maximum = 100;
            this.brightness_trackBar.Name = "brightness_trackBar";
            this.brightness_trackBar.Size = new System.Drawing.Size(130, 20);
            this.brightness_trackBar.TabIndex = 20;
            this.brightness_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.brightness_trackBar.Value = 50;
            this.brightness_trackBar.Scroll += new System.EventHandler(this.brightness_trackBar_Scroll);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.left_pictureBox);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.right_pictureBox);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(881, 443);
            this.splitContainer1.SplitterDistance = 422;
            this.splitContainer1.TabIndex = 5;
            // 
            // left_pictureBox
            // 
            this.left_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.left_pictureBox.Name = "left_pictureBox";
            this.left_pictureBox.Size = new System.Drawing.Size(422, 443);
            this.left_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.left_pictureBox.TabIndex = 5;
            this.left_pictureBox.TabStop = false;
            // 
            // right_pictureBox
            // 
            this.right_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.right_pictureBox.Name = "right_pictureBox";
            this.right_pictureBox.Size = new System.Drawing.Size(455, 443);
            this.right_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.right_pictureBox.TabIndex = 6;
            this.right_pictureBox.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2D);
            this.tabControl1.Controls.Add(this.tabPage3D);
            this.tabControl1.Location = new System.Drawing.Point(4, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1093, 539);
            this.tabControl1.TabIndex = 1;
            // 
            // threeD_pictureBox
            // 
            this.threeD_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threeD_pictureBox.Location = new System.Drawing.Point(4, 6);
            this.threeD_pictureBox.Name = "threeD_pictureBox";
            this.threeD_pictureBox.Size = new System.Drawing.Size(873, 501);
            this.threeD_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.threeD_pictureBox.TabIndex = 6;
            this.threeD_pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1100, 552);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "3DAD Image & Video Viewer";
            this.tabPage3D.ResumeLayout(false);
            this.tabPage3D.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabPage2D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blur_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpen_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hue_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturation_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrast_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_trackBar)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.left_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_pictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.threeD_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3D;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optimized_radioButton;
        private System.Windows.Forms.RadioButton half_radioButton;
        private System.Windows.Forms.RadioButton color_radioButton;
        private System.Windows.Forms.RadioButton grey_RadioButton;
        private System.Windows.Forms.RadioButton true_radioButton;
        private System.Windows.Forms.Button save3d_button;
        private System.Windows.Forms.TabPage tabPage2D;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button original_button;
        private System.Windows.Forms.Button quickBlur_button;
        private System.Windows.Forms.Button quickSharpen_button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox blur_textBox;
        private System.Windows.Forms.TrackBar blur_trackBar;
        private System.Windows.Forms.TextBox sharpen_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar sharpen_trackBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar hue_trackBar;
        private System.Windows.Forms.TextBox saturation_textBox;
        private System.Windows.Forms.RadioButton greyscale_radioButton;
        private System.Windows.Forms.TrackBar saturation_trackBar;
        private System.Windows.Forms.RadioButton sepia_radioButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rotate_radioButton;
        private System.Windows.Forms.TextBox contrast_textBox;
        private System.Windows.Forms.RadioButton invert_radioButton;
        private System.Windows.Forms.TrackBar contrast_trackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox brt_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hue_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar brightness_trackBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox left_pictureBox;
        private System.Windows.Forms.PictureBox right_pictureBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox threeD_pictureBox;
    }
}

