using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core;
using Simple_Web_Browser.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Windows.Forms;

namespace Simple_Web_Browser
{
    public partial class FrmMain : Form
    {
        private WebView2 webView = null;
        private List<ResponseInfo> favourites = new List<ResponseInfo>();
        private readonly string FavouritesFile = Path.Join(Application.StartupPath, "favourites.json");
        private List<ResponseInfo> historyList = new List<ResponseInfo>();
        private readonly string HistoryFile = Path.Join(Application.StartupPath, "history.json");

        public FrmMain()
        {
            InitializeComponent();
        }

        public void FrmMain_Load(object sender, EventArgs e)
        {
            InitWebBrowserTab(true);
            LoadFavourites();
            LoadHistory();
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            /* Common Shortcuts */
            if (e.KeyCode == Keys.F5)
            {
                webView?.Reload();
            }
            if (e.Alt && e.KeyCode == Keys.Left)
            {
                if (webView != null && webView.CanGoBack) { webView.GoBack(); }
            }
            if (e.Alt && e.KeyCode == Keys.Right)
            {
                if (webView != null && webView.CanGoForward) { webView.GoForward(); }
            }
            if (e.Alt && e.KeyCode == Keys.Home)
            {
                webView.Source = GetUri(Settings.Default.Homepage);
            }
            /* End of Common Shortcuts */

            /* Tab Shortcuts */
            if (e.Control && e.KeyCode == Keys.N)
            {
                OpenNewTab();
            }
            if (e.Control && e.KeyCode == Keys.H)
            {
                FrmHistory frmHistory = new FrmHistory(HistoryFile);
                frmHistory.FormClosed += FrmHistory_FormClosed;
                frmHistory.ShowDialog();
            }
            if (e.Control && e.KeyCode == Keys.P)
            {
                webView?.CoreWebView2.ShowPrintUI();
            }
            if (e.Control && e.Shift && e.KeyCode == Keys.Delete)
            {
                FrmHistory frmHistory = new FrmHistory(HistoryFile, true);
                LoadHistory();
            }
            /* End of Tab Shortcuts */
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            webView?.GoBack();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            webView?.GoForward();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            webView?.Reload();
        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUrl.Text))
            {
                GoToWebpage(txtUrl.Text);
            }
        }

        private void BtnAddTab_Click(object sender, EventArgs e)
        {
            OpenNewTab();
        }

        private void OpenNewTab()
        {
            txtUrl.Clear();
            InitWebBrowserTab();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            GoToWebpage(Settings.Default.Homepage);
        }

        private void BtnAddToFavourites_Click(object sender, EventArgs e)
        {
            if (webView != null && tabControl.SelectedTab != null && tabControl.SelectedTab.Controls.Count > 0)
            {
                WebView2 view = ((WebView2)tabControl.SelectedTab.Controls[0]);
                AddUrlToFavourites(tabControl.SelectedTab.Text, GetUri(view.CoreWebView2.Source));
            }
        }

        private void BtnViewFavourites_Click(object sender, EventArgs e)
        {
            FrmFavourites frmFavourites = new FrmFavourites(FavouritesFile);
            frmFavourites.FormClosed += FrmFavourites_FormClosed;
            frmFavourites.ShowDialog();
        }

        private void FrmFavourites_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadFavourites();
            FrmFavourites favourites = (FrmFavourites)sender;
            if (favourites.clickedItem != null && webView != null)
            {
                webView.Source = favourites.clickedItem.Uri;
            }
        }

        private void BtnViewHistory_Click(object sender, EventArgs e)
        {
            FrmHistory frmHistory = new FrmHistory(HistoryFile);
            frmHistory.FormClosed += FrmHistory_FormClosed;
            frmHistory.ShowDialog();
        }

        private void FrmHistory_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadHistory();
            FrmHistory history = (FrmHistory)sender;
            if(history.clickedItem != null)
            {
                webView.Source = history.clickedItem.Uri;
            }
        }

        private void BtnBulkDownload_Click(object sender, EventArgs e)
        {
            FrmBulkDownload frmBulkDownload = new FrmBulkDownload();
            frmBulkDownload.ShowDialog();
        }

        private void BtnGoogleSearch_Click(object sender, EventArgs e)
        {
            webView.Source = GetUri("https://www.google.com");
        }

        private void closeTab_Click(object sender, EventArgs e)
        {
            tabControl.Controls.Remove(tabControl.SelectedTab);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tabControl.SelectedTab != null && tabControl.SelectedTab.Controls.Count > 0)
                {
                    WebView2 webBrowser = (WebView2)tabControl.SelectedTab.Controls[0];
                    webView = webBrowser;
                    if (webBrowser != null)
                    {
                        txtUrl.Text = webBrowser.CoreWebView2.Source;
                        ToggleOtherButtons(true);
                    }
                    else if (tabControl.SelectedTab.Text.Equals("Blank Page"))
                    {
                        txtUrl.Clear();
                        ToggleOtherButtons(false);
                    }
                    InitActionButtons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitWebBrowserTab(bool IsStartup = false)
        {
            TabPage tab = new TabPage
            {
                Text = IsStartup ? "Loading" : "Blank Page",
            };
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            if (IsStartup)
            {
                webView = new WebView2
                {
                    Parent = tab,
                    Dock = DockStyle.Fill,
                    Source = GetUri(Settings.Default.Homepage)
                };
            }
            else
            {
                webView = new WebView2
                {
                    Parent = tab,
                    Dock = DockStyle.Fill
                };
            }
            webView.NavigationCompleted += WebView_NavigationCompleted;
            tabControl.SelectedTab.Controls.Add(webView);
            InitActionButtons();
            ToggleOtherButtons(false);
        }

        private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            if(e.IsSuccess)
            {
                txtUrl.Text = webView.Source.ToString();
                SetTabInfo(webView?.CoreWebView2.DocumentTitle, e.HttpStatusCode);
                InitActionButtons();
                AddUrlToHistoryList(webView.CoreWebView2.DocumentTitle, webView?.Source);
            }
            else
            {
                SetTabInfo("Error!", (int)e.WebErrorStatus);
            }
        }

        private void GoToWebpage(string url)
        {
            try
            {
                Uri uri = GetUri(url);
                if (uri != null)
                {
                    webView.Source = uri;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Uri GetUri(string url)
        {
            Uri uri = new UriBuilder(url).Uri;
            try
            {
                bool result = Uri.TryCreate(uri.AbsoluteUri, UriKind.Absolute, out Uri uriResult)
                        && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
                return result ? uriResult : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void SetTabInfo(string PageTitle, int HttpStatusCode)
        {
            tabControl.SelectedTab.Text = $"{PageTitle} | HTTP Status Code: {HttpStatusCode}";
            ToggleOtherButtons(true);
        }

        protected void InitActionButtons()
        {
            if (webView != null)
            {
                BtnBack.Enabled = webView.CanGoBack;
                BtnForward.Enabled = webView.CanGoForward;
            }
        }

        protected void ToggleOtherButtons(bool val)
        {
            BtnRefresh.Enabled = BtnAddToFavourites.Enabled = val;
        }

        private void LoadFavourites()
        {
            try
            {
                if (File.Exists(FavouritesFile))
                {
                    favourites = (List<ResponseInfo>)JsonSerializer.Deserialize(File.ReadAllText(FavouritesFile), typeof(List<ResponseInfo>));
                }
                else
                {
                    File.WriteAllText(FavouritesFile, JsonSerializer.Serialize(favourites, typeof(List<ResponseInfo>)));
                }
                BtnViewFavourites.Enabled = favourites.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUrlToFavourites(string name, Uri url)
        {
            try
            {
                ResponseInfo userFavourites = new ResponseInfo()
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    Uri = url
                };
                favourites.Add(userFavourites);
                File.WriteAllText(FavouritesFile, JsonSerializer.Serialize(favourites, typeof(List<ResponseInfo>)));
                BtnViewFavourites.Enabled = favourites.Count > 0;
                MessageBox.Show("Added to favourites", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (File.Exists(HistoryFile))
                {
                    historyList = (List<ResponseInfo>)JsonSerializer.Deserialize(File.ReadAllText(HistoryFile), typeof(List<ResponseInfo>));
                }
                else
                {
                    File.WriteAllText(HistoryFile, JsonSerializer.Serialize(historyList, typeof(List<ResponseInfo>)));
                }
                BtnViewHistory.Enabled = historyList.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddUrlToHistoryList(string name, Uri uri)
        {
            try
            {
                ResponseInfo history = new ResponseInfo()
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    Uri = uri,
                };
                historyList.Add(history);
                File.WriteAllText(HistoryFile, JsonSerializer.Serialize(historyList, typeof(List<ResponseInfo>)));
                BtnViewHistory.Enabled = historyList.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtUrl.Text) && txtUrl.Text.Length > 0)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                webView.Source = GetUri(txtUrl.Text);
            }
        }

        private void txtUrl_Enter(object sender, EventArgs e)
        {
            txtUrl.SelectAll();
        }

        private void txtUrl_MouseClick(object sender, MouseEventArgs e)
        {
            txtUrl.SelectAll();
        }
    }
}