namespace viewerGui
{
    partial class multipleIOcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(multipleIOcs));
            this.left_pictureBox = new System.Windows.Forms.PictureBox();
            this.right_pictureBox = new System.Windows.Forms.PictureBox();
            this.anaglyph_pictureBox = new System.Windows.Forms.PictureBox();
            this.save3D_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.left_button = new System.Windows.Forms.Button();
            this.right_button = new System.Windows.Forms.Button();
            this.color_comboBox = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.left_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.right_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stereo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.import_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.dataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.left_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaglyph_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // left_pictureBox
            // 
            this.left_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.left_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("left_pictureBox.Image")));
            this.left_pictureBox.Location = new System.Drawing.Point(12, 291);
            this.left_pictureBox.Name = "left_pictureBox";
            this.left_pictureBox.Size = new System.Drawing.Size(146, 136);
            this.left_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.left_pictureBox.TabIndex = 54;
            this.left_pictureBox.TabStop = false;
            // 
            // right_pictureBox
            // 
            this.right_pictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.right_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("right_pictureBox.Image")));
            this.right_pictureBox.Location = new System.Drawing.Point(161, 291);
            this.right_pictureBox.Name = "right_pictureBox";
            this.right_pictureBox.Size = new System.Drawing.Size(146, 136);
            this.right_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.right_pictureBox.TabIndex = 55;
            this.right_pictureBox.TabStop = false;
            // 
            // anaglyph_pictureBox
            // 
            this.anaglyph_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.anaglyph_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("anaglyph_pictureBox.Image")));
            this.anaglyph_pictureBox.Location = new System.Drawing.Point(307, 291);
            this.anaglyph_pictureBox.Name = "anaglyph_pictureBox";
            this.anaglyph_pictureBox.Size = new System.Drawing.Size(146, 136);
            this.anaglyph_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anaglyph_pictureBox.TabIndex = 56;
            this.anaglyph_pictureBox.TabStop = false;
            this.anaglyph_pictureBox.DoubleClick += new System.EventHandler(this.anaglyph_pictureBox_DoubleClick);
            // 
            // save3D_button
            // 
            this.save3D_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.save3D_button.BackColor = System.Drawing.Color.DarkGray;
            this.save3D_button.Location = new System.Drawing.Point(389, 251);
            this.save3D_button.Name = "save3D_button";
            this.save3D_button.Size = new System.Drawing.Size(67, 26);
            this.save3D_button.TabIndex = 57;
            this.save3D_button.Text = "Save";
            this.save3D_button.UseVisualStyleBackColor = false;
            this.save3D_button.Click += new System.EventHandler(this.save3D_button_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 430);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Left";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Right";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 430);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Anaglyph";
            // 
            // left_button
            // 
            this.left_button.BackColor = System.Drawing.Color.DarkGray;
            this.left_button.Location = new System.Drawing.Point(30, 16);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(67, 26);
            this.left_button.TabIndex = 61;
            this.left_button.Text = "Left";
            this.left_button.UseVisualStyleBackColor = false;
            this.left_button.Click += new System.EventHandler(this.left_button_Click);
            // 
            // right_button
            // 
            this.right_button.BackColor = System.Drawing.Color.DarkGray;
            this.right_button.Location = new System.Drawing.Point(103, 16);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(67, 26);
            this.right_button.TabIndex = 62;
            this.right_button.Text = "Right";
            this.right_button.UseVisualStyleBackColor = false;
            this.right_button.Click += new System.EventHandler(this.right_button_Click);
            // 
            // color_comboBox
            // 
            this.color_comboBox.FormattingEnabled = true;
            this.color_comboBox.Location = new System.Drawing.Point(176, 21);
            this.color_comboBox.Name = "color_comboBox";
            this.color_comboBox.Size = new System.Drawing.Size(88, 21);
            this.color_comboBox.TabIndex = 63;
            this.color_comboBox.SelectedIndexChanged += new System.EventHandler(this.color_comboBox_SelectedIndexChanged);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.Color.DarkGray;
            this.add_button.Location = new System.Drawing.Point(270, 16);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(67, 26);
            this.add_button.TabIndex = 64;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.left_col,
            this.right_col,
            this.Stereo_col,
            this.dataType});
            this.dataGridView1.Location = new System.Drawing.Point(18, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(438, 182);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // left_col
            // 
            this.left_col.HeaderText = "Left Path";
            this.left_col.Name = "left_col";
            // 
            // right_col
            // 
            this.right_col.HeaderText = "Right Path";
            this.right_col.Name = "right_col";
            // 
            // Stereo_col
            // 
            this.Stereo_col.HeaderText = "Anaglyph Type";
            this.Stereo_col.Name = "Stereo_col";
            // 
            // import_button
            // 
            this.import_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.import_button.Location = new System.Drawing.Point(399, 16);
            this.import_button.Name = "import_button";
            this.import_button.Size = new System.Drawing.Size(67, 26);
            this.import_button.TabIndex = 66;
            this.import_button.Text = "Import";
            this.import_button.UseVisualStyleBackColor = false;
            this.import_button.Click += new System.EventHandler(this.import_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.DarkGray;
            this.clear_button.Location = new System.Drawing.Point(18, 251);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(67, 26);
            this.clear_button.TabIndex = 67;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // dataType
            // 
            this.dataType.HeaderText = "Data Type";
            this.dataType.Name = "dataType";
            // 
            // multipleIOcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 479);
            this.Controls.Add(this.left_pictureBox);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.import_button);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.color_comboBox);
            this.Controls.Add(this.right_button);
            this.Controls.Add(this.left_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.save3D_button);
            this.Controls.Add(this.anaglyph_pictureBox);
            this.Controls.Add(this.right_pictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(494, 518);
            this.Name = "multipleIOcs";
            this.Text = "3DAD Simple IO";
            ((System.ComponentModel.ISupportInitialize)(this.left_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaglyph_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox left_pictureBox;
        private System.Windows.Forms.PictureBox right_pictureBox;
        private System.Windows.Forms.PictureBox anaglyph_pictureBox;
        private System.Windows.Forms.Button save3D_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.ComboBox color_comboBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn left_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn right_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stereo_col;
        private System.Windows.Forms.Button import_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataType;
    }
}
