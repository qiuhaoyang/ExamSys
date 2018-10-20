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
    public delegate void ShowControl();  //用于显示父窗体的控件的代理函数
    public delegate void TransferNameID(string Name, string ID, string UnitName);
    public partial class FormIDCheck : Form
    {
        public event ShowControl ShowControl;
        public event TransferNameID TransferNameID;
        public FormIDCheck()
        {
            InitializeComponent();
            try
            {
                string UnitName = AppConfigTool.GetAppSettings("Unit");
                string[] Unit = UnitName.Split(' ');
                foreach(string str in Unit)
                {
                    comboBoxUnit.Items.Add(str);
                }
                comboBoxUnit.SelectedIndex = 0;
            }
            catch
            {
                MessageBox.Show("获取单位名称失败！");
            }
            /*
            finally
            {
                comboBoxUnit.Items.Add("一车间");
                comboBoxUnit.Items.Add("二车间");
                comboBoxUnit.Items.Add("三车间");
                comboBoxUnit.Items.Add("四车间");
                comboBoxUnit.Items.Add("五车间");
                comboBoxUnit.Items.Add("机  关");
                comboBoxUnit.Items.Add("其  他");
                comboBoxUnit.SelectedIndex = 0;
            }   
            */        

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {

            if (textBoxName.Text == "" || textBoxID.Text == "" || comboBoxUnit.Text == "")
            {
                MessageBox.Show("请把个人信息填写完整！");
            }
            else
            {
                ShowControl();
                TransferNameID(textBoxName.Text, textBoxID.Text, comboBoxUnit.Text);
                this.Close();
            }

        }

        private void textBoxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (!char.IsNumber((char)e.KeyValue) && ((int)e.KeyValue > 105 || (int)e.KeyValue < 96))
            {
                if ((e.KeyValue != (int)Keys.Back) && (e.KeyValue != (int)Keys.Enter))
                {
                    e.Handled = true;
                    MessageBox.Show("请输入数字！");
                    textBoxID.Clear();
                }

            }
        }
    }
}
