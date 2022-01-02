using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20
{
    class Program
    {
        delegate double MyDelegate(double R);
        static void Main(string[] args)
        
        {
            MyDelegate myDelegate = DlinaOkr;
            myDelegate += AreaСircle;
            myDelegate += ObyemShara;

            myDelegate(5);
            Console.ReadKey();
        }
        static double DlinaOkr(double R)
        {
            double D = 2 * Math.PI * R;
            Console.WriteLine(D);
            return D;
        }
        static double AreaСircle(double R)
        {
            double S = Math.PI * R * R;
            Console.WriteLine(S);
            return S;
        }
        static double ObyemShara(double R)
        {
            double V = 4 / 3 * Math.PI * R * R * R;
            Console.WriteLine(V);
            return V;
        }
        
    }
}
