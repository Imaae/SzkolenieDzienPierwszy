﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab24___KlasaAbstrakcyjna_cwiczenie_
{
    class TrainRobot:Robot
    {
        public override string Work()
        {
            return "produkuje pociagi";
        }
        public override string GiveName()
        {
            //base.GiveName();

            return this.GetType().Name;

        }
    }
}
