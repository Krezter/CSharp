using System;
using SeaBattle.Authors;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Title
{
    [Specialization]
    class Developer : Specialization
    {
        public override string Name => "Разработка";

        public override List<Author> AuthorsList => new List<Author> { new Krezter() };
    }
}
