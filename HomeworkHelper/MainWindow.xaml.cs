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

 
    public partial class loginForm : Window
    {
        private Student student;

        public loginForm()
        {
            InitializeComponent();
            student = new Student();
           
        }

        private void New_User_Button_Click(object sender, RoutedEventArgs e)
        {
            newUser newU = new newUser();
            this.Close();
            newU.ShowDialog();
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            FileReadWrite file = new FileReadWrite();
              if (usernameTB.Text.Trim() == "" && passwordBox.Password == "")
              {
                  MessageBox.Show("Please enter Username and Password.");
              }
              else
              {
                  if (file.readStudentFromFile(student, usernameTB.Text.Trim(), passwordBox.Password.Trim()))
                  {
                      file.ReadDataFromFile(student);
                      homeScreen studentForm = new homeScreen(student);
                      
                      this.Close();
                      studentForm.ShowDialog();

                  }
                  else
                  {
                      MessageBox.Show("Username and password is incorrect.");
                  }
              }
          }

        private void usernameTB_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }

