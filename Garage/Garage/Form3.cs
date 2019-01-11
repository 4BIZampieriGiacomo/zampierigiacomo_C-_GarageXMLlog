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
    public partial class Form3 : Form
    {
        public Form1 genitore;
        public Form3(Form1 unGenitore)
        {
            InitializeComponent();
            genitore = unGenitore;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxTarga.Text == "")
            {
                Label labelMess = new Label();
                labelMess.Name = "labelMess";
                labelMess.Text = "Non tutti i campi sono stati inseriti correttamente";
                labelMess.TextAlign = ContentAlignment.MiddleCenter;
                labelMess.ForeColor = Color.Yellow;
                labelMess.Font = new Font(this.Font, FontStyle.Bold);
                labelMess.Width = 200;
                labelMess.Height = 50;
                Point p = new Point(30, 0);
                labelMess.Location = p;
                this.Controls.Add(labelMess);
            }
            else
            {
                bool finito = false;
                int i = 0;
                while (!finito && i < 61)
                {
                    if (i == 60)
                    {
                        Auto a = new Auto();
                        a.IsElettrica = checkBoxIsElettrica.Checked;
                        a.Targa = textBoxTarga.Text;
                        a.OraIngresso = (int)numericOra.Value;
                        if (checkBoxIsElettrica.Checked == true)
                        {
                            genitore.CreaImmagineVeicolo(genitore.Garagee.EntraVeicoloElettrico(a), genitore.immAutoElettrica);
                        }
                        else
                        {
                            genitore.CreaImmagineVeicolo(genitore.Garagee.EntraVeicoloNonElettrico(a), genitore.immAutoNonElettrica);
                        }
                        genitore.AggiornaMessaggio(4);
                        finito = true;
                        string tipoAzione = "EntrataAuto";
                        //...,EntrataAuto,è/non è elettrica,targa,ora ingresso
                        string azione = (a.IsElettrica == true ? "Elettrica" : "NonElettrica") + "," + a.Targa + "," + a.OraIngresso;
                        genitore.Garagee.AggiornaLog(tipoAzione, azione);
                        this.Close();
                    }
                    else if (genitore.Garagee.arrVeicoli[i] == null)
                    {
                        i++;
                    }
                    else if (genitore.Garagee.arrVeicoli[i].Targa == textBoxTarga.Text)
                    {
                        Label labelMess = new Label();
                        labelMess.Name = "labelMess";
                        labelMess.Text = "É già presente un veicolo con la targa: \"" + textBoxTarga.Text + "\"";
                        labelMess.TextAlign = ContentAlignment.MiddleCenter;
                        labelMess.ForeColor = Color.Yellow;
                        labelMess.Font = new Font(this.Font, FontStyle.Bold);
                        labelMess.Width = 200;
                        labelMess.Height = 50;
                        Point p = new Point(30, 0);
                        labelMess.Location = p;
                        this.Controls.Add(labelMess);
                        finito = true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }

        private void numericOra_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
