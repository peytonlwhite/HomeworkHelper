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
            string time = "11:11";
            var newTime = Convert.ToDateTime(time);
            DateTime realTime = newTime;

        }

        private void AddTaskButton(object sender, RoutedEventArgs e)
        {
            bool reocurring = false;
            if (YesRB.IsChecked == true)
            {
                reocurring = true;
            }
            Task_ task = new Task_(NameOfTaskTB.Text, Convert.ToString(TypeComboBox.Text), reocurring,
                (DateTime)RemindOfTaskDP.SelectedDate,
                                  (DateTime)DueDateOfTaskDP.SelectedDate, (DateTime)EndDateOfTaskDP.SelectedDate);

            student.AddTask(task);

            homeScreen home = new homeScreen(student);

            this.Close();
            home.Show();

        }
    }
}
