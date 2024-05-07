using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
   class DataStore<T>
    {
        public T Data { get; set; }
        //public T data;
        public T[] data=new T[10];
        public void AddOrUpdate(int index, T item)
        {
            if (index>=0 && index<10)
            {
                data[index]=item;
            }
        }
        public T GetData(int index)
        {
            if(index>=0 && index<10)
            {
                return data[index];
            }
            else
            {
                return default(T);  
            }
        }
    }
}
