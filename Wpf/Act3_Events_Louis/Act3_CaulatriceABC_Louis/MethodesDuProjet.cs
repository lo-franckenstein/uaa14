using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Act3_CaulatriceABC_Louis
{
    class MethodesDuProjet
    {

        public void ResoudreTrinome(int a, int b, int c, out int x1, out int x2, out string type)
        {
            int delta = (int)Math.Pow(b, 2) - 4 * a * c;
            x1 = 0;
            x2 = 0;
            if (delta < 0)
            {
                type = "Il n'y a pas de solution réelle";

            }
            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                type = "Il y a une solution " + x1;
            }
            else
            {
                x1 = (int)(-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (int)(-b - Math.Sqrt(delta)) / (2 * a);
                type = "Il y a deux solutions " + x1 + " et " + x2;
            }

        }

    }
}
