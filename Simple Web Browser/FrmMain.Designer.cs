using System;
using System.Drawing;
using System.Windows.Forms;

namespace Simple_Web_Browser
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl = new TabControl();
            tabContextMenuStrip = new ContextMenuStrip(components);
            closeTab = new ToolStripMenuItem();
            txtUrl = new TextBox();
            BtnGo = new Button();
            BtnAddTab = new Button();
            BtnHome = new Button();
            BtnBack = new Button();
            BtnForward = new Button();
            BtnRefresh = new Button();
            mainTooltip = new ToolTip(components);
            BtnAddToFavourites = new Button();
            BtnViewFavourites = new Button();
            BtnViewHistory = new Button();
            BtnGoogleSearch = new Button();
            BtnBulkDownload = new Button();
            tabContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.ContextMenuStrip = tabContextMenuStrip;
            tabControl.Location = new Point(14, 63);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(970, 521);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabContextMenuStrip
            // 
            tabContextMenuStrip.Items.AddRange(new ToolStripItem[] { closeTab });
            tabContextMenuStrip.Name = "tabContextMenuStrip";
            tabContextMenuStrip.Size = new Size(104, 26);
            // 
            // closeTab
            // 
            closeTab.Name = "closeTab";
            closeTab.Size = new Size(103, 22);
            closeTab.Text = "Close";
            closeTab.Click += closeTab_Click;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(145, 20);
            txtUrl.Margin = new Padding(3, 4, 3, 4);
            txtUrl.Name = "txtUrl";
            txtUrl.PlaceholderText = "Enter URL";
            txtUrl.Size = new Size(498, 27);
            txtUrl.TabIndex = 1;
            txtUrl.MouseClick += txtUrl_MouseClick;
            txtUrl.Enter += txtUrl_Enter;
            txtUrl.KeyDown += txtUrl_KeyDown;
            // 
            // BtnGo
            // 
            BtnGo.Cursor = Cursors.Hand;
            BtnGo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGo.Image = Properties.Resources.icon_go_24;
            BtnGo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGo.Location = new Point(649, 19);
            BtnGo.Name = "BtnGo";
            BtnGo.Size = new Size(36, 36);
            BtnGo.TabIndex = 2;
            mainTooltip.SetToolTip(BtnGo, "Go to the typed URL");
            BtnGo.UseVisualStyleBackColor = true;
            BtnGo.Click += BtnGo_Click;
            // 
            // BtnAddTab
            // 
            BtnAddTab.Cursor = Cursors.Hand;
            BtnAddTab.Image = Properties.Resources.icon_new_tab_24;
            BtnAddTab.Location = new Point(691, 19);
            BtnAddTab.Name = "BtnAddTab";
            BtnAddTab.Size = new Size(36, 36);
            BtnAddTab.TabIndex = 3;
            mainTooltip.SetToolTip(BtnAddTab, "Add a new tab");
            BtnAddTab.UseVisualStyleBackColor = true;
            BtnAddTab.Click += BtnAddTab_Click;
            // 
            // BtnHome
            // 
            BtnHome.Cursor = Cursors.Hand;
            BtnHome.Image = Properties.Resources.icon_home_24;
            BtnHome.Location = new Point(733, 19);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(36, 36);
            BtnHome.TabIndex = 4;
            mainTooltip.SetToolTip(BtnHome, "Go to Homepage");
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // BtnBack
            // 
            BtnBack.Cursor = Cursors.Hand;
            BtnBack.Image = Properties.Resources.icon_previous_24;
            BtnBack.Location = new Point(17, 19);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(36, 36);
            BtnBack.TabIndex = 5;
            mainTooltip.SetToolTip(BtnBack, "Go Back");
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnForward
            // 
            BtnForward.Cursor = Cursors.Hand;
            BtnForward.Image = Properties.Resources.icon_next_24;
            BtnForward.Location = new Point(60, 19);
            BtnForward.Name = "BtnForward";
            BtnForward.Size = new Size(36, 36);
            BtnForward.TabIndex = 6;
            mainTooltip.SetToolTip(BtnForward, "Go Forward");
            BtnForward.UseVisualStyleBackColor = true;
            BtnForward.Click += BtnForward_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.Cursor = Cursors.Hand;
            BtnRefresh.Enabled = false;
            BtnRefresh.Image = Properties.Resources.icon_refresh_24;
            BtnRefresh.Location = new Point(102, 19);
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Size = new Size(36, 36);
            BtnRefresh.TabIndex = 7;
            mainTooltip.SetToolTip(BtnRefresh, "Refresh this page");
            BtnRefresh.UseVisualStyleBackColor = true;
            BtnRefresh.Click += BtnRefresh_Click;
            // 
            // mainTooltip
            // 
            mainTooltip.IsBalloon = true;
            // 
            // BtnAddToFavourites
            // 
            BtnAddToFavourites.Cursor = Cursors.Hand;
            BtnAddToFavourites.Enabled = false;
            BtnAddToFavourites.Image = Properties.Resources.icon_favourite_24;
            BtnAddToFavourites.Location = new Point(775, 19);
            BtnAddToFavourites.Name = "BtnAddToFavourites";
            BtnAddToFavourites.Size = new Size(36, 36);
            BtnAddToFavourites.TabIndex = 8;
            mainTooltip.SetToolTip(BtnAddToFavourites, "Add this page to favourites");
            BtnAddToFavourites.UseVisualStyleBackColor = true;
            BtnAddToFavourites.Click += BtnAddToFavourites_Click;
            // 
            // BtnViewFavourites
            // 
            BtnViewFavourites.Cursor = Cursors.Hand;
            BtnViewFavourites.Image = Properties.Resources.icon_favourites_24;
            BtnViewFavourites.Location = new Point(817, 19);
            BtnViewFavourites.Name = "BtnViewFavourites";
            BtnViewFavourites.Size = new Size(36, 36);
            BtnViewFavourites.TabIndex = 9;
            mainTooltip.SetToolTip(BtnViewFavourites, "View Favourites");
            BtnViewFavourites.UseVisualStyleBackColor = true;
            BtnViewFavourites.Click += BtnViewFavourites_Click;
            // 
            // BtnViewHistory
            // 
            BtnViewHistory.Cursor = Cursors.Hand;
            BtnViewHistory.Image = Properties.Resources.icon_history_24;
            BtnViewHistory.Location = new Point(859, 19);
            BtnViewHistory.Name = "BtnViewHistory";
            BtnViewHistory.Size = new Size(36, 36);
            BtnViewHistory.TabIndex = 10;
            mainTooltip.SetToolTip(BtnViewHistory, "View History");
            BtnViewHistory.UseVisualStyleBackColor = true;
            BtnViewHistory.Click += BtnViewHistory_Click;
            // 
            // BtnGoogleSearch
            // 
            BtnGoogleSearch.Cursor = Cursors.Hand;
            BtnGoogleSearch.Image = Properties.Resources.icon_google_24;
            BtnGoogleSearch.Location = new Point(943, 19);
            BtnGoogleSearch.Name = "BtnGoogleSearch";
            BtnGoogleSearch.Size = new Size(36, 36);
            BtnGoogleSearch.TabIndex = 11;
            mainTooltip.SetToolTip(BtnGoogleSearch, "Google Search");
            BtnGoogleSearch.UseVisualStyleBackColor = true;
            BtnGoogleSearch.Click += BtnGoogleSearch_Click;
            // 
            // BtnBulkDownload
            // 
            BtnBulkDownload.Cursor = Cursors.Hand;
            BtnBulkDownload.Image = Properties.Resources.icon_download_24;
            BtnBulkDownload.Location = new Point(901, 19);
            BtnBulkDownload.Name = "BtnBulkDownload";
            BtnBulkDownload.Size = new Size(36, 36);
            BtnBulkDownload.TabIndex = 12;
            mainTooltip.SetToolTip(BtnBulkDownload, "Bulk Download URLs");
            BtnBulkDownload.UseVisualStyleBackColor = true;
            BtnBulkDownload.Click += BtnBulkDownload_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 600);
            Controls.Add(BtnBulkDownload);
            Controls.Add(BtnGoogleSearch);
            Controls.Add(BtnViewHistory);
            Controls.Add(BtnViewFavourites);
            Controls.Add(BtnAddToFavourites);
            Controls.Add(BtnRefresh);
            Controls.Add(BtnForward);
            Controls.Add(BtnBack);
            Controls.Add(BtnHome);
            Controls.Add(BtnAddTab);
            Controls.Add(BtnGo);
            Controls.Add(txtUrl);
            Controls.Add(tabControl);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Web Browser";
            WindowState = FormWindowState.Maximized;
            Load += FrmMain_Load;
            KeyDown += FrmMain_KeyDown;
            tabContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl;
        private TextBox txtUrl;
        private Button BtnGo;
        private Button BtnAddTab;
        private ContextMenuStrip tabContextMenuStrip;
        private ToolStripMenuItem closeTab;
        private Button BtnHome;
        private Button BtnBack;
        private Button BtnForward;
        private Button BtnRefresh;
        private ToolTip mainTooltip;
        private Button BtnAddToFavourites;
        private Button BtnViewFavourites;
        private Button BtnViewHistory;
        private Button BtnGoogleSearch;
        private Button BtnBulkDownload;
    }
}