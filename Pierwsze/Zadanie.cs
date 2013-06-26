using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Numerics;
using System.Threading;
using System.Diagnostics;

namespace Pierwsze
{
    public class Zadanie
    {

        private Stopwatch sw = new Stopwatch();
        private object Objekt = new object();
        protected BigInteger liczba;
        protected DateTime czas_dodania;
        protected TimeSpan czas_wykonywania;
        protected int postep;
        protected String wynik = "pierwsza";
        protected String algorytm;

        public String get_algorytm()
        {
            return algorytm;
        }

        public String get_wynik()
        {
            return wynik;
        }

        public int get_postęp()
        {
            return postep;
        }
        public String get_liczba()
        {
            return liczba.ToString();
        }

        public String get_czasdodania()
        {
            return czas_dodania.ToLongTimeString();
        }

        public String get_czaswykonywania()
        {
            return czas_wykonywania.ToString();
        }

        public Zadanie()
        {
            liczba = 0;
            czas_dodania = DateTime.Now;
            czas_wykonywania = TimeSpan.Zero;
            postep = 0;
            wynik = "pierwsza";
            algorytm = "Bruteforce";
        }

        public Zadanie(BigInteger licz)
        {
            liczba = licz;
            czas_dodania = DateTime.Now;
            czas_wykonywania = TimeSpan.Zero;
            postep = 0;
            wynik = "pierwsza";
            algorytm = "Bruteforce";

        }

        private List<Thread> watki = new List<Thread>();
        private List<przedzial> przedzial_list = new List<przedzial>();
        private bool pierwsza = true;
       



        private static BigInteger Sqrt(BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!isSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }

        private static Boolean isSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }

        private void przedzialy(BigInteger liczba, int ile_watkow)
        {
            BigInteger start = 2;
            BigInteger pierw = Sqrt(liczba);
            BigInteger koniec = Sqrt(liczba) /(BigInteger)ile_watkow + 2;
            BigInteger skok = koniec;
            przedzial_list.Add(new przedzial(start, koniec));

            for (int i = 1; i < ile_watkow; i++)
            {
                start = start + skok;
                koniec = koniec + skok;
                if (koniec > liczba) koniec = liczba;
                przedzial_list.Add(new przedzial(start, koniec));
                if (i == ile_watkow - 1)
                {
                    przedzial_list[i].ostatni = true;
                }
            }
        }



        private void Czy_pierwsza(object o)
        {
            przedzial a = (przedzial)o;
            // BigInteger pierw = Sqrt(liczbaa);

            if (liczba == 1 || liczba == 2)
            {

                pierwsza = true;

            }
            else
            {
                for (BigInteger i = a.poczatek; i <= a.koniec; i++)
                {
                    if (pierwsza != false)
                    {
                        if (a.ostatni)
                        {
                            lock (Objekt)
                            {

                            }
                        }
                        if (liczba % i == 0)
                        {

                            pierwsza = false;
                            return;

                        }

                    }

                    else
                    {
                        return;

                    }

                }

            }
            return;
        }


        virtual public void licz ()
        {

            int ilosc_watkow = 4;
            przedzial_list.Clear();
            watki.Clear();

            przedzialy(liczba, ilosc_watkow);
            sw.Start();
            for (int i = 0; i < ilosc_watkow; i++)
            {
                Thread a = new Thread(Czy_pierwsza);
                watki.Add(a);
                watki[i].Start(przedzial_list[i]);

            }

            foreach (Thread thr in watki)
            {
                thr.Join();
            }
            sw.Stop();
            czas_wykonywania = TimeSpan.FromMilliseconds(sw.ElapsedMilliseconds);
            if (pierwsza == true)
            {
               
                wynik = "pierwsza";


            }
            else
            {
                
                wynik = "złożona";
            }


        }

    }

}
