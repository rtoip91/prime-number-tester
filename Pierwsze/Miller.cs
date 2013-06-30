using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pierwsze
{
    class Miller : Zadanie
    {
        public Miller() : base ()
        {
            algorytm = "Miller";
        }

        public Miller(BigInteger liczba) : base (liczba)
        {
            algorytm = "Miller";
        }

        public override void licz()
        {
            base.licz();
        }
    }
}
