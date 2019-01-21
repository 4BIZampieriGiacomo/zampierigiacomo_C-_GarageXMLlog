using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Garage
{
    public class Log
    {
        public StreamWriter log;



        public void CreaLog()
        {
            if (File.Exists("log.csv"))
            {
                log = new StreamWriter("log.csv", append: true);
            }
            else
            {
                log = new StreamWriter("log.csv", append: false);
            }
        }

        public void AggiornaLog(string tipo, string azione)
        {
            string oraAzione = Convert.ToString(DateTime.Now);
            string tipoAzione = tipo;
            string azioneEffettuata = azione;
            string lg = oraAzione + "," + tipoAzione + (azioneEffettuata == "" ? "" : ",") + azioneEffettuata;
            log.WriteLine(lg);
        }

        public void ControllaPostoLog(Veicolo v, int posiz)
        {
            string tip = "Controlla posto";
            string azione = posiz + "," + v == null ? "null" : (v is Auto ? "Auto" : (v is Furgone ? "Furgone" : (v is Moto ? "Moto" : "null")));
            AggiornaLog(tip, azione);
        }

        public void ChiudiLog()
        {
            log.Dispose();
        }


        public void EstraiStringaDalLog()
        {
            int i = 0;
            foreach (string line in File.ReadAllLines("log.csv"))
            {
                string[] parts = line.Split(',');
                //foreach (string part in parts)
                //{
                //    Console.WriteLine("{0}:{1}",
                //        i,
                //        part);
                //}
                //i++;
            }
        }
    }
}
