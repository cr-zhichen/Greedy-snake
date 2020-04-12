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
    public partial class Form1 : Form
    {
        Snake Game = new Snake();
        double p = 5;//定义timer基准值
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game.InitHead(pictureBox1); //初始化蛇头坐标
            p = Game.SnakeSize(0, 10);   //调用Game.SnakeSize
            Game.Timer(label3, label4, timer1, 12 * p, false);    //更改timer1 属性为12 * p
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Game.background(Form.ActiveForm);    //背景控制
            Game.KeyControl(Form.ActiveForm,pictureBox1, e, label1);    //控制蛇头移动
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Game.Algorithm(pictureBox1.CreateGraphics(), pictureBox1, label1);  //基本玩法
        }

        private void 一个ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Foodnumber(1); //更改食物数量为1
        }

        private void 两个ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Foodnumber(2); //更改食物数量为2
        }

        private void 一级默认ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Timer(label3,label4,timer1, 20 * p, false);    //更改timer1 属性为20 * p
        }

        private void 二级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Timer(label3, label4, timer1, 16 * p, false);    //更改timer1 属性为16 * p
        }

        private void 三级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Timer(label3, label4, timer1, 12 * p, false);    //更改timer1 属性为12 * p
        }

        private void 四级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Timer(label3, label4, timer1, 8 * p, false);    //更改timer1 属性为8 * p
        }

        private void 五级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Timer(label3, label4, timer1, 4 * p, false);    //更改timer1 属性为4 * p
        }

        private void 地狱级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.Timer(label3, label4, timer1, 1 * p, false);    //更改timer1 属性为1 * p
        }

        private void 图标1默认ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.FoodBeautify(1);   //向game.FoodBeautify中传入1
        }

        private void 图标2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.FoodBeautify(2);   //向game.FoodBeautify中传入2
        }

        private void 图标3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Game.FoodBeautify(3);   //向game.FoodBeautify中传入3
        }

        private void 图标3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Game.FoodBeautify(4);   //向game.FoodBeautify中传入4
        }

        private void 历史记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  //new一个窗口
            form2.ShowDialog(this); //显示窗口
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            Game.Focus();   //调用Game.Focus
        }

        private void 小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p = Game.SnakeSize(0, 5);   //调用Game.SnakeSize
            Game.Timer(label3, label4, timer1, 12 * p, false);    //更改timer1 属性为12 * p
        }

        private void 中ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p = Game.SnakeSize(0, 10);   //调用Game.SnakeSize
            Game.Timer(label3, label4, timer1, 12 * p, false);    //更改timer1 属性为12 * p
        }

        private void 大ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p = Game.SnakeSize(0, 15);   //调用Game.SnakeSize
            Game.Timer(label3, label4, timer1, 12 * p, false);    //更改timer1 属性为12 * p

        }

    }
}
