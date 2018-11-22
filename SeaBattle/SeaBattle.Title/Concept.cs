using System;
using SeaBattle.Authors;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Title
{
    [Specialization]
    class Concept : Specialization
    {
        public override string Name => "Концепция";

        public override List<Author> AuthorsList => new List<Author> { new ITCourses() };
    }
}
