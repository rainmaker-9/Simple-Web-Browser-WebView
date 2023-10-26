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
            BtnSelectFile = new System.Windows.Forms.Button();
            TxtResponse = new System.Windows.Forms.TextBox();
            LblProcess = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // BtnSelectFile
            // 
            BtnSelectFile.Location = new System.Drawing.Point(12, 16);
            BtnSelectFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            BtnSelectFile.Name = "BtnSelectFile";
            BtnSelectFile.Size = new System.Drawing.Size(86, 31);
            BtnSelectFile.TabIndex = 0;
            BtnSelectFile.Text = "Select File";
            BtnSelectFile.UseVisualStyleBackColor = true;
            BtnSelectFile.Click += BtnSelectFile_Click;
            // 
            // TxtResponse
            // 
            TxtResponse.Location = new System.Drawing.Point(12, 54);
            TxtResponse.Multiline = true;
            TxtResponse.Name = "TxtResponse";
            TxtResponse.PlaceholderText = "Response will appear here";
            TxtResponse.ReadOnly = true;
            TxtResponse.Size = new System.Drawing.Size(600, 375);
            TxtResponse.TabIndex = 1;
            // 
            // LblProcess
            // 
            LblProcess.Location = new System.Drawing.Point(104, 16);
            LblProcess.Name = "LblProcess";
            LblProcess.Size = new System.Drawing.Size(508, 31);
            LblProcess.TabIndex = 2;
            LblProcess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmBulkDownload
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(624, 441);
            Controls.Add(LblProcess);
            Controls.Add(TxtResponse);
            Controls.Add(BtnSelectFile);
            Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

        private System.Windows.Forms.Button BtnSelectFile;
        private System.Windows.Forms.TextBox TxtResponse;
        private System.Windows.Forms.Label LblProcess;
    }
}