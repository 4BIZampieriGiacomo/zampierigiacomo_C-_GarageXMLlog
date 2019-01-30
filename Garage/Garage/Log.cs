using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Garage
{
    public class Log
    {
        public StreamWriter log;
        public int nVeicoliTot = 0;
        public int nAutoTot = 0;
        public int nFurgoniTot = 0;
        public int nMotoTot = 0;

        public int tVeicoloMedio = 0;
        public int tVeicoloTot = 0;

        public int tAutoMedio = 0;
        public int tAutoTot = 0;

        public int tFurgoniMedio = 0;
        public int tFurgoneTot = 0;

        public int tMotoMedio = 0;
        public int tMotoTot = 0;

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
            string tip = "ControllaPosto";
            string azione = posiz + "," + v == null ? "null" : (v is Auto ? "Auto" : (v is Furgone ? "Furgone" : (v is Moto ? "Moto" : "null")));
            AggiornaLog(tip, azione);
        }

        public void ChiudiLog()
        {
            log.Dispose();
        }


        public void EstraiStringaDalLog()
        {
            foreach (string line in File.ReadAllLines("log.csv"))
            {
                string[] parts = line.Split(',');
                for(int i = 0; i<parts.Length; i++)
                {
                    if(parts[i] == "EntrataAuto")
                    {
                        nAutoTot++;
                    }

                    if(parts[i] == "EntrataFurgone")
                    {
                        nFurgoniTot++;
                    }

                    if(parts[i] == "EntrataMoto")
                    {
                        nMotoTot++;
                    }

                    nVeicoliTot = nAutoTot + nFurgoniTot + nMotoTot;

                    if (parts[i] == "UscitaVeicolo")
                    {
                        if(parts[i + 1].Substring(0,4) == "Auto")
                        {
                            int n1 = Convert.ToInt32(parts[4]);
                            int n2 = Convert.ToInt32(parts[5]);

                            if (n1 == 0 && n2 == 0)
                            {
                                tAutoTot = tAutoTot + 24;
                            }
                            else if ( n1 < n2 )
                            {
                                int a = n1;
                                n1 = n2;
                                n2 = a;
                                tAutoTot = tAutoTot + (n1 - n2);
                            }
                            else
                            {
                                tAutoTot = tAutoTot + (n1 - n2);
                            }
                        }

                        if (parts[i + 1] == "Furgone")
                        {
                            int n1 = Convert.ToInt32(parts[4]);
                            int n2 = Convert.ToInt32(parts[5]);

                            if (n1 == 0 && n2 == 0)
                            {
                                tFurgoneTot = tFurgoneTot + 24;
                            }
                            else if (n1 < n2)
                            {
                                int a = n1;
                                n1 = n2;
                                n2 = a;
                                tFurgoneTot = tFurgoneTot + (n1 - n2);
                            }
                            else
                            {
                                tFurgoneTot = tFurgoneTot + (n1 - n2);
                            }
                        }

                        if (parts[i + 1] == "Moto")
                        {
                            int n1 = Convert.ToInt32(parts[4]);
                            int n2 = Convert.ToInt32(parts[5]);

                            if (n1 == 0 && n2 == 0)
                            {
                                tMotoTot = tMotoTot + 24;
                            }
                            else if (n1 < n2)
                            {
                                int a = n1;
                                n1 = n2;
                                n2 = a;
                                tMotoTot = tMotoTot + (n1 - n2);
                            }
                            else
                            {
                                tMotoTot = tMotoTot + (n1 - n2);
                            }
                        }
                    }
                }
            }

            if (nAutoTot == 0)
            {
                tAutoMedio = 0;
            }
            else
            {
                tAutoMedio = tAutoTot / nAutoTot;
            }

            if (nFurgoniTot == 0)
            {
                tFurgoniMedio = 0;
            }
            else
            {
                tFurgoniMedio = tFurgoneTot / nFurgoniTot;
            }

            if (nMotoTot == 0)
            {
                tMotoMedio = 0;
            }
            else
            {
                tMotoMedio = tMotoTot / nMotoTot;
            }

            if (nVeicoliTot == 0)
            {
                tVeicoloMedio = 0;
            }
            else
            {
                tVeicoloTot = tAutoTot + tFurgoneTot + tMotoTot;
                tVeicoloMedio = tVeicoloTot / nVeicoliTot;
            }
        }
    }
}
