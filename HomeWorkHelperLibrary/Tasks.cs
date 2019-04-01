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
        /// <param name="taskName">String for the task name</param>
        /// <param name="reTask"> Bool for if the task is a reocurring task</param>
        /// <param name="remindTime">The user sets to remind them about the task</param>
        /// <param name="dueDate">The user sets the date when the task is due</param>
        /// <param name="endDueDate">The user sets the date when the last day to turn in the task</param>
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
        /// <param name="newName">A string for the new name the user inputs</param>
        public void EditTaskName(Tasks task,string newName)
        {
            task.TaskName = newName;
        }

        /// <summary>
        /// Edits the reocurring selection
        /// </summary>
        /// <param name="task">Which task the user is editing</param>
        /// <param name="newName">A bool that the user changes the task to</param>
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

        /// <summary>
        /// Edits the due date for the task
        /// </summary>
        /// <param name="task">Which task the user is editing</param>
        /// <param name="newDueDate">The new due date the user picks</param>
        public void EditTaskDueDate(Tasks task, DateTime newDueDate)
        {
            task.DueDate = newDueDate;
        }

        /// <summary>
        /// Edits the end date of the task
        /// </summary>
        /// <param name="task">Which task the user is editing</param>
        /// <param name="newDateEnd">What the new end date is</param>
        public void EditTaskEndDate(Tasks task, DateTime newDateEnd)
        {
            task.DueDateEnd = newDateEnd;
        }



        /// <summary>
        /// Adds a task to the task list inside the student class
        /// </summary>
        /// <param name="task">Lets it know what task it is</param>
        public void AddTask(Tasks task,Student student)
        {
            student._taskList.Add(task);
        }


        /// <summary>
        /// Deletes a certain task in the list
        /// </summary>
        /// <param name="task">Which task the user is deleting</param>
        /// <param name="student">Which student to delete the task from</param>
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

       /// <summary>
       /// Checks for the task and assigns it to enum and defines the type
       /// Homework,Quiz.....
       /// </summary>
       /// <param name="taskType">An Enum list that has HW, quiz...</param>
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
