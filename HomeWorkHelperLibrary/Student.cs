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
        string _name;
        string _userName;
        string _password;
        string[] _securityQuestions = new string[3];
        public  List<Courses> _courseList = new List<Courses>();
        public List<Tasks> _taskList = new List<Tasks>();

        

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
            private set
            {
                _password = value;
            }
        }
        public string[] SecurityQuestions
        {

            get
            {
                return SecurityQuestions;

            }
          private set
            {
                _securityQuestions = value;
            }

        }

        // Default constructor 
        public Student()
        {

        }

        // Constructor 
       public Student(string name, string passWord, string userName, string[] SQ)
        {
            Name = name;
            UserName = userName;
            SecurityQuestions = SQ;
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
    
    /// <summary>
    /// Adds a task to the task list inside the student class
    /// </summary>
    /// <param name="task">lets it know what task it is</param>
            
    public void AddTask(Tasks task)
        {
            _taskList.Add(task);
        }
     
        /// <summary>
        /// adds a course to the courseList inside the student class
        /// </summary>
        /// <param name="course">lets it know what course it is</param>
    public void AddCourse(Courses course)
        {
            _courseList.Add(course);
        }


    }
}
