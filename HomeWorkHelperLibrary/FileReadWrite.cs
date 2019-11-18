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
            outputFile = new StreamWriter("StudentDetails.txt", true);

            outputFile.WriteLine(student.UserName + ',' + student.Password + ',' + student.Name + ',' +
                student.SecurityQuestionAnswers[0] + ',' + student.SecurityQuestionAnswers[1]
                + ';');

            outputFile.Close();
        }

        public bool readStudentFromFile(Student student, string userName, string password)
        {
            reader = new StreamReader("StudentDetails.txt", true);
            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var parts = line.Split(',');

                    string fileUserName = parts[0];
                    string filePassword = parts[1];

                    if (fileUserName.Trim() == userName && filePassword.Trim() == password)
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
            outputFile = new StreamWriter(fileName, true);

            outputFile.WriteLine(student.UserName + 'c' + ',' + course.CourseName + ','
                        + course.CourseNumber + ',' + course.CourseTime
                        + ',' + course.DateOfCourse + ';');

            outputFile.Close();
        }

        public void AddTaskToFile(Student student, Task_ task)
        {
            outputFile = new StreamWriter(fileName, true);

            outputFile.WriteLine(student.UserName + 't' + ',' + task.TaskName + ',' + task.Type + ','
                                 + task.ReoccuringTask + ',' + task.DueDate + ',' + task.DueDateEnd + ';');

            outputFile.Close();

        }

        public void ReadDataFromFile(Student student)
        {
            reader = new StreamReader(fileName);

            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    var parts = line.Split(',');

                    string userName = parts[0];

                    //checks if username mathces and sees if it is a course
                    if (userName.Trim() == (student.UserName + 'c'))
                    {
                        string courseName = parts[1];
                        string courseNumber = parts[2];
                        string courseTime = parts[3];
                        string courseDate = parts[4].TrimEnd(';');

                        //converts each string and creates the new course
                        Course course = new Course(Convert.ToInt32(courseNumber), courseName,
                            courseTime, Convert.ToDateTime(courseDate));

                        //adds the course to the list
                        student.AddCourse(course);
                    }

                    //checks if the line is a task 
                    else if (userName.Trim() == (student.UserName + 't'))
                    {

                        string taskName = parts[1];
                        string taskType = parts[2];
                        string TaskReocurring = parts[3];
                        string TaskStartDate = parts[4];
                        string TaskEndDate = parts[5].TrimEnd(';');

                        //creates the new task 
                        Task_ newTask = new Task_(taskName, taskType, Convert.ToBoolean(TaskReocurring),
                           Convert.ToDateTime(TaskStartDate), Convert.ToDateTime(TaskEndDate));

                        student.AddTask(newTask);
                    }
                }
                reader.Close();
            }
        } 

        public void EditTaskToFile(Student student, Task_ editTask, Task_ oldTask)
        {
            //path to file
            //creates a list and reads in the file before editing
            List<string> lines = File.ReadAllLines(fileName).ToList();
            //allows the access to file read and write
            reader = new StreamReader(fileName);

            int LineToDelete = 0;

            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    //reads in the username
                    string line = reader.ReadLine();
                    var parts = line.Split(',');

                    string userName = parts[0];
                    //checks for the t for the task
                    if (userName.Trim() == student.UserName + 't')
                    {
                        string taskName = parts[1];
                        //checks to see if the task name matches if so then get
                        //out of function bc line found
                        if (taskName.Trim() == oldTask.TaskName)
                            break;
                        else
                            LineToDelete++;
                    }
                    else
                        LineToDelete++;
                }
            }

            //removes the line to array
            lines.RemoveAt(LineToDelete);

            //rewrite the new lines to file
            File.WriteAllLines(fileName, lines.ToArray());
            //adds the new task to file 
            AddTaskToFile(student, editTask);

            reader.Close();
        }


        public void EditCourseToFile(Student student, Course oldCourse, Course newCourse)
        {

            //path to file
            //creates a list and reads in the file before editing
            List<string> lines = File.ReadAllLines(fileName).ToList();
            //allows the access to file read and write
            reader = new StreamReader(fileName);

            int LineToDelete = 0;

            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    //reads in the username
                    string line = reader.ReadLine();
                    var parts = line.Split(',');

                    string userName = parts[0];
                    //checks for the t for the task
                    if (userName.Trim() == student.UserName + 'c')
                    {
                        string courseName = parts[1];
                        //checks to see if the task name matches if so then get
                        //out of function bc line found
                        if (courseName.Trim() == oldCourse.CourseName)
                            break;
                        else
                            LineToDelete++;
                    }
                    else
                        LineToDelete++;
                }
            }

            lines.RemoveAt(LineToDelete);
            File.WriteAllLines(fileName, lines.ToArray());
            AddCourseToFile(student, newCourse);
        }




        public void DeleteCourseToFile(Student student, Course oldCourse)
        {
 
            List<string> lines = File.ReadAllLines(fileName).ToList();
            //access to both read and write

            reader = new StreamReader(fileName);


            int LineToDelete = 0;

            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    //reads in the username
                    string line = reader.ReadLine();
                    var parts = line.Split(',');

                    string userName = parts[0];
                    //checks for the t for the task
                    if (userName.Trim() == student.UserName + 'c')
                    {
                        string courseName = parts[1];
                        //checks to see if the task name matches if so then get
                        //out of function bc line found
                        if (courseName.Trim() == oldCourse.CourseName)
                            break;
                        else
                            LineToDelete++;
                    }
                    else
                        LineToDelete++;
                }
            }


            //removes the course and writes new lines to file
            lines.RemoveAt(LineToDelete);
            File.WriteAllLines(fileName, lines.ToArray());
        }

        public void DeleteTaskToFile(Student student, Task_ oldTask)
        {
            List<string> lines = File.ReadAllLines(fileName).ToList(); ;


            reader = new StreamReader(fileName);

            int LineToDelete = 0;

            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    //reads in the username
                    string line = reader.ReadLine();
                    var parts = line.Split(',');

                    string userName = parts[0];
                    //checks for the t for the task
                    if (userName.Trim() == student.UserName + 't')
                    {
                        string taskName = parts[1];
                        //checks to see if the task name matches if so then get
                        //out of function bc line found
                        if (taskName.Trim() == oldTask.TaskName)
                            break;
                        else
                            LineToDelete++;
                    }
                    else
                        LineToDelete++;
                }
            }
            lines.RemoveAt(LineToDelete);
            File.WriteAllLines(fileName, lines.ToArray());
        }
    }
}





















