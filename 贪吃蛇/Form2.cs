using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 贪吃蛇
{
    public partial class Form2 : Form
    {
        Snake Game = new Snake();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Game.Read(richTextBox1);    //向Game.Read中传入richTextBox1
        }

        private void 清除历史记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Reset(richTextBox1);   //向Game.Reset传入 richTextBox1
        }
    }
}
