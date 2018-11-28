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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2D = new System.Windows.Forms.TabPage();
            this.both_button = new System.Windows.Forms.Button();
            this.right_button = new System.Windows.Forms.Button();
            this.save2d_button = new System.Windows.Forms.Button();
            this.open_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.tabPage3D = new System.Windows.Forms.TabPage();
            this.save3d_button = new System.Windows.Forms.Button();
            this.left_pictureBox = new System.Windows.Forms.PictureBox();
            this.right_pictureBox = new System.Windows.Forms.PictureBox();
            this.threeD_pictureBox = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1.SuspendLayout();
            this.tabPage2D.SuspendLayout();
            this.tabPage3D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.left_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeD_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2D);
            this.tabControl1.Controls.Add(this.tabPage3D);
            this.tabControl1.Location = new System.Drawing.Point(4, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2D
            // 
            this.tabPage2D.Controls.Add(this.splitContainer1);
            this.tabPage2D.Controls.Add(this.both_button);
            this.tabPage2D.Controls.Add(this.right_button);
            this.tabPage2D.Controls.Add(this.save2d_button);
            this.tabPage2D.Controls.Add(this.open_button);
            this.tabPage2D.Controls.Add(this.left_button);
            this.tabPage2D.Location = new System.Drawing.Point(4, 22);
            this.tabPage2D.Name = "tabPage2D";
            this.tabPage2D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2D.Size = new System.Drawing.Size(776, 411);
            this.tabPage2D.TabIndex = 0;
            this.tabPage2D.Text = "2D";
            this.tabPage2D.UseVisualStyleBackColor = true;
            // 
            // both_button
            // 
            this.both_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.both_button.Location = new System.Drawing.Point(344, 382);
            this.both_button.Name = "both_button";
            this.both_button.Size = new System.Drawing.Size(75, 23);
            this.both_button.TabIndex = 4;
            this.both_button.Text = "Both";
            this.both_button.UseVisualStyleBackColor = true;
            this.both_button.Click += new System.EventHandler(this.both_button_Click);
            // 
            // right_button
            // 
            this.right_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.right_button.Location = new System.Drawing.Point(425, 382);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(75, 23);
            this.right_button.TabIndex = 3;
            this.right_button.Text = "Right";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.Click += new System.EventHandler(this.right_button_Click);
            // 
            // save2d_button
            // 
            this.save2d_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save2d_button.Location = new System.Drawing.Point(695, 6);
            this.save2d_button.Name = "save2d_button";
            this.save2d_button.Size = new System.Drawing.Size(75, 23);
            this.save2d_button.TabIndex = 2;
            this.save2d_button.Text = "Save";
            this.save2d_button.UseVisualStyleBackColor = true;
            this.save2d_button.Click += new System.EventHandler(this.save2d_button_Click);
            // 
            // open_button
            // 
            this.open_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.open_button.Location = new System.Drawing.Point(614, 6);
            this.open_button.Name = "open_button";
            this.open_button.Size = new System.Drawing.Size(75, 23);
            this.open_button.TabIndex = 1;
            this.open_button.Text = "Open";
            this.open_button.UseVisualStyleBackColor = true;
            this.open_button.Click += new System.EventHandler(this.open_button_Click);
            // 
            // left_button
            // 
            this.left_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.left_button.Location = new System.Drawing.Point(263, 382);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(75, 23);
            this.left_button.TabIndex = 0;
            this.left_button.Text = "Left";
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.Click += new System.EventHandler(this.left_button_Click);
            // 
            // tabPage3D
            // 
            this.tabPage3D.Controls.Add(this.threeD_pictureBox);
            this.tabPage3D.Controls.Add(this.save3d_button);
            this.tabPage3D.Location = new System.Drawing.Point(4, 22);
            this.tabPage3D.Name = "tabPage3D";
            this.tabPage3D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3D.Size = new System.Drawing.Size(776, 411);
            this.tabPage3D.TabIndex = 1;
            this.tabPage3D.Text = "3D";
            this.tabPage3D.UseVisualStyleBackColor = true;
            // 
            // save3d_button
            // 
            this.save3d_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save3d_button.Location = new System.Drawing.Point(695, 6);
            this.save3d_button.Name = "save3d_button";
            this.save3d_button.Size = new System.Drawing.Size(75, 23);
            this.save3d_button.TabIndex = 0;
            this.save3d_button.Text = "Save";
            this.save3d_button.UseVisualStyleBackColor = true;
            this.save3d_button.Click += new System.EventHandler(this.save3d_button_Click);
            // 
            // left_pictureBox
            // 
            this.left_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.left_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("left_pictureBox.Image")));
            this.left_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.left_pictureBox.Name = "left_pictureBox";
            this.left_pictureBox.Size = new System.Drawing.Size(373, 341);
            this.left_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.left_pictureBox.TabIndex = 5;
            this.left_pictureBox.TabStop = false;
            this.left_pictureBox.Click += new System.EventHandler(this.left_pictureBox_Click);
            // 
            // right_pictureBox
            // 
            this.right_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.right_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("right_pictureBox.Image")));
            this.right_pictureBox.Location = new System.Drawing.Point(0, 0);
            this.right_pictureBox.Name = "right_pictureBox";
            this.right_pictureBox.Size = new System.Drawing.Size(387, 341);
            this.right_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.right_pictureBox.TabIndex = 6;
            this.right_pictureBox.TabStop = false;
            this.right_pictureBox.Click += new System.EventHandler(this.right_pictureBox_Click);
            // 
            // threeD_pictureBox
            // 
            this.threeD_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threeD_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("threeD_pictureBox.Image")));
            this.threeD_pictureBox.Location = new System.Drawing.Point(4, 6);
            this.threeD_pictureBox.Name = "threeD_pictureBox";
            this.threeD_pictureBox.Size = new System.Drawing.Size(685, 399);
            this.threeD_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.threeD_pictureBox.TabIndex = 6;
            this.threeD_pictureBox.TabStop = false;
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.right_pictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(764, 341);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "3DAD";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2D.ResumeLayout(false);
            this.tabPage3D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.left_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threeD_pictureBox)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2D;
        private System.Windows.Forms.TabPage tabPage3D;
        private System.Windows.Forms.Button both_button;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Button save2d_button;
        private System.Windows.Forms.Button open_button;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.Button save3d_button;
        private System.Windows.Forms.PictureBox right_pictureBox;
        private System.Windows.Forms.PictureBox left_pictureBox;
        private System.Windows.Forms.PictureBox threeD_pictureBox;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

