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

        private void Tetszoleges(object sender, RoutedEventArgs e)
        {
            String eredmeny =
                $"{txtAszam.Text} + {txtBszam.Text} = " +
                $"{Convert.ToDouble(txtAszam.Text) + Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("Az összeadás eredménye: " + eredmeny);
            lbEredmenyek.Items.Add
                (eredmeny);
            this.Background = new SolidColorBrush(Colors.DarkBlue);
        }

        private void btnKivon_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny =
                $"{txtAszam.Text} - {txtBszam.Text} = " +
                $"{Convert.ToDouble(txtAszam.Text) - Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("A kivonás eredménye: " + eredmeny);
            lbEredmenyek.Items.Add
                (eredmeny);
            this.Background = new SolidColorBrush(Colors.LightSteelBlue);
        }

        private void btnSzoroz_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny =
                $"{txtAszam.Text} * {txtBszam.Text} = " +
                $"{Convert.ToDouble(txtAszam.Text) * Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("A kivonás eredménye: " + eredmeny);
            lbEredmenyek.Items.Add
                (eredmeny);
            this.Background = new SolidColorBrush(Colors.DarkCyan);
        }

        private void btnEloszt_Click(object sender, RoutedEventArgs e)
        {
            String eredmeny =
                $"{txtAszam.Text} / {txtBszam.Text} = " +
                $"{Convert.ToDouble(txtAszam.Text) / Convert.ToDouble(txtBszam.Text)}";
            MessageBox.Show("A kivonás eredménye: " + eredmeny);
            lbEredmenyek.Items.Add
                (eredmeny);
            this.Background = new SolidColorBrush(Colors.LightSkyBlue);
        }
    }
}
