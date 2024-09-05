using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{

    internal class Utrka : Entitet
    {
        public DateTime? Datum { get; set; }

        public string Mjesto { get; set; }

        public string  Naziv { get; set; }

        public Utrka(DateTime? datum, string mjesto, string naziv)
        {
            this.Datum = datum;
            this.Mjesto = mjesto;
            this.Naziv = naziv;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Datum: " + this.Datum);
            sb.AppendLine("Mjesto: " + this.Mjesto);
            sb.AppendLine("Naziv: " + this.Naziv);


            return base.ToString();
        }

    }
}
