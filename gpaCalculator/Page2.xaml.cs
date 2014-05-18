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
using System.IO.IsolatedStorage;
using Google.AdMob.Ads.WindowsPhone7;

namespace gpaCalculator
{
    

    public partial class Page2 : PhoneApplicationPage
    {
        static double Aplus, Aminus, Bplus, Bminus, Cplus, Cminus, Dplus, Dminus;
        double temp;


        public Page2()
        {
            InitializeComponent();
        }

        
        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //A+
            double.TryParse(textBox1.Text, out temp);
            Aplus = temp;
        }

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            //A-
            double.TryParse(textBox2.Text, out temp);
            Aminus = temp;
        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {
            //B+
            double.TryParse(textBox3.Text, out temp);
            Bplus = temp;
        }

        private void textBox4_TextChanged(object sender, TextChangedEventArgs e)
        {
            //B-
            double.TryParse(textBox4.Text, out temp);
            Bminus = temp;
        }

        private void textBox5_TextChanged(object sender, TextChangedEventArgs e)
        {
            //C+
            double.TryParse(textBox5.Text, out temp);
            Cplus = temp;
        }

        private void textBox6_TextChanged(object sender, TextChangedEventArgs e)
        {
            //C-
            double.TryParse(textBox6.Text, out temp);
            Cminus = temp;
        }

        private void textBox7_TextChanged(object sender, TextChangedEventArgs e)
        {
            //D+
            double.TryParse(textBox7.Text, out temp);
            Dplus = temp;
        }

        private void textBox8_TextChanged(object sender, TextChangedEventArgs e)
        {
            //D-
            if (textBox8.Text.StartsWith("."))
            {
                textBox8.Text = "0" + textBox8.Text;
            }
            double.TryParse(textBox8.Text, out temp);
            Dminus = temp;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //Set Button
            IsolatedStorageSettings settings = IsolatedStorageSettings.ApplicationSettings;
            if (!settings.Contains("Aplus")) { settings.Add("Aplus", textBox1.Text); } else { settings["Aplus"] = textBox1.Text; }
            if (!settings.Contains("Aminus")) { settings.Add("Aminus", textBox2.Text); } else { settings["Aminus"] = textBox2.Text; }
            if (!settings.Contains("Bplus")) { settings.Add("Bplus", textBox3.Text); } else { settings["Bplus"] = textBox3.Text; }
            if (!settings.Contains("Bminus")) { settings.Add("Bminus", textBox4.Text); } else { settings["Bminus"] = textBox4.Text; }
            if (!settings.Contains("Cplus")) { settings.Add("Cplus", textBox5.Text); } else { settings["Cplus"] = textBox5.Text; }
            if (!settings.Contains("Cminus")) { settings.Add("Cminus", textBox6.Text); } else { settings["Cminus"] = textBox6.Text; }
            if (!settings.Contains("Dplus")) { settings.Add("Dplus", textBox7.Text); } else { settings["Dplus"] = textBox7.Text; }
            if (!settings.Contains("Dminus")) { settings.Add("Dminus", textBox8.Text); } else { settings["Dminus"] = textBox8.Text; }
            settings.Save();

            NavigationService.Navigate(new Uri("/Page1.xaml?Aplus=" + textBox1.Text +
                                                          "&Aminus=" + textBox2.Text +
                                                          "&Bplus=" + textBox3.Text +
                                                          "&Bminus=" + textBox4.Text +
                                                          "&Cplus=" + textBox5.Text +
                                                          "&Cminus=" + textBox6.Text +
                                                          "&Dplus=" + textBox7.Text +
                                                          "&Dminus=" + textBox8.Text, UriKind.Relative));
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            if (IsolatedStorageSettings.ApplicationSettings.Contains("Aplus")) { textBox1.Text = IsolatedStorageSettings.ApplicationSettings["Aplus"] as string; }
            if (IsolatedStorageSettings.ApplicationSettings.Contains("Aminus")) { textBox2.Text = IsolatedStorageSettings.ApplicationSettings["Aminus"] as string; }
            if (IsolatedStorageSettings.ApplicationSettings.Contains("Bplus")) { textBox3.Text = IsolatedStorageSettings.ApplicationSettings["Bplus"] as string; }
            if (IsolatedStorageSettings.ApplicationSettings.Contains("Bminus")) { textBox4.Text = IsolatedStorageSettings.ApplicationSettings["Bminus"] as string; }
            if (IsolatedStorageSettings.ApplicationSettings.Contains("Cplus")) { textBox5.Text = IsolatedStorageSettings.ApplicationSettings["Cplus"] as string; }
            if (IsolatedStorageSettings.ApplicationSettings.Contains("Cminus")) { textBox6.Text = IsolatedStorageSettings.ApplicationSettings["Cminus"] as string; }
            if (IsolatedStorageSettings.ApplicationSettings.Contains("Dplus")) { textBox7.Text = IsolatedStorageSettings.ApplicationSettings["Dplus"] as string; }
            if (IsolatedStorageSettings.ApplicationSettings.Contains("Dminus")) { textBox8.Text = IsolatedStorageSettings.ApplicationSettings["Dminus"] as string; }

        }
    }
}
