using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.E16NasljedivanjePolimorfizam.ZavrsniRad
{
    internal class Zadatak
    {

        /*
         * 
         * Kreirati klase prema ERA dijagramu Vaše baze podataka
         * Implementirati nasljeđivanje i prepisati metodu ToString
         * 
         * Za svaku klasu napraviti po jedan konstruktor
         * 
         * Svaku klasu instancirati u ovoj klasu
         * 
         */

        public Zadatak() {
            //ovdje instancirati svaku kreiranu klasu jednom i dodjeliti svim svojstvima vrijednosti
            var utrka = new Utrka("15.06.2024", "Osijek", "OSRS");
            utrka.sifra = 1;

            var vozac = new Vozac("Hrvoje","Puljić",27104444467);
            vozac.sifra = 1;

            var vozilo = new Vozilo("Honda", "Civic", "Prednji", 300);
            vozilo.sifra = 1;
        } 

    }
}
