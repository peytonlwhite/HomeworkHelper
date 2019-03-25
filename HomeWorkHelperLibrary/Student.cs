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
        List<Courses> _courseList = new List<Courses>();
        List<Tasks> _taskList = new List<Tasks>();

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

        //methods 
        
        // constructor
        public Student(string name, string userName, string Password)
        {
            _name = name;
            _userName = userName;
            _password = Password;
        }


        






    }
}
