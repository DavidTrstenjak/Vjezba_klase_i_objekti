using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_Klase_i_objekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov x380 = new Zrakoplov();
            x380.setNaziv("Airbus");
            x380.setDosegLeta(2000);
            x380.setSnagaMotora(6000);

            Zrakoplov C162 = new Zrakoplov();
            C162.setNaziv("Cessna Skycatcher");
            C162.setDosegLeta(75);
            C162.setSnagaMotora(870);

            Zrakoplov PC_21 = new Zrakoplov();
            PC_21.setNaziv("Pilatus");
            PC_21.setDosegLeta(1200);
            PC_21.setSnagaMotora(1333);

            Console.WriteLine("Prvi zrakoplov : " + "\n");
            Console.WriteLine("Naziv : " + x380.getNaziv());
            Console.WriteLine("Doseg leta : " + x380.getDosegLeta() + " km");
            Console.WriteLine("Snaga motora : " + x380.getSnagaMotora() + "kW" + "\n");

            Console.WriteLine("Drugi zrakoplov : " + "\n");
            Console.WriteLine("Naziv : " + C162.getNaziv());
            Console.WriteLine("Doseg leta : " + C162.getDosegLeta() + " km");
            Console.WriteLine("Snaga motora : " + C162.getSnagaMotora() + "kW" + "\n");

            Console.WriteLine("Treci zrakoplov : " + "\n");
            Console.WriteLine("Naziv : " + PC_21.getNaziv());
            Console.WriteLine("Doseg leta : " + PC_21.getDosegLeta() + " km");
            Console.WriteLine("Snaga motora : " + PC_21.getSnagaMotora() + "kW" + "\n");


            Console.ReadKey();
        }
    }

    class Zrakoplov
    {
        string Naziv;
        int DosegLeta;
        double SnagaMotora;

        public Zrakoplov(string naziv, int dosegLeta, double snagaMotora)
        {
            Naziv =naziv;
            DosegLeta = dosegLeta;
            SnagaMotora = snagaMotora;
        }

        public Zrakoplov()
        {
        }

        public void setNaziv(string Naziv)
        {
            this.Naziv = Naziv;
        }

        public string getNaziv()
        {
            return Naziv;
        }

        public void setDosegLeta(int DosegLeta)
        {
            this.DosegLeta = DosegLeta;
        }

        public int getDosegLeta()
        {
            return DosegLeta;
        }

        public void setSnagaMotora(double SnagaMotora)
        {
            this.SnagaMotora = SnagaMotora;
        }

        public double getSnagaMotora()
        {
            return SnagaMotora;
        }
    }
}
