﻿using System;
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
            sQA = SecurityQuestionAnswers;
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
        public void DeleteTask(Task_ task, Student student)
        {
            int i = 0;
            foreach (Task_ t in student._taskList)
            {
                if (t == task)
                {
                    student._taskList.RemoveAt(i);
                }
                i++;
            }

        }
        public void AddTask(Task_ task)
        {
            _taskList.Add(task);
        }

        public void AddCourse(Course course)
        {
            _courseList.Add(course);
        }


        /// <summary>
        /// Deletes a certain course
        /// </summary>
        /// <param name="Course">Which course to delete</param>
        /// <param name="student">Which student to delete it from</param>
        public void DeleteCourse(int i)
        {
             
             _courseList.RemoveAt(i);
              
        }
       

     





    }
}
