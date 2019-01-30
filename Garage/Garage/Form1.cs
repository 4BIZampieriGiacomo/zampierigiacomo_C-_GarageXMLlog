using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Garage
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Garage Garagee { get; set; }
        public Log lg = new Log();
        public double SoldiDaPagare { get; set; }
        public int PosizioneDaCercare { get; set; }

        public Image immAutoElettrica = Properties.Resources.AutoElettrica;
        public Image immAutoNonElettrica = Properties.Resources.AutoNonElettrica;
        public Image immFurgone = Properties.Resources.Furgone;
        public Image immMoto = Properties.Resources.Moto;

        public Form1()
        {
            InitializeComponent();
            Garagee = new Garage();
            lg.EstraiStringaDalLog();
            lg.CreaLog();
            string tipo = "AperturaProgramma";
            string azione = "";
            lg.AggiornaLog(tipo, azione);
            CreaGarage.Enabled = true;
            butEntraAuto.Enabled = false;
            butEntraFurgone.Enabled = false;
            buttonEntraMoto.Enabled = false;
            buttonEsceVeicolo.Enabled = false;
            butCercaVeicolo.Enabled = false;
            butControllaPosto.Enabled = false;
            butSalva.Enabled = false;
            lblPostiLiberi.Text = "Posti disponibili: 60";
        }


        public void labelMessaggio_Click(object sender, EventArgs e)
        {

        }

        public void CreaGarage_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(this);
            f.Show();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void TextBoxTFurgone_TextChanged(object sender, EventArgs e)
        {

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            if (Garagee.nVeicoli == 60)
            {
                labelMessaggio.Text = "il parcheggio è pieno";
            }
            else
            {
                f3.Show();
            }
        }

        public void textBoxOra_TextChanged(object sender, EventArgs e)
        {

        }

        public void butEntraFurgone_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this, 1);
            if (Garagee.nVeicoli == 60)
            {
                labelMessaggio.Text = "il parcheggio è pieno";
            }
            else
            {
                f4.Show();
            }
        }

        public void buttonEntraMoto_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this, 0);
            if (Garagee.nVeicoli == 60)
            {
                labelMessaggio.Text = "il parcheggio è pieno";
            }
            else
            {
                f4.Show();
            }
        }

        public void buttonEsceVeicolo_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this, 2);
            if (Garagee.nVeicoli == 0)
            {
                labelMessaggio.Text = "il parcheggio è vuoto";
            }
            else
            {
                f4.Show();
            }
        }

        public void butCercaVeicolo_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this, 3);
            if (Garagee.nVeicoli == 0)
            {
                labelMessaggio.Text = "il parcheggio è vuoto";
            }
            else
            {
                f4.Show();
            }
        }

        public void butControllaPosto_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this, 4);
            if (Garagee.nVeicoli == 0)
            {
                labelMessaggio.Text = "il parcheggio è vuoto";
                string tipo = "Controlla posto";
                //...,Controlla posto,posizione
                string azione = "Parcheggio vuoto";
                lg.AggiornaLog(tipo, azione);
            }
            else
            {
                f4.Show();
            }
        }

        public void labelTariffe_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            AbilitaBottoni();
            Garagee.CaricaXML(Garagee);
            labelMessaggio.Text = "Il file è stato caricato con successo";
            AggiornaMessaggio(0);
            for (int i = 0; i < Garagee.arrVeicoli.Length; i++)
            {
                if (Garagee.arrVeicoli[i] != null)
                {
                    if (Garagee.arrVeicoli[i] is Auto)
                    {
                        if ((Garagee.arrVeicoli[i] as Auto).IsElettrica == true)
                        {
                            CreaImmagineVeicolo(i, immAutoElettrica);
                        }
                        else
                        {
                            CreaImmagineVeicolo(i, immAutoNonElettrica);
                        }
                    }
                    else if (Garagee.arrVeicoli[i] is Furgone)
                    {
                        CreaImmagineVeicolo(i, immFurgone);
                    }
                    else if (Garagee.arrVeicoli[i] is Moto)
                    {
                        CreaImmagineVeicolo(i, immMoto);
                    }
                }
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {

            Garagee.SalvaXML(Garagee);
            labelMessaggio.Text = "Il file è stato salvato";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(this);
            if (File.Exists("log.csv"))
            {
                f5.Show();
            }
            else
            {
                labelMessaggio.Text = "Non esiste il file log";
            }
        }

        public void AggiornaMessaggio(int tipo)
        {
            if (tipo == 0)//tariffe
            {
                labelTariffe.Text = "Tariffa Auto: " + Garagee.TariffaAuto + "€" + '\n' + "Tariffa Furgone: " + Garagee.TariffaFurgoni + "€" + '\n' + "Tariffa Moto: " + Garagee.TariffaMoto + "€";
            }

            if (tipo == 1)//pagamento all'uscita
            {
                labelMessaggio.Text = "il veicolo è uscito dal garage, deve pagare: €" + Convert.ToString(SoldiDaPagare);
                lblPostiLiberi.Text = "Posti disponibili: " + (60 - Garagee.nVeicoli);
            }

            if (tipo == 2)//cerca veicolo
            {
                if (PosizioneDaCercare == -1)
                {
                    labelMessaggio.Text = "non vi è alcun veicolo con la corrispondente targa";
                }
                else
                {
                    labelMessaggio.Text = Garagee.arrVeicoli[PosizioneDaCercare].Descrizione() + " ed è presente nella posizione: " + PosizioneDaCercare;
                }
            }

            if (tipo == 3)//controlla posto
            {
                string descriz = "";
                if (Garagee.arrVeicoli[PosizioneDaCercare] == null)
                {
                    descriz = "il posto è vuoto";
                    lg.ControllaPostoLog(Garagee.arrVeicoli[PosizioneDaCercare], PosizioneDaCercare);
                }
                else
                {
                    if (Garagee.arrVeicoli[PosizioneDaCercare] is Auto)
                    {
                        descriz = "è presente un Auto con targa: \" " + Garagee.arrVeicoli[PosizioneDaCercare].Targa + " \"";
                    }

                    if (Garagee.arrVeicoli[PosizioneDaCercare] is Furgone)
                    {
                        descriz = "è presente un Furgone con targa: \" " + Garagee.arrVeicoli[PosizioneDaCercare].Targa + " \"";
                    }

                    if (Garagee.arrVeicoli[PosizioneDaCercare] is Moto)
                    {
                        descriz = "è presente un Moto con targa: \" " + Garagee.arrVeicoli[PosizioneDaCercare].Targa + " \"";
                    }
                    lg.ControllaPostoLog(Garagee.arrVeicoli[PosizioneDaCercare], PosizioneDaCercare);
                }
                labelMessaggio.Text = descriz;
            }

            if (tipo == 4)//entra auto
            {
                labelMessaggio.Text = "l'auto è entrata nel garage";
                lblPostiLiberi.Text = "Posti disponibili: " + (60 - Garagee.nVeicoli);
            }

            if (tipo == 5)//entra furgone
            {
                labelMessaggio.Text = "il furgone è entrato nel garage";
                lblPostiLiberi.Text = "Posti disponibili: " + (60 - Garagee.nVeicoli);
            }

            if (tipo == 6)//entra moto
            {
                labelMessaggio.Text = "la moto è entrata nel garage";
                lblPostiLiberi.Text = "Posti disponibili: " + (60 - Garagee.nVeicoli);
            }
        }

        public void AbilitaBottoni()
        {
            butEntraAuto.Enabled = true;
            butEntraFurgone.Enabled = true;
            buttonEntraMoto.Enabled = true;
            buttonEsceVeicolo.Enabled = true;
            butCercaVeicolo.Enabled = true;
            butControllaPosto.Enabled = true;
            butSalva.Enabled = true;
            Statistiche.Enabled = true;
        }

        public void CreaImmagineVeicolo(int posiz, Image veicolo)
        {
            if (posiz < 10)
            {
                PictureBox pb = new PictureBox();
                pb.Name = "Veicolo" + posiz;
                pb.Image = immAutoElettrica;
                pb.Width = 52;
                pb.Height = 75;
                int x = 5 + (posiz * 61);
                int y = 10;
                Point p = new Point(x, y);
                pb.Location = p;
                pb.Tag = posiz;
                pictureBox1.Controls.Add(pb);
                pb.Click += new EventHandler(daiDescrizione);
            }
            else if (posiz < 15)
            {
                PictureBox pb = new PictureBox();
                pb.Name = "Veicolo" + posiz;
                pb.Image = veicolo;
                pb.Width = 52;
                pb.Height = 75;
                int x = 5 + (posiz * 61);
                int y = 10;
                Point p = new Point(x, y);
                pb.Location = p;
                pb.Tag = posiz;
                pictureBox1.Controls.Add(pb);
                pb.Click += new EventHandler(daiDescrizione);
            }
            else if (posiz < 30)
            {
                PictureBox pb = new PictureBox();
                pb.Name = "Veicolo" + posiz;
                pb.Image = veicolo;
                pb.Width = 52;
                pb.Height = 75;
                int x = 5 + ((posiz - 15) * 61);
                int y = 97;
                Point p = new Point(x, y);
                pb.Location = p;
                pb.Tag = posiz;
                pictureBox1.Controls.Add(pb);
                pb.Click += new EventHandler(daiDescrizione);
            }
            else if (posiz < 45)
            {
                PictureBox pb = new PictureBox();
                pb.Name = "Veicolo" + posiz;
                pb.Image = veicolo;
                pb.Width = 52;
                pb.Height = 75;
                int x = 5 + ((posiz - 30) * 61);
                int y = 252;
                Point p = new Point(x, y);
                pb.Location = p;
                pb.Tag = posiz;
                pictureBox1.Controls.Add(pb);
                pb.Click += new EventHandler(daiDescrizione);
            }
            else
            {
                PictureBox pb = new PictureBox();
                pb.Name = "Veicolo" + posiz;
                pb.Image = veicolo;
                pb.Width = 52;
                pb.Height = 75;
                int x = 5 + ((posiz - 45) * 61);
                int y = 340;
                Point p = new Point(x, y);
                pb.Location = p;
                pb.Tag = posiz;
                pictureBox1.Controls.Add(pb);
                pb.Click += new EventHandler(daiDescrizione);
            }
        }

        public void RimuoviImm(int posiz)
        {
            foreach (PictureBox p in pictureBox1.Controls)
            {
                if ((int)p.Tag == posiz)
                {
                    pictureBox1.Controls.Remove(p);
                }
            }
        }

        public void DammiDescrizione(int p)
        {
            labelMessaggio.Text = Garagee.arrVeicoli[p].Descrizione();
        }

        public void daiDescrizione(object sender, EventArgs e)
        {
            DammiDescrizione((int)(((PictureBox)sender).Tag));
            string type = "RichiestaDescrizione";
            string pos = Convert.ToString(((PictureBox)sender).Tag);
            lg.AggiornaLog(type,pos);
        }

        private void Chiusura(object sender, FormClosingEventArgs e)
        {
            //Alla chiusura del programma salva tutte le attività nel file log
            string tipo = "ChiusuraProgramma";
            string azione = "";
            lg.AggiornaLog(tipo, azione);
            lg.ChiudiLog();
        }
    }
}
