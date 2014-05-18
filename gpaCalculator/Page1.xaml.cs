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
using Google.AdMob.Ads.WindowsPhone7;

namespace gpaCalculator
{
    public partial class Page1 : PhoneApplicationPage
    {
        string aPlus;
        string aMinus;
        double aPlus1 = 0;
        double aMinus1 = 0;

        string bPlus;
        string bMinus;
        double bPlus1 = 0;
        double bMinus1 = 0;

        string dPlus;
        string dMinus;
        double dPlus1 = 0;
        double dMinus1 = 0;

        string cPlus;
        string cMinus;
        double cPlus1 = 0;
        double cMinus1 = 0;
        double temp = 0;

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (NavigationContext.QueryString.TryGetValue("Aplus", out aPlus)) ;
            if (NavigationContext.QueryString.TryGetValue("Aminus", out aMinus));

            if (NavigationContext.QueryString.TryGetValue("Bplus", out bPlus));
            if (NavigationContext.QueryString.TryGetValue("Bminus", out bMinus));

            if (NavigationContext.QueryString.TryGetValue("Cplus", out cPlus));
            if (NavigationContext.QueryString.TryGetValue("Cminus", out cMinus));

            if (NavigationContext.QueryString.TryGetValue("Dplus", out dPlus));
            if (NavigationContext.QueryString.TryGetValue("Dminus", out dMinus));
        }

        public Page1()
        {
            InitializeComponent();

        }


        double grade = 0;
        double count;
        double result;




        private void button9_Click(object sender, RoutedEventArgs e)
        {
            //A Plus
            count++;
            double.TryParse(aPlus, out temp);
            aPlus1 = temp;
            grade = grade + aPlus1;
            button8.Content = count + " grade A+";
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            //A
            count++;
            grade = grade + 4;
            button8.Content = count + " grade A";
        }

        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            //B
            count++;
            grade = grade + 3;
            button8.Content = count + " grade B";
        }

        private void button4_Click_1(object sender, RoutedEventArgs e)
        {
            //C
            count++;
            grade = grade + 2;
            button8.Content = count + " grade C";
        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            //D
            count++;
            grade = grade + 1;
            button8.Content = count + " grade D";
        }

        private void button6_Click_1(object sender, RoutedEventArgs e)
        {
            //F
            count++;
            grade = grade + 0;
            button8.Content = count + " grade F";
        }

        private void button7_Click_1(object sender, RoutedEventArgs e)
        {
            //Clear
            count = 0;
            grade = 0;
            button8.Content = "GPA";
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
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

        private void button8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            //A-
            count++;
            double.TryParse(aMinus, out temp);
            aMinus1 = temp;
            grade = grade + aMinus1;
            button8.Content = count + " grade A-";
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            //B+
            count++;
            double.TryParse(bPlus, out temp);
            bPlus1 = temp;
            grade = grade + bPlus1;
            button8.Content = count + " grade B+";
        }

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            //B-
            count++;
            double.TryParse(bMinus, out temp);
            bMinus1 = temp;
            grade = grade + bMinus1;
            button8.Content = count + " grade B-";
        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            //C+
            count++;
            double.TryParse(cPlus, out temp);
            cPlus1 = temp;
            grade = grade + cPlus1;
            button8.Content = count + " grade C+";
        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            //C-
            count++;
            double.TryParse(cMinus, out temp);
            cMinus1 = temp;
            grade = grade + cMinus1;
            button8.Content = count + " grade C-";
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            //D+
            count++;
            double.TryParse(dPlus, out temp);
            dPlus1 = temp;
            grade = grade + dPlus1;
            button8.Content = count + " grade D+";
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            //D-
            count++;
            double.TryParse(dMinus, out temp);
            dMinus1 = temp;
            grade = grade + dMinus1;
            button8.Content = count + " grade D-";
        }
    }
}