using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pierwsze
{
    public static class BigIntRandom
    {
        

        public static BigInteger NextRand(BigInteger max)
        {
            BigInteger ret = 0;
            var rng = new RNGCryptoServiceProvider();
            byte[] bytes = max.ToByteArray();
            do
            {
                rng.GetBytes(bytes);
                ret = new BigInteger(bytes);
            } while (ret > max || ret<0);
            return ret;
        }

        public static BigInteger NextRand(BigInteger min, BigInteger max)
        {
            BigInteger ret = 0;
            var rng = new RNGCryptoServiceProvider();
            byte[] bytes = max.ToByteArray();
            do
            {
                rng.GetBytes(bytes);
                ret = new BigInteger(bytes);
                
            } while (ret > max || ret < min);
            return ret;
        }
    }
}
