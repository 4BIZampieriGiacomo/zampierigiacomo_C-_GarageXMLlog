namespace Garage
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelOra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTarga = new System.Windows.Forms.TextBox();
            this.checkBoxIsElettrica = new System.Windows.Forms.CheckBox();
            this.numericOra = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericOra)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(123, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelOra
            // 
            this.labelOra.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOra.ForeColor = System.Drawing.Color.White;
            this.labelOra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOra.Location = new System.Drawing.Point(44, 94);
            this.labelOra.Name = "labelOra";
            this.labelOra.Size = new System.Drawing.Size(125, 23);
            this.labelOra.TabIndex = 18;
            this.labelOra.Text = "Ora Ingresso";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Targa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxTarga
            // 
            this.textBoxTarga.Location = new System.Drawing.Point(175, 61);
            this.textBoxTarga.Name = "textBoxTarga";
            this.textBoxTarga.Size = new System.Drawing.Size(100, 22);
            this.textBoxTarga.TabIndex = 19;
            // 
            // checkBoxIsElettrica
            // 
            this.checkBoxIsElettrica.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsElettrica.ForeColor = System.Drawing.Color.White;
            this.checkBoxIsElettrica.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkBoxIsElettrica.Location = new System.Drawing.Point(61, 131);
            this.checkBoxIsElettrica.Name = "checkBoxIsElettrica";
            this.checkBoxIsElettrica.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxIsElettrica.Size = new System.Drawing.Size(130, 24);
            this.checkBoxIsElettrica.TabIndex = 21;
            this.checkBoxIsElettrica.Text = "È elettrica";
            this.checkBoxIsElettrica.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxIsElettrica.UseVisualStyleBackColor = true;
            // 
            // numericOra
            // 
            this.numericOra.Location = new System.Drawing.Point(175, 95);
            this.numericOra.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericOra.Name = "numericOra";
            this.numericOra.Size = new System.Drawing.Size(120, 22);
            this.numericOra.TabIndex = 22;
            this.numericOra.ValueChanged += new System.EventHandler(this.numericOra_ValueChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(342, 253);
            this.Controls.Add(this.numericOra);
            this.Controls.Add(this.checkBoxIsElettrica);
            this.Controls.Add(this.textBoxTarga);
            this.Controls.Add(this.labelOra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "Garage";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericOra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelOra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTarga;
        private System.Windows.Forms.CheckBox checkBoxIsElettrica;
        private System.Windows.Forms.NumericUpDown numericOra;
    }
}