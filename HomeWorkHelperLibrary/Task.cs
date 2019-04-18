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
        string _taskName;
        bool _reoccuringTask;
        DateTime _remindTime;
        DateTime _remindDate;
        DateTime _dueDate;
        DateTime _dueDateEnd;
        string _type;
            

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
        public DateTime RemindTime
        {
            get
            {
                return _remindTime;
            }
            private set
            {
                _remindTime = value;
            }
        }

        public DateTime RemindDate
        {
            get
            {
                return _remindDate;
            }
            private set
            {
                _remindDate = value;
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



        /// <summary>
        /// Accepts what makes a task and defines the task
        /// </summary>
        /// <param name="taskName">String for the task name</param>
        /// <param name="reTask"> Bool for if the task is a reocurring task</param>
        /// <param name="remindTime">The user sets to remind them about the task</param>
        /// <param name="dueDate">The user sets the date when the task is due</param>
        /// <param name="endDueDate">The user sets the date when the last day to turn in the task</param>
        public Task_(string taskName,string type, bool reTask, DateTime dueDate,DateTime remindTime, DateTime endDueDate)
        {
            TaskName = taskName;
            _reoccuringTask = reTask;
            RemindTime = remindTime;
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
