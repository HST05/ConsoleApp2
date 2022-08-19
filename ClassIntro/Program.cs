using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Samet";
            int yas = 22;

            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2= new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Kerem";
            kurs2.IzlenmeOrani = 62;


            Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen);



        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
    