using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Authors
{
    class Title
    {
        public void Menu()
        {
            MainAuthors repository = new MainAuthors();
            repository.Init();

            Console.Clear();
            Console.WriteLine("\tАвторы:");
            foreach (var Spec in repository.FindAllSpecialization())
            {
                Console.WriteLine($"\n {Spec.Name} > {string.Join("\n ", Spec.AuthorsList)}");
            }

            Console.ReadKey();
        }
    }
}
