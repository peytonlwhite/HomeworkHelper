using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HomeWorkHelperLibrary
{

    public class Task_
    {
      
           
        public string Type { get; private set; }

        public bool ReoccuringTask { get; private set; }
      
        public string TaskName { get; private set; }

        public DateTime DueDateEnd { get; private set; }

        public DateTime DueDate { get; private set; }

        public Task_(string taskName,string type, bool reTask,DateTime dueDate, DateTime endDueDate)
        {
            TaskName = taskName;
            ReoccuringTask = reTask;
            DueDate = dueDate;
            DueDateEnd = endDueDate;
            Type = type;
        }        
    }
}
