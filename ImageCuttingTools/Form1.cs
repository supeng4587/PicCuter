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

        public string[] _filesPath;
        public string _saveFolderPath;

        private void btnChoice_Click(object sender, EventArgs e)
        {
            _filesPath = null;
            txtChoicePath.Text = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要缩放的图片";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"c:\";
            ofd.Filter = "jpg|*.jpg|jpeg|*.jpeg|png|*.png";
            ofd.ShowDialog();

            _filesPath = ofd.FileNames;
            int stringlength = _filesPath.Length;
            for (int i = 0; i < stringlength; i++)
            {
                txtChoicePath.AppendText(_filesPath[i]+"\n");
            }
            
        }

        private void btnCleanChoice_Click(object sender, EventArgs e)
        {
            txtChoicePath.Text = null;
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            _saveFolderPath = null;
            txtSaveFolder.Text = null;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            _saveFolderPath = fbd.SelectedPath + DateTime.Now.ToString("PicyyMMddHHmmss");
            txtSaveFolder.AppendText(_saveFolderPath+"\n");
            txtSaveFolder.AppendText("--------------\n");
            txtSaveFolder.AppendText("此处为存储目录");
        }

        private void btnExecuteCutting_Click(object sender, EventArgs e)
        {
            
        }


    }
}
