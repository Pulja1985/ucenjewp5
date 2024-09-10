using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{

    internal class Vozilo : Entitet



    {
        public string Marka { get; set; }

        public string Model { get; set; }




        public string Pogon { get; set; }

        public string Snaga { get; set; }



        public int VozacSifra { get; set; }

        public Vozilo(string marka, string model, string pogon, string snaga, int vozacSifra)
        {
            this.Marka = marka;
            this.Model = model;
            this.Pogon = pogon;
            this.Snaga = snaga;
            this.VozacSifra = vozacSifra;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marka: " + this.Marka);
            sb.AppendLine("Model: " + this.Model);
            sb.AppendLine("Pogon: " + this.Pogon);
            sb.AppendLine("Snaga: " + this.Snaga);

            return sb.ToString();

        }






    }
}
