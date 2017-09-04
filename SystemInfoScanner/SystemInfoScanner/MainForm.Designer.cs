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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_Show = new System.Windows.Forms.Button();
            this.comboBox_Queries = new System.Windows.Forms.ComboBox();
            this.dataGridViewQuery = new System.Windows.Forms.DataGridView();
            this.btn_Chassis = new System.Windows.Forms.Button();
            this.textBox_Chassis = new System.Windows.Forms.TextBox();
            this.btn_getRAMinfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(661, 22);
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
            this.comboBox_Queries.Location = new System.Drawing.Point(194, 26);
            this.comboBox_Queries.Name = "comboBox_Queries";
            this.comboBox_Queries.Size = new System.Drawing.Size(461, 21);
            this.comboBox_Queries.TabIndex = 1;
            // 
            // dataGridViewQuery
            // 
            this.dataGridViewQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuery.Location = new System.Drawing.Point(31, 67);
            this.dataGridViewQuery.Name = "dataGridViewQuery";
            this.dataGridViewQuery.Size = new System.Drawing.Size(947, 479);
            this.dataGridViewQuery.TabIndex = 2;
            // 
            // btn_Chassis
            // 
            this.btn_Chassis.Location = new System.Drawing.Point(641, 565);
            this.btn_Chassis.Name = "btn_Chassis";
            this.btn_Chassis.Size = new System.Drawing.Size(125, 26);
            this.btn_Chassis.TabIndex = 3;
            this.btn_Chassis.Text = "Chassis Type";
            this.btn_Chassis.UseVisualStyleBackColor = true;
            this.btn_Chassis.Click += new System.EventHandler(this.btn_Chassis_Click);
            // 
            // textBox_Chassis
            // 
            this.textBox_Chassis.Location = new System.Drawing.Point(772, 569);
            this.textBox_Chassis.Name = "textBox_Chassis";
            this.textBox_Chassis.Size = new System.Drawing.Size(206, 20);
            this.textBox_Chassis.TabIndex = 4;
            // 
            // btn_getRAMinfo
            // 
            this.btn_getRAMinfo.Location = new System.Drawing.Point(848, 22);
            this.btn_getRAMinfo.Name = "btn_getRAMinfo";
            this.btn_getRAMinfo.Size = new System.Drawing.Size(129, 26);
            this.btn_getRAMinfo.TabIndex = 5;
            this.btn_getRAMinfo.Text = "Get RAM info";
            this.btn_getRAMinfo.UseVisualStyleBackColor = true;
            this.btn_getRAMinfo.Click += new System.EventHandler(this.btn_getRAMinfo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1008, 609);
            this.Controls.Add(this.btn_getRAMinfo);
            this.Controls.Add(this.textBox_Chassis);
            this.Controls.Add(this.btn_Chassis);
            this.Controls.Add(this.dataGridViewQuery);
            this.Controls.Add(this.comboBox_Queries);
            this.Controls.Add(this.btn_Show);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Info Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.ComboBox comboBox_Queries;
        private System.Windows.Forms.DataGridView dataGridViewQuery;
        private System.Windows.Forms.Button btn_Chassis;
        private System.Windows.Forms.TextBox textBox_Chassis;
        private System.Windows.Forms.Button btn_getRAMinfo;
    }
}

