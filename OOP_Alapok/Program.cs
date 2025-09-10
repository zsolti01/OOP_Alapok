using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Alapok
{
    public class Szemely
    {
        public string nev = "Peti";
        public int kor = 34;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            Console.WriteLine($"A tanuló neve: {tanulo1.nev}");
            Console.WriteLine($"A kora: {tanulo1.kor}");
        }
    }
}
