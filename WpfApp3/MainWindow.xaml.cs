using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        class topvo
        { public string ob { get; set; }
        public string plot { get; set; }
        }


      public  class storage
        {
            public string obhran { get; set; } = "500";
            public string zapas { get; set; } = "4000";
        }

        class gasstation
        {
            void fill(int obyem)
            {

            }
        }
      
     

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           topvo tp = new topvo();
            tp.plot = plotnost.Text;
            tp.ob = obyem.Text;

            int M = int.Parse(tp.plot) * int.Parse(tp.ob);
            MessageBox.Show(M.ToString());
            
          
        }

        private void rasshetmassy_Click(object sender, RoutedEventArgs e)
        {
            massa.Visibility = Visibility.Visible;
            buttons.Visibility = Visibility.Hidden;
        }

        private void storage_Click(object sender, RoutedEventArgs e)
        {
            storage storage = new storage();
            MessageBox.Show($"{"Запас: " + storage.zapas + " " + "Объем: " + storage.obhran}");
        }

        private void filling_Click(object sender, RoutedEventArgs e)
        {

        }

        private void izvldob_Click(object sender, RoutedEventArgs e)
        {
            upravlenie.Visibility = Visibility.Visible;
            buttons.Visibility= Visibility.Hidden;
        }

        private void addfuel_Click(object sender, RoutedEventArgs e)
        {
            storage st = new storage();
            int zap = int.Parse(st.zapas);

            zap += int.Parse(adddivtb.Text);

            MessageBox.Show(zap.ToString());
        }

        private void divfuel_Click(object sender, RoutedEventArgs e)
        {
            storage st = new storage();
            int zap = int.Parse(st.zapas);

            zap -= int.Parse(adddivtb.Text);

            MessageBox.Show(zap.ToString());
        }
    }
}
