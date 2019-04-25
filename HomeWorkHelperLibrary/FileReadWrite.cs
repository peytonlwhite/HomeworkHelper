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
        static int numofStudents = 0;
        static int numOfAddFiles = 0;
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


                using (outputFile)
                {

                    outputFile.WriteLine(student.UserName + ',' + student.Password + ',' + student.Name + ',' +
                                          student.SecurityQuestionAnswers[0] + ',' + student.SecurityQuestionAnswers[1]
                                          + ';');
                    //outputFile.Write(",");
                    //  outputFile.Write(student.Password);
                    //  outputFile.Write(",");
                    //  outputFile.Write(student.Name);
                    //  outputFile.Write(",");
                    //  for (int i = 0; i < student.SecurityQuestionAnswers.Count(); i++)
                    //  {
                    //     outputFile.Write(student.SecurityQuestionAnswers[i]);

                    //     if (i == student.SecurityQuestionAnswers.Count() - 1)
                    //     {
                    //         outputFile.Write(";");

                    //     }
                    //     else
                    //    {
                    // outputFile.Write(",");
                    //    }
                    // }


                }
                outputFile.Close();
            }
            outputFile.Close();
            numofStudents++;
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

                    outputFile.WriteLine(student.UserName + 'c' + ',' + course.CourseName + ',' + course.CourseNumber + ',' + course.CourseTime
                                          + ',' + course.DateOfCourse + ';');
                  /* outputFile.WriteLine();
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
                    */
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

                    outputFile.WriteLine(student.UserName + 't' + ',' + task.TaskName + ',' + task.Type + ','
                                         + task.ReoccuringTask + ',' + task.DueDate + ',' + task.DueDateEnd + ';');

                    /* outputFile.Write('t');
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

      */
                }
            }
            numOfAddFiles++;
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

            using (reader)
            {
                while (!reader.EndOfStream)
                {

                    Console.WriteLine(5);

                    while ((char)reader.Peek() != ',')
                    {
                        username += (char)reader.Read();
                        Console.WriteLine(6);
                        if (reader.EndOfStream)
                        {
                            return;
                        }
                    }

                    restOfLine += (char)reader.Read();


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
                    }

                    username = "";
                }

                reader.Close();
            }
        }

        public void EditTaskToFile(Student student, Task_ editTask, Task_ oldTask)
        {

            string docPath = Path.GetFullPath(fileName);
            List<string> quotelist = File.ReadAllLines(docPath).ToList(); ;
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

            foreach (var line in quotelist)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("count::::" + quotelist[1]);

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

                    Console.WriteLine(userName);
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

            Console.WriteLine("linessssssss" + LineToDelete);
            quotelist.RemoveAt(LineToDelete);
            foreach (var line in quotelist)
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines(docPath, quotelist.ToArray());
            AddTaskToFile(student, editTask);
        }


        public void EditCourseToFile(Student student, Course oldCourse, Course newCourse)
        {

            string docPath = Path.GetFullPath(fileName);
            List<string> quotelist = File.ReadAllLines(docPath).ToList(); ;
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

            foreach (var line in quotelist)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("count::::" + quotelist[1]);

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

                    Console.WriteLine(userName);
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

            Console.WriteLine("linessssssss" + LineToDelete);
            quotelist.RemoveAt(LineToDelete);
            foreach (var line in quotelist)
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines(docPath, quotelist.ToArray());
            AddCourseToFile(student, newCourse);
        }




        public void DeleteCourseToFile(Student student, Course oldCourse)
        {

            string docPath = Path.GetFullPath(fileName);
            List<string> quotelist = File.ReadAllLines(docPath).ToList(); ;
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);

            foreach (var line in quotelist)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("count::::" + quotelist[1]);
            Console.WriteLine(oldCourse.CourseName);
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

                    Console.WriteLine(userName);
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

            Console.WriteLine("linessssssss" + LineToDelete);
            quotelist.RemoveAt(LineToDelete);
            foreach (var line in quotelist)
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines(docPath, quotelist.ToArray());
            

        }


        public void DeleteTaskToFile(Student student, Task_ oldTask)
        {

            string docPath = Path.GetFullPath(fileName);
            List<string> quotelist = File.ReadAllLines(docPath).ToList(); ;
            Stream file = new FileStream(docPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
            Console.WriteLine(oldTask.TaskName);
            foreach (var line in quotelist)
            {
                Console.WriteLine(line);
            }
            Console.WriteLine("count::::" + quotelist[1]);

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

                    Console.WriteLine(userName);
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

            Console.WriteLine("linessssssss" + LineToDelete);
            quotelist.RemoveAt(LineToDelete);
            foreach (var line in quotelist)
            {
                Console.WriteLine(line);
            }

            File.WriteAllLines(docPath, quotelist.ToArray());
            
        }


    }
}

















