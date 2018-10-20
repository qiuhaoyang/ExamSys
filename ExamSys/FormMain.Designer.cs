namespace ExamSys
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuTopOne = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExamSet = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemClearScores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTopTwo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTopThree = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.checkBoxA = new System.Windows.Forms.CheckBox();
            this.checkBoxB = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.checkBoxD = new System.Windows.Forms.CheckBox();
            this.labelType = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTopOne,
            this.MenuTopTwo,
            this.MenuTopThree});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuTopOne
            // 
            this.MenuTopOne.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemExamSet,
            this.MenuItemClearScores});
            this.MenuTopOne.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuTopOne.Name = "MenuTopOne";
            this.MenuTopOne.Size = new System.Drawing.Size(104, 31);
            this.MenuTopOne.Text = "考试管理";
            this.MenuTopOne.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MenuItemExamSet
            // 
            this.MenuItemExamSet.Name = "MenuItemExamSet";
            this.MenuItemExamSet.Size = new System.Drawing.Size(170, 32);
            this.MenuItemExamSet.Text = "考试设置";
            this.MenuItemExamSet.Click += new System.EventHandler(this.ToolStripMenuItem1_Click_1);
            // 
            // MenuItemClearScores
            // 
            this.MenuItemClearScores.Name = "MenuItemClearScores";
            this.MenuItemClearScores.Size = new System.Drawing.Size(170, 32);
            this.MenuItemClearScores.Text = "清空成绩";
            this.MenuItemClearScores.Click += new System.EventHandler(this.MenuItemClearScores_Click);
            // 
            // MenuTopTwo
            // 
            this.MenuTopTwo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuTopTwo.Name = "MenuTopTwo";
            this.MenuTopTwo.Size = new System.Drawing.Size(104, 31);
            this.MenuTopTwo.Text = "开始考试";
            this.MenuTopTwo.Click += new System.EventHandler(this.MenuTopTwo_Click);
            // 
            // MenuTopThree
            // 
            this.MenuTopThree.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MenuTopThree.Name = "MenuTopThree";
            this.MenuTopThree.Size = new System.Drawing.Size(104, 31);
            this.MenuTopThree.Text = "模拟考试";
            this.MenuTopThree.Click += new System.EventHandler(this.MenuTopThree_Click);
            // 
            // textBoxQ
            // 
            this.textBoxQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxQ.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxQ.Location = new System.Drawing.Point(88, 74);
            this.textBoxQ.Multiline = true;
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.ReadOnly = true;
            this.textBoxQ.Size = new System.Drawing.Size(1074, 188);
            this.textBoxQ.TabIndex = 1;
            this.textBoxQ.TabStop = false;
            this.textBoxQ.Visible = false;
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonNext.Location = new System.Drawing.Point(969, 628);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(143, 48);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "下一题";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Visible = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxA.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxA.Location = new System.Drawing.Point(127, 300);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(973, 31);
            this.textBoxA.TabIndex = 7;
            this.textBoxA.TabStop = false;
            this.textBoxA.Visible = false;
            // 
            // textBoxB
            // 
            this.textBoxB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxB.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxB.Location = new System.Drawing.Point(127, 379);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.ReadOnly = true;
            this.textBoxB.Size = new System.Drawing.Size(973, 31);
            this.textBoxB.TabIndex = 8;
            this.textBoxB.TabStop = false;
            this.textBoxB.Visible = false;
            // 
            // textBoxC
            // 
            this.textBoxC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxC.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxC.Location = new System.Drawing.Point(127, 457);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.ReadOnly = true;
            this.textBoxC.Size = new System.Drawing.Size(973, 31);
            this.textBoxC.TabIndex = 9;
            this.textBoxC.TabStop = false;
            this.textBoxC.Visible = false;
            // 
            // textBoxD
            // 
            this.textBoxD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxD.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxD.Location = new System.Drawing.Point(127, 527);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.ReadOnly = true;
            this.textBoxD.Size = new System.Drawing.Size(973, 31);
            this.textBoxD.TabIndex = 10;
            this.textBoxD.TabStop = false;
            this.textBoxD.Visible = false;
            // 
            // checkBoxA
            // 
            this.checkBoxA.AutoSize = true;
            this.checkBoxA.Location = new System.Drawing.Point(88, 310);
            this.checkBoxA.Name = "checkBoxA";
            this.checkBoxA.Size = new System.Drawing.Size(18, 17);
            this.checkBoxA.TabIndex = 11;
            this.checkBoxA.UseVisualStyleBackColor = true;
            this.checkBoxA.Visible = false;
            // 
            // checkBoxB
            // 
            this.checkBoxB.AutoSize = true;
            this.checkBoxB.Location = new System.Drawing.Point(88, 389);
            this.checkBoxB.Name = "checkBoxB";
            this.checkBoxB.Size = new System.Drawing.Size(18, 17);
            this.checkBoxB.TabIndex = 12;
            this.checkBoxB.UseVisualStyleBackColor = true;
            this.checkBoxB.Visible = false;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(88, 467);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(18, 17);
            this.checkBoxC.TabIndex = 13;
            this.checkBoxC.UseVisualStyleBackColor = true;
            this.checkBoxC.Visible = false;
            // 
            // checkBoxD
            // 
            this.checkBoxD.AutoSize = true;
            this.checkBoxD.Location = new System.Drawing.Point(88, 537);
            this.checkBoxD.Name = "checkBoxD";
            this.checkBoxD.Size = new System.Drawing.Size(18, 17);
            this.checkBoxD.TabIndex = 14;
            this.checkBoxD.UseVisualStyleBackColor = true;
            this.checkBoxD.Visible = false;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("黑体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelType.Location = new System.Drawing.Point(81, 33);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(131, 38);
            this.labelType.TabIndex = 15;
            this.labelType.Text = "单选题";
            this.labelType.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ExamSys.Properties.Resources.backgrand;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.checkBoxD);
            this.Controls.Add(this.checkBoxC);
            this.Controls.Add(this.checkBoxB);
            this.Controls.Add(this.checkBoxA);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "考试系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuTopOne;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExamSet;
        private System.Windows.Forms.ToolStripMenuItem MenuItemClearScores;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.ToolStripMenuItem MenuTopTwo;
        private System.Windows.Forms.CheckBox checkBoxA;
        private System.Windows.Forms.CheckBox checkBoxB;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.CheckBox checkBoxD;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ToolStripMenuItem MenuTopThree;
    }
}

