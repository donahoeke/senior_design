using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace viewerGui
{
    public partial class original : Form
    {
        public original()
        {
            InitializeComponent();
        }

        private Form1 mainForm = null;
        public original(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();

            Bitmap resultImage_left = this.mainForm.getOriginallImageLeft();
            Bitmap resultImage_right = this.mainForm.getOriginallImageRight();
            big_pictureBox.Image = resultImage_left;
            big_pictureBox2.Image = resultImage_right;
        }
    }
}
