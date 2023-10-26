using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Simple_Web_Browser
{
    public partial class FrmHistory : Form
    {
        private readonly string HistoryFile = string.Empty;
        private List<ResponseInfo> historyList = new List<ResponseInfo>();
        public ResponseInfo clickedItem = null;
        public FrmHistory(string historyFile, bool clearHistory = false)
        {
            InitializeComponent();
            HistoryFile = historyFile;
            if (clearHistory) { ClearBrowsingHistory(); }
        }

        private void FrmHistory_Load(object sender, EventArgs e)
        {
            try
            {
                DGVHistory.AutoGenerateColumns = false;
                LoadHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            try
            {
                ClearBrowsingHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHistory()
        {
            try
            {
                DGVHistory.DataSource = null;
                if (File.Exists(HistoryFile))
                {
                    historyList = (List<ResponseInfo>)JsonSerializer.Deserialize(File.ReadAllText(HistoryFile), typeof(List<ResponseInfo>));
                    if (historyList.Count > 0)
                    {
                        historyList = historyList.OrderByDescending(itm => itm.Date.TimeOfDay).ToList();
                        DGVHistory.DataSource = historyList;
                    }
                }
                BtnClearHistory.Enabled = historyList.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVHistory_KeyDown(object sender, KeyEventArgs e)
        {
            if (DGVHistory.SelectedRows.Count > 0 && e.KeyCode == Keys.Delete)
            {
                try
                {
                    DeleteHistoryItem((ResponseInfo)DGVHistory.SelectedRows[0].DataBoundItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (historyList.Count > 0 && DGVHistory.SelectedRows.Count > 0)
                {
                    DeleteHistoryItem((ResponseInfo)DGVHistory.SelectedRows[0].DataBoundItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearBrowsingHistory()
        {
            if (MessageBox.Show("Are you sure you want to clear browsing history?", "Clear History", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                historyList.Clear();
                File.WriteAllText(HistoryFile, JsonSerializer.Serialize(historyList, typeof(List<ResponseInfo>)));
                Close();
            }
        }

        private void DeleteHistoryItem(ResponseInfo responseInfo)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Delete History Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (historyList.Remove(responseInfo))
                {
                    File.WriteAllText(HistoryFile, JsonSerializer.Serialize(historyList, typeof(List<ResponseInfo>)));
                    LoadHistory();
                }
            }
        }

        private void DGVHistory_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    clickedItem = (ResponseInfo)DGVHistory.Rows[e.RowIndex].DataBoundItem;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
