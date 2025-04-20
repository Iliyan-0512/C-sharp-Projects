using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuReflection
{
    [AttributeUsage(AttributeTargets.Method)]
    public class MenuItemAttribute :Attribute
    {
        public string Caption { get;  }
        public int SortOrder { get;  }
        public bool EndRepl { get; }
        public MenuItemAttribute (string caption,int sortOrder,bool endRepl=false)
        {
            Caption = caption;
            SortOrder = sortOrder;
            EndRepl = endRepl;
        }
    }
}
