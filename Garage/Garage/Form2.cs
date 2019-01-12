using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage
{
    [Serializable]
    public partial class Form2 : Form
    {
        public Form1 genitore;
        public Form2(Form1 unGenitore)
        {
            InitializeComponent();
            genitore = unGenitore;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if ((int)numercTAuto.Value == 0 || (int)numericTFurgoni.Value == 0 || (int)numericTMoto.Value == 0)
            {
                Label labelMess = new Label();
                labelMess.Name = "labelMess";
                labelMess.Text = "Inserisci tutte le tariffe";
                labelMess.ForeColor = Color.Yellow;
                labelMess.Font = new Font(this.Font, FontStyle.Bold);
                labelMess.Width = 200;
                labelMess.Height = 50;
                Point p = new Point(60, 20);
                labelMess.Location = p;
                this.Controls.Add(labelMess);
                string tipo = "Cambio tariffe fallito";
                //primi 3 valori non idonei
                string azione = (int)numercTAuto.Value + "," + (int)numericTFurgoni.Value + "," + (int)numericTMoto.Value;
                genitore.Garagee.AggiornaLog(tipo, azione);
            }
            else
            {
                string oldTAuto = genitore.Garagee.TariffaAuto.ToString();
                string oldTFurgoni = genitore.Garagee.TariffaFurgoni.ToString();
                string oldMoto = genitore.Garagee.TariffaMoto.ToString();
                genitore.Garagee.TariffaAuto = (int)numercTAuto.Value;                                                                                     
                genitore.Garagee.TariffaFurgoni = (int)numericTFurgoni.Value;                                                                                    
                genitore.Garagee.TariffaMoto = (int)numericTMoto.Value;
                genitore.AggiornaMessaggio(0);
                genitore.AbilitaBottoni();
                string tipo = "Cambio tariffe";
                //primi 3 valori vecchi - ultimi 3 valori nuovi
                string azione = oldTAuto + "," + oldTFurgoni + "," + oldMoto + "," + genitore.Garagee.TariffaAuto + "," + genitore.Garagee.TariffaFurgoni + "," + genitore.Garagee.TariffaMoto;
                genitore.Garagee.AggiornaLog(tipo,azione);
                this.Close();
            }
        }
    }
}
