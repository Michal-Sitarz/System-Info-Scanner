namespace SystemInfoScanner
{
    partial class MainForm
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
            this.btn_Show = new System.Windows.Forms.Button();
            this.comboBox_Queries = new System.Windows.Forms.ComboBox();
            this.dataGridViewQuery = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(687, 32);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(136, 26);
            this.btn_Show.TabIndex = 0;
            this.btn_Show.Text = "Show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // comboBox_Queries
            // 
            this.comboBox_Queries.FormattingEnabled = true;
            this.comboBox_Queries.Location = new System.Drawing.Point(198, 36);
            this.comboBox_Queries.Name = "comboBox_Queries";
            this.comboBox_Queries.Size = new System.Drawing.Size(461, 21);
            this.comboBox_Queries.TabIndex = 1;
            // 
            // dataGridViewQuery
            // 
            this.dataGridViewQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery.Location = new System.Drawing.Point(31, 93);
            this.dataGridViewQuery.Name = "dataGridViewQuery";
            this.dataGridViewQuery.Size = new System.Drawing.Size(947, 479);
            this.dataGridViewQuery.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.dataGridViewQuery);
            this.Controls.Add(this.comboBox_Queries);
            this.Controls.Add(this.btn_Show);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Info Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.ComboBox comboBox_Queries;
        private System.Windows.Forms.DataGridView dataGridViewQuery;
    }
}

