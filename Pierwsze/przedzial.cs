using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pierwsze
{
    class przedzial
    {
        public BigInteger poczatek;
        public BigInteger koniec;
        public bool ostatni;

        public przedzial()
        {
            koniec = 0;
            ostatni = false;
            poczatek = 0;
        }

        public przedzial(BigInteger start, BigInteger finish)
        {
            poczatek = start;
            koniec = finish;
            ostatni = false;
        }
    }
}
