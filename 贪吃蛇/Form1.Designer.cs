namespace 贪吃蛇
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.难度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一级默认ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.三级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.四级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.五级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地狱级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.定义食物数量ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一个ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.两个ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.食物图标ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图标1默认ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图标2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图标3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图标3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.蛇身大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(41, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 400);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(269, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "得分：0000";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.难度ToolStripMenuItem,
            this.定义食物数量ToolStripMenuItem,
            this.食物图标ToolStripMenuItem,
            this.蛇身大小ToolStripMenuItem,
            this.历史记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 难度ToolStripMenuItem
            // 
            this.难度ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.难度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一级默认ToolStripMenuItem,
            this.二级ToolStripMenuItem,
            this.三级ToolStripMenuItem,
            this.四级ToolStripMenuItem,
            this.五级ToolStripMenuItem,
            this.地狱级ToolStripMenuItem});
            this.难度ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.难度ToolStripMenuItem.Name = "难度ToolStripMenuItem";
            this.难度ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.难度ToolStripMenuItem.Text = "难度";
            // 
            // 一级默认ToolStripMenuItem
            // 
            this.一级默认ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.一级默认ToolStripMenuItem.Name = "一级默认ToolStripMenuItem";
            this.一级默认ToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.一级默认ToolStripMenuItem.Text = "一级";
            this.一级默认ToolStripMenuItem.Click += new System.EventHandler(this.一级默认ToolStripMenuItem_Click);
            // 
            // 二级ToolStripMenuItem
            // 
            this.二级ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.二级ToolStripMenuItem.Name = "二级ToolStripMenuItem";
            this.二级ToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.二级ToolStripMenuItem.Text = "二级";
            this.二级ToolStripMenuItem.Click += new System.EventHandler(this.二级ToolStripMenuItem_Click);
            // 
            // 三级ToolStripMenuItem
            // 
            this.三级ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.三级ToolStripMenuItem.Name = "三级ToolStripMenuItem";
            this.三级ToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.三级ToolStripMenuItem.Text = "三级（默认）";
            this.三级ToolStripMenuItem.Click += new System.EventHandler(this.三级ToolStripMenuItem_Click);
            // 
            // 四级ToolStripMenuItem
            // 
            this.四级ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.四级ToolStripMenuItem.Name = "四级ToolStripMenuItem";
            this.四级ToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.四级ToolStripMenuItem.Text = "四级";
            this.四级ToolStripMenuItem.Click += new System.EventHandler(this.四级ToolStripMenuItem_Click);
            // 
            // 五级ToolStripMenuItem
            // 
            this.五级ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.五级ToolStripMenuItem.Name = "五级ToolStripMenuItem";
            this.五级ToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.五级ToolStripMenuItem.Text = "五级";
            this.五级ToolStripMenuItem.Click += new System.EventHandler(this.五级ToolStripMenuItem_Click);
            // 
            // 地狱级ToolStripMenuItem
            // 
            this.地狱级ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.地狱级ToolStripMenuItem.Name = "地狱级ToolStripMenuItem";
            this.地狱级ToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.地狱级ToolStripMenuItem.Text = "地狱级";
            this.地狱级ToolStripMenuItem.Click += new System.EventHandler(this.地狱级ToolStripMenuItem_Click);
            // 
            // 定义食物数量ToolStripMenuItem
            // 
            this.定义食物数量ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一个ToolStripMenuItem,
            this.两个ToolStripMenuItem});
            this.定义食物数量ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.定义食物数量ToolStripMenuItem.Name = "定义食物数量ToolStripMenuItem";
            this.定义食物数量ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.定义食物数量ToolStripMenuItem.Text = "食物数量";
            // 
            // 一个ToolStripMenuItem
            // 
            this.一个ToolStripMenuItem.Name = "一个ToolStripMenuItem";
            this.一个ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.一个ToolStripMenuItem.Text = "一个（默认）";
            this.一个ToolStripMenuItem.Click += new System.EventHandler(this.一个ToolStripMenuItem_Click);
            // 
            // 两个ToolStripMenuItem
            // 
            this.两个ToolStripMenuItem.Name = "两个ToolStripMenuItem";
            this.两个ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.两个ToolStripMenuItem.Text = "两个";
            this.两个ToolStripMenuItem.Click += new System.EventHandler(this.两个ToolStripMenuItem_Click);
            // 
            // 食物图标ToolStripMenuItem
            // 
            this.食物图标ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图标1默认ToolStripMenuItem,
            this.图标2ToolStripMenuItem,
            this.图标3ToolStripMenuItem,
            this.图标3ToolStripMenuItem1});
            this.食物图标ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.食物图标ToolStripMenuItem.Name = "食物图标ToolStripMenuItem";
            this.食物图标ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.食物图标ToolStripMenuItem.Text = "食物图标";
            // 
            // 图标1默认ToolStripMenuItem
            // 
            this.图标1默认ToolStripMenuItem.Name = "图标1默认ToolStripMenuItem";
            this.图标1默认ToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.图标1默认ToolStripMenuItem.Text = "图标1（默认）";
            this.图标1默认ToolStripMenuItem.Click += new System.EventHandler(this.图标1默认ToolStripMenuItem_Click);
            // 
            // 图标2ToolStripMenuItem
            // 
            this.图标2ToolStripMenuItem.Name = "图标2ToolStripMenuItem";
            this.图标2ToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.图标2ToolStripMenuItem.Text = "图标2";
            this.图标2ToolStripMenuItem.Click += new System.EventHandler(this.图标2ToolStripMenuItem_Click);
            // 
            // 图标3ToolStripMenuItem
            // 
            this.图标3ToolStripMenuItem.Name = "图标3ToolStripMenuItem";
            this.图标3ToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.图标3ToolStripMenuItem.Text = "图标3";
            this.图标3ToolStripMenuItem.Click += new System.EventHandler(this.图标3ToolStripMenuItem_Click);
            // 
            // 图标3ToolStripMenuItem1
            // 
            this.图标3ToolStripMenuItem1.Name = "图标3ToolStripMenuItem1";
            this.图标3ToolStripMenuItem1.Size = new System.Drawing.Size(191, 26);
            this.图标3ToolStripMenuItem1.Text = "图标4";
            this.图标3ToolStripMenuItem1.Click += new System.EventHandler(this.图标3ToolStripMenuItem1_Click);
            // 
            // 蛇身大小ToolStripMenuItem
            // 
            this.蛇身大小ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.小ToolStripMenuItem,
            this.中ToolStripMenuItem,
            this.大ToolStripMenuItem});
            this.蛇身大小ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.蛇身大小ToolStripMenuItem.Name = "蛇身大小ToolStripMenuItem";
            this.蛇身大小ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.蛇身大小ToolStripMenuItem.Text = "蛇身大小";
            // 
            // 小ToolStripMenuItem
            // 
            this.小ToolStripMenuItem.Name = "小ToolStripMenuItem";
            this.小ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.小ToolStripMenuItem.Text = "小";
            this.小ToolStripMenuItem.Click += new System.EventHandler(this.小ToolStripMenuItem_Click);
            // 
            // 中ToolStripMenuItem
            // 
            this.中ToolStripMenuItem.Name = "中ToolStripMenuItem";
            this.中ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.中ToolStripMenuItem.Text = "中（默认）";
            this.中ToolStripMenuItem.Click += new System.EventHandler(this.中ToolStripMenuItem_Click);
            // 
            // 大ToolStripMenuItem
            // 
            this.大ToolStripMenuItem.Name = "大ToolStripMenuItem";
            this.大ToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.大ToolStripMenuItem.Text = "大";
            this.大ToolStripMenuItem.Click += new System.EventHandler(this.大ToolStripMenuItem_Click);
            // 
            // 历史记录ToolStripMenuItem
            // 
            this.历史记录ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.历史记录ToolStripMenuItem.Name = "历史记录ToolStripMenuItem";
            this.历史记录ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.历史记录ToolStripMenuItem.Text = "历史记录";
            this.历史记录ToolStripMenuItem.Click += new System.EventHandler(this.历史记录ToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(457, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "难度：三级";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(457, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "分数倍率：1.5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(682, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "贪吃蛇";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 定义食物数量ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一个ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 两个ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 难度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一级默认ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 三级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 四级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 五级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地狱级ToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem 食物图标ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图标1默认ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图标2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图标3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图标3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 历史记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 蛇身大小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大ToolStripMenuItem;
    }
}

