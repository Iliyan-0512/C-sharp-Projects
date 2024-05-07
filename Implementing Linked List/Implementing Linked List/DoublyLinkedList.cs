using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Linked_List
{
    public class DoublyLinkedList
    {
        private LinkedListItem first = null;
        private LinkedListItem last = null;
        public int Count
        {
            get
            {
                var count = 0;
                var current = first;
                while (current!=null)
                {
                    count++;
                    current = current.Next;

                }
                
                return count;
            }
        }
        public void AddFirst(int element)
        {
            var newItem = new LinkedListItem(element);
            if (first == null)
            {
                first = newItem;
                last = newItem;
            }
            else
            {
                newItem.Next = first;
                first.Prevous = newItem;
                first = newItem;
            }
            //Count++;
        }
        public void AddLast(int element)
        {
            ///*Count*/++;
            var newItem = new LinkedListItem(element);
            /// var newItem = new LinkedListItem(element);
            if (last == null)
            {
                first = newItem;
                last = newItem;
            }
            else
            {
                newItem.Next = last;
                last.Prevous = newItem;
                last = newItem;
            }
        }
        public int RemoveFirst()
        {
            var currentFirstValue = first.Value;
            if (first == null)
            {
                throw new InvalidOperationException("Linked list empty");

                //return 0;
            }
            else if (first == last)
            {
                first = null;
                last = null;
            }
            else
            {
                var newFirst = first.Next;
                newFirst.Prevous = null;
                first = newFirst;
            }
            //Count++;
            return currentFirstValue;
            

        }
        public int RemoveLast()
        {
           

            if (last == null)
            {
                throw new InvalidOperationException("Linked list empty");
            }
            var currentLastvalue = last.Value;
            if (first == last)
            {
                first = null;
                last = null;
            }
            else
            {
                var newLast = last.Prevous;
                newLast.Next = null;
                last = newLast;
            }
            ////Count++;
            return currentLastvalue;
        }
        public void ForEach(Action<int> action)
        {
            
                var current=first;
            while (current != null)
            {
                action(current.Value);
                current = current.Next;
            }
        }
        public int[] ToArray()
        {
            var array=new int[Count];
            var current = first;
            var index =0;
            while (current != null)
            {
                array[index] = current.Value;
                index++;
                current=current.Next;
            }
            return array;
        }
    }
}
