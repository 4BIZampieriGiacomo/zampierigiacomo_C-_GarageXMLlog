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
    public partial class Form4 : Form
    {
        public Form1 genitore;
        public int autoMoto;
        public Form4(Form1 unGenitore, int unAutoMoto)
        {
            InitializeComponent();
            genitore = unGenitore;
            autoMoto = unAutoMoto;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (autoMoto == 1)//furgone
            {
                label3.Text = "Lunghezza";
            }
            else if (autoMoto == 0)//moto
            {
                label3.Text = "Cilindrata";
            }
            else if(autoMoto == 2)//esce veicolo
            {
                label1.Enabled = false;
                label1.Visible = false;
                textBoxTarga.Enabled = false;
                textBoxTarga.Visible = false;
                label2.Text = "Ora Uscita";
                label3.Text = "Posizione";
            }
            else if(autoMoto == 3)//cerca veicolo
            {
                label2.Enabled = false;
                label2.Visible = false;
                numericOra.Enabled = false;
                numericOra.Visible = false;

                label3.Enabled = false;
                label3.Visible = false;
                numericNumero.Enabled = false;
                numericNumero.Visible = false;
            }
            else if(autoMoto == 4)//controlla posto
            {
                label1.Enabled = false;
                label1.Visible = false;
                textBoxTarga.Enabled = false;
                textBoxTarga.Visible = false;

                label2.Enabled = false;
                label2.Visible = false;
                numericOra.Enabled = false;
                numericOra.Visible = false;
                label3.Text = "Posizione";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (autoMoto == 1)//furgone
            {
                if (textBoxTarga.Text == "")
                {
                    CreaLabelCampi("Non tutti i campi sono stati inseriti correttamente");
                }
                else
                {
                    bool finito = false;
                    int i = 0;
                    while (!finito && i < 61)
                    {
                        if (i == 60)
                        {
                            Furgone f = new Furgone();
                            f.Lunghezza = (int)numericNumero.Value;
                            f.Targa = textBoxTarga.Text;
                            f.OraIngresso = (int)numericOra.Value;
                            genitore.CreaImmagineVeicolo(genitore.Garagee.EntraVeicoloNonElettrico(f), genitore.immFurgone);
                            genitore.Garagee.nVeicoli++;
                            genitore.AggiornaMessaggio(5);
                            finito = true;
                            string tipoAzione = "EntrataFurgone";
                            //...,EntrataFurgone,Lunghezza,targa,ora ingresso
                            string azione = f.Lunghezza + "," + f.Targa + "," + f.OraIngresso;
                            genitore.Garagee.AggiornaLog(tipoAzione, azione);
                            this.Close();                        }
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
            else if (autoMoto == 0)//moto
            {
                if (textBoxTarga.Text == "")
                {
                    CreaLabelCampi("Non tutti i campi sono stati inseriti correttamente");
                }
                else
                {
                    bool finito = false;
                    int i = 0;
                    while (!finito && i < 61)
                    {
                        if (i == 60)
                        {
                            Moto m = new Moto();
                            m.Targa = textBoxTarga.Text;
                            m.OraIngresso = (int)numericOra.Value;
                            m.Cilindrata = (int)numericNumero.Value;
                            genitore.CreaImmagineVeicolo(genitore.Garagee.EntraVeicoloNonElettrico(m), genitore.immMoto);
                            genitore.Garagee.nVeicoli++;
                            genitore.AggiornaMessaggio(6);
                            finito = true;
                            string tipoAzione = "EntrataMoto";
                            //...,EntrataFurgone,Lunghezza,targa,ora ingresso
                            string azione = m.Cilindrata + "," + m.Targa + "," + m.OraIngresso;
                            genitore.Garagee.AggiornaLog(tipoAzione, azione);
                            this.Close();                        }
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
            else if (autoMoto == 2)//esce veicolo
            {
                if ((int)numericNumero.Value > 59)
                {
                    CreaLabelCampi("posizione inesistente");
                }
                else
                {
                    int pos = (int)numericNumero.Value;
                    int ora = (int)numericOra.Value;
                    if (genitore.Garagee.arrVeicoli[pos] == null)
                    {
                        CreaLabelCampi("non esiste alcun veicolo in quella posizione");
                    }
                    else
                    {
                        string tipoAzione = "UscitaVeicolo";
                        //...,UscitaVeicolo,tipoVeicolo,targa,oraIngresso,oraUscita,soldiDaPagare
                        string spezzoneAzioneLog = (
                            genitore.Garagee.arrVeicoli[pos] is Auto ? "Auto" + (
                            (genitore.Garagee.arrVeicoli[pos] as Auto).IsElettrica == true ? "Elettrica" : "NonElettrica") :
                            genitore.Garagee.arrVeicoli[pos] is Furgone ? "Furgone" : "Moto") + "," + genitore.Garagee.arrVeicoli[pos].Targa + 
                            "," + genitore.Garagee.arrVeicoli[pos].OraIngresso;
                        genitore.SoldiDaPagare = genitore.Garagee.EsceVeicolo(pos, ora);
                        genitore.Garagee.nVeicoli--;
                        genitore.RimuoviImm(pos);
                        genitore.AggiornaMessaggio(1);
                        string azione =  spezzoneAzioneLog + "," + ora + "," + genitore.SoldiDaPagare;
                        genitore.Garagee.AggiornaLog(tipoAzione, azione);
                        this.Close();
                    }
                }
            }
            else if (autoMoto == 3)//cerca veicolo
            {
                if (textBoxTarga.Text == "")
                {
                    CreaLabelCampi("Non tutti i campi sono stati inseriti correttamente");
                }
                else
                {
                    string a = textBoxTarga.Text;
                    genitore.PosizioneDaCercare = genitore.Garagee.CercaVeicolo(a);
                    genitore.AggiornaMessaggio(2);
                    this.Close();
                }
            }
            else if(autoMoto == 4)//controlla posto
            {
                if((int)numericNumero.Value > 59)
                {
                    CreaLabelCampi("posto inesistente");
                }
                else
                {
                    genitore.PosizioneDaCercare = (int)numericNumero.Value;
                    genitore.AggiornaMessaggio(3);
                    this.Close();
                }
            }
        }



        public void CreaLabelCampi(string messaggio)
        {
            Label labelMess = new Label();
            labelMess.Name = "labelMess";
            labelMess.Text = messaggio;
            labelMess.TextAlign = ContentAlignment.MiddleCenter;
            labelMess.ForeColor = Color.Yellow;
            labelMess.Font = new Font(this.Font, FontStyle.Bold);
            labelMess.Width = 200;
            labelMess.Height = 50;
            Point p = new Point(30, 0);
            labelMess.Location = p;
            this.Controls.Add(labelMess);
        }
    }
}
