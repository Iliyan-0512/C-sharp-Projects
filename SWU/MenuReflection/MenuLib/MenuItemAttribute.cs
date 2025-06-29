using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuReflection
{
    [AttributeUsage(AttributeTargets.Method)]
    /// <summary>
    /// An attribute that marks the methods that will be displayed as menu options.
    /// </summary>
    public class MenuItemAttribute :Attribute
    {
        public string Caption { get;  }
        public int SortOrder { get;  }
        public bool EndRepl { get; }
        /// <summary>
        /// Creates a new MenuItem attribute.
        /// </summary>
        /// <param name="caption">option name.</param>
        /// <param name="sortOrder">Menu option order.</param>
        /// <param name="endRepl">Whether to hide the option.</param>
        public MenuItemAttribute (string caption,int sortOrder,bool endRepl=false)
        {
            Caption = caption;
            SortOrder = sortOrder;
            EndRepl = endRepl;
        }
    }
}
