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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BMI_Rechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Berechnen(object sender, RoutedEventArgs e)
       {
            try
            {
                double Gewichte = Double.Parse(Gewicht.Text);
                double Groessen = Double.Parse(Grosse.Text);
                string Geschlechter = Geschlecht.SelectedItem.ToString();
                string[] Geschlecht_string = Geschlechter.Split(':');
                double Groessen_meter = Groessen / 100;
                double Ergebnis = Gewichte / Math.Pow(Groessen_meter, 2);
                string Test = Geschlecht_string[1];
                Ausgabe.Content = "Der BMI Beträgt: " + Ergebnis + Geschlecht_string[1];

                //infos von https://www.brigitte.de/gesund/abnehmen/bmi-rechner--hier-kostenlos-bmi-berechnen-10102054.html
                if (Geschlecht_string[1] != "Weiblich" )
                {
                    if (Ergebnis < 19)
                    {
                        BMI.Content = " Sie sind im Untergewicht, bitte suchen Sie einen Arzt auf um Gesundheitliche Risiken in der Zukunft zu minimieren";
                    }
                   if (Ergebnis >= 19 && Ergebnis<= 24)
                    {
                        BMI.Content = " Sie sind im Normalgewicht";
                    }
                    if (Ergebnis >= 25 && Ergebnis <= 30)
                    {
                        BMI.Content = " Sie sind im Übergewicht, bitte suchen Sie einen Arzt auf um Gesundheitliche Risiken in der Zukunft zu minimieren";
                    }
                   if (Ergebnis >= 31 )
                    {
                        BMI.Content = " Sie sind Adipositas, bitte suchen Sie einen Arzt auf um Gesundheitliche Risiken in der Zukunft zu minimieren";
                     
                    }
                }
           else     
                {
                    if (Ergebnis < 20)
                    {
                        BMI.Content = " Sie sind im Untergewicht, bitte suchen Sie einen Arzt auf um Gesundheitliche Risiken in der Zukunft zu minimieren";
                    }
                 else   if (Ergebnis >= 20 && Ergebnis <= 25)
                    {
                        BMI.Content = " Sie sind im Normalgewicht";
                    }
                  else  if (Ergebnis >= 26 && Ergebnis <= 30)
                    {
                        BMI.Content = " Sie sind im Übergewicht, bitte suchen Sie einen Arzt auf um Gesundheitliche Risiken in der Zukunft zu minimieren";
                    }
                  else  if (Ergebnis >= 31 )
                    {
                        BMI.Content = " Sie sind Adipositas bitte suchen Sie einen Arzt auf um Gesundheitliche Risiken in der Zukunft zu minimieren";
                    }
                }

            }
            catch
            {
                Ausgabe.Content= ("Ungültiges Gewicht bitte geben Sie ein gültiges Gewicht an");
            }
        }

       
    }
}
