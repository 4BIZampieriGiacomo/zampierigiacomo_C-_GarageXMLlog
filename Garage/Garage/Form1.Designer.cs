namespace Garage
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMessaggio = new System.Windows.Forms.Label();
            this.CreaGarage = new System.Windows.Forms.Button();
            this.butEntraAuto = new System.Windows.Forms.Button();
            this.butEntraFurgone = new System.Windows.Forms.Button();
            this.buttonEntraMoto = new System.Windows.Forms.Button();
            this.buttonEsceVeicolo = new System.Windows.Forms.Button();
            this.butCercaVeicolo = new System.Windows.Forms.Button();
            this.butControllaPosto = new System.Windows.Forms.Button();
            this.labelTariffe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPostiLiberi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butApri = new System.Windows.Forms.Button();
            this.butSalva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMessaggio
            // 
            this.labelMessaggio.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessaggio.ForeColor = System.Drawing.Color.Yellow;
            this.labelMessaggio.Location = new System.Drawing.Point(12, 9);
            this.labelMessaggio.Name = "labelMessaggio";
            this.labelMessaggio.Size = new System.Drawing.Size(1575, 41);
            this.labelMessaggio.TabIndex = 3;
            this.labelMessaggio.Text = "La sosta in questo parcheggio non può protrarsi oltre le 24 ore consecutive!!";
            this.labelMessaggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMessaggio.Click += new System.EventHandler(this.labelMessaggio_Click);
            // 
            // CreaGarage
            // 
            this.CreaGarage.BackColor = System.Drawing.Color.RoyalBlue;
            this.CreaGarage.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreaGarage.ForeColor = System.Drawing.Color.White;
            this.CreaGarage.Location = new System.Drawing.Point(44, 624);
            this.CreaGarage.Margin = new System.Windows.Forms.Padding(1);
            this.CreaGarage.Name = "CreaGarage";
            this.CreaGarage.Size = new System.Drawing.Size(137, 50);
            this.CreaGarage.TabIndex = 4;
            this.CreaGarage.Text = "Modifica tariffe";
            this.CreaGarage.UseVisualStyleBackColor = false;
            this.CreaGarage.Click += new System.EventHandler(this.CreaGarage_Click);
            // 
            // butEntraAuto
            // 
            this.butEntraAuto.BackColor = System.Drawing.Color.RoyalBlue;
            this.butEntraAuto.Enabled = false;
            this.butEntraAuto.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEntraAuto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.butEntraAuto.Location = new System.Drawing.Point(185, 624);
            this.butEntraAuto.Name = "butEntraAuto";
            this.butEntraAuto.Size = new System.Drawing.Size(137, 50);
            this.butEntraAuto.TabIndex = 11;
            this.butEntraAuto.Text = "Entra un auto";
            this.butEntraAuto.UseVisualStyleBackColor = false;
            this.butEntraAuto.Click += new System.EventHandler(this.Button1_Click);
            // 
            // butEntraFurgone
            // 
            this.butEntraFurgone.BackColor = System.Drawing.Color.RoyalBlue;
            this.butEntraFurgone.Enabled = false;
            this.butEntraFurgone.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEntraFurgone.ForeColor = System.Drawing.Color.White;
            this.butEntraFurgone.Location = new System.Drawing.Point(328, 624);
            this.butEntraFurgone.Name = "butEntraFurgone";
            this.butEntraFurgone.Size = new System.Drawing.Size(137, 50);
            this.butEntraFurgone.TabIndex = 17;
            this.butEntraFurgone.Text = "Entra un furgone";
            this.butEntraFurgone.UseVisualStyleBackColor = false;
            this.butEntraFurgone.Click += new System.EventHandler(this.butEntraFurgone_Click);
            // 
            // buttonEntraMoto
            // 
            this.buttonEntraMoto.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEntraMoto.Enabled = false;
            this.buttonEntraMoto.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntraMoto.ForeColor = System.Drawing.Color.White;
            this.buttonEntraMoto.Location = new System.Drawing.Point(471, 624);
            this.buttonEntraMoto.Name = "buttonEntraMoto";
            this.buttonEntraMoto.Size = new System.Drawing.Size(137, 50);
            this.buttonEntraMoto.TabIndex = 18;
            this.buttonEntraMoto.Text = "Entra una moto";
            this.buttonEntraMoto.UseVisualStyleBackColor = false;
            this.buttonEntraMoto.Click += new System.EventHandler(this.buttonEntraMoto_Click);
            // 
            // buttonEsceVeicolo
            // 
            this.buttonEsceVeicolo.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonEsceVeicolo.Enabled = false;
            this.buttonEsceVeicolo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEsceVeicolo.ForeColor = System.Drawing.Color.White;
            this.buttonEsceVeicolo.Location = new System.Drawing.Point(614, 624);
            this.buttonEsceVeicolo.Name = "buttonEsceVeicolo";
            this.buttonEsceVeicolo.Size = new System.Drawing.Size(137, 50);
            this.buttonEsceVeicolo.TabIndex = 19;
            this.buttonEsceVeicolo.Text = "Esce un veicolo";
            this.buttonEsceVeicolo.UseVisualStyleBackColor = false;
            this.buttonEsceVeicolo.Click += new System.EventHandler(this.buttonEsceVeicolo_Click);
            // 
            // butCercaVeicolo
            // 
            this.butCercaVeicolo.BackColor = System.Drawing.Color.RoyalBlue;
            this.butCercaVeicolo.Enabled = false;
            this.butCercaVeicolo.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCercaVeicolo.ForeColor = System.Drawing.Color.White;
            this.butCercaVeicolo.Location = new System.Drawing.Point(757, 624);
            this.butCercaVeicolo.Name = "butCercaVeicolo";
            this.butCercaVeicolo.Size = new System.Drawing.Size(137, 50);
            this.butCercaVeicolo.TabIndex = 20;
            this.butCercaVeicolo.Text = "Cerca un veicolo";
            this.butCercaVeicolo.UseVisualStyleBackColor = false;
            this.butCercaVeicolo.Click += new System.EventHandler(this.butCercaVeicolo_Click);
            // 
            // butControllaPosto
            // 
            this.butControllaPosto.BackColor = System.Drawing.Color.RoyalBlue;
            this.butControllaPosto.Enabled = false;
            this.butControllaPosto.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butControllaPosto.ForeColor = System.Drawing.Color.White;
            this.butControllaPosto.Location = new System.Drawing.Point(900, 624);
            this.butControllaPosto.Name = "butControllaPosto";
            this.butControllaPosto.Size = new System.Drawing.Size(137, 50);
            this.butControllaPosto.TabIndex = 21;
            this.butControllaPosto.Text = "Controlla un posto";
            this.butControllaPosto.UseVisualStyleBackColor = false;
            this.butControllaPosto.Click += new System.EventHandler(this.butControllaPosto_Click);
            // 
            // labelTariffe
            // 
            this.labelTariffe.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTariffe.ForeColor = System.Drawing.Color.Yellow;
            this.labelTariffe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTariffe.Location = new System.Drawing.Point(12, 68);
            this.labelTariffe.Name = "labelTariffe";
            this.labelTariffe.Size = new System.Drawing.Size(180, 94);
            this.labelTariffe.TabIndex = 22;
            this.labelTariffe.Text = "Tariffe";
            this.labelTariffe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTariffe.Click += new System.EventHandler(this.labelTariffe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "0~14";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(209, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "15~29";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(209, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "30~44";
            // 
            // lblPostiLiberi
            // 
            this.lblPostiLiberi.Font = new System.Drawing.Font("Modern No. 20", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostiLiberi.ForeColor = System.Drawing.Color.White;
            this.lblPostiLiberi.Location = new System.Drawing.Point(14, 527);
            this.lblPostiLiberi.Name = "lblPostiLiberi";
            this.lblPostiLiberi.Size = new System.Drawing.Size(181, 64);
            this.lblPostiLiberi.TabIndex = 28;
            this.lblPostiLiberi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(211, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "45~59";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Garage.Properties.Resources.Parcheggio2___Copia;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(270, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1220, 523);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // butApri
            // 
            this.butApri.BackColor = System.Drawing.Color.RoyalBlue;
            this.butApri.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butApri.ForeColor = System.Drawing.Color.White;
            this.butApri.Location = new System.Drawing.Point(1266, 624);
            this.butApri.Name = "butApri";
            this.butApri.Size = new System.Drawing.Size(137, 50);
            this.butApri.TabIndex = 30;
            this.butApri.Text = "Apri Salvataggio";
            this.butApri.UseVisualStyleBackColor = false;
            this.butApri.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // butSalva
            // 
            this.butSalva.BackColor = System.Drawing.Color.RoyalBlue;
            this.butSalva.Enabled = false;
            this.butSalva.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalva.ForeColor = System.Drawing.Color.White;
            this.butSalva.Location = new System.Drawing.Point(1427, 624);
            this.butSalva.Name = "butSalva";
            this.butSalva.Size = new System.Drawing.Size(137, 50);
            this.butSalva.TabIndex = 31;
            this.butSalva.Text = "Salva";
            this.butSalva.UseVisualStyleBackColor = false;
            this.butSalva.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1632, 693);
            this.Controls.Add(this.butSalva);
            this.Controls.Add(this.butApri);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPostiLiberi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTariffe);
            this.Controls.Add(this.butControllaPosto);
            this.Controls.Add(this.butCercaVeicolo);
            this.Controls.Add(this.buttonEsceVeicolo);
            this.Controls.Add(this.buttonEntraMoto);
            this.Controls.Add(this.butEntraFurgone);
            this.Controls.Add(this.butEntraAuto);
            this.Controls.Add(this.CreaGarage);
            this.Controls.Add(this.labelMessaggio);
            this.Name = "Form1";
            this.Text = "Garage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Chiusura);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMessaggio;
        private System.Windows.Forms.Button CreaGarage;
        private System.Windows.Forms.Button butEntraAuto;
        private System.Windows.Forms.Button butEntraFurgone;
        private System.Windows.Forms.Button buttonEntraMoto;
        private System.Windows.Forms.Button buttonEsceVeicolo;
        private System.Windows.Forms.Button butCercaVeicolo;
        private System.Windows.Forms.Button butControllaPosto;
        private System.Windows.Forms.Label labelTariffe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPostiLiberi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butApri;
        private System.Windows.Forms.Button butSalva;
    }
}

