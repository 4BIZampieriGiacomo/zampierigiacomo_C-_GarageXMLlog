namespace Garage
{
    partial class Form5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridLog = new System.Windows.Forms.DataGridView();
            this.TipoDati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLog
            // 
            this.dataGridLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridLog.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoDati,
            this.Dati});
            this.dataGridLog.GridColor = System.Drawing.Color.Black;
            this.dataGridLog.Location = new System.Drawing.Point(12, 12);
            this.dataGridLog.Name = "dataGridLog";
            this.dataGridLog.RowTemplate.Height = 24;
            this.dataGridLog.Size = new System.Drawing.Size(1266, 528);
            this.dataGridLog.TabIndex = 0;
            this.dataGridLog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLog_CellContentClick);
            // 
            // TipoDati
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.TipoDati.DefaultCellStyle = dataGridViewCellStyle2;
            this.TipoDati.HeaderText = "Tipo";
            this.TipoDati.Name = "TipoDati";
            this.TipoDati.ReadOnly = true;
            // 
            // Dati
            // 
            this.Dati.HeaderText = "Dati";
            this.Dati.Name = "Dati";
            this.Dati.ReadOnly = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1290, 552);
            this.Controls.Add(this.dataGridLog);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dati;
    }
}