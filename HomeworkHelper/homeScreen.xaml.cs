using HomeWorkHelperLibrary;
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
using System.Windows.Shapes;

namespace HomeworkHelper
{
    /// <summary>
    /// Interaction logic for student.xaml
    /// </summary>
    /// 

    public partial class homeScreen : Window
    {

        public List<Task_> tasks { get; set; }
        private Student student;
        
        public homeScreen(Student student)
        {

            InitializeComponent();
            

            this.student = student;
            tasks = new List<Task_>();

            for (int i = 0; i < student.TaskList.Count; i++)
            {
                tasks.Add(student.TaskList[i]);
            }

            DataContext = this;

        }
       
        
        private void AddCourse_Click(object sender, RoutedEventArgs e)
        {
           
            AddCourse addcourse = new AddCourse(student);

            this.Close();
            addcourse.Show();
        }

        private void View_CourseClick(object sender, RoutedEventArgs e)
        {
            ViewCourses viewCourse = new ViewCourses(student);
            this.Close();
            viewCourse.Show();
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            AddTask add = new AddTask(student);
            this.Close();
            add.Show();
        }

        private void edit_task_click(object sender, RoutedEventArgs e)
        {
            if (student.TaskList.Count == 0)
            {
                MessageBox.Show("There are no tasks to be edited");
            }
            else
            {
                EditTask et = new EditTask(student);
                this.Close();
                et.Show();
            }
        }

        private void delete_task_click(object sender, RoutedEventArgs e)
        {
            if (student.TaskList.Count == 0)
            {
                MessageBox.Show("There are no tasks to be deleted");
            }
            else
            {
                DeleteTask dt = new DeleteTask(student);
                this.Close();
                dt.Show();
            }
        }
    }
}
