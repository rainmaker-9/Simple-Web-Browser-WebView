namespace Simple_Web_Browser
{
    partial class FrmHistory
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
            DGVHistory = new System.Windows.Forms.DataGridView();
            Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            historyContextMenu = new System.Windows.Forms.ContextMenuStrip(components);
            deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            BtnClearHistory = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            historyTooltip = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)DGVHistory).BeginInit();
            historyContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // DGVHistory
            // 
            DGVHistory.AllowUserToAddRows = false;
            DGVHistory.AllowUserToDeleteRows = false;
            DGVHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            DGVHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Title, Address, Date });
            DGVHistory.ContextMenuStrip = historyContextMenu;
            DGVHistory.Location = new System.Drawing.Point(14, 125);
            DGVHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DGVHistory.Name = "DGVHistory";
            DGVHistory.ReadOnly = true;
            DGVHistory.RowTemplate.Height = 25;
            DGVHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            DGVHistory.Size = new System.Drawing.Size(649, 373);
            DGVHistory.TabIndex = 0;
            DGVHistory.CellMouseDoubleClick += DGVHistory_CellMouseDoubleClick;
            DGVHistory.KeyDown += DGVHistory_KeyDown;
            // 
            // Title
            // 
            Title.DataPropertyName = "Name";
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Address
            // 
            Address.DataPropertyName = "Uri";
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // historyContextMenu
            // 
            historyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { deleteToolStripMenuItem });
            historyContextMenu.Name = "historyContextMenu";
            historyContextMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            deleteToolStripMenuItem.Text = "Delete";
            deleteToolStripMenuItem.Click += deleteToolStripMenuItem_Click;
            // 
            // BtnClearHistory
            // 
            BtnClearHistory.AutoSize = true;
            BtnClearHistory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnClearHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            BtnClearHistory.Depth = 0;
            BtnClearHistory.Icon = Properties.Resources.icon_clear_24;
            BtnClearHistory.Location = new System.Drawing.Point(618, 79);
            BtnClearHistory.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            BtnClearHistory.MouseState = MaterialThemeCore.MouseState.HOVER;
            BtnClearHistory.Name = "BtnClearHistory";
            BtnClearHistory.Primary = false;
            BtnClearHistory.Size = new System.Drawing.Size(44, 36);
            BtnClearHistory.TabIndex = 2;
            historyTooltip.SetToolTip(BtnClearHistory, "Clear History");
            BtnClearHistory.UseVisualStyleBackColor = true;
            BtnClearHistory.Click += BtnClearHistory_Click;
            // 
            // FrmHistory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(675, 511);
            Controls.Add(BtnClearHistory);
            Controls.Add(DGVHistory);
            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmHistory";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "History";
            Load += FrmHistory_Load;
            ((System.ComponentModel.ISupportInitialize)DGVHistory).EndInit();
            historyContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView DGVHistory;
        private MaterialThemeCore.MaterialControls.MaterialFlatButton BtnClearHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.ToolTip historyTooltip;
        private System.Windows.Forms.ContextMenuStrip historyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}