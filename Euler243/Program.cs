using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler243
{
    public class Program
    {
        static List<int> primes = new List<int>() { 2, 3, 5, 7 };

        static void Main(string[] args)
        {
            long d = 12;
            while(true)
            {
                long phi = (long) eulerphi(d);
                if(phi * 94744 < (d - 1) * 15499)
                {
                    Console.WriteLine(d);
                    Console.ReadLine();
                    return;
                }
                d++;
            }
        }

        public static long eulerphi(long n)
        {
            while (primes.Last() <= n)
                getNextPrime();

            long phi = 1;
            long m = n;
            foreach(int p in primes)
            {
                int k = 0;
                while(m % p == 0)
                {
                    k++;
                    m = m / p;
                }
                if (k == 0)
                    continue;
                phi = phi * (p - 1);
                for (int i = 0; i < k - 1; i++)
                    phi = phi * p;
            }
            return phi;
        }

        static void getNextPrime()
        {
            int n = primes.Last() + 2;
            while(true)
            {
                bool notPrime = false;
                foreach(int p in primes)
                {
                    if (n % p == 0)
                    {
                        notPrime = true;
                        break;
                    }
                }
                if(notPrime == false)
                {
                    primes.Add(n);
                    return;
                }
                n += 2;
            }
        }
    }
}
