using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teglatestek
{
    internal class Program
    {
        static List<Test> test = new List<Test>();
        static void Main(string[] args)
        {
            test.Add(new Henger(3,5));
            test.Add(new Kocka(3));
            test.Add(new TeglalapTeglatest(3, 5, 7));

            foreach (var item in test)
            {
                Console.WriteLine($"{item} \t térfogata: {item.Terfogat()} \t felszine: {item.Felszin()}");
            }
            Console.ReadKey();

        }
    }
}
