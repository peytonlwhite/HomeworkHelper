using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkHelperLibrary
{
    public class FileReadWrite
    {

        private string fileName;
        private StreamReader reader;
        private StreamWriter outputFile;


        public FileReadWrite()
        {
            fileName = "StudentDetails.txt";
        }

        public void AddStudentToFile(Student student)
        {  
            
            // Set a variable to the Documents path.
            string docPath = Path.GetFullPath(fileName);
            outputFile = new StreamWriter(docPath, true);

          
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
                outputFile.Close();
            }
            else
            {
                using (outputFile)
                {
                    //outputs the user information to the file
                    outputFile.WriteLine(student.UserName + ',' + 
                        student.Password + ',' + student.Name + ',' +
                        student.SecurityQuestionAnswers[0] + ',' + student.SecurityQuestionAnswers[1]
                        + ';');
                }
                outputFile.Close();
            }
            outputFile.Close();
           
        }

        public bool readStudentFromFile(ref Student student, string userName, string password)
        {
            // sets the path and the reader for file
            string docPath = Path.GetFullPath(fileName);
            reader = new StreamReader(docPath, true);

            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    string fileUserName = "";
                    string filePassWord = "";
                    string restOfLine = "";
                    //reads until the comma the user name is the first thing in each line
                    while ((char)reader.Peek() != ',')
                    {
                        fileUserName += (char)reader.Read();
                    }
                    //buffer reads in the comma 
                    string buffer = "";
                    buffer += (char)reader.Read();
                    //reads until the next comma for the user password
                    while ((char)reader.Peek() != ',')
                    {
                        filePassWord += (char)reader.Read();
                    }
                    // reads in the comma 
                    restOfLine = Convert.ToString(reader.ReadLine());

                    // checks to see if the username and pass matches 
                    //if so then it sets the username and pass through reference
                    if (fileUserName.Trim() == userName && filePassWord.Trim() == password)
                    {
                        student.UserName = userName;
                        student.Password = password;
                        return true;
                    }
                }
                return false;
            }
        }

        public void AddCourseToFile(Student student, Course course)
        {
            string docPath = Path.GetFullPath(fileName);
            // this statement allows reading and writing for the file
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            reader = new StreamReader(file);
            outputFile = new StreamWriter(file);

            using (reader)
            {
                // reads till end so the output is at the end
                reader.ReadToEnd();

                using (outputFile)
                {
                    //outputs a c after username because it is a course
                    outputFile.WriteLine(student.UserName + 'c' + ',' + course.CourseName + ','
                        + course.CourseNumber + ',' + course.CourseTime
                        + ',' + course.DateOfCourse + ';');
                }
            }
        }

        public void AddTaskToFile(Student student, Task_ task)
        {
            string docPath = Path.GetFullPath(fileName);
            //allows reading and writing access
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            reader = new StreamReader(file);
            outputFile = new StreamWriter(file);

            using (reader)
            {
                //reads till end for output
                reader.ReadToEnd();

                using (outputFile)
                {

                    outputFile.WriteLine(student.UserName + 't' + ',' + task.TaskName + ',' + task.Type + ','
                                         + task.ReoccuringTask + ',' + task.DueDate + ',' + task.DueDateEnd + ';');
                }
            }
            
        }

        public void ReadDataFromFile(ref Student student)
        {

            string docPath = Path.GetFullPath(fileName);
            //allows access for reading and writing
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            reader = new StreamReader(file);
            Task_ newTask;
            Course newCourse;
            string username = "";
            string restOfLine = "";

            using (reader)
            {
                while (!reader.EndOfStream)
                {

                    Console.WriteLine(5);
                    //reads in the usernames
                    while ((char)reader.Peek() != ',')
                    {
                        username += (char)reader.Read();
                        //if there is one  user then this stops the error
                        if (reader.EndOfStream)
                        {
                            return;
                        }
                    }
                    //reads in the comma
                    restOfLine += (char)reader.Read();

                    //checks if username mathces and sees if it is a course
                    if (username.Trim() == (student.UserName + 'c'))
                    {
                        string courseName = "";
                        string courseNumber = "";
                        string courseTime = "";
                        string courseDate = "";
                        //reads in the coursename
                        while ((char)reader.Peek() != ',')
                        {
                            courseName += (char)reader.Read();
                        }

                        restOfLine += (char)reader.Read();
                        //reads in the coursenumber
                        while ((char)reader.Peek() != ',')
                        {
                            courseNumber += (char)reader.Read();
                        }
                        //reads in the comma
                        restOfLine += (char)reader.Read();
                        //reads in the coursetime
                        while ((char)reader.Peek() != ',')
                        {
                            courseTime += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();
                        //reads in the course date
                        while ((char)reader.Peek() != ';')
                        {
                            courseDate += (char)reader.Read();
                        }
                        //reads in the ;
                        restOfLine += (char)reader.Read();
                        //converts each string and creates the new course
                        newCourse = new Course(Convert.ToInt32(courseNumber), courseName,
                            courseTime, Convert.ToDateTime(courseDate));

                        //adds the course to the list
                        student.AddCourse(newCourse);

                        //resetes the vars
                        courseName = "";
                        courseNumber = "";
                        courseTime = "";
                        courseDate = "";
                    }

                    //checks if the line is a task 
                    else if (username.Trim() == (student.UserName + 't'))
                    {
                        string taskName = "";
                        string taskType = "";
                        string TaskReocurring = "";
                        string TaskStartDate = "";
                        string TaskEndDate = "";

                        //reads in the taskname
                        while ((char)reader.Peek() != ',')
                        {
                            taskName += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();
                        //reads in the type
                        while ((char)reader.Peek() != ',')
                        {
                            taskType += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();
                        //reads in the bool
                        while ((char)reader.Peek() != ',')
                        {
                            TaskReocurring += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();
                        //reads in the date
                        while ((char)reader.Peek() != ',')
                        {
                            TaskStartDate += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();
                        //reads in date
                        while ((char)reader.Peek() != ';')
                        {
                            TaskEndDate += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();
                        //creates the new task 
                        newTask = new Task_(taskName, taskType, Convert.ToBoolean(TaskReocurring), 
                            Convert.ToDateTime(TaskStartDate), Convert.ToDateTime(TaskEndDate));

                        student.AddTask(newTask);
                        //resets the vars
                        taskName = "";
                        taskType = "";
                        TaskReocurring = "";
                        TaskStartDate = "";
                        TaskEndDate = "";
                    }
                    else
                    {
                        //reads unitl end of line if it isnt a task or a course
                        while ((char)reader.Peek() != ';')
                        {
                            restOfLine += (char)reader.Read();
                        }

                        restOfLine += (char)reader.Read();
                    }
                    username = "";
                }

                reader.Close();
            }
        }

        public void EditTaskToFile(Student student, Task_ editTask, Task_ oldTask)
        {
            //path to file
            string docPath = Path.GetFullPath(fileName);
            //creates a list and reads in the file before editing
            List<string> quotelist = File.ReadAllLines(docPath).ToList(); 
            //allows the access to file read and write
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

            reader = new StreamReader(file);

            int LineToDelete = 0;
            string taskName = "";
            string userName = "";
            string buffer = "";
            using (reader)
            {

                while (!reader.EndOfStream)
                {
                    //reads in the username
                    while ((char)reader.Peek() != ',')
                    {
                        userName += (char)reader.Read();
                    }
                    buffer += (char)reader.Read();
                    //checks for the t for the task
                    if (userName.Trim() == student.UserName + 't')
                    {
                        while ((char)reader.Peek() != ',')
                        {
                            taskName += (char)reader.Read();
                        }
                        buffer += (char)reader.Read();
                        //checks to see if the task name matches if so then get
                        //out of function bc line found
                        if (taskName.Trim() == oldTask.TaskName)
                        {
                            break;
                        }
                        else
                        {
                            //not a task then reads till next line
                            while ((char)reader.Peek() != ';')
                            {
                                buffer += (char)reader.Read();
                            }
                            buffer += (char)reader.Read();
                            //updates line integer
                            LineToDelete++;
                            taskName = "";
                        }
                    }
                    else
                    {
                        //reads line till end all else fails
                        while ((char)reader.Peek() != ';')
                        {
                            buffer += (char)reader.Read();
                        }
                        buffer += (char)reader.Read();
                        LineToDelete++;
                    }

                    userName = "";
                }
            }

           //removes the line to array
            quotelist.RemoveAt(LineToDelete);
           
            //rewrite the new lines to file
            File.WriteAllLines(docPath, quotelist.ToArray());
            //adds the new task to file 
            AddTaskToFile(student, editTask);
        }


        public void EditCourseToFile(Student student, Course oldCourse, Course newCourse)
        {

            string docPath = Path.GetFullPath(fileName);
            List<string> quotelist = File.ReadAllLines(docPath).ToList(); ;
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

          

            reader = new StreamReader(file);

            int LineToDelete = 0;
            string courseName = "";
            string userName = "";
            string buffer = "";

            using (reader)
            {

                while (!reader.EndOfStream)
                {

                    while ((char)reader.Peek() != ',')
                    {
                        userName += (char)reader.Read();
                    }
                    buffer += (char)reader.Read();

                    if (userName.Trim() == student.UserName + 'c')
                    {
                        while ((char)reader.Peek() != ',')
                        {
                            courseName += (char)reader.Read();
                        }
                        buffer += (char)reader.Read();

                        if (courseName.Trim() == oldCourse.CourseName)
                        {
                            break;
                        }
                        else
                        {
                            while ((char)reader.Peek() != ';')
                            {
                                buffer += (char)reader.Read();
                            }
                            buffer += (char)reader.Read();
                            LineToDelete++;
                            courseName = "";

                        }
                    }
                    else
                    {
                        while ((char)reader.Peek() != ';')
                        {
                            buffer += (char)reader.Read();
                        }
                        buffer += (char)reader.Read();
                        LineToDelete++;
                    }

                    userName = "";
                }
            }


            quotelist.RemoveAt(LineToDelete);
            File.WriteAllLines(docPath, quotelist.ToArray());
            AddCourseToFile(student, newCourse);
        }



      
        public void DeleteCourseToFile(Student student, Course oldCourse)
        {
            //path of file
            string docPath = Path.GetFullPath(fileName);
            //list of filelines
            List<string> quotelist = File.ReadAllLines(docPath).ToList(); 
            //access to both read and write
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

          
            reader = new StreamReader(file);


            int LineToDelete = 0;
            string courseName = "";
            string userName = "";
            string buffer = "";
            using (reader)
            {

                while (!reader.EndOfStream)
                {
                    //read for username
                    while ((char)reader.Peek() != ',')
                    {
                        userName += (char)reader.Read();
                    }
                    buffer += (char)reader.Read();
                    //checks for the user course
                    if (userName.Trim() == student.UserName + 'c')
                    {
                        while ((char)reader.Peek() != ',')
                        {
                            courseName += (char)reader.Read();
                        }
                        buffer += (char)reader.Read();
                        //checks for courses matches
                        if (courseName.Trim() == oldCourse.CourseName)
                        {
                            break;
                        }
                        else
                        {
                            //reads in the next line
                            while ((char)reader.Peek() != ';')
                            {
                                buffer += (char)reader.Read();
                            }
                            buffer += (char)reader.Read();
                            LineToDelete++;
                            courseName = "";

                        }
                    }
                    else
                    {
                        //reads in next line if not a course
                        while ((char)reader.Peek() != ';')
                        {
                            buffer += (char)reader.Read();
                        }
                        buffer += (char)reader.Read();
                        LineToDelete++;
                    }

                    userName = "";
                }
            }


            //removes the course and writes new lines to file
            quotelist.RemoveAt(LineToDelete);
            File.WriteAllLines(docPath, quotelist.ToArray());


        }

        /// <summary>
        /// same thing as course above 
        /// finds the username checks to see if it is course 
        /// checks to see if coruse name matches and deletes it
        /// </summary>
        /// <param name="student"></param>
        /// <param name="oldTask"></param>
        public void DeleteTaskToFile(Student student, Task_ oldTask)
        {

            string docPath = Path.GetFullPath(fileName);
            List<string> quotelist = File.ReadAllLines(docPath).ToList(); ;
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            Console.WriteLine(oldTask.TaskName);
          

            reader = new StreamReader(file);

            int LineToDelete = 0;
            string taskName = "";
            string userName = "";
            string buffer = "";
            using (reader)
            {

                while (!reader.EndOfStream)
                {

                    while ((char)reader.Peek() != ',')
                    {
                        userName += (char)reader.Read();
                    }
                    buffer += (char)reader.Read();

                    if (userName.Trim() == student.UserName + 't')
                    {
                        while ((char)reader.Peek() != ',')
                        {
                            taskName += (char)reader.Read();
                        }
                        buffer += (char)reader.Read();

                        if (taskName.Trim() == oldTask.TaskName)
                        {
                            break;
                        }
                        else
                        {
                            while ((char)reader.Peek() != ';')
                            {
                                buffer += (char)reader.Read();
                            }
                            buffer += (char)reader.Read();
                            LineToDelete++;
                            taskName = "";

                        }
                    }
                    else
                    {
                        while ((char)reader.Peek() != ';')
                        {
                            buffer += (char)reader.Read();
                        }
                        buffer += (char)reader.Read();
                        LineToDelete++;
                    }

                    userName = "";
                }
            }

          

            quotelist.RemoveAt(LineToDelete);
            File.WriteAllLines(docPath, quotelist.ToArray());
        }
    }
}

















