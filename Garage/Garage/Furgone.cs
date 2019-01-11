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
    public class Furgone:Veicolo
    {
        public int Lunghezza { get; set; }

        public override string Descrizione()
        {
            return "Il furgone con targa: \" " + Targa + " \" è lungo: " + Lunghezza;
        }




    }
}
