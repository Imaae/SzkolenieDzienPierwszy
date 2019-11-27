#define Przyklad1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab08___DyrektywyPreprocesora
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Pierwszy        


            #endregion

            #if (Przyklad1)
            int a = 10;
            #elif (Przyklad2)
            int a =20;
            #endif

        }
    }
}
