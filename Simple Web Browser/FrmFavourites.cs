using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace Simple_Web_Browser
{
    public partial class FrmFavourites : Form
    {
        private List<ResponseInfo> favourites = new List<ResponseInfo>();
        private string favouritesFile = string.Empty;
        public ResponseInfo clickedItem = null;
        public FrmFavourites(string favouritesFile)
        {
            InitializeComponent();
            this.favouritesFile = favouritesFile;
        }

        private void FrmFavourites_Load(object sender, EventArgs e)
        {
            LoadFavourites();
        }

        private void LoadFavourites()
        {
            try
            {
                favouritesList.DataSource = null;
                if (File.Exists(favouritesFile))
                {
                    favourites = (List<ResponseInfo>)JsonSerializer.Deserialize(File.ReadAllText(favouritesFile), typeof(List<ResponseInfo>));
                    favourites = favourites.OrderByDescending(itm => itm.Date.TimeOfDay).ToList();
                    favouritesList.DataSource = favourites;
                    favouritesList.DisplayMember = "Name";
                    favouritesList.ValueMember = "Id";
                    if (favourites.Count > 0)
                    {
                        favouritesList.SelectedIndex = 0;
                    }
                    BtnClearFavourites.Enabled = favourites.Count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void favouritesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int idx = favouritesList.IndexFromPoint(e.Location);
                if (idx != ListBox.NoMatches)
                {
                    clickedItem = (ResponseInfo)favouritesList.SelectedItem;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearFavourites_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to clear favourites?", "Clear Favourites", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    favourites.Clear();
                    File.WriteAllText(favouritesFile, JsonSerializer.Serialize(favourites, typeof(List<ResponseInfo>)));
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (favourites.Count > 0 && favouritesList.SelectedItem != null && favouritesList.SelectedIndex >= 0)
                {
                    DeleteFavouriteItem((ResponseInfo)favouritesList.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void favouritesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    if (favourites.Count > 0 && favouritesList.SelectedItem != null && favouritesList.SelectedIndex >= 0)
                    {
                        DeleteFavouriteItem((ResponseInfo)favouritesList.SelectedItem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteFavouriteItem(ResponseInfo responseInfo)
        {
            if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Favourite Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (favourites.Remove(responseInfo))
                {
                    File.WriteAllText(favouritesFile, JsonSerializer.Serialize(favourites, typeof(List<ResponseInfo>)));
                    LoadFavourites();
                }
            }
        }
    }
}
