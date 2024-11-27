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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string liczba = sigma.Text;
            string figuraa = figura.Text;
            int bok;
            int pole;
            if(int.TryParse(liczba, out bok))
            {
              if(figuraa=="Kwadrat")
                {
                    pole = bok * 4;
                    MessageBox.Show(pole.ToString());
                } else if (figuraa == "trojkat")
                {
                    pole = bok * 3;
                    MessageBox.Show(pole.ToString());
                }
                else if(figuraa== "pieciokat")
                {
                    pole = bok * 5;
                    MessageBox.Show(pole.ToString());
                }
                else
                {
                    MessageBox.Show("Podaj figure");
                }
               
            }
            else
            {
                MessageBox.Show("To nie jest liczba");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string kwotaa = kwota.Text;
            int pieniadz;
            float wynik;
            if(int.TryParse(kwotaa, out pieniadz))
            {
                if (Euro.IsChecked == true)
                {
                    wynik = (float)(pieniadz * 0.26);
                    MessageBox.Show(wynik.ToString());

                }
                else if(Frank.IsChecked == true)
                {
                    wynik=(float)(pieniadz * 0.22);
                    MessageBox.Show(wynik.ToString());
                }
                else if(Dolar.IsChecked == true)
                {
                    wynik = (float)(pieniadz * 0.24);
                    MessageBox.Show(wynik.ToString());
                }
                else
                {
                    MessageBox.Show("Wybierz walute");
                }
            }
        }
    }
}
