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

namespace TwoMassiv
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[,] mas;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = int.Parse(NRow.Text);
                int m = int.Parse(NCol.Text);
                mas = new int[n, m];
                Random rnd = new Random();
                string st = "";
                for (int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        mas[i, j] = rnd.Next(10);
                        st += mas[i, j] + " ";
                    }
                    st += Environment.NewLine;
                }
                Result.Text = st;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int[,] mas = new int[5, 5];
            string str = "";
            for(int m = 0; m < 5; m++)
            {
                for(int t = 0; t < 5; t++)
                {
                    mas[m, t] = 1;
                    if (m == 0 & t == 1) mas[m, t] = 0;
                    if (m == 1 & t == 0) mas[m, t] = 0;
                    if (m == 2 & t == 2) mas[m, t] = 0;
                    if (m == 3 & t == 0) mas[m, t] = 0;
                    if (m == 4 & t == 1) mas[m, t] = 0;
                    if (m == 0 & t == 3) mas[m, t] = 0;
                    if (m == 1 & t == 4) mas[m, t] = 0;
                    if (m == 3 & t == 4) mas[m, t] = 0;
                    if (m == 4 & t == 3) mas[m, t] = 0;
                    str += mas[m, t] + " ";
                }
                str += Environment.NewLine;
            }
            Result.Text += str + Environment.NewLine;
        }
    }
}
