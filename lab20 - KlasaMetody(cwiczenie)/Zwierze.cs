using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab20___KlasaMetody_cwiczenie_
{
    class Zwierze
    {/// <summary>
    /// nazwa zierzaka
    /// </summary>
        public string nazwa;
        public int iloscNog;
        public int iloscOczu;
        /// <summary>
        /// Metoda która zwroci parametry zwierzaka
        /// </summary>
        public void OpisKonsola()
        {
            Console.WriteLine($" - nazwa: {nazwa} iloscNog: {iloscNog} iloscOczu: {iloscOczu}");
        }
        /// <summary>
        /// opis
        /// </summary>
        /// <returns>reurnowa wartosc</returns>
        public string Opis()
        {
            string powrot;
            //switch (name)
            //{
            //    case "nazwa":
            //         powrot = $" nazwa: {nazwa}";
            //        break;
            //    case "iloscNog":
            //         powrot = $"iloscNog: {iloscNog} ";
            //        break;
            //    case "iloscOczu":
            //         powrot = $"iloscOczu: {iloscOczu}";
            //        break;
            //    default:
            //        powrot = $"niezdefiniowano";
            //        break;
            //}
            powrot =$" nazwa: {nazwa} iloscNog: {iloscNog} iloscOczu: {iloscOczu}";
            return powrot;
        }
    }
}
