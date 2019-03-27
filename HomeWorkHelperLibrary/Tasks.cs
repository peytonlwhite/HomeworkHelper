using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace HomeWorkHelperLibrary
{

    public enum TaskType
    {

        HomeWork,
        Quiz,
        Test,
        Project

    };
    public class Tasks
    {
      
        // member variables 
        string _taskName;
        bool _reoccuringTask;
        DateTime _remindTime;
        DateTime _dueDate;
        DateTime _dueDateEnd;
        List<TaskType> TaskTypes = new List<TaskType>();
        Student student = new Student();
    
        
        
            

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

        public Tasks()
        {
            
            
        }

        public void AddTask(Tasks task)
        {
            

        }
        public void EditTask(Tasks task)
        {

        }
        public void DeleteTask(Tasks task)
        {
            int i = 0;
            foreach(Tasks t in _taskList)
            {
                if(t.Name == task.Name)
                {
                    _taskList.RemoveAt(i);
                }
                i++;
            }

        }
        public void ChangeDueDate(Tasks task, DateTime changedDate)
        {
            task.DueDate = changedDate;
        }



        

    }
}
