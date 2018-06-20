using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;

namespace WindowsForms_Hyperlinks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dgvHyperlinkData.DataError += delegate (object sender, DataGridViewDataErrorEventArgs e) { };
        }
        //*****Paste data to DataGridView
        private void dgvHyperlinkData_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Modifiers == Keys.Control) && (e.KeyCode == Keys.V) && (dgvHyperlinkData.CurrentCell != null))//Ctrl+V貼上指令
            {
                dgvHyperlinkData[dgvHyperlinkData.CurrentCell.ColumnIndex, dgvHyperlinkData.CurrentCell.RowIndex].Value = Clipboard.GetText();
            }
        }
        //***** Browse excel file to text
        string excelName = string.Empty;
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "File excel | *.xlsx";
            DialogResult re = fd.ShowDialog();
            excelName = fd.SafeFileName;
            if (re == DialogResult.OK)
            {
                string fileName = fd.FileName;
                txtExcelPath.Text = fileName;
            }
        }

        private void btnReadExcel_Click(object sender, EventArgs e)
        {
            readExcel(txtExcelPath.Text);
        }
        //*****Read data on Excel and write onto datagridview
        string name, path;
        public void readExcel(string excelPath)
        {
            Excel.Application xlAPP;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;

            xlAPP = new Excel.Application();
            xlWorkBook = xlAPP.Workbooks.Open(excelPath, 0, true,5,"","",true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1,0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            for (rCnt = 1; rCnt <= rw; rCnt++)
            {
                for (cCnt = 1; cCnt <= cl; cCnt++){
                    name = Convert.ToString((range.Cells[rCnt, 1] as Excel.Range).Value2);
                    path = Convert.ToString((range.Cells[rCnt, 2] as Excel.Range).Value2);
                }
                dgvHyperlinkData.Rows.Add(name, path);
            }
            xlWorkBook.Close(true, null, null);
            xlAPP.Quit();
            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlAPP);
        }
        String FilePathName = Application.StartupPath + "/Datagridview";//***previous data of Datagridview
        private void btnSaveDGV_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sfg = new SaveFileDialog();
            //sfg.FileName = "Datagridview";
            //sfg.Filter = "Text Document|*.text";
            //sfg.Title = "Save DatagridView as";
            //DialogResult result = sfg.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //MessageBox.Show(FilePathName);
                TextWriter writer = new StreamWriter(FilePathName);
                for(int i = 0; i <= dgvHyperlinkData.Rows.Count-2; i++)
                {
                    for (int j = 0; j <= dgvHyperlinkData.Columns.Count-1; j++)
                    {
                        //writer.Write(('\t' + (dgvHyperlinkData.Rows[i].Cells[j].Value.ToString() + ('\t' + "|"))));
                        writer.Write(dgvHyperlinkData.Rows[i].Cells[j].Value.ToString()+",");
                    }
                    writer.WriteLine("");
                }
                writer.Close();
                //MessageBox.Show("Data save");
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Read data from StartupPath. If there is nothing,then null.
            //*****Check previous data and load in.
            if (System.IO.File.Exists(FilePathName))
            {
                //MessageBox.Show("I got it");
                TextReader reader = new StreamReader(FilePathName);
                //dgvHyperlinkData.Rows[0].Cells[0].Value = 1;
                //dgvHyperlinkData.Rows[0].Cells[1].Value = 1;
                //MessageBox.Show(Convert.ToString(lines));
                string a = reader.ReadToEnd();
                string[] txtFile = a.Split(',');
                for (int i = 0; i < txtFile.Length-1; i++)
                {
                    //if (i == 0)
                    //    dgvHyperlinkData.Rows[i].Cells[0].Value = txtFile[i];
                    //else if (i % 2 == 0)
                    //    dgvHyperlinkData.Rows[i / 2].Cells[0].Value = txtFile[i];
                    //else
                    //{
                    //    dgvHyperlinkData.Rows[i / 2].Cells[1].Value = txtFile[i];
                    //    dgvHyperlinkData.Rows.Add(txtFile[i]);
                    //}
                    if (i%2==0)
                        dgvHyperlinkData.Rows.Add(txtFile[i],txtFile[i+1]);
                }                
            }
            //else
            //    MessageBox.Show("I did get it");
        }
    }
}
