using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkHelperLibrary
{
    public class Tasks : Student
    {
        // member variables 
        string _taskName;
        bool _reoccuringTask;
        DateTime _remindTime;
        DateTime _dueDate;
        DateTime _dueDateEnd;
        //Enum _taskType;
        
            

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

        public Tasks(string taskName)
        {
            TaskName = taskName;
        }


    }
}
