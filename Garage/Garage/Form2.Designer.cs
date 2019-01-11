namespace Garage
{
    partial class Form2
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.numercTAuto = new System.Windows.Forms.NumericUpDown();
            this.numericTFurgoni = new System.Windows.Forms.NumericUpDown();
            this.numericTMoto = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numercTAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTFurgoni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTMoto)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOK.ForeColor = System.Drawing.Color.White;
            this.buttonOK.Location = new System.Drawing.Point(124, 164);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(102, 46);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.ForeColor = System.Drawing.Color.White;
            this.labelA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelA.Location = new System.Drawing.Point(22, 60);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(161, 20);
            this.labelA.TabIndex = 4;
            this.labelA.Text = "Tariffa per le Auto";
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelF.ForeColor = System.Drawing.Color.White;
            this.labelF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelF.Location = new System.Drawing.Point(5, 88);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(178, 20);
            this.labelF.TabIndex = 5;
            this.labelF.Text = "Tariffa per i Furgoni";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.ForeColor = System.Drawing.Color.White;
            this.labelM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelM.Location = new System.Drawing.Point(20, 116);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(163, 20);
            this.labelM.TabIndex = 6;
            this.labelM.Text = "Tariffa per le Moto";
            // 
            // numercTAuto
            // 
            this.numercTAuto.Location = new System.Drawing.Point(206, 58);
            this.numercTAuto.Name = "numercTAuto";
            this.numercTAuto.Size = new System.Drawing.Size(120, 22);
            this.numercTAuto.TabIndex = 7;
            // 
            // numericTFurgoni
            // 
            this.numericTFurgoni.Location = new System.Drawing.Point(206, 86);
            this.numericTFurgoni.Name = "numericTFurgoni";
            this.numericTFurgoni.Size = new System.Drawing.Size(120, 22);
            this.numericTFurgoni.TabIndex = 8;
            // 
            // numericTMoto
            // 
            this.numericTMoto.Location = new System.Drawing.Point(206, 114);
            this.numericTMoto.Name = "numericTMoto";
            this.numericTMoto.Size = new System.Drawing.Size(120, 22);
            this.numericTMoto.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(335, 222);
            this.Controls.Add(this.numericTMoto);
            this.Controls.Add(this.numericTFurgoni);
            this.Controls.Add(this.numercTAuto);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelF);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.buttonOK);
            this.Name = "Form2";
            this.Text = "Garage";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numercTAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTFurgoni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericTMoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.NumericUpDown numercTAuto;
        private System.Windows.Forms.NumericUpDown numericTFurgoni;
        private System.Windows.Forms.NumericUpDown numericTMoto;
    }
}