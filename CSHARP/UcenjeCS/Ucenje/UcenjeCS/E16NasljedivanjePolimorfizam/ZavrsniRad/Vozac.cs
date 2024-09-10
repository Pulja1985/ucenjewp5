﻿using System;
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

        public string OIB { get; set; }

        public Vozac(string Ime, string Prezime, string OIB)
        {
            this.Ime = Ime;
            this.Prezime = Prezime;
            this.OIB = OIB;

            
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Ime: " + this.Ime);
            sb.AppendLine("Prezime: " + this.Prezime);
            sb.AppendLine("OIB: " + this.OIB);
            

            return base.ToString();
        }

        
        
            
            
        



    }
}
