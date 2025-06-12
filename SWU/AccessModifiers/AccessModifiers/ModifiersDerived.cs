using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class ModifiersDerived : ModifiersBase
    {
        public static void XXX()
        {
            AAA();
            BBB();
            CCC();
        }
    }
}
