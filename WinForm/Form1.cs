using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //openFileDialog1.Filter = "(*.xls)|*.xls";
        }

        private void btnbrowser_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = openFileDialog1.FileName;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("test");
            IRow row = null;
            ICell cell = null;
            row = sheet.CreateRow(0);
            cell = row.CreateCell(0);
            cell.SetCellValue("姓名");
            cell = row.CreateCell(1);
            cell.SetCellValue("地址");
            cell = row.CreateCell(2);
            cell.SetCellValue("邮箱");
            cell = row.CreateCell(3);
            cell.SetCellValue("电话");

            if (File.Exists("test.xls"))
            {
                File.Delete("test.xls");
            }
            using (FileStream fs = File.OpenWrite("test.xls"))
            {
                workbook.Write(fs);
            }
            workbook = null;
            sheet = null;
            MessageBox.Show("生成excel成功");
        }
    }
}
