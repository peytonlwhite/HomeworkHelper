﻿using HomeWorkHelperLibrary;
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
    public partial class student : Window
    {

        private Course course;

        public student()
        {
            InitializeComponent();

            InitializeComponent();
            List<Course> items = new List<Course>();
        }

        

        private void AddCourse_Click(object sender, RoutedEventArgs e)
        {

            AddCourse addcourse = new AddCourse();
            this.Close();
            addcourse.Show();
        }
    }
}
