using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
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

namespace JsonConvertTO
{
    public partial class Form1 : Form
    {
        private string fileName;
        private string outputFileName;
        private IWorkbook workbook = null;
        private FileStream fs = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var stream = new StreamReader(fileName);
                var str = stream.ReadToEnd();

                var json = JsonConvert.DeserializeObject<List<JObject>>(str);

                var data = GenerateData(json);
                DataTableToExcel(data, "sheet", true);
            }
            catch (Exception ex)
            {
                txt_log.AppendText(ex.Message+ "\r\n");
            }
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            var open = openFileDialog1.ShowDialog();
            if (open == DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                txt_selectFilePath.Text = fileName;
                var fName = Path.GetFileName(fileName);
                var lastIndex = fName.LastIndexOf(".");
                outputFileName = fName.Substring(0, lastIndex) + ".xls";
            }
        }
        public DataTable GenerateData(List<JObject> keyValues)
        {
            txt_log.AppendText("开始生成数据……\r\n");
            var colnums = new List<string>();

            var fistData = keyValues.First();
            var pros = fistData.Properties();
            foreach (var item in pros)
            {
                colnums.Add(item.Name);
            }

            DataTable data = new DataTable();

            for (int i = 0; i < colnums.Count; ++i)
            {
                data.Columns.Add(colnums[i], typeof(string));
            }

            foreach (var item in keyValues)
            {
                var pros2 = item.Properties().ToArray();
                DataRow row = data.NewRow();
                for (int y = 0; y < colnums.Count; y++)
                {
                    row[colnums[y]] = pros2[y].Value.ToString();
                }
                data.Rows.Add(row);
            }
            return data;
        }
        public int DataTableToExcel(DataTable data, string sheetName, bool isColumnWritten)
        {
            txt_log.AppendText("开始导出……\r\n");
            var _outputFileName = Path.Combine(txt_output.Text, outputFileName);
            int i = 0;
            int j = 0;
            int count = 0;
            ISheet sheet = null;

            fs = new FileStream(_outputFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            if (_outputFileName.IndexOf(".xlsx") > 0) // 2007版本
                workbook = new XSSFWorkbook();
            else if (_outputFileName.IndexOf(".xls") > 0) // 2003版本
                workbook = new HSSFWorkbook();


            if (workbook != null)
            {
                sheet = workbook.CreateSheet(sheetName);
            }
            else
            {
                return -1;
            }

            if (isColumnWritten == true) //写入DataTable的列名
            {
                IRow row = sheet.CreateRow(0);
                for (j = 0; j < data.Columns.Count; ++j)
                {
                    row.CreateCell(j).SetCellValue(data.Columns[j].ColumnName);
                }
                count = 1;
            }
            else
            {
                count = 0;
            }

            for (i = 0; i < data.Rows.Count; ++i)
            {
                IRow row = sheet.CreateRow(count);
                for (j = 0; j < data.Columns.Count; ++j)
                {
                    row.CreateCell(j).SetCellValue(data.Rows[i][j].ToString());
                }
                ++count;
            }
            workbook.Write(fs); //写入到excel
            workbook.Close();
            fs.Flush();
            fs.Close();
            txt_log.AppendText($"共导出{count}条！\r\n");
            return count;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var open = folderBrowserDialog1.ShowDialog();
            if (open == DialogResult.OK)
            {
                txt_output.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
