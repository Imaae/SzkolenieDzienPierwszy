using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasaAbstrakcyjna_cwiczenie_
{
    class CarRobot : Robot
    {
        public override string Work()
        {
            return "produkuje samochody";
        }
        public override string GiveName()
        {
            //base.GiveName();
            
               return this.GetType().Name;
            
        }
    }
}
