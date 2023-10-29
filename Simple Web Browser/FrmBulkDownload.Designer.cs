namespace Simple_Web_Browser
{
    partial class FrmBulkDownload
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
            BtnSelectFile = new MaterialThemeCore.MaterialControls.MaterialFlatButton();
            TxtResponse = new System.Windows.Forms.TextBox();
            LblProcess = new MaterialThemeCore.MaterialControls.MaterialLabel();
            SuspendLayout();
            // 
            // BtnSelectFile
            // 
            BtnSelectFile.AutoSize = true;
            BtnSelectFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BtnSelectFile.Depth = 0;
            BtnSelectFile.Icon = null;
            BtnSelectFile.Location = new System.Drawing.Point(12, 82);
            BtnSelectFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnSelectFile.MouseState = MaterialThemeCore.MouseState.HOVER;
            BtnSelectFile.Name = "BtnSelectFile";
            BtnSelectFile.Primary = false;
            BtnSelectFile.Size = new System.Drawing.Size(100, 36);
            BtnSelectFile.TabIndex = 0;
            BtnSelectFile.Text = "Select File";
            BtnSelectFile.UseVisualStyleBackColor = true;
            BtnSelectFile.Click += BtnSelectFile_Click;
            // 
            // TxtResponse
            // 
            TxtResponse.Location = new System.Drawing.Point(12, 125);
            TxtResponse.Multiline = true;
            TxtResponse.Name = "TxtResponse";
            TxtResponse.PlaceholderText = "Response will appear here";
            TxtResponse.ReadOnly = true;
            TxtResponse.Size = new System.Drawing.Size(600, 370);
            TxtResponse.TabIndex = 1;
            // 
            // LblProcess
            // 
            LblProcess.Depth = 0;
            LblProcess.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LblProcess.ForeColor = System.Drawing.Color.FromArgb(222, 0, 0, 0);
            LblProcess.Location = new System.Drawing.Point(118, 82);
            LblProcess.MouseState = MaterialThemeCore.MouseState.HOVER;
            LblProcess.Name = "LblProcess";
            LblProcess.Size = new System.Drawing.Size(494, 36);
            LblProcess.TabIndex = 2;
            LblProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmBulkDownload
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(624, 507);
            Controls.Add(LblProcess);
            Controls.Add(TxtResponse);
            Controls.Add(BtnSelectFile);
            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBulkDownload";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Bulk Download";
            Load += BulkDownload_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaterialThemeCore.MaterialControls.MaterialFlatButton BtnSelectFile;
        private System.Windows.Forms.TextBox TxtResponse;
        private MaterialThemeCore.MaterialControls.MaterialLabel LblProcess;
    }
}