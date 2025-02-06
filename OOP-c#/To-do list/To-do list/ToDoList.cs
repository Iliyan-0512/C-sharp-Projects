using System;
using System.Collections.Generic;
using System.Linq;

namespace To_do_list
{
    public class ToDoList : TaskItem
    {
        public List<TaskItem> Tasks { get; set; } 

        public ToDoList()
            : base() 
        {
            Tasks = new List<TaskItem>();
        }

        public void AddTask(TaskItem task)
        {
            Tasks.Add(task); // Добавяне на TaskItem вместо грешния new Task()
        }

        public void RemoveTask(string title)
        {
            var taskToRemove = Tasks.FirstOrDefault(t => t.Title == title);
            if (taskToRemove != null)
            {
                Tasks.Remove(taskToRemove);
            }
        }

        public TaskItem GetTask(string title)
        {
            return Tasks.FirstOrDefault(t => t.Title == title);
        }

        public List<TaskItem> GetAllTasks()
        {
            return Tasks;
        }

        public List<TaskItem> GetPendingTasks()
        {
            return Tasks.Where(t => !t.IsCompleted).ToList();
        }

        public List<TaskItem> GetCompletedTasks()
        {
            return Tasks.Where(t => t.IsCompleted).ToList();
        }
    }
}
