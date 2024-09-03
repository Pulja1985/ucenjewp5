using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Vozilo:Entitet
    {
        public string Marka { get; set; }

        public string Model { get; set; }

        public int Snaga { get; set; }

        public string Pogon { get; set; }

        public int VozacSifra { get; set; }
    }
}
