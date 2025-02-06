using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_list
{
    public class TaskItem
    {
       public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
        public TaskItem() { }
        public TaskItem(string title,string description,bool isComleted, DateTime dueDate) 
        {
            Title = title;
            Description = description;
            IsCompleted = isComleted;
            DueDate = dueDate; 
        }
        public void MarkAsComplete()
        {
            IsCompleted = false;
        }
        public string UpdateTitle(string NewTitle)
        {
            Title= NewTitle;
            return Title;
        }
        void UpdateDescribtion(string NewDеrscribtion)
        {
            Description = NewDеrscribtion;
        }
       
    }
}
