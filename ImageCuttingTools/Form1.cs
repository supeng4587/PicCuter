using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCuttingTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要缩放的图片";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"c:\";
            ofd.Filter = "jpg|*.jpg|jpeg|*.jpeg|png|*.png";
            ofd.ShowDialog();

            string[] filesPath = ofd.FileNames;

            //12txtChoicePath.Text=
        }
    }
}
