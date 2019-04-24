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
                   
                    
                    restOfLine = Convert.ToString(reader.ReadLine());
                    Console.WriteLine(student.Password);
                    Console.WriteLine(filePassWord);

                    Console.WriteLine(student.UserName);
                    Console.WriteLine(fileUserName);

                    if (student.Password.Trim() == filePassWord.Trim() && student.UserName.Trim() == fileUserName.Trim())
                    {
                        reader.Close();
                        using (outputFile = new StreamWriter(docPath,true))
                        {
                           
                            
                            outputFile.Write(course.CourseNumber);
                            outputFile.Write(',');
                            outputFile.Write(course.CourseName);
                            outputFile.Write(',');
                            outputFile.Write(course.CourseTime);
                            outputFile.Write(',');
                            outputFile.Write(course.DateOfCourse);
                            outputFile.Write(';');

                            outputFile.Close();
                            break;
                        }



                    }
                   

                }

                
            }


        }

        public void AddTaskToFile(Student student, Task_ course)
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


                    restOfLine = Convert.ToString(reader.ReadLine());
                    Console.WriteLine(student.Password);
                    Console.WriteLine(filePassWord);

                    Console.WriteLine(student.UserName);
                    Console.WriteLine(fileUserName);

                    if (student.Password.Trim() == filePassWord.Trim() && student.UserName.Trim() == fileUserName.Trim())
                    {
                        reader.Close();
                        using (outputFile = new StreamWriter(docPath, true))
                        {


                           // outputFile.Write(course.CourseNumber);
                            outputFile.Write(',');
                           // outputFile.Write(course.CourseName);
                            outputFile.Write(',');
                           // outputFile.Write(course.CourseTime);
                            outputFile.Write(',');
                           // outputFile.Write(course.DateOfCourse);
                            outputFile.Write(';');

                            outputFile.Close();
                            break;
                        }



                    }


                }


            }


        }

















    }
}



