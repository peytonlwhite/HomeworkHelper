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

        string fileName = "StudentDetails.txt";

        public FileReadWrite()
        {

        }

        public void AddStudentToFile(Student student)
        {

            // Set a variable to the Documents path.
            if (!File.Exists(fileName))
            {
                File.Create(fileName);

            }
            else
            {
                //string docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string docPath = Path.GetFullPath(fileName);

                // Append text to an existing file named "WriteLines.txt".
                using (StreamWriter outputFile = new StreamWriter(docPath, true))
                {
                    outputFile.WriteLine();
                    outputFile.Write(student.UserName);
                    outputFile.WriteLine();
                    outputFile.Write(student.Password);
                    outputFile.WriteLine();
                    outputFile.Close();
                }
            }
        }

        public bool readStudentFromFile(ref Student student, string userName, string password)
        {
            string docPath = Path.GetFullPath(fileName);

            using (var reader = new StreamReader(docPath))
            {

                while (!reader.EndOfStream)
                {


                    if (reader.ReadLine() == userName)
                    {
                        student.UserName = userName;
                        if (reader.ReadLine() == password)
                        {
                            student.Password = reader.ReadLine();

                            return true;

                        }
                    }

                }

            }
            return false;
        }
    }
}
