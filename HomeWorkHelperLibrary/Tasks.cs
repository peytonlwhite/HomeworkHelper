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


        /// <summary>
        /// Accepts what makes a task and defines the task
        /// </summary>
        /// <param name="taskName"> string for the task name</param>
        /// <param name="reTask"> bool for if the task is a reocurring task</param>
        /// <param name="remindTime">the user sets to remind them about the task</param>
        /// <param name="dueDate">the user sets the date when the task is due</param>
        /// <param name="endDueDate">the user sets the date when the last day to turn in the task</param>
        public Tasks(string taskName, bool reTask, DateTime remindTime,DateTime dueDate, DateTime endDueDate)
        {
            TaskName = taskName;
            _reoccuringTask = reTask;
            RemindTime = remindTime;
            DueDate = dueDate;
            DueDateEnd = endDueDate; 
        }
        
        /// <summary>
        /// Edits the task name
        /// </summary>
        /// <param name="task">Which task the user is editing</param>
        /// <param name="newName">a string for the new name the user inputs</param>
        public void EditTaskName(Tasks task,string newName)
        {
            task.TaskName = newName;
        }

        /// <summary>
        /// Edits the reocurring selection
        /// </summary>
        /// <param name="task">Which task the user is editing</param>
        /// <param name="newName">a bool that the user changes the task to</param>
        public void EditTaskReoCurring(Tasks task, bool newReo)
        {
            task.ReoccuringTask = newReo;
        }

        /// <summary>
        /// Edits the remindTime for the task
        /// </summary>
        /// <param name="task"></param>
        /// <param name="newDate"></param>
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
