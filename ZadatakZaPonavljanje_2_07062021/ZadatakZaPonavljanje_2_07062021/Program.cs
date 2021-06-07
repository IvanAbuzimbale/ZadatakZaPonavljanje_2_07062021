using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakZaPonavljanje_2_07062021
{
    class Program
    {
        static void Main(string[] args)
        {
            string argument1;
            string broj;
            Console.Write("True ili false? ");
            argument1 = Console.ReadLine();
            Console.Write("Upiši neki broj: ");
            broj = Console.ReadLine();
            Console.WriteLine("Ha! Nije nego je " + KlasaD.Suprotno(Convert.ToBoolean(argument1)));
            Console.WriteLine("Vaš broj u suprotnosti je: " + KlasaD.Suprotni(Convert.ToInt32(broj)));
            Console.ReadKey();
        }
    }
}
