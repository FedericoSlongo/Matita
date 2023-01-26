using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Matita;
using System.Threading.Tasks;

namespace Pencil
{
    class Program
    {
        static void Main(string[] args)
        {
            MatitaConGommino pen = new MatitaConGommino();
            Console.Write(pen.Scrivi("these nuts are so good ngl I do like my nuts be like uaahahahahahahahahahahaha\n"));
            Console.WriteLine(pen.Scrivi("these nuts are so good ngl I do like my nuts be like uaahahahahahahahahahahaha\n"));

            pen.Cancella(1);
            Console.WriteLine(pen.cio_che_ha_scritto);
            Console.ReadKey();
        }
    }
}
