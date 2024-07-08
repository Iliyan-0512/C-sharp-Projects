using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorProblem
{
    public class Author: Attribute
    {
        public string Name { get; }

        public Author(string name)
        {
            Name = name;
        }
    }
}
