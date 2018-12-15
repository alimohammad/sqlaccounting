namespace WBoxSqlAccountingForDD
{
    partial class WboxDataImporter
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
            this.textDBPath = new System.Windows.Forms.TextBox();
            this.txtDBName = new System.Windows.Forms.TextBox();
            this.txtUN = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.importFromWbox = new System.Windows.Forms.Button();
            this.exportToSqlAccounting = new System.Windows.Forms.Button();
            this.wboxDataImport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.wboxDataImport)).BeginInit();
            this.SuspendLayout();
            // 
            // textDBPath
            // 
            this.textDBPath.Location = new System.Drawing.Point(42, 24);
            this.textDBPath.Name = "textDBPath";
            this.textDBPath.Size = new System.Drawing.Size(380, 20);
            this.textDBPath.TabIndex = 0;
            this.textDBPath.Text = "D:\\eStream\\SQLAccounting\\Share\\DEFAULT.DCF";
            // 
            // txtDBName
            // 
            this.txtDBName.Location = new System.Drawing.Point(944, 24);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.Size = new System.Drawing.Size(380, 20);
            this.txtDBName.TabIndex = 1;
            this.txtDBName.Text = "ACC-0001.FDB";
            // 
            // txtUN
            // 
            this.txtUN.Location = new System.Drawing.Point(42, 68);
            this.txtUN.Name = "txtUN";
            this.txtUN.Size = new System.Drawing.Size(380, 20);
            this.txtUN.TabIndex = 2;
            this.txtUN.Text = "ADMIN";
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(944, 68);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(380, 20);
            this.txtPW.TabIndex = 3;
            this.txtPW.Text = "ADMIN";
            // 
            // importFromWbox
            // 
            this.importFromWbox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.importFromWbox.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importFromWbox.Location = new System.Drawing.Point(42, 116);
            this.importFromWbox.Name = "importFromWbox";
            this.importFromWbox.Size = new System.Drawing.Size(380, 83);
            this.importFromWbox.TabIndex = 4;
            this.importFromWbox.Text = "Import From WBox";
            this.importFromWbox.UseVisualStyleBackColor = false;
            this.importFromWbox.Click += new System.EventHandler(this.importFromWbox_Click);
            // 
            // exportToSqlAccounting
            // 
            this.exportToSqlAccounting.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.exportToSqlAccounting.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportToSqlAccounting.Location = new System.Drawing.Point(944, 116);
            this.exportToSqlAccounting.Name = "exportToSqlAccounting";
            this.exportToSqlAccounting.Size = new System.Drawing.Size(380, 83);
            this.exportToSqlAccounting.TabIndex = 5;
            this.exportToSqlAccounting.Text = "Export to SQLAccounting";
            this.exportToSqlAccounting.UseVisualStyleBackColor = false;
            this.exportToSqlAccounting.Click += new System.EventHandler(this.exportToSqlAccounting_Click);
            // 
            // wboxDataImport
            // 
            this.wboxDataImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wboxDataImport.Location = new System.Drawing.Point(42, 226);
            this.wboxDataImport.Name = "wboxDataImport";
            this.wboxDataImport.Size = new System.Drawing.Size(1282, 255);
            this.wboxDataImport.TabIndex = 6;
            // 
            // WboxDataImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.wboxDataImport);
            this.Controls.Add(this.exportToSqlAccounting);
            this.Controls.Add(this.importFromWbox);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtUN);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.textDBPath);
            this.Name = "WboxDataImporter";
            this.Text = "Wbox To SqlAccounting Importer";
            ((System.ComponentModel.ISupportInitialize)(this.wboxDataImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textDBPath;
        private System.Windows.Forms.TextBox txtDBName;
        private System.Windows.Forms.TextBox txtUN;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Button importFromWbox;
        private System.Windows.Forms.Button exportToSqlAccounting;
        private System.Windows.Forms.DataGridView wboxDataImport;
    }
}

