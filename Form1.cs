using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 显示消息框，询问用户是否打开新页面
            DialogResult result = MessageBox.Show("确定打开图片吗？","提示",MessageBoxButtons.YesNoCancel);

            if (result==DialogResult.Yes) 
            {
                openImage();
            }

        }
        private void openImage() 
        {
            Form imageForm = new Form();
            PictureBox pictureBox = new PictureBox();

            // 设置 PictureBox 属性
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.Image = Image.FromFile(@"E:\BEACI照片\IMG_20230906_095119-1.jpg");

            // 将 PictureBox 添加到窗体
            imageForm.Controls.Add(pictureBox);
            imageForm.Text = "图片";
            imageForm.WindowState = FormWindowState.Maximized;

            // 显示窗体
            imageForm.ShowDialog();
        }
    }
}
