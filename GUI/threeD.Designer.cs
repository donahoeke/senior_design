namespace viewerGui
{
    partial class threeD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(threeD));
            this.big_pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optimized_radioButton = new System.Windows.Forms.RadioButton();
            this.save3d_button = new System.Windows.Forms.Button();
            this.true_radioButton = new System.Windows.Forms.RadioButton();
            this.half_radioButton = new System.Windows.Forms.RadioButton();
            this.grey_RadioButton = new System.Windows.Forms.RadioButton();
            this.color_radioButton = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.big_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // big_pictureBox
            // 
            this.big_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.big_pictureBox.BackColor = System.Drawing.Color.Silver;
            this.big_pictureBox.Location = new System.Drawing.Point(3, 15);
            this.big_pictureBox.Name = "big_pictureBox";
            this.big_pictureBox.Size = new System.Drawing.Size(515, 508);
            this.big_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.big_pictureBox.TabIndex = 47;
            this.big_pictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(547, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Anaglyph Options";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // optimized_radioButton
            // 
            this.optimized_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optimized_radioButton.AutoSize = true;
            this.optimized_radioButton.BackColor = System.Drawing.Color.Silver;
            this.optimized_radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.optimized_radioButton.Location = new System.Drawing.Point(562, 106);
            this.optimized_radioButton.Name = "optimized_radioButton";
            this.optimized_radioButton.Size = new System.Drawing.Size(71, 17);
            this.optimized_radioButton.TabIndex = 53;
            this.optimized_radioButton.TabStop = true;
            this.optimized_radioButton.Text = "Optimized";
            this.optimized_radioButton.UseVisualStyleBackColor = false;
            this.optimized_radioButton.CheckedChanged += new System.EventHandler(this.optimized_radioButton_CheckedChanged);
            // 
            // save3d_button
            // 
            this.save3d_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save3d_button.BackColor = System.Drawing.Color.DarkGray;
            this.save3d_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.save3d_button.Location = new System.Drawing.Point(0, 529);
            this.save3d_button.Name = "save3d_button";
            this.save3d_button.Size = new System.Drawing.Size(521, 23);
            this.save3d_button.TabIndex = 48;
            this.save3d_button.Text = "Save";
            this.save3d_button.UseVisualStyleBackColor = false;
            this.save3d_button.Click += new System.EventHandler(this.save3d_button_Click);
            // 
            // true_radioButton
            // 
            this.true_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.true_radioButton.AutoSize = true;
            this.true_radioButton.BackColor = System.Drawing.Color.Silver;
            this.true_radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.true_radioButton.Location = new System.Drawing.Point(562, 83);
            this.true_radioButton.Name = "true_radioButton";
            this.true_radioButton.Size = new System.Drawing.Size(47, 17);
            this.true_radioButton.TabIndex = 49;
            this.true_radioButton.TabStop = true;
            this.true_radioButton.Text = "True";
            this.true_radioButton.UseVisualStyleBackColor = false;
            this.true_radioButton.CheckedChanged += new System.EventHandler(this.true_radioButton_CheckedChanged);
            // 
            // half_radioButton
            // 
            this.half_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.half_radioButton.AutoSize = true;
            this.half_radioButton.BackColor = System.Drawing.Color.Silver;
            this.half_radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.half_radioButton.Location = new System.Drawing.Point(562, 152);
            this.half_radioButton.Name = "half_radioButton";
            this.half_radioButton.Size = new System.Drawing.Size(71, 17);
            this.half_radioButton.TabIndex = 52;
            this.half_radioButton.TabStop = true;
            this.half_radioButton.Text = "Half Color";
            this.half_radioButton.UseVisualStyleBackColor = false;
            this.half_radioButton.CheckedChanged += new System.EventHandler(this.half_radioButton_CheckedChanged);
            // 
            // grey_RadioButton
            // 
            this.grey_RadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grey_RadioButton.AutoSize = true;
            this.grey_RadioButton.BackColor = System.Drawing.Color.Silver;
            this.grey_RadioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grey_RadioButton.Location = new System.Drawing.Point(562, 129);
            this.grey_RadioButton.Name = "grey_RadioButton";
            this.grey_RadioButton.Size = new System.Drawing.Size(47, 17);
            this.grey_RadioButton.TabIndex = 50;
            this.grey_RadioButton.TabStop = true;
            this.grey_RadioButton.Text = "Grey";
            this.grey_RadioButton.UseVisualStyleBackColor = false;
            this.grey_RadioButton.CheckedChanged += new System.EventHandler(this.grey_RadioButton_CheckedChanged);
            // 
            // color_radioButton
            // 
            this.color_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.color_radioButton.AutoSize = true;
            this.color_radioButton.BackColor = System.Drawing.Color.Silver;
            this.color_radioButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.color_radioButton.Location = new System.Drawing.Point(562, 60);
            this.color_radioButton.Name = "color_radioButton";
            this.color_radioButton.Size = new System.Drawing.Size(49, 17);
            this.color_radioButton.TabIndex = 51;
            this.color_radioButton.TabStop = true;
            this.color_radioButton.Text = "Color";
            this.color_radioButton.UseVisualStyleBackColor = false;
            this.color_radioButton.CheckedChanged += new System.EventHandler(this.color_radioButton_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(550, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.save3d_button);
            this.panel1.Controls.Add(this.big_pictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 563);
            this.panel1.TabIndex = 56;
            // 
            // threeD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(655, 578);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optimized_radioButton);
            this.Controls.Add(this.true_radioButton);
            this.Controls.Add(this.half_radioButton);
            this.Controls.Add(this.grey_RadioButton);
            this.Controls.Add(this.color_radioButton);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "threeD";
            this.Text = "3DAD Anaglyph Image";
            this.Load += new System.EventHandler(this.threeD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.big_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox big_pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton optimized_radioButton;
        private System.Windows.Forms.Button save3d_button;
        private System.Windows.Forms.RadioButton true_radioButton;
        private System.Windows.Forms.RadioButton half_radioButton;
        private System.Windows.Forms.RadioButton grey_RadioButton;
        private System.Windows.Forms.RadioButton color_radioButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}