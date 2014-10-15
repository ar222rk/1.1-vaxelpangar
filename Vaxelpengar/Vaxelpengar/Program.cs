using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaxelpengar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variabel


            double totalSum = 0.0;      //   totalsumma       371,38
            uint total = 0;        //   totalt           371 Avrundat  
            int kontant = 0;        //   belopp           1000
            double ores = 0.0;      //   öresavrunding   -0,38
            int tillB = 0;        //    tillbaks        629   belopp  1000 - 371 = 629     



            // Mata in totalsumma.
            
            Console.Write("Ange totalsumma      : ");
            totalSum = double.Parse(Console.ReadLine());

            // Öresavrundning

            total = (uint)Math.Round(totalSum, MidpointRounding.AwayFromZero);
            ores = total - totalSum;

            // mata in belopp.






            Console.Write("Ange erhållet belopp : ");

            kontant = int.Parse(Console.ReadLine());

            tillB = kontant - (int)total;



            // 




            // Kvitto 
            Console.WriteLine(" \nKVITTO");


            Console.WriteLine("------------------------------------------\n");

            Console.WriteLine("Totalt:              {0,15:c}", totalSum);
            Console.WriteLine("Öresavrundning:      {0,15:f2}", ores);
            Console.WriteLine("Att betala:          {0,15:c}", total);
            Console.WriteLine("Kontant:             {0,15:c}", kontant);
            Console.WriteLine("Tillbaka:            {0,15:c}", tillB);

            Console.WriteLine("-----------------------------------------");

            // variabel till sedlar

            int sedlar = 0;

            sedlar = tillB / 500;
            tillB = tillB % 500;
            Console.WriteLine("500-lappar  {0:}", sedlar);

            sedlar = tillB / 100;
            tillB = tillB % 100;
            Console.WriteLine("100-lappar  {0:}", sedlar);

            sedlar = tillB / 20;
            tillB = tillB % 20;
            Console.WriteLine("20-lappar    {0:}", sedlar);

            sedlar = tillB / 5;
            tillB = tillB % 5;
            Console.WriteLine("5-kronor       {0:}", sedlar);

            sedlar = tillB / 1;
            tillB = tillB % 1;
            Console.WriteLine("1-kronor        {0:}", sedlar);


            // 

        }
    }
}
