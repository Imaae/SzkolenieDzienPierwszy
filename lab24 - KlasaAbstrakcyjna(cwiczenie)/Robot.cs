using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasaAbstrakcyjna_cwiczenie_
{
    public abstract class Robot
    {

        public virtual string GiveName()
        {
           return this.GetType().Name;
        }
        public abstract string Work();
    }
}
