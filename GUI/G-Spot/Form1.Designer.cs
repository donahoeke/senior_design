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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3D = new System.Windows.Forms.TabPage();
            this.threeD_pictureBox = new System.Windows.Forms.PictureBox();
            this.save3d_button = new System.Windows.Forms.Button();
            this.tabPage2D = new System.Windows.Forms.TabPage();
            this.threeD_button = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LEFTpictureBox = new System.Windows.Forms.PictureBox();
            this.RIGHTpictureBox = new System.Windows.Forms.PictureBox();
            this.both_button = new System.Windows.Forms.Button();
            this.right_button = new System.Windows.Forms.Button();
            this.left_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage3D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threeD_pictureBox)).BeginInit();
            this.tabPage2D.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LEFTpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHTpictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1025, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem,
            this.rightToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftToolStripMenuItem1,
            this.rightToolStripMenuItem1});
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            // 
            // leftToolStripMenuItem1
            // 
            this.leftToolStripMenuItem1.Name = "leftToolStripMenuItem1";
            this.leftToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.leftToolStripMenuItem1.Text = "Left ";
            this.leftToolStripMenuItem1.Click += new System.EventHandler(this.leftToolStripMenuItem1_Click);
            // 
            // rightToolStripMenuItem1
            // 
            this.rightToolStripMenuItem1.Name = "rightToolStripMenuItem1";
            this.rightToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.rightToolStripMenuItem1.Text = "Right";
            this.rightToolStripMenuItem1.Click += new System.EventHandler(this.rightToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // tabPage3D
            // 
            this.tabPage3D.Controls.Add(this.threeD_pictureBox);
            this.tabPage3D.Controls.Add(this.save3d_button);
            this.tabPage3D.Location = new System.Drawing.Point(4, 22);
            this.tabPage3D.Name = "tabPage3D";
            this.tabPage3D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3D.Size = new System.Drawing.Size(1005, 583);
            this.tabPage3D.TabIndex = 1;
            this.tabPage3D.Text = "3D";
            this.tabPage3D.UseVisualStyleBackColor = true;
            // 
            // threeD_pictureBox
            // 
            this.threeD_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.threeD_pictureBox.Location = new System.Drawing.Point(40, 6);
            this.threeD_pictureBox.Name = "threeD_pictureBox";
            this.threeD_pictureBox.Size = new System.Drawing.Size(637, 423);
            this.threeD_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.threeD_pictureBox.TabIndex = 6;
            this.threeD_pictureBox.TabStop = false;
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
            // tabPage2D
            // 
            this.tabPage2D.Controls.Add(this.threeD_button);
            this.tabPage2D.Controls.Add(this.splitContainer1);
            this.tabPage2D.Controls.Add(this.both_button);
            this.tabPage2D.Controls.Add(this.right_button);
            this.tabPage2D.Controls.Add(this.left_button);
            this.tabPage2D.Location = new System.Drawing.Point(4, 22);
            this.tabPage2D.Name = "tabPage2D";
            this.tabPage2D.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2D.Size = new System.Drawing.Size(1005, 583);
            this.tabPage2D.TabIndex = 0;
            this.tabPage2D.Text = "2D";
            this.tabPage2D.UseVisualStyleBackColor = true;
            // 
            // threeD_button
            // 
            this.threeD_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.threeD_button.Location = new System.Drawing.Point(924, 6);
            this.threeD_button.Name = "threeD_button";
            this.threeD_button.Size = new System.Drawing.Size(75, 23);
            this.threeD_button.TabIndex = 6;
            this.threeD_button.Text = "3D";
            this.threeD_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.threeD_button.UseVisualStyleBackColor = true;
            this.threeD_button.Click += new System.EventHandler(this.threeD_button_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(19, 35);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LEFTpictureBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.RIGHTpictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(980, 513);
            this.splitContainer1.SplitterDistance = 474;
            this.splitContainer1.TabIndex = 5;
            // 
            // LEFTpictureBox
            // 
            this.LEFTpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.LEFTpictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LEFTpictureBox.Location = new System.Drawing.Point(0, 0);
            this.LEFTpictureBox.Name = "LEFTpictureBox";
            this.LEFTpictureBox.Size = new System.Drawing.Size(474, 513);
            this.LEFTpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LEFTpictureBox.TabIndex = 0;
            this.LEFTpictureBox.TabStop = false;
            this.LEFTpictureBox.DoubleClick += new System.EventHandler(this.left_pictureBox_DoubleClick);
            // 
            // RIGHTpictureBox
            // 
            this.RIGHTpictureBox.BackColor = System.Drawing.Color.Transparent;
            this.RIGHTpictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RIGHTpictureBox.Location = new System.Drawing.Point(0, 0);
            this.RIGHTpictureBox.Name = "RIGHTpictureBox";
            this.RIGHTpictureBox.Size = new System.Drawing.Size(502, 513);
            this.RIGHTpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RIGHTpictureBox.TabIndex = 0;
            this.RIGHTpictureBox.TabStop = false;
            this.RIGHTpictureBox.Click += new System.EventHandler(this.RIGHTpictureBox_Click);
            this.RIGHTpictureBox.DoubleClick += new System.EventHandler(this.right_pictureBox_DoubleClick);
            // 
            // both_button
            // 
            this.both_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.both_button.Location = new System.Drawing.Point(458, 554);
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
            this.right_button.Location = new System.Drawing.Point(539, 554);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(75, 23);
            this.right_button.TabIndex = 3;
            this.right_button.Text = "Right";
            this.right_button.UseVisualStyleBackColor = true;
            this.right_button.Click += new System.EventHandler(this.right_button_Click);
            // 
            // left_button
            // 
            this.left_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.left_button.Location = new System.Drawing.Point(377, 554);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(75, 23);
            this.left_button.TabIndex = 0;
            this.left_button.Text = "Left";
            this.left_button.UseVisualStyleBackColor = true;
            this.left_button.Click += new System.EventHandler(this.left_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2D);
            this.tabControl1.Controls.Add(this.tabPage3D);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1013, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 648);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "3DAD";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3D.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.threeD_pictureBox)).EndInit();
            this.tabPage2D.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LEFTpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIGHTpictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem1;
        private System.Windows.Forms.TabPage tabPage3D;
        private System.Windows.Forms.PictureBox threeD_pictureBox;
        private System.Windows.Forms.Button save3d_button;
        private System.Windows.Forms.TabPage tabPage2D;
        private System.Windows.Forms.Button threeD_button;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox LEFTpictureBox;
        private System.Windows.Forms.Button both_button;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.PictureBox RIGHTpictureBox;
    }
}

