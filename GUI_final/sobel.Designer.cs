namespace viewerGui
{
    partial class sobel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sobel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.save3d_button = new System.Windows.Forms.Button();
            this.big_pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.big_pictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1135, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // save3d_button
            // 
            this.save3d_button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save3d_button.BackColor = System.Drawing.Color.DarkGray;
            this.save3d_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.save3d_button.Location = new System.Drawing.Point(2, -2);
            this.save3d_button.Name = "save3d_button";
            this.save3d_button.Size = new System.Drawing.Size(597, 23);
            this.save3d_button.TabIndex = 56;
            this.save3d_button.Text = "Save";
            this.save3d_button.UseVisualStyleBackColor = false;
            this.save3d_button.Click += new System.EventHandler(this.save3d_button_Click);
            // 
            // big_pictureBox2
            // 
            this.big_pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.big_pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.big_pictureBox2.Name = "big_pictureBox2";
            this.big_pictureBox2.Size = new System.Drawing.Size(596, 597);
            this.big_pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.big_pictureBox2.TabIndex = 55;
            this.big_pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(0, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(593, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // big_pictureBox
            // 
            this.big_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.big_pictureBox.Enabled = false;
            this.big_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.big_pictureBox.Name = "big_pictureBox";
            this.big_pictureBox.Size = new System.Drawing.Size(594, 597);
            this.big_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.big_pictureBox.TabIndex = 57;
            this.big_pictureBox.TabStop = false;
            this.big_pictureBox.Click += new System.EventHandler(this.big_pictureBox_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Enabled = false;
            this.splitContainer1.Location = new System.Drawing.Point(12, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.big_pictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.big_pictureBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1194, 597);
            this.splitContainer1.SplitterDistance = 594;
            this.splitContainer1.TabIndex = 59;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(12, 637);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.save3d_button);
            this.splitContainer2.Size = new System.Drawing.Size(1194, 32);
            this.splitContainer2.SplitterDistance = 591;
            this.splitContainer2.TabIndex = 60;
            // 
            // sobel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1214, 670);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sobel";
            this.Text = "3DAD Sobel Image ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_pictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button save3d_button;
        private System.Windows.Forms.PictureBox big_pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox big_pictureBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}
