using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkHelperLibrary
{
   public class Student
    {
        // member variables
        private string _name;
        private string _userName;
        private string _password;
        private string[] _securityQuestionAnswers;
        private  List<Course> _courseList = new List<Course>();
        private List<Task> _taskList = new List<Task>();

        

        // properties 
        public string Name {

            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }
        public string UserName {

            get
            {
                return _userName;

            }
           private set
            {
                _userName = value;
            }

        }
        public string Password
        {

            get
            {
                return _password;
            }
             set
            {
                _password = value;
            }
        }
        public string[] SecurityQuestionAnswers
        {

            get
            {
                return _securityQuestionAnswers;

            }
           private set
            {
                _securityQuestionAnswers = value;
            }

        }

        // Default constructor 
        public Student()
        {

        }

        // Constructor 
       public Student(string name, string userName, string passWord)
        {
            Name = name;
            UserName = userName;
            Password = passWord;
        }

       /// <summary>
       /// Checks for password when logging in
       /// </summary>
       /// <param name="passWord">the password that the user inputed in login</param>
       /// <returns>returns true if passwords match return false if not</returns>
     public bool CheckForPassword(string passWord)
        {
            if(Password == passWord)
            {
                return true;
            }

            return false;
            
        }
        public void DeleteTask(Task task, Student student)
        {
            int i = 0;
            foreach (Task t in student._taskList)
            {
                if (t == task)
                {
                    student._taskList.RemoveAt(i);
                }
                i++;
            }

        }
        public void AddTask(Task task, Student student)
        {
            student._taskList.Add(task);
        }

        public void AddCourse(Course course, Student student)
        {
            student._courseList.Add(course);
        }


        /// <summary>
        /// Deletes a certain course
        /// </summary>
        /// <param name="Course">Which course to delete</param>
        /// <param name="student">Which student to delete it from</param>
        public void DeleteCourse(Course Course, Student student)
        {
            int i = 0;
            foreach (Course c in student._courseList)
            {
                if (c == Course)
                {
                    student._courseList.RemoveAt(i);
                }
                i++;
            }

        }

    }
}
