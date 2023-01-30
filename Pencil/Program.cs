using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Matita;
using System.Threading;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Pencil
{
    class Program
    {
        static void Main(string[] args)
        {
            UnicodeEncoding unicode = new UnicodeEncoding();
            Console.ForegroundColor = ConsoleColor.Red;
            MatitaConGommino pen = new MatitaConGommino();
            Console.WriteLine("Inserire cosa si vuole scrivere: ");
            Console.Write(pen.Scrivi(Console.ReadLine()));

            Console.WriteLine("Si vuole cancellare? [y,n]\n");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("Di quando vuole cancellare? \n");
                pen.Cancella(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(pen.Scrivi(pen.cio_che_ha_scritto));
            }
            Console.WriteLine("Adios Amigos");
            ProcessStartInfo sInfo = new ProcessStartInfo("https://pastebin.com/raw/TBinjKJN");
            Process.Start(sInfo);

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
