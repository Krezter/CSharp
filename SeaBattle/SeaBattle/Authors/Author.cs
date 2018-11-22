using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaBattle.Authors
{
    public abstract class Author
    {
        public abstract string FullName { get; }

        public override string ToString()
        {
            return !string.IsNullOrEmpty(FullName) ? FullName : base.ToString();
        }
    }
}
