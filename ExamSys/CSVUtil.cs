using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ExamSys
{
    class CSVUtil
    {
        public static void WriteCSV(string filePathName, bool append, string studentScore)
        {
            try
            {
                StreamWriter CSVWriter = new StreamWriter(filePathName, append, Encoding.Default);
                CSVWriter.WriteLine(studentScore);
                CSVWriter.Flush();
                CSVWriter.Close();
            }
            catch
            {
                MessageBox.Show("写入考生成绩失败！");
            }
        }
        public static void ClearCSV(string filePathName)
        {

        }
    }
}
