using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HomeWorkHelperLibrary
{

    public class Task_
    {
      
        // member variables
        private string _taskName;
        private bool _reoccuringTask;
        private DateTime _dueDate;
        private DateTime _dueDateEnd;
        private string _type;
            

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        public bool ReoccuringTask
        {
            get
            {
                return _reoccuringTask;
            }
            private set
            {
                _reoccuringTask = value;
            }
        }
      
        public string TaskName
        {
            get
            {
                return _taskName;
            }
            private set
            {
                _taskName = value;
            }
        }

        public DateTime DueDateEnd
        {
            get
            {
                return _dueDateEnd;
            }
           private set
            {
                _dueDateEnd = value;
            }
        }

        public DateTime DueDate
        {
            get
            {
                return _dueDate;
            }
            private set
            {
                _dueDate = value;
            }
        }

        public Task_(string taskName,string type, bool reTask,DateTime dueDate, DateTime endDueDate)
        {
            TaskName = taskName;
            _reoccuringTask = reTask;
            DueDate = dueDate;
            DueDateEnd = endDueDate;
            Type = type;
        }
        public Task_(string taskName)
        {
            TaskName = taskName;
        }          
    }
}
