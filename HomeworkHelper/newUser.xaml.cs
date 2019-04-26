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
    /// Interaction logic for newUser.xaml
    /// </summary>
    public partial class newUser : Window
    {

        Student student;
        

        public newUser()
        {
            InitializeComponent();
          
     
        }

        private void answerTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            //student.SecurityQuestionAnswers[0] = "d";
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            string[] sQA = { answerTB.Text.Trim(), answerTB2.Text.Trim() };
            student = new Student(firstNameTB.Text, usernameTB1.Text, passwordTB.Text,sQA);
           

            if (answerTB.Text.Trim() == "" || answerTB2.Text.Trim() == "" || firstNameTB.Text.Trim() == "" ||
                usernameTB1.Text.Trim() == "" || passwordTB.Text.Trim() == "")
            {
                MessageBox.Show("Please enter all information");
            }
            else
            {
                FileReadWrite file = new FileReadWrite();
                file.AddStudentToFile(student);
                homeScreen hs = new homeScreen(student);

                this.Close();
                hs.Show();
                
            }       
            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }

}
