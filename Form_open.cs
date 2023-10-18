using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 界面图片编辑
{
    public partial class Form_open : Form
    {
        public Form_open()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            // 实例化 MyForm 窗体
            Main_Form main_Form = new Main_Form();

            // 显示 MyForm 窗体
            main_Form.Show();

            //隐藏当前窗口
            this.Hide();
        }
    }
}
