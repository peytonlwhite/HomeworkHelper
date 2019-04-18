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
    /// Interaction logic for AddTask.xaml
    /// </summary>
    public partial class AddTask : Window
    {
        Student student;
        public AddTask(Student stu)
        {
            InitializeComponent();
            student = stu;

        }

        private void add_task_button_Click(object sender, RoutedEventArgs e)
        {
            //Task task = new Task(task_title_tb.Text, type, Convert.ToDateTime(remind_time_tb.Text),
             // Convert.ToDateTime(due_date_tb.Text));
            //student.AddTask(task);
            homeScreen hs = new homeScreen(student);
            this.Close();
            hs.Show();
        }

        private void task_type_select_cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
 
        }
    }
}
