/*
 * 姓名：张程瑞
 * 学号：19107350111
 * 项目名称：贪吃蛇
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace 贪吃蛇
{
    class Snake
    {
        Image stopImage = Image.FromFile("zt.png");    //定义一个image变量用来存储stopImage.png 暂停图片
        Image dieImage = Image.FromFile("sw.png");    //定义一个image变量用来存储dieImage.png 死亡图片
        Image blankBackgroundImage = Image.FromFile("bgN.png");    //定义一个image变量用来存储bgN.png 空白背景图片
        Image backgroundImage = Image.FromFile("bgN0.png");    //定义一个image变量用来存储bgN0.png 提示背景图片
        Image HeadImage = Image.FromFile("Head.png");    //定义一个image变量用来存储Head.png   蛇头图片
        Image FoodImage = Image.FromFile("Food.png");    //定义一个image变量用来存储Food.png   食物图片

        bool pause = false;//表示是否暂停
        bool die = false;//用来存储是否死亡
        bool start = false;//表示游戏是否开始
        bool save = false;//表示是否保存
        int foodNumber = 0;//现有食物数量
        int foodScreen = 1;//同屏出现食物数量
        int score = 0;//表示得分
        int direction;//表示移动方向 8上 5下 4左 6右
        int time = 0;//表示循环次数
        int snakelength = 0;//用来存储蛇吃了多少
        int snakeR = 5;//定义蛇的半径
        double magnification = 1.5;//定义得分倍率


        //蛇头类
        class HeadClass //定义一个类
        {
            public int HdX;    //定义一个int类型变量HdX
            public int HdY;    //定义一个int类型变量HdY
            public Image image; //定义一个Imgage类型变量image

            public HeadClass(int x, int y, Image image)   //定义一个方法
            {
                HdX = x;  //将x赋值给HdX
                HdY = y;  //将y赋值给HdY
                this.image = image; //将image赋值给image
            }
        }
        //蛇头列表
        List<HeadClass> HeadList = new List<HeadClass>();   //定义一个列表并把HeadClass加入列表

        //食物类
        class FoodsClass    //定义一个类
        {
            public int FdX;    //定义一个int类型变量FdX
            public int FdY;    //定义一个int类型变量FdY
            public Image image; //定义一个Imgage类型变量image

            public FoodsClass(int x, int y, Image image)   //定义一个方法
            {
                FdX = x;  //将x赋值给FdX
                FdY = y;  //将y赋值给FdY
                this.image = image; //将image赋值给image
            }
        }
        //食物列表
        List<FoodsClass> FoodList = new List<FoodsClass>();   //定义一个列表并把FoodsClass加入列表

        //蛇头坐标
        int HdX;    //定义int类型变量HdX
        int HdY;    //定义int类型变量HdY

        //初始化蛇头坐标
        public void InitHead(PictureBox pictureBox) //定义一个方法
        {
            HdX = pictureBox.Width / 2; //使HdX等于pictureBox宽的一半
            HdY = pictureBox.Height / 2; //使HdY等于pictureBox高的一半
        }

        //控制模块
        public void KeyControl(Form form,PictureBox pictureBox,KeyEventArgs e,Label label)    //定义一个方法
        {
            //按方向键移动
            if (e.KeyCode == Keys.Up)   //判断是否按下方向上键
            {
                if (HdY >= 0 && direction != 5 && die != true)  //判断HdY是否大于等于0，且direction不等于5，且die不等于true
                {
                    //HdY -= 10;
                    direction = 8;  //使direction等于8
                }
            }
            if (e.KeyCode == Keys.Down)   //判断是否按下方向下键
            {
                if (HdY <= 389 && direction != 8 && die != true)   //判断HdY是否小于等于389，且direction不等于8，且die不等于true
                {
                    //HdY += 10;
                    direction = 5;  //使direction等于5
                }
            }
            if (e.KeyCode == Keys.Left)   //判断是否按下方向左键
            {
                if (HdX >= 0 && direction != 6 && die != true)    //判断HdX是否大于等于0，且direction不等于6，且die不等于true
                {
                    //HdX -= 10;
                    direction = 4;  //使direction等于4
                }
            }
            if (e.KeyCode == Keys.Right)   //判断是否按下方向右键
            {
                if (HdX <= 589 && direction != 4 && die != true)     //判断HdX是否小于等于589，且direction不等于4，且die不等于true
                {
                    //HdX += 10;
                    direction = 6;  //使direction等于6
                }
            }

            //按空格暂停
            if (e.KeyCode == Keys.Space)    //判断是否按下空格键
            {
                pause = !pause; //使pause等于非pause
            }

            //按R键或回车重新开始游戏
            if (e.KeyCode == Keys.R||e.KeyCode==Keys.Enter)    //判断是否按下R键
            {
                if (die)    //判断die是否为true
                {
                    die = false; //使die等于false
                    InitHead(pictureBox);   //重新初始化蛇位置
                    int x = HeadList.Count;   //定义x为HeadList的数量
                    for (int i = 0; i < x; i++)  //循环判断 int i =0 在i小于x的数量中循环 i++    //遍历HeadList
                    {
                        HeadList.RemoveAt(0); //从HeadList中移出下标为i的元素
                    }
                    snakelength = 1;    //使snakelength等于1
                    time = 0;   //使time等于0
                    score = 0;  //使score等于0
                    label.Text = "得分：" + Convert.ToString(score);   //使label输出文字和分数
                    direction = 0;  //使direction等于0
                    start = false;  //使start等于false
                    form.BackgroundImage = backgroundImage;    //将窗口背景图案改为backgroundImage
                    save = false;   //使save等于false
                }
                //重启程序
                //Application.Exit(); //退出程序
                //System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);   //重启程序
            }
        }

        //背景控制
        public void background(Form form)    //定义一个方法
        {
            //判断开始游戏
            if (!start) //判断start是否为false
            {
                form.BackgroundImage = blankBackgroundImage; //使窗口的背景图案设置为blankBackgroundImage
                start = true;   //使start为true
            }
        }

        //游戏算法实现
        public void Algorithm(Graphics g,PictureBox pictureBox,Label label) //定义一个方法
        {
            //判断游戏是否开始
            if (start)  //判断游戏是否开始
            {
                //是否死亡
                if (die)    //如果die等于true
                {
                    g.DrawImage(dieImage, 0, 0, 600, 400);    //绘制死亡图像
                    if (save == false)  //判断save是否为false
                    {
                        Record(Convert.ToString(score));    //将score传入record
                        save = true;    //使save等于true
                        start = false;
                    }
                    return;
                }

                //空格暂停
                else    //否则
                {
                    if (pause)  //判断pause是否等于true
                    {
                        g.DrawImage(stopImage, 0, 0, 600, 400);    //绘制暂停图片
                        return; //返回值 阻止程序执行下面的操作
                    }
                    else    //否则
                    {
                        //绘制画布
                        pictureBox.Refresh();   //刷新背景
                                                //g.DrawImage(bg1, 0, 0, 600, 400);
                    }
                }

                //生成蛇头
                if (time >= 1)  //如果time大于等于1
                {
                    HeadList.RemoveAt(0); //从HeadList中移出下标为0的数
                }
                time += 1;  //使time等于time+1
                HeadClass HeadClass = new HeadClass(HdX, HdY, HeadImage);    //将HdX HdY HeadImage传入HeadClass中
                HeadList.Add(HeadClass);  //将HeadClass加入HeadList

                //画蛇头
                g.DrawImage(HeadImage, new Point(HdX, HdY)); //在HdX，HdY坐标绘制HeadImage

                //蛇头移动
                if (direction == 8 && HdY >= 10)    //判断direction等于8 并且HdY大于等于10
                {
                    HdY -= snakeR * 2;  //HdY等于HdY-snakeR * 2
                }
                if (direction == 5 && HdY <= 389)    //判断direction等于5 并且HdY小于等于389
                {
                    HdY += snakeR * 2;  //HdY等于HdY+snakeR * 2
                }
                if (direction == 4 && HdX >= 10)    //判断direction等于4 并且HdX大于等于10
                {
                    HdX -= snakeR * 2;  //HdX等于HdX-snakeR * 2
                }
                if (direction == 6 && HdX <= 589)    //判断direction等于6 并且HdX小于等于589
                {
                    HdX += snakeR * 2;  //HdX等于HdX+snakeR * 2
                }

                //生成食物
                if (foodNumber < foodScreen)  //判断foodNumber是否小于1
                {
                    int tX = new Random().Next(10, 580); //定义int变量tX 等于在10到580中取随机数
                    System.Threading.Thread.Sleep(100); //延迟100毫秒   //用来防止两次生成随机数相同
                    int tY = new Random().Next(10, 380); //定义int变量tY 等于在10到380中取随机数
                    foodNumber += 1; //使foodNumber等于foodNumber+1
                    FoodsClass FoodsClass = new FoodsClass(tX, tY, FoodImage);   //将tX tY FoodImage传入FoodsClass中
                    FoodList.Add(FoodsClass);  //将food加入FoodList
                }

                //绘制食物
                for (int i = 0; i < FoodList.Count; i++)  //循环判断 定义int i等于0，在i小于FoodList的长度中循环，i++   //遍历FoodList
                {
                    g.DrawImage(FoodList[i].image, new Point(FoodList[i].FdX, FoodList[i].FdY));  //绘制FoodList中下标为i的图片，在FoodList中下标为i的横坐标FdX，纵坐标为FdY的位置
                }

                //吃食物
                for (int i = 0; i < FoodList.Count; i++)   //循环判断 定义int i等于0，在i小于FoodList的长度中循环，i++   //遍历FoodList
                {
                    for (int j = 0; j < HeadList.Count; j++)   //循环判断 定义int j等于0，在j小于HeadList的长度中循环，j++   //遍历HeadList
                    {
                        //碰撞检测
                        if (Math.Abs((FoodList[i].FdX) - (HeadList[j].HdX)) <= (2 * snakeR) && Math.Abs((FoodList[i].FdY) - (HeadList[j].HdY)) <= (2 * snakeR)) 
                        //判断 FoodList中下标为i的横坐标 减去HeadList中下标为j的横坐标 的绝对值 是否小于等于2r，并且FoodList中下标为i的纵坐标 减去HeadList中下标为j的纵坐标 的绝对值 是否小于等于2r
                        {
                            foodNumber -= 1; //foodNumber等于foodNumber-1
                            score += Convert.ToInt32(100 * magnification);   //score等于score+100
                            snakelength += 1;   //snakelength等于snakelength+1
                                                //增加蛇身长度
                            if (snakelength > 0)    //判断snakelength是否大于0
                            {
                                HeadClass HeadClass0 = new HeadClass(HdX, HdY, HeadImage);   //将HdX HdY HeadImage 传入HeadClass中
                                HeadList.Add(HeadClass0); //将HeadClass0添加到HeadList中
                                GC.Collect();   //强制进行垃圾回收
                            }
                            label.Text = "得分：" + Convert.ToString(score);   //使label输出文字和分数
                            FoodList.Remove(FoodList[i]);   //从FoodList中移出FoodList中下标为i的成员
                            break;  //跳出循环
                        }
                    }
                }

                //画蛇身
                for (int i = 1; i <= snakelength; i++)  //循环判断 定义int i等于1，在i小于snakelength中循环，i++   //遍历snakelength
                {
                    g.DrawImage(HeadImage, new Point(HeadList[snakelength - i].HdX, HeadList[snakelength - i].HdY)); //在横坐标等于HeadList中下标snakelength-i，纵坐标等于HeadList中下标snakelength-i的位置绘制HeadImage
                }

                Collision(snakeR);   //调用碰撞检测
            }
        }

        //碰撞检测
        public void Collision(int snakeR)
        {
            //判断是否撞到自身
            for (int j = 2; j < snakelength; j++)   //循环判断 定义int j等于2，在j小于snakelength中循环，j++   //遍历snakelength
            {
                if (Math.Abs((HeadList[j].HdX + snakeR) - (HeadList[0].HdX + snakeR)) < (2 * snakeR) && Math.Abs((HeadList[j].HdY + snakeR) - (HeadList[0].HdY + snakeR)) < (2 * snakeR))
                //判断HeadList中下标为j的横坐标+snakeR 减去HeadList中下标为0的横坐标+snakeR的绝对值是否小于2 * snakeR，并且HeadList中下标为j的纵坐标 减去HeadList中下标为0的纵坐标+snakeR的绝对值是都小于2 * snakeR
                {
                    die = true; //使die等于true
                    foodNumber = 0;   //使蛇吃的食物数量归零
                    for (int i = 0; i <= FoodList.Count; i++)    //遍历foodlist
                    {
                        FoodList.Remove(FoodList[0]);   //从FoodList中移出FoodList中下标为0的成员
                    }
                }
            }

            //判断是否撞墙
            for (int i = 0; i < HeadList.Count; i++)  //循环判断 定义int i等于0，在i小于HeadList的长度中循环，i++   //遍历HeadList
            {
                if (HeadList[i].HdX <= 5 || HeadList[i].HdY <= 5 || HeadList[i].HdX >= 590 || HeadList[i].HdY >= 390)
                //判断 HeadList下标为i的横坐标是否小于等于5 或者 HeadList下标为i的纵坐标是否小于等于5 或者 HeadList下标为i的横坐标是否大于等于590 或者 HeadList下标为i的纵坐标是否大于等于390
                {
                    die = true; //使die等于true
                    foodNumber = 0;   //使蛇吃的食物数量归零
                    for (int j = 0; j <= FoodList.Count; j++)    //遍历foodlist
                    {
                        FoodList.Remove(FoodList[0]);   //从FoodList中移出FoodList中下标为0的成员
                    }
                }
            }
        }

        //更改蛇的大小
        public double SnakeSize(double i,int R)    //定义一个方法
        {
            //根据传入数值更改蛇的大小
            if (R == 5) //判断R是否等于5
            {
                snakeR = R;
                HeadImage = Image.FromFile("Head.png"); //将图片赋值给HeadImage
                i = 5;
                return i;
            }
            if (R == 10) //判断R是否等于10
            {
                snakeR = R;
                HeadImage = Image.FromFile("HeadBig.png"); //将图片赋值给HeadImage
                i = 10;
                return i;
            }
            if (R == 15) //判断R是否等于15
            {
                snakeR = R;
                HeadImage = Image.FromFile("HeadBig2.png"); //将图片赋值给HeadImage
                i = 15;
                return i;
            }
            return 0;
        }

        //更改食物数量
        public void Foodnumber(int i)   //定义一个方法
        {
            foodScreen = i;  //使foodScreen等于i
        }

        //更改游戏难度
        public void Timer(Label label, Label label1, Timer timer, double i, bool x)    //定义一个方法
        {
            timer.Interval = Convert.ToInt32(i); //使timer的值等于i
            string j = "";  //定义变量j
            if (((i == 100 && snakeR == 5) || (i == 200 && snakeR == 10) || (i == 300 && snakeR == 15)) && x == false)    //判断i
            {
                j = "一级";   //输出文字
                magnification = 1;
            }
            if (((i == 80 && snakeR == 5) || (i == 160 && snakeR == 10) || (i == 240 && snakeR == 15)) && x == false)   //判断i
            {
                j = "二级";   //输出文字
                magnification = 1.2;
            }
            if (((i == 60 && snakeR == 5) || (i == 120 && snakeR == 10) || (i == 180 && snakeR == 15)) && x == false)   //判断i
            {
                j = "三级";   //输出文字
                magnification = 1.5;
            }
            if (((i == 40 && snakeR == 5) || (i == 80 && snakeR == 10) || (i == 120 && snakeR == 15)) && x == false)   //判断i
            {
                j = "四级";   //输出文字
                magnification = 1.8;
            }
            if (((i == 20 && snakeR == 5) || (i == 40 && snakeR == 10) || (i == 60 && snakeR == 15)) && x == false)  //判断i
            {
                j = "五级";   //输出文字
                magnification = 2.2;
            }
            if (((i == 5 && snakeR == 5) || (i == 10 && snakeR == 10) || (i == 15 && snakeR == 15)) && x == false)   //判断i
            {
                j = "地狱级";   //输出文字
                magnification = 5;
            }
            label.Text = "难度：" + j ;   //使label输出难度
            label1.Text = "分数倍率：" + Convert.ToString(magnification);   //使label输出难度
        }

        //自定义食物图片
        public void FoodBeautify(int i) //定义一个方法
        {
            if (i == 1) //判断i是否等于1
            {
                FoodImage = Image.FromFile("FoodImage.png");  //改变存储图片
            }
            if (i == 2) //判断i是否等于2
            {
                FoodImage = Image.FromFile("Food1.png");  //改变存储图片
            }
            if (i == 3) //判断i是否等于3
            {
                FoodImage = Image.FromFile("Food2.png");  //改变存储图片
            }
            if (i == 4) //判断i是否等于4
            {
                FoodImage = Image.FromFile("Food3.png");  //改变存储图片
            }
        }

        //保存历史记录
        public void Record(string i)    //定义一个方法
        {
            //保存记录
            if (System.IO.File.Exists("d:\\Record.txt"))   //判断文件是否存在
            {
                StreamWriter streamWriter = new StreamWriter("d:\\Record.txt", true);   //调用D盘中的文件 若没有则创建 并追加
                streamWriter.Write("\n"+"  分数：" + i + " ");    //写入数据
                streamWriter.Close();   //关闭流
            }
            else
            {
                StreamWriter streamWriter = new StreamWriter("d:\\Record.txt", true);   //调用D盘中的文件 若没有则创建 并追加
                streamWriter.Write("\n" + "  分数：" + i + " ");    //写入数据
                streamWriter.Close();   //关闭流
            }
            List<string> lines = new List<string>(File.ReadAllLines("d:\\Record.txt")); //将文件赋值给列表lines

            //保证历史记录不超过六条
            if (lines.Count > 6)    //判断 如果lines的数量大于6
            {
                string i0 = "", i1 = "", i2 = "", i3 = "", i4 = "", i5 = "";    //定义6个string变量
                for (int j = 0; j <= lines.Count; j++)  //定义j=0 在j<lines长度下循环 j++   //遍历
                {
                    //取前2-7行分别赋值
                    if (j == 1)
                    {
                        i0 = lines[1];
                    }
                    if (j == 2)
                    {
                        i1 = lines[2];
                    }
                    if (j == 3)
                    {
                        i2 = lines[3];
                    }
                    if (j == 4)
                    {
                        i3 = lines[4];
                    }
                    if (j == 5)
                    {
                        i4 = lines[5];
                    }
                    if (j == 6)
                    {
                        i5 = lines[6];
                    }
                }
                StreamWriter streamWriter = new StreamWriter("d:\\Record.txt");   //调用D盘中的文件 若没有则创建 并追加
                streamWriter.Write(i0 + "\n" + i1 + "\n" + i2 + "\n" + i3 + "\n" + i4 + "\n" + i5);  //写入数据
                streamWriter.Close();   //关闭流

                //File.WriteAllLines("d:\\Record.txt", lines.ToArray());  //重新写入文档
            }
        }

        //读取历史记录
        public void Read(RichTextBox richTextBox)   //定义一个方法
        {
            if (!System.IO.File.Exists("d:\\Record.txt"))   //判断文件是否不存在
            {
                StreamWriter streamWriter = new StreamWriter("d:\\Record.txt", true);   //调用D盘中的文件 若没有则创建 并追加
                streamWriter.Close();   //关闭流
            }
            FileStream fs = new FileStream("d:\\Record.txt", FileMode.Open, FileAccess.Read);   //读取D盘中路径文件
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);  //用UTF8格式打开文件
            string[] s = sr.ReadToEnd().Split(' ');  //将sr中的文字按照 空格 分割保存到数组s中
            Array.Reverse(s);   //反转数组s
            string j = string.Join("",s);   //将数组s中元素合并至str类型变量j中
            if (j == "")    //判断j是否为空
            {
                j = "\n  暂无历史记录";   //将文字赋值给j
            }
            richTextBox.Text = j;  //使richtextbox中文字等于j
            fs.Close();   //关闭流
            sr.Close();   //关闭流
        }

        //重新建立文件（清除历史记录）
        public void Reset(RichTextBox richTextBox) //定义一个方法
        {
            StreamWriter streamWriter = new StreamWriter("d:\\Record.txt");   //调用D盘中的文件 若没有则创建
            streamWriter.Close();   //关闭流
            Read(richTextBox);
        }

        //判断失去焦点时暂停游戏
        public void Focus() //定义一个方法
        {
            if (start) //判断start不等于true
            {
                pause = true;   //使pause等于true
            }
        }

    }
}
