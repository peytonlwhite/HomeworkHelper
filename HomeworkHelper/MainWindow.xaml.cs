using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HomeWorkHelperLibrary;

namespace HomeworkHelper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
            string[] arr = { "Clarksville", "APSU", "Chevy"};

            DateTime date = new DateTime(2010, 5, 5);
            List<DateTime> dates = new List<DateTime>();
            

            Student Peyton = new Student("Peyton", "Peyton18", "Peyton White",arr);

            Tasks Quiz = new Tasks("quiz 1", true, date, date, date);
            Quiz.AddTask(Quiz, Peyton);
            Quiz.EditTaskName(Quiz, "quiz 3");

            Courses MathCourse = new Courses(2010, "stats", "sucks", dates, dates);
            MathCourse.AddCourse(MathCourse, Peyton);


           foreach(Tasks t in Peyton._taskList)
            {
                Console.WriteLine(t.TaskName);
            }
           


        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
