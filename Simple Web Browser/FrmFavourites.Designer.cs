﻿namespace Simple_Web_Browser
{
    partial class FrmFavourites
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            favouritesList = new System.Windows.Forms.ListBox();
            favouritesContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            BtnClearFavourites = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            favouritesTooltip = new System.Windows.Forms.ToolTip(components);
            favouritesContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // favouritesList
            // 
            favouritesList.ContextMenuStrip = favouritesContextMenu;
            favouritesList.FormattingEnabled = true;
            favouritesList.ItemHeight = 20;
            favouritesList.Location = new System.Drawing.Point(12, 115);
            favouritesList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            favouritesList.Name = "favouritesList";
            favouritesList.Size = new System.Drawing.Size(410, 344);
            favouritesList.TabIndex = 0;
            favouritesList.KeyDown += favouritesList_KeyDown;
            favouritesList.MouseDoubleClick += favouritesList_MouseDoubleClick;
            // 
            // favouritesContextMenu
            // 
            favouritesContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { deleteToolStripMenuItem });
            favouritesContextMenu.Name = "favouritesContextMenu";
            favouritesContextMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // BtnClearFavourites
            // 
            BtnClearFavourites.AutoSize = true;
            BtnClearFavourites.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnClearFavourites.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnClearFavourites.Depth = 0;
            BtnClearFavourites.Icon = Properties.Resources.icon_clear_24;
            BtnClearFavourites.Location = new System.Drawing.Point(377, 71);
            BtnClearFavourites.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            BtnClearFavourites.MouseState = MaterialThemeCore.MouseState.HOVER;
            BtnClearFavourites.Name = "BtnClearFavourites";
            BtnClearFavourites.Primary = false;
            BtnClearFavourites.Size = new System.Drawing.Size(44, 36);
            BtnClearFavourites.TabIndex = 1;
            favouritesTooltip.SetToolTip(BtnClearFavourites, "Clear Favourites");
            BtnClearFavourites.UseVisualStyleBackColor = true;
            BtnClearFavourites.Click += BtnClearFavourites_Click;
            // 
            // FrmFavourites
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(434, 474);
            Controls.Add(BtnClearFavourites);
            Controls.Add(favouritesList);
            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFavourites";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Favourites";
            Load += FrmFavourites_Load;
            favouritesContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox favouritesList;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton BtnClearFavourites;
        private System.Windows.Forms.ContextMenuStrip favouritesContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolTip favouritesTooltip;
    }
}