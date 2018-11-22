using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Records
{
    class RecordMenu
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("\tРекорды\n");

            MainRepository repository = new MainRepository();
            repository.Init();
            int i = 1;

            foreach (var ining in repository.FindAllRecords())
            {
                Console.WriteLine($" {i}) {ining.Name} {ining.Record}");
                i++;
            }

            Console.ReadKey();
        }
    }
}
