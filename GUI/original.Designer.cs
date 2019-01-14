namespace viewerGui
{
    partial class original
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(original));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.big_pictureBox = new System.Windows.Forms.PictureBox();
            this.big_pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.big_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Enabled = false;
            this.splitContainer1.Location = new System.Drawing.Point(12, 34);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.big_pictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.big_pictureBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1194, 618);
            this.splitContainer1.SplitterDistance = 594;
            this.splitContainer1.TabIndex = 61;
            // 
            // big_pictureBox
            // 
            this.big_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.big_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.big_pictureBox.Name = "big_pictureBox";
            this.big_pictureBox.Size = new System.Drawing.Size(594, 618);
            this.big_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.big_pictureBox.TabIndex = 57;
            this.big_pictureBox.TabStop = false;
            // 
            // big_pictureBox2
            // 
            this.big_pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.big_pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.big_pictureBox2.Name = "big_pictureBox2";
            this.big_pictureBox2.Size = new System.Drawing.Size(596, 618);
            this.big_pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.big_pictureBox2.TabIndex = 55;
            this.big_pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1135, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 60;
            this.pictureBox1.TabStop = false;
            // 
            // original
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1214, 655);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "original";
            this.Text = "3DAD Original Images";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.big_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.big_pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox big_pictureBox;
        private System.Windows.Forms.PictureBox big_pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}