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

        private void AddTaskButton(object sender, RoutedEventArgs e)
        {
            if (NameOfTaskTB.Text == "" || TypeComboBox.Text == "" || DueDateOfTaskDP.SelectedDate == null
                || EndDateOfTaskDP.SelectedDate == null)
            {
                MessageBox.Show("Please enter all information");
            }
            else
            {
                bool reocurring = false;
                string taskName = NameOfTaskTB.Text;
                string type = Convert.ToString(TypeComboBox.Text);
                DateTime dueDate = (DateTime)DueDateOfTaskDP.SelectedDate;
                DateTime endDate = (DateTime)EndDateOfTaskDP.SelectedDate;


                if (YesRB.IsChecked == true)
                {
                    reocurring = true;
                }

                Task_ task = new Task_(taskName, type, reocurring, dueDate, endDate);

                student.AddTask(task);
                FileReadWrite file = new FileReadWrite();
                file.AddTaskToFile(student, task, false);
                homeScreen home = new homeScreen(student);


                this.Close();
                home.Show();
            }
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            homeScreen home = new homeScreen(student);
            this.Close();
            home.Show();
        }
    }
}
