using MaterialThemeCore.MaterialControls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Simple_Web_Browser
{
    public partial class FrmBulkDownload : MaterialThemeForm
    {
        //private List<HttpWebResponse> responseList;
        public FrmBulkDownload()
        {
            InitializeComponent();
        }

        private void BulkDownload_Load(object sender, EventArgs e)
        {

        }

        private void BtnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Please select a file containing URLs to download",
                Multiselect = false,
                DefaultExt = "txt",
                CheckFileExists = true,
                CheckPathExists = true,
                FileName = "bulk.txt",
                Filter = "Text Files|*.txt"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = File.ReadLines(openFileDialog.FileName).ToList();
                if (lines.Count > 0)
                {
                    LblProcess.Text = "Processing";
                    Cursor = Cursors.WaitCursor;
                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line) || string.IsNullOrEmpty(line)) continue;
                        ResponseMessage response = RequestMessage.GetResponseMessage(new Uri(line));
                        if(response != null)
                        {
                            string result = $"{(int)response.StatusCode} | {response.ContentLength} | {line}";
                            TxtResponse.AppendText($"{result}{Environment.NewLine}");
                        }
                    }
                    LblProcess.Text = string.Empty;
                    Cursor = Cursors.Arrow;
                    MessageBox.Show("Bulk download request completed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Selected file is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
