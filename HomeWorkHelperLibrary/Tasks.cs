using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TaskType
{
    HomeWork,
    Quiz,
    Test,
    Paper
};


namespace HomeWorkHelperLibrary
{

    public class Tasks
    {
      
        // member variables
        string _taskName;
        bool _reoccuringTask;
        DateTime _remindTime;
        DateTime _remindDate;
        DateTime _dueDate;
        DateTime _dueDateEnd;
        TaskType type;
            
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


        public Tasks(string taskName, bool reTask, DateTime remindTime,DateTime dueDate, DateTime endDueDate,int typeOf)
        {
            TaskName = taskName;
            _reoccuringTask = reTask;
            RemindTime = remindTime;
            DueDate = dueDate;
            DueDateEnd = endDueDate; 
        }
        
        public void EditTaskName(Tasks task,string newName)
        {
            task.TaskName = newName;
        }
        public void EditTaskReoCurring(Tasks task, bool newReo)
        {
            task.ReoccuringTask = newReo;
        }
        public void EditTaskRemindTime(Tasks task, DateTime newDate)
        {
            task.RemindTime = newDate;
        }
        public void EditTaskDueDate(Tasks task, DateTime newDueDate)
        {
            task.DueDate = newDueDate;
        }
        public void EditTaskEndDate(Tasks task, DateTime newDateEnd)
        {
            task.DueDateEnd = newDateEnd;
        }
        public void DeleteTask(Tasks task,Student student)
        {
            int i = 0;
            foreach(Tasks t in student._taskList)
            {
                if(t == task)
                {
                    student._taskList.RemoveAt(i);
                }
                i++;
            }

        }

        // Checks for the task and assigns it 
        public void CheckForTask(TaskType taskType)
        {
            if (taskType == TaskType.HomeWork)
            {
                type = TaskType.HomeWork;
            }
            else if (taskType == TaskType.Paper)
            {
                type = TaskType.Paper;
            }
            else if(taskType == TaskType.Quiz)
            {
                type = TaskType.Quiz;
            }
            else if(taskType == TaskType.Test)
            {
                type = TaskType.Quiz;
            }
        }
    }
}
