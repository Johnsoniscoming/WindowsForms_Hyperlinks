namespace WindowsForms_Hyperlinks
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvHyperlinkData = new System.Windows.Forms.DataGridView();
            this.名稱 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.位置 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReadExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExcelPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnSaveDGV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHyperlinkData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHyperlinkData
            // 
            this.dgvHyperlinkData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHyperlinkData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名稱,
            this.位置});
            this.dgvHyperlinkData.Location = new System.Drawing.Point(26, 34);
            this.dgvHyperlinkData.Name = "dgvHyperlinkData";
            this.dgvHyperlinkData.RowTemplate.Height = 31;
            this.dgvHyperlinkData.Size = new System.Drawing.Size(1045, 355);
            this.dgvHyperlinkData.TabIndex = 0;
            this.dgvHyperlinkData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvHyperlinkData_KeyDown);
            // 
            // 名稱
            // 
            this.名稱.HeaderText = "名稱";
            this.名稱.MinimumWidth = 10;
            this.名稱.Name = "名稱";
            // 
            // 位置
            // 
            this.位置.HeaderText = "位置";
            this.位置.Name = "位置";
            // 
            // btnReadExcel
            // 
            this.btnReadExcel.Location = new System.Drawing.Point(895, 478);
            this.btnReadExcel.Name = "btnReadExcel";
            this.btnReadExcel.Size = new System.Drawing.Size(162, 60);
            this.btnReadExcel.TabIndex = 1;
            this.btnReadExcel.Text = "載入Excel";
            this.btnReadExcel.UseVisualStyleBackColor = true;
            this.btnReadExcel.Click += new System.EventHandler(this.btnReadExcel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(32, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Path";
            // 
            // txtExcelPath
            // 
            this.txtExcelPath.Location = new System.Drawing.Point(131, 417);
            this.txtExcelPath.Name = "txtExcelPath";
            this.txtExcelPath.Size = new System.Drawing.Size(732, 29);
            this.txtExcelPath.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(895, 416);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(162, 30);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnSaveDGV
            // 
            this.btnSaveDGV.Location = new System.Drawing.Point(36, 500);
            this.btnSaveDGV.Name = "btnSaveDGV";
            this.btnSaveDGV.Size = new System.Drawing.Size(108, 38);
            this.btnSaveDGV.TabIndex = 5;
            this.btnSaveDGV.Text = "SaveDGV";
            this.btnSaveDGV.UseVisualStyleBackColor = true;
            this.btnSaveDGV.Click += new System.EventHandler(this.btnSaveDGV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 550);
            this.Controls.Add(this.btnSaveDGV);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtExcelPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReadExcel);
            this.Controls.Add(this.dgvHyperlinkData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHyperlinkData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHyperlinkData;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名稱;
        private System.Windows.Forms.DataGridViewTextBoxColumn 位置;
        private System.Windows.Forms.Button btnReadExcel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExcelPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnSaveDGV;
    }
}

