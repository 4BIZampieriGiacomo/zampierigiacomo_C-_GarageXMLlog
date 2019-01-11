using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Garage
{
    [XmlInclude(typeof(Auto))]
    [XmlInclude(typeof(Moto))]
    [XmlInclude(typeof(Furgone))]
    [Serializable]
    public abstract class Veicolo: IEquatable<Veicolo>
    {
        public string Targa { get; set; }
        public int OraIngresso { get; set; }



        public abstract string Descrizione();

        public bool Equals(Veicolo altroVeicolo)
        {
            return this.Targa.Equals(altroVeicolo.Targa);
        }
    }
}
