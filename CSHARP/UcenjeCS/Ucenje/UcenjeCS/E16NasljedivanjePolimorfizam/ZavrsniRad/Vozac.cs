using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Vozac : Entitet
    {
        public string Ime { get; set; }

        public string Prezime { get; set; }

        public int OIB { get; set; }
    }
}
