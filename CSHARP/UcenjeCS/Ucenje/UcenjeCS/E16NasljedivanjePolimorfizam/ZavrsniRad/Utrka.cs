using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Utrka: Entitet
    {
        

        public DateTime Datum { get; set; }

        public string Mjesto { get; set; }

        public string Naziv { get; set; }
    }
}
