using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Coding4Fun.Phone.Controls;
using Google.AdMob.Ads.WindowsPhone7;

namespace gpaCalculator
{

    public partial class MainPage : PhoneApplicationPage
    {
        
        double grade = 0;
        double count;
        double result;



        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Calculate

            if (count == 0)
            {
                button8.Content = "Enter 1st Grade";
            }

            else
            {

                result = grade / count;
                result = Math.Round(result, 2);
                button8.Content = result.ToString();
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            //F
            count++;
            grade = grade + 0;
            button8.Content = count + " grade F";
 
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            //D
            count++;
            grade = grade + 1;
            button8.Content = count + " grade D";
            
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            //C
            count++;
            grade = grade + 2;
            button8.Content = count + " grade C";
            
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            //B
            count++;
            grade = grade + 3;
            button8.Content = count + " grade B";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            //A
            count++;
            grade = grade + 4;
            button8.Content = count + " grade A";
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            //Clear
            count = 0;
            grade = 0;

            button8.Content = "GPA";

        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {

        }

        //ApplicationBarMode
        private void Settings_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Page2.xaml", UriKind.Relative));
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            count = 0;
            grade = 0;
            button8.Content = "GPA";
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            //InputPrompt input = new InputPrompt();
            //input.Completed += input_Completed;
            //input.Title = "Basic Input";
            //input.Message = "I'm a basic input prompt";
            //input.Show();
        }

        void input_Completed(object sender, PopUpEventArgs<object, PopUpResult> e)
        {
            int x = 98;
        }

    }
}