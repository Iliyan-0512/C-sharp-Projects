using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    public  class Citizen:IPerson,IBirthable,IIdentifiable
    {
        private string name;
        private int age;
        private string id;
        private string birtday;
        public Citizen(string name, int age,string id,string birthday)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.birtday = birthday;

        }
        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
        public string Id
        {
            get { return id; }
        }
        public string Birthday
        {
            get { return birtday; }
        }
        
    }
}
