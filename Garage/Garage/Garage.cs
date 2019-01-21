using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Garage
{
    [Serializable]
    public class Garage
    {
        public Veicolo[] arrVeicoli { get; set; }
        public int nVeicoli { get; set; }
        public int TariffaAuto { get; set; }
        public int TariffaFurgoni { get; set; }
        public int TariffaMoto { get; set; }
        public Log l = new Log();

        public Garage()
        {
            arrVeicoli = new Veicolo[60];
            nVeicoli = 0;
        }



        public int EntraVeicoloElettrico(Veicolo unVeicolo)
        {
            int posizione = -1;
            bool finito = false;
            int i = 0;
            while (!finito)
            {
                if (arrVeicoli[i] == null)
                {
                    arrVeicoli[i] = unVeicolo;
                    nVeicoli++;
                    posizione = i;
                    finito = true;
                }
                else
                {
                    i++;
                }

                if (i == 60)
                {
                    finito = true;
                }
            }
            return posizione;
        }



        public int EntraVeicoloNonElettrico(Veicolo unVeicolo)
        {
            int posizione = -1;
            bool finito = false;
            int i = 10;
            while (!finito)
            {
                if (arrVeicoli[i] == null)
                {
                    arrVeicoli[i] = unVeicolo;
                    nVeicoli++;
                    posizione = i;
                    finito = true;
                }
                else
                {
                    i++;
                }

                if (i == 60)
                {
                    finito = true;
                }
            }
            return posizione;
        }


        public int EsceVeicolo(int posizione, int oraUscita)
        {
            int soldiDaPagare = 0;
            int oreDiParcheggio = 0;
            if (arrVeicoli[posizione].OraIngresso == oraUscita)
            {
                oreDiParcheggio = 24;
            }
            else if (arrVeicoli[posizione].OraIngresso > oraUscita)
            {
                oreDiParcheggio = oraUscita - arrVeicoli[posizione].OraIngresso + 24;
            }
            else
            {
                oreDiParcheggio = oraUscita - arrVeicoli[posizione].OraIngresso;
            }

            if (arrVeicoli[posizione] is Auto)
            {
                soldiDaPagare = oreDiParcheggio * TariffaAuto;
                arrVeicoli[posizione] = null;
            }

            if (arrVeicoli[posizione] is Furgone)
            {
                soldiDaPagare = oreDiParcheggio * TariffaFurgoni;
                arrVeicoli[posizione] = null;
            }

            if (arrVeicoli[posizione] is Moto)
            {
                soldiDaPagare = oreDiParcheggio * TariffaMoto;
                arrVeicoli[posizione] = null;
            }

            return soldiDaPagare;
        }

        public int CercaVeicolo(string targa)
        {
            int posizione = -1;
            bool finito = false;
            int i = 0;
            while (!finito)
            {
                if(i > 59)
                {

                    finito = true;
                }
                else if (arrVeicoli[i] == null)
                {
                    i++;
                }
                else
                {
                    if (arrVeicoli[i].Targa == targa)
                    {
                        posizione = i;
                        finito = true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return posizione;
        }

        public void RicreaImmGarage()
        {
            Form1 g = new Form1();
            for(int i = 0; i<60; i++)
            {
                if(arrVeicoli[i] != null)
                {
                    if(arrVeicoli[i] is Auto)
                    {
                        if((arrVeicoli[i] as Auto).IsElettrica == true)
                        {
                            g.CreaImmagineVeicolo(i,g.immAutoElettrica);
                        }
                        else
                        {
                            g.CreaImmagineVeicolo(i, g.immAutoNonElettrica);
                        }
                    }

                    if(arrVeicoli[i] is Furgone)
                    {
                        g.CreaImmagineVeicolo(i, g.immFurgone);
                    }

                    if(arrVeicoli[i] is Moto)
                    {
                        g.CreaImmagineVeicolo(i, g.immMoto);
                    }
                }
            }
        }

        public void SalvaXML(Garage g)
        {
            StreamWriter file = new StreamWriter("garage.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(Garage));
            serializer.Serialize(file, g);
            file.Close();
            string tipoAzione = "Salvataggio";
            string azione = "";
            l.AggiornaLog(tipoAzione, azione);
        }

        public void CaricaXML(Garage g1)
        {
            if (File.Exists("garage.xml"))
            {
                Garage g = new Garage();
                StreamReader file = new StreamReader("garage.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(Garage));
                g = (Garage)serializer.Deserialize(file);
                TariffaAuto = g.TariffaAuto;
                TariffaFurgoni = g.TariffaFurgoni;
                TariffaMoto = g.TariffaMoto;
                arrVeicoli = g.arrVeicoli;
                nVeicoli = g.nVeicoli;
                g1 = g;
                file.Close();
                string tipoAzione = "Apertura file";
                string azione = "";
                l.AggiornaLog(tipoAzione, azione);
            }
        }
    }
}
