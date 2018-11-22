using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Authors
{
    public abstract class Specialization
    {
        public abstract string Name { get; }

        public abstract List<Author> AuthorsList { get; }
    }
}
