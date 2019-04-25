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

        string fileName;

        StreamReader reader;
        StreamWriter outputFile;


        public FileReadWrite()
        {
            fileName = "StudentDetails.txt";

        }

        public void AddStudentToFile(Student student)
        {
            string docPath = Path.GetFullPath(fileName);
            outputFile = new StreamWriter(docPath, true);

            // Set a variable to the Documents path.
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
                outputFile.Close();
            }
            else
            {

                // Append text to an existing file named "WriteLines.txt".
                using (outputFile)
                {
                    outputFile.WriteLine();
                    outputFile.Write(student.UserName);
                    outputFile.Write(",");
                    outputFile.Write(student.Password);
                    outputFile.Write(",");
                    outputFile.Write(student.Name);
                    outputFile.Write(",");
                    for (int i = 0; i < student.SecurityQuestionAnswers.Count(); i++)
                    {
                        outputFile.Write(student.SecurityQuestionAnswers[i]);

                        if (i == student.SecurityQuestionAnswers.Count() - 1)
                        {
                            outputFile.Write(";");

                        }
                        else
                        {
                            outputFile.Write(",");
                        }
                    }
                    outputFile.WriteLine();

                }
                outputFile.Close();
            }
            outputFile.Close();
        }

        public bool readStudentFromFile(ref Student student, string userName, string password)
        {

            string docPath = Path.GetFullPath(fileName);
            reader = new StreamReader(docPath, true);


            using (reader)
            {

                while (!reader.EndOfStream)
                {
                    string fileUserName = "";
                    string filePassWord = "";
                    string restOfLine = "";
                    Console.WriteLine(1);
                    while ((char)reader.Peek() != ',')
                    {
                        fileUserName += (char)reader.Read();
                        Console.WriteLine(2);
                    }
                    string buffer = "";
                    buffer += (char)reader.Read();
                    while ((char)reader.Peek() != ',')
                    {
                        filePassWord += (char)reader.Read();
                        Console.WriteLine(3);
                    }
                    Console.WriteLine(fileUserName);
                    Console.WriteLine(filePassWord);
                    restOfLine = Convert.ToString(reader.ReadLine());
                    // while (reader.Read() != ';')
                    //{
                    //    restOfLine += reader.Read();
                    Console.WriteLine(4);
                    //}
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
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            reader = new StreamReader(file);
            outputFile = new StreamWriter(file);

            using (reader)
            {

                reader.ReadToEnd();

                using (outputFile)
                {
                    outputFile.WriteLine();
                    outputFile.Write(student.UserName);
                    outputFile.Write('c');
                    outputFile.Write(',');
                    outputFile.Write(course.CourseName);
                    outputFile.Write(',');
                    outputFile.Write(course.CourseNumber);
                    outputFile.Write(',');
                    outputFile.Write(course.CourseTime);
                    outputFile.Write(',');
                    outputFile.Write(course.DateOfCourse);
                    outputFile.Write(';');



                }
            }

        }



        public void AddTaskToFile(Student student, Task_ task)
        {


            string docPath = Path.GetFullPath(fileName);
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            reader = new StreamReader(file);
            outputFile = new StreamWriter(file);

            using (reader)
            {

                reader.ReadToEnd();

                using (outputFile)
                {
                    outputFile.WriteLine();
                    outputFile.Write(student.UserName);
                    outputFile.Write('t');
                    outputFile.Write(',');
                    outputFile.Write(task.TaskName);
                    outputFile.Write(',');
                    outputFile.Write(task.Type);
                    outputFile.Write(',');
                    outputFile.Write(task.ReoccuringTask);
                    outputFile.Write(',');
                    outputFile.Write(task.DueDate);
                    outputFile.Write(',');
                    outputFile.Write(task.DueDate);
                    outputFile.Write(';');


                }
            }

        }



        public void ReadDataFromFile(ref Student student)
        {

            string docPath = Path.GetFullPath(fileName);
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            reader = new StreamReader(file);
            Task_ newTask;
            Course newCourse;
            string username = "";
            string restOfLine = "";
            int lines = 0;
            while (!reader.EndOfStream)
            {
                reader.ReadLine();
                lines++;
            }
            reader.BaseStream.Position = 0;


            using (reader)
            {
                while (!reader.EndOfStream)
                {
                    Console.WriteLine(5);
                    while ((char)reader.Peek() != ',')
                    {
                        username += (char)reader.Read();
                        Console.WriteLine(6);
                    }

                    restOfLine += (char)reader.Read();

                    Console.WriteLine(username);
                    if(lines == 1)
                    {
                        break;
                    }
                    if (username.Trim() == (student.UserName + 'c'))
                    {
                        string courseName = "";
                        string courseNumber = "";
                        string courseTime = "";
                        string courseDate = "";
                        Console.WriteLine(7);
                        while ((char)reader.Peek() != ',')
                        {
                            courseName += (char)reader.Read();
                        }

                        restOfLine += (char)reader.Read();

                        while ((char)reader.Peek() != ',')
                        {
                            courseNumber += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();
                        Console.WriteLine(courseNumber);
                        while ((char)reader.Peek() != ',')
                        {
                            courseTime += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();

                        while ((char)reader.Peek() != ';')
                        {
                            courseDate += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();

                        newCourse = new Course(Convert.ToInt32(courseNumber), courseName, courseTime, Convert.ToDateTime(courseDate));

                        student.AddCourse(newCourse);

                        courseName = "";
                        courseNumber = "";
                        courseTime = "";
                        courseDate = "";
                        Console.WriteLine(8);


                    }

                    else if (username.Trim() == (student.UserName + 't'))
                    {
                        string taskName = "";
                        string taskType = "";
                        string TaskReocurring = "";
                        string TaskStartDate = "";
                        string TaskEndDate = "";


                        while ((char)reader.Peek() != ',')
                        {
                            taskName += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();

                        while ((char)reader.Peek() != ',')
                        {
                            Console.WriteLine(9);
                            taskType += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();

                        while ((char)reader.Peek() != ',')
                        {
                            TaskReocurring += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();

                        while ((char)reader.Peek() != ',')
                        {
                            TaskStartDate += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();

                        while ((char)reader.Peek() != ';')
                        {
                            TaskEndDate += (char)reader.Read();
                        }
                        restOfLine += (char)reader.Read();

                        newTask = new Task_(taskName, taskType, Convert.ToBoolean(TaskReocurring), Convert.ToDateTime(TaskStartDate), Convert.ToDateTime(TaskEndDate));

                        student.AddTask(newTask);

                        taskName = "";
                        taskType = "";
                        TaskReocurring = "";
                        TaskStartDate = "";
                        TaskEndDate = "";


                    }
                   
                    else
                    {

                        while ((char)reader.Peek() != ';')
                        {
                            restOfLine += (char)reader.Read();
                            Console.WriteLine(1);

                        }
                       
                        restOfLine += (char)reader.Read();
                        Console.WriteLine(10);
                    }
                    username = "";



                    Console.WriteLine("end");
                }

                reader.Close();


            }



        }










    }
}

















