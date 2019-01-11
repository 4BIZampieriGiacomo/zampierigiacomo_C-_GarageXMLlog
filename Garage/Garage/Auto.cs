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
    public class Auto : Veicolo
    {
        public bool IsElettrica { get; set; }


        public override string Descrizione()
        {
            string a = "elettrica";
            string b = "";
            if(IsElettrica == true)
            {
                b = "l'auto con targa: \" " + Targa + " \" è " + a;
            }
            else
            {
                b = "l'auto con targa: \" " + Targa + " \" non è " + a;
            }
            return b;
        }

    }
}
