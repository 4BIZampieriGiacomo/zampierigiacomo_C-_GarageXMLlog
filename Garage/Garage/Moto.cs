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
    public class Moto :Veicolo
    {
        public int Cilindrata { get; set; }

        public override string Descrizione()
        {
            return "La moto con targa: \" " + Targa + " \" ha " + Cilindrata + " di cilindrata";
        }




    }
}
