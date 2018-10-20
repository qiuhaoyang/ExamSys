using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
namespace ExamSys
{
    class ClassReadExcel
    {
        static string DirCurrent = Environment.CurrentDirectory;
        //static string excelFile = "C:\\Users\\Administrator\\Documents\\Visual Studio 2015\\Projects\\ExamSys\\ExamSys\\bin\\x86\\Release\\Exam.xls";
        static string excelFile = string.Concat(DirCurrent,"\\Exam.exm");
        static string strCon = string.Format("Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source ={0}; Extended Properties = 'Excel 8.0'",excelFile);
        //static string strCon = "Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = " + DirCurrent + @"\Exam.xls; Extended Properties = 'Excel 8.0'";
        public static OleDbConnection myConn;
        private DataTable tblSchema = new DataTable();

        public DataSet GetConnet(int SheetIndex)
        {

            string strCom = "SELECT * FROM [Sheet" + Convert.ToString(SheetIndex) + "$]";
            myConn = new OleDbConnection(strCon);
            try
            {
                myConn.Open();
            }
            catch
            {
                MessageBox.Show("Excel文件连接异常！");
            }


            tblSchema = myConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new object[] { null, null, null, "TABLE" });
            List<string> tblNames = new List<string>();
            if(tblSchema.Rows.Count == 0)
            {
                MessageBox.Show("Table数量为0！");
            }
            foreach (DataRow row in tblSchema.Rows)
            {
                tblNames.Add((string)row["TABLE_NAME"]); // 读取表名 
            }
            if (tblNames.Count == 0)
            {
                MessageBox.Show("表名为空！");
            }
            else
            {
                //MessageBox.Show(tblNames[0]);
            }

            OleDbDataAdapter myCommand = new OleDbDataAdapter(strCom, myConn);
            DataSet myDataSet = new DataSet();
            myCommand.Fill(myDataSet, "[Sheet" + Convert.ToString(SheetIndex) + "$]");
            //myConn.Close();
            myCommand.Dispose();

            return myDataSet;

        }
    }
}
