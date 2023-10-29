using MaterialThemeCore.MaterialControls;
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
            tabControl = new MaterialTabControl();
            tabContextMenuStrip = new ContextMenuStrip(components);
            closeTab = new ToolStripMenuItem();
            txtUrl = new MaterialSingleLineTextField();
            BtnGo = new MaterialFlatButton();
            BtnAddTab = new MaterialFlatButton();
            BtnHome = new MaterialFlatButton();
            BtnBack = new MaterialFlatButton();
            BtnForward = new MaterialFlatButton();
            BtnRefresh = new MaterialFlatButton();
            mainTooltip = new ToolTip(components);
            BtnAddToFavourites = new MaterialFlatButton();
            BtnViewFavourites = new MaterialFlatButton();
            BtnViewHistory = new MaterialFlatButton();
            BtnBulkDownload = new MaterialFlatButton();
            materialTabSelector1 = new MaterialTabSelector();
            tabContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.ContextMenuStrip = tabContextMenuStrip;
            tabControl.Depth = 0;
            tabControl.Location = new Point(14, 158);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.MouseState = MaterialThemeCore.MouseState.HOVER;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(970, 530);
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
            txtUrl.Depth = 0;
            txtUrl.Hint = "Enter URL";
            txtUrl.Location = new Point(150, 82);
            txtUrl.Margin = new Padding(3, 4, 3, 4);
            txtUrl.MaxLength = 32767;
            txtUrl.MouseState = MaterialThemeCore.MouseState.HOVER;
            txtUrl.Name = "txtUrl";
            txtUrl.Padding = new Padding(10);
            txtUrl.PasswordChar = '\0';
            txtUrl.SelectedText = "";
            txtUrl.SelectionLength = 0;
            txtUrl.SelectionStart = 0;
            txtUrl.Size = new Size(524, 23);
            txtUrl.TabIndex = 1;
            txtUrl.TabStop = false;
            txtUrl.UseSystemPasswordChar = false;
            txtUrl.KeyDown += txtUrl_KeyDown;
            // 
            // BtnGo
            // 
            BtnGo.AutoSize = true;
            BtnGo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnGo.Cursor = Cursors.Hand;
            BtnGo.Depth = 0;
            BtnGo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnGo.Icon = Properties.Resources.icon_go_24;
            BtnGo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGo.Location = new Point(681, 82);
            BtnGo.Margin = new Padding(4, 6, 4, 6);
            BtnGo.MouseState = MaterialThemeCore.MouseState.HOVER;
            BtnGo.Name = "BtnGo";
            BtnGo.Primary = false;
            BtnGo.Size = new Size(44, 36);
            BtnGo.TabIndex = 2;
            mainTooltip.SetToolTip(BtnGo, "Go to the typed URL");
            BtnGo.UseVisualStyleBackColor = true;
            BtnGo.Click += BtnGo_Click;
            // 
            // BtnAddTab
            // 
            BtnAddTab.AutoSize = true;
            BtnAddTab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAddTab.Cursor = Cursors.Hand;
            BtnAddTab.Depth = 0;
            BtnAddTab.Icon = Properties.Resources.icon_new_tab_24;
            BtnAddTab.Location = new Point(723, 82);
            BtnAddTab.Margin = new Padding(4, 6, 4, 6);
            BtnAddTab.MouseState = MaterialThemeCore.MouseState.HOVER;
            BtnAddTab.Name = "BtnAddTab";
            BtnAddTab.Primary = false;
            BtnAddTab.Size = new Size(44, 36);
            BtnAddTab.TabIndex = 3;
            mainTooltip.SetToolTip(BtnAddTab, "Add a new tab");
            BtnAddTab.UseVisualStyleBackColor = true;
            BtnAddTab.Click += BtnAddTab_Click;
            // 
            // BtnHome
            // 
            BtnHome.AutoSize = true;
            BtnHome.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnHome.Cursor = Cursors.Hand;
            BtnHome.Depth = 0;
            BtnHome.Icon = Properties.Resources.icon_home_24;
            BtnHome.Location = new Point(765, 82);
            BtnHome.Margin = new Padding(4, 6, 4, 6);
            BtnHome.MouseState = MaterialThemeCore.MouseState.HOVER;
            BtnHome.Name = "BtnHome";
            BtnHome.Primary = false;
            BtnHome.Size = new Size(44, 36);
            BtnHome.TabIndex = 4;
            mainTooltip.SetToolTip(BtnHome, "Go to Homepage");
            BtnHome.UseVisualStyleBackColor = true;
            BtnHome.Click += BtnHome_Click;
            // 
            // BtnBack
            // 
            BtnBack.AutoSize = true;
            BtnBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnBack.Cursor = Cursors.Hand;
            BtnBack.Depth = 0;
            BtnBack.Icon = Properties.Resources.icon_previous_24;
            BtnBack.Location = new Point(14, 82);
            BtnBack.Margin = new Padding(4, 6, 4, 6);
            BtnBack.MouseState = MaterialThemeCore.MouseState.HOVER;
            BtnBack.Name = "BtnBack";
            BtnBack.Primary = false;
            BtnBack.Size = new Size(44, 36);
            BtnBack.TabIndex = 5;
            mainTooltip.SetToolTip(BtnBack, "Go Back");
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnForward
            // 
            BtnForward.AutoSize = true;
            BtnForward.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnForward.Cursor = Cursors.Hand;
            BtnForward.Depth = 0;
            BtnForward.Icon = Properties.Resources.icon_next_24;
            BtnForward.Location = new Point(57, 82);
            BtnForward.Margin = new Padding(4, 6, 4, 6);
            BtnForward.MouseState = MaterialThemeCore.MouseState.HOVER;
            BtnForward.Name = "BtnForward";
            BtnForward.Primary = false;
            BtnForward.Size = new Size(44, 36);
            BtnForward.TabIndex = 6;
            mainTooltip.SetToolTip(BtnForward, "Go Forward");
            BtnForward.UseVisualStyleBackColor = true;
            BtnForward.Click += BtnForward_Click;
            // 
            // BtnRefresh
            // 
            BtnRefresh.AutoSize = true;
            BtnRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnRefresh.Cursor = Cursors.Hand;
            BtnRefresh.Depth = 0;
            BtnRefresh.Enabled = false;
            BtnRefresh.Icon = Properties.Resources.icon_refresh_24;
            BtnRefresh.Location = new Point(99, 82);
            BtnRefresh.Margin = new Padding(4, 6, 4, 6);
            BtnRefresh.MouseState = MaterialThemeCore.MouseState.HOVER;
            BtnRefresh.Name = "BtnRefresh";
            BtnRefresh.Primary = false;
            BtnRefresh.Size = new Size(44, 36);
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
            BtnAddToFavourites.AutoSize = true;
            BtnAddToFavourites.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnAddToFavourites.Cursor = Cursors.Hand;
            BtnAddToFavourites.Depth = 0;
            BtnAddToFavourites.Enabled = false;
            BtnAddToFavourites.Icon = Properties.Resources.icon_favourite_24;
            BtnAddToFavourites.Location = new Point(807, 82);
            BtnAddToFavourites.Margin = new Padding(4, 6, 4, 6);
            BtnAddToFavourites.MouseState = MaterialThemeCore.MouseState.HOVER;
            BtnAddToFavourites.Name = "BtnAddToFavourites";
            BtnAddToFavourites.Primary = false;
            BtnAddToFavourites.Size = new Size(44, 36);
            BtnAddToFavourites.TabIndex = 8;
            mainTooltip.SetToolTip(BtnAddToFavourites, "Add this page to favourites");
            BtnAddToFavourites.UseVisualStyleBackColor = true;
            BtnAddToFavourites.Click += BtnAddToFavourites_Click;
            // 
            // BtnViewFavourites
            // 
            BtnViewFavourites.AutoSize = true;
            BtnViewFavourites.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnViewFavourites.Cursor = Cursors.Hand;
            BtnViewFavourites.Depth = 0;
            BtnViewFavourites.Icon = Properties.Resources.icon_favourites_24;
            BtnViewFavourites.Location = new Point(849, 82);
            BtnViewFavourites.Margin = new Padding(4, 6, 4, 6);
            BtnViewFavourites.MouseState = MaterialThemeCore.MouseState.HOVER;
            BtnViewFavourites.Name = "BtnViewFavourites";
            BtnViewFavourites.Primary = false;
            BtnViewFavourites.Size = new Size(44, 36);
            BtnViewFavourites.TabIndex = 9;
            mainTooltip.SetToolTip(BtnViewFavourites, "View Favourites");
            BtnViewFavourites.UseVisualStyleBackColor = true;
            BtnViewFavourites.Click += BtnViewFavourites_Click;
            // 
            // BtnViewHistory
            // 
            BtnViewHistory.AutoSize = true;
            BtnViewHistory.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnViewHistory.Cursor = Cursors.Hand;
            BtnViewHistory.Depth = 0;
            BtnViewHistory.Icon = Properties.Resources.icon_history_24;
            BtnViewHistory.Location = new Point(891, 82);
            BtnViewHistory.Margin = new Padding(4, 6, 4, 6);
            BtnViewHistory.MouseState = MaterialThemeCore.MouseState.HOVER;
            BtnViewHistory.Name = "BtnViewHistory";
            BtnViewHistory.Primary = false;
            BtnViewHistory.Size = new Size(44, 36);
            BtnViewHistory.TabIndex = 10;
            mainTooltip.SetToolTip(BtnViewHistory, "View History");
            BtnViewHistory.UseVisualStyleBackColor = true;
            BtnViewHistory.Click += BtnViewHistory_Click;
            // 
            // BtnBulkDownload
            // 
            BtnBulkDownload.AutoSize = true;
            BtnBulkDownload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BtnBulkDownload.Cursor = Cursors.Hand;
            BtnBulkDownload.Depth = 0;
            BtnBulkDownload.Icon = Properties.Resources.icon_download_24;
            BtnBulkDownload.Location = new Point(933, 82);
            BtnBulkDownload.Margin = new Padding(4, 6, 4, 6);
            BtnBulkDownload.MouseState = MaterialThemeCore.MouseState.HOVER;
            BtnBulkDownload.Name = "BtnBulkDownload";
            BtnBulkDownload.Primary = false;
            BtnBulkDownload.Size = new Size(44, 36);
            BtnBulkDownload.TabIndex = 12;
            mainTooltip.SetToolTip(BtnBulkDownload, "Bulk Download URLs");
            BtnBulkDownload.UseVisualStyleBackColor = true;
            BtnBulkDownload.Click += BtnBulkDownload_Click;
            // 
            // materialTabSelector1
            // 
            materialTabSelector1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            materialTabSelector1.BaseTabControl = null;
            materialTabSelector1.ContextMenuStrip = tabContextMenuStrip;
            materialTabSelector1.Depth = 0;
            materialTabSelector1.Location = new Point(14, 130);
            materialTabSelector1.MouseState = MaterialThemeCore.MouseState.HOVER;
            materialTabSelector1.Name = "materialTabSelector1";
            materialTabSelector1.Size = new Size(970, 23);
            materialTabSelector1.TabIndex = 13;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 704);
            Controls.Add(materialTabSelector1);
            Controls.Add(BtnBulkDownload);
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

        private MaterialTabControl tabControl;
        private MaterialSingleLineTextField txtUrl;
        private MaterialFlatButton BtnGo;
        private MaterialFlatButton BtnAddTab;
        private ContextMenuStrip tabContextMenuStrip;
        private ToolStripMenuItem closeTab;
        private MaterialFlatButton BtnHome;
        private MaterialFlatButton BtnBack;
        private MaterialFlatButton BtnForward;
        private MaterialFlatButton BtnRefresh;
        private ToolTip mainTooltip;
        private MaterialFlatButton BtnAddToFavourites;
        private MaterialFlatButton BtnViewFavourites;
        private MaterialFlatButton BtnViewHistory;
        private MaterialFlatButton BtnBulkDownload;
        private MaterialTabSelector materialTabSelector1;
    }
}