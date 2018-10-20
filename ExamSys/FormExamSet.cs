using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSys
{
    public delegate void SetExam(int SingleNum, int MultiNum);
    public partial class FormExamSet : Form
    {
        public event SetExam SetExam;
        //public AppConfigTool config;
        int QueNum { get; set; }  //单张试卷的单选和多选题目总数
        public FormExamSet()
        {
            InitializeComponent();
            //config = new AppConfigTool();
            //QueNum = Convert.ToInt32(AppConfigTool.GetAppSettings("SingleNum")) + Convert.ToInt32(AppConfigTool.GetAppSettings("MultiNum"));
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (true)
            {
                if (!char.IsNumber((char)e.KeyValue) && (e.KeyValue > 105 || (int)e.KeyValue < 96))
                {
                    if ((e.KeyValue != (int)Keys.Back) && (e.KeyValue != (int)Keys.Enter))
                    {
                        e.Handled = true;
                        MessageBox.Show("请输入数字！");
                        textBox1.Clear();
                    }

                }
            }

        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsNumber((char)e.KeyValue) && ((int)e.KeyValue > 105 || (int)e.KeyValue < 96))
            {
                if ((e.KeyValue != (int)Keys.Back) && (e.KeyValue != (int)Keys.Enter))
                {
                    e.Handled = true;
                    MessageBox.Show("请输入数字！");
                    textBox2.Clear();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("请输入各题型的出题数量！");
            }
            else
            {
                int Single = Convert.ToInt32(textBox1.Text);
                int Multi = Convert.ToInt32(textBox2.Text);
                int SumNum = Convert.ToInt32(textBox3.Text);
                if ((Single + Multi) != SumNum)
                {
                    MessageBox.Show("您输入的数量总和不等于" + Convert.ToString(SumNum) + "，请重新输入！");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    //AppConfigTool.SetAppSetting("SingleNum", Convert.ToString(Single));
                    //AppConfigTool.SetAppSetting("MultiNum", Convert.ToString(Multi));
                    SetExam(Single, Multi);
                    this.Close();
                }
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsNumber((char)e.KeyValue) && ((int)e.KeyValue > 105 || (int)e.KeyValue < 96))
            {
                if ((e.KeyValue != (int)Keys.Back) && (e.KeyValue != (int)Keys.Enter))
                {
                    e.Handled = true;
                    MessageBox.Show("请输入数字！");
                    textBox3.Clear();
                }

            }
        }
    }
}
