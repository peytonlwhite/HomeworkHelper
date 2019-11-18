using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
        private List<Task_> _taskList = new List<Task_>();
        

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
       public List<Course> CourseList
        {
            get
            {
                return _courseList;
            }
            set
            {
                _courseList = value;
            }
        }
        public List<Task_> TaskList
        {
            get
            {
                return _taskList;
            }
            set
            {
                _taskList = value;
            }
        }
        public string UserName {

            get
            {
                return _userName;

            }
            set
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
       public Student(string name, string userName, string passWord,string[] sQA)
        {
            Name = name;
            UserName = userName;
            Password = passWord;
            SecurityQuestionAnswers = sQA;
        }
        public void DeleteTask(int index)
        {
            TaskList.RemoveAt(index);

        }
        public void AddTask(Task_ task)
        {
            _taskList.Add(task);
        }

        public void AddCourse(Course course)
        {
            _courseList.Add(course);
        }
        public void DeleteCourse(int i)
        {    
             _courseList.RemoveAt(i);      
        }
    }
}
