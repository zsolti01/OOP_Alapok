using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Alapok
{
    public class Szemely
    {
        protected string nev;
        int kor;


        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int Kor
        {
            get { return kor; }
            set { kor = value; }
        }

        public override string ToString()
        {
            return $"A személy neve {nev}, életkora {kor}.";
        }

        /*
        public Szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }

        public string Kiir()
        {
            return $"A tanuló neve: {nev} és {kor} éves.";
        }
        */
    }

    public class Bankszamla
    {
        private int egyenleg;

        public int Egyenleg
        {
            get { return egyenleg; }
            set
            {
                if(value >= 0)
                    egyenleg = value;
                else Console.WriteLine("Az érték nem lehet negatív!");
            }
        }

        public void Betesz()
        {

        }

        public void Kivesz()
        {

        }
    }

    public class Hallgato : Szemely
    {
        private string netpunKod;
        
        public string NetpunKod
        {
            get { return netpunKod; }
            set
            {
                if (value.Length <= 6) netpunKod = value;
                else Console.WriteLine("Nem megfelelő hosszúság!");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            tanulo1.Kor = 26;
            Console.WriteLine(tanulo1);

            Bankszamla bankszamla1 = new Bankszamla();
            bankszamla1.Egyenleg = 5700;
            Console.WriteLine($"A tanuló bankszámláján lévő összeg: {bankszamla1.Egyenleg}Ft.");

            Hallgato hallgato1 = new Hallgato();
            hallgato1.NetpunKod = "HIE596";
            Console.WriteLine(hallgato1.NetpunKod);

            List<Hallgato> hallgatok = new List<Hallgato>();
            for (int i = 0; i < 2; i++)
            {
                Hallgato hallgato = new Hallgato();
                Console.WriteLine($"Kérem a(z) {i+1}. hallgató nevét: ");
                hallgato.Nev = Console.ReadLine();
                Console.WriteLine($"Kérem az életkorát is: ");
                hallgato.Kor = int.Parse(Console.ReadLine());
                Console.WriteLine($"Kérem az netpunkódját is: ");
                hallgato.NetpunKod = Console.ReadLine();
                hallgatok.Add(hallgato);
            }

            Console.WriteLine();
            Console.WriteLine("Hallgatók neve:");

            foreach (var item in hallgatok)
            {
                Console.WriteLine(item.Nev);
            }

            /*
            Szemely tanulo1 = new Szemely("Peti", 34);
            Console.WriteLine(tanulo1.Kiir());

            Szemely tanulo2 = new Szemely("Jani", 38);
            Console.WriteLine(tanulo2.Kiir());
            */
        }
    }
}
