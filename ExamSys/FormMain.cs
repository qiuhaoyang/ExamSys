using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ExamSys
{
    public partial class FormMain : Form
    {
        string StudentName { get; set; }
        //string StudentName = null;  //临时保存考生姓名
        string StudentID { get; set; }
        //string StudentID = null;  //临时保存考生ID
        string StudentUnitName { get; set; }
        //string StudentUnitName = null;  //临时保存考生单位名称
        int Score { get; set; }
        //int Score = 0; //临时保存考生成绩
        DataSet SingleExamExcel { get; set; }
        //DataSet SingleExamExcel = new DataSet();  //保存单选考试试题
        DataSet MultiExamExcel { get; set; }
        //DataSet MultiExamExcel = new DataSet();  //保存多选考试试题
        int intSingleNum { get; set; }
        //int intSingleNum = 0;  //保存单选题个数
        int intMultiNum { get; set; }
        //int intMultiNum = 0; //保存多选题个数
        Queue<stringQA> ExamPaper { get; set; }
        //Queue<stringQA> ExamPaper = new Queue<stringQA>();  //保存本次考试试卷
        stringQA tempQA { get; set; }
        //stringQA tempQA = new stringQA(); //用于临时保存从试卷中dequeue出来的单个试题
        //ClassReadExcel ReadExcel { get; set; }
        ClassReadExcel ClassReadExcel = new ClassReadExcel();
        bool SimTest { get; set; }
        /*        public struct structStuScore
                {
                    string StuName;
                    string StuID;
                    string StuScore;
                }

               structStuScore StudentScore = new structStuScore();
        */
        public void InitParam()
        {
            StudentName = null;  //临时保存考生姓名
            StudentID = null;  //临时保存考生ID
            StudentUnitName = null;  //临时保存考生单位名称
            Score = 0; //临时保存考生成绩
            ExamPaper = new Queue<stringQA>();  //保存本次考试试卷
            tempQA = new stringQA(); //用于临时保存从试卷中dequeue出来的单个试题
            intSingleNum = Convert.ToInt32(AppConfigTool.GetAppSettings("SingleNum"));
            intMultiNum = Convert.ToInt32(AppConfigTool.GetAppSettings("MultiNum"));

        }
        public FormMain()
        {
            InitializeComponent();

            SingleExamExcel = ClassReadExcel.GetConnet(1);  //里面有可能存在空行
            ClassReadExcel.myConn.Close();
            MultiExamExcel = ClassReadExcel.GetConnet(2);  //里面有可能存在空行
            RemoveNullRows(SingleExamExcel);
            RemoveNullRows(MultiExamExcel);
            InitParam();

        }
        //检查dataset的每一行，若第一列的问题为空，则remove此行
        public void RemoveNullRows(DataSet dataSet)
        {
            int count = dataSet.Tables[0].Rows.Count;
            for (int i = count - 1; i >= 0; i--)
            {
                if (dataSet.Tables[0].Rows[i][0] is System.DBNull)
                {
                    dataSet.Tables[0].Rows.RemoveAt(i);
                }
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (ExamPaper.Count != 0)
            {
                Score += CalScore();
                tempQA = ExamPaper.Dequeue();
                FillText();
            }
            else
            {
                //buttonNext.Text = "交  卷";
                Score += CalScore();
                MessageBox.Show("您的成绩是" + Convert.ToString(Score) + "分！");
                if (SimTest != true)
                {
                    string str = StudentName + "\t" + StudentID + "\t" + StudentUnitName + "\t" + Score.ToString() + "\t" + DateTime.Now.Date.ToShortDateString() + "\t" + DateTime.Now.ToLongTimeString();
                    string filePath = Environment.CurrentDirectory + "\\Score.sco";
                    CSVUtil.WriteCSV(filePath, true, str);
                }
                InitParam();
                HideControl();
            }
        }

        public int CalScore()
        {
            int rtn = 0;
            string answer = (checkBoxA.Checked ? "A" : "") + (checkBoxB.Checked ? "B" : "") + (checkBoxC.Checked ? "C" : "") + (checkBoxD.Checked ? "D" : "");
            rtn = (answer == tempQA.TureAnswer) ? 1 : 0;
            if (SimTest == true)
            {
                if (answer == tempQA.TureAnswer)
                {
                    MessageBox.Show("恭喜你，答对了！");
                }
                else
                {
                    MessageBox.Show("本题的正确答案是：" + tempQA.TureAnswer);
                }
            }
            return rtn;
        }
        public void ShowControl()
        {
            labelType.Visible = true;
            textBoxQ.Visible = true;
            textBoxA.Visible = true;
            textBoxB.Visible = true;
            textBoxC.Visible = true;
            textBoxD.Visible = true;

            checkBoxA.Visible = true;
            checkBoxB.Visible = true;
            checkBoxC.Visible = true;
            checkBoxD.Visible = true;

            buttonNext.Visible = true;
            MenuTopTwo.Visible = false;
            MenuTopOne.Visible = false;
            MenuTopThree.Visible = false;

            BackgroundImage = null;


        }
        public void HideControl()
        {
            labelType.Visible = false;
            textBoxQ.Visible = false;
            textBoxA.Visible = false;
            textBoxB.Visible = false;
            textBoxC.Visible = false;
            textBoxD.Visible = false;

            checkBoxA.Visible = false;
            checkBoxB.Visible = false;
            checkBoxC.Visible = false;
            checkBoxD.Visible = false;

            buttonNext.Visible = false;
            MenuTopTwo.Visible = true;
            MenuTopOne.Visible = true;
            MenuTopThree.Visible = true;

            BackgroundImage = Properties.Resources.backgrand;
        }
        //点击“开始考试”，显示填写考生信息的窗体，填完考生信息后，点击“确定”，主窗体显示考题，开始考试
        private void MenuTopTwo_Click(object sender, EventArgs e)
        {
            SimTest = false;
            FormIDCheck FormID = new FormIDCheck();
            FormID.ShowControl += FormID_ShowControl;
            FormID.TransferNameID += FormID_TransferNameID;
            FormID.Show();


        }

        private void FormID_TransferNameID(string Name, string ID, string UnitName)
        {
            StudentUnitName = UnitName;
            StudentID = ID;
            StudentName = Name;

            //throw new NotImplementedException();
        }

        private void FormID_ShowControl()
        {
            FillTextBox();
            ShowControl();
            //throw new NotImplementedException();
        }

        private void ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FormExamSet FormSet = new FormExamSet();
            FormSet.SetExam += FormSet_SetExam;
            FormSet.Show();
        }

        private void FormSet_SetExam(int SingleNum, int MultiNum)
        {
            intSingleNum = SingleNum;
            intMultiNum = MultiNum;
            AppConfigTool.SetAppSetting("SingleNum", SingleNum.ToString());
            AppConfigTool.SetAppSetting("MultiNum", MultiNum.ToString());
            AppConfigTool.SetAppSetting("QueNum", (SingleNum + MultiNum).ToString());
            //throw new NotImplementedException();
        }
        //填充题目和选项
        public void FillText()
        {
            if (tempQA.singleQ == true)
            {
                labelType.Text = "单选题";
            }
            else if (tempQA.MultiQ == true)
            {
                labelType.Text = "多选题";
            }
            else
            {
                labelType.Text = "其  他";
            }
            textBoxQ.Text = tempQA.Question;
            textBoxA.Text = tempQA.AnswerA;
            textBoxB.Text = tempQA.AnswerB;
            textBoxC.Text = tempQA.AnswerC;
            textBoxD.Text = tempQA.AnswerD;

            checkBoxA.Checked = false;
            checkBoxB.Checked = false;
            checkBoxC.Checked = false;
            checkBoxD.Checked = false;
        }
        //在TextBox中插入问题和选项文本
        public void FillTextBox()
        {
            ExamPaper = GeneratePaper();
            try
            {
                tempQA = ExamPaper.Dequeue();
            }
            catch
            {
                MessageBox.Show("试卷生成错误！");
            }
            Score = 0;
            FillText();
        }
        //生成试卷中题目的队列
        public Queue<stringQA> GeneratePaper()
        {
            Queue<stringQA> rtn = new Queue<stringQA>();
            //stringQA tempQA = new stringQA();
            //产生单选题
            if (intSingleNum != 0)
            {
                if (intSingleNum > SingleExamExcel.Tables[0].Rows.Count)
                {
                    MessageBox.Show("考试设置错误：出题量超过了题库同题型的数量！");
                    InitParam();
                    HideControl();
                }
                else
                {
                    List<int> SingleList = GetNumList(intSingleNum, SingleExamExcel.Tables[0].Rows.Count);
                    SingleList.Sort();
                    foreach (int index in SingleList)
                    {
                        stringQA tempQA = GetQA(index, SingleExamExcel);
                        tempQA.singleQ = true;
                        rtn.Enqueue(tempQA);
                    }
                }
            }
            //产生多选题
            if (intMultiNum != 0)
            {
                if (intMultiNum > MultiExamExcel.Tables[0].Rows.Count)
                {
                    MessageBox.Show("考试设置错误：出题量超过了题库同题型的数量！");
                    HideControl();
                    InitParam();
                }
                else
                {
                    List<int> MultiList = GetNumList(intMultiNum, MultiExamExcel.Tables[0].Rows.Count);
                    MultiList.Sort();
                    foreach (int index in MultiList)
                    {
                        stringQA tempQA = GetQA(index, MultiExamExcel);
                        tempQA.MultiQ = true;
                        rtn.Enqueue(tempQA);
                    }
                }
            }
            return rtn;
        }
        //给定题号和DataSet，返回对应的stringQA结构
        public stringQA GetQA(int index, DataSet dataSet)
        {
            stringQA rtn = new stringQA();
            rtn.Question = (string)dataSet.Tables[0].Rows[index][0];
            rtn.AnswerA = (string)dataSet.Tables[0].Rows[index][1];
            rtn.AnswerB = (string)dataSet.Tables[0].Rows[index][2];
            rtn.AnswerC = (string)dataSet.Tables[0].Rows[index][3];
            rtn.AnswerD = (string)dataSet.Tables[0].Rows[index][4];
            rtn.TureAnswer = (string)dataSet.Tables[0].Rows[index][5];

            return rtn;
        }
        //生成题号序列，count表示需要的题目数，Max表示最大题号
        public List<int> GetNumList(int count, int MaxNum)
        {
            List<int> NumList = new List<int>();
            while (count != 0)
            {
                int tempNum = GetRandomNumber(1, MaxNum);
                if (!NumList.Contains(tempNum))
                {
                    NumList.Add(tempNum);
                    count--;
                }
                else
                {
                    continue;
                }
            }
            return NumList;
        }
        //生成随机数，由于计算机执行很快，因此采用GUID标识符随机产生不同的随机数
        public static int GetRandomNumber(int min, int max)
        {
            int rtn = 0;
            Random r = new Random();
            byte[] buffer = Guid.NewGuid().ToByteArray();
            int iSeed = BitConverter.ToInt32(buffer, 0);
            r = new Random(iSeed);
            rtn = r.Next(min, max);
            return rtn;
        }
        //重载窗体关闭函数，关闭数据表连接
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("你确认要退出该程序吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ClassReadExcel.myConn.Close();
                ClassReadExcel.myConn.Dispose();
                base.OnFormClosing(e);
            }
            else
                e.Cancel = true;
        }

        private void MenuTopThree_Click(object sender, EventArgs e)
        {
            SimTest = true;
            FillTextBox();
            ShowControl();
        }

        private void MenuItemClearScores_Click(object sender, EventArgs e)
        {
            string filePath = Environment.CurrentDirectory + "\\Score.sco";

            File.Delete(filePath);
        }
    }
}
