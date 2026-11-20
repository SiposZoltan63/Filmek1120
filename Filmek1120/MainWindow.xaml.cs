using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Filmek1120
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        List<Filmek> filmek = new List<Filmek>();
        public MainWindow()
        {
            InitializeComponent();
            filmek.Add(new Filmek("Titanic",2,"sci-fi"));
        }

        private void Filmekbetoltese(object sender, RoutedEventArgs e)
        {
            dGrid.ItemsSource = filmek;
        }
        private void Filmekszama(object sender, RoutedEventArgs e)
        {
            int filmekszam = filmek.Count();
            MessageBox.Show($"Ennyi film van: {Convert.ToString(filmekszam)}");
        }
        private void Filmhossz(object sender, RoutedEventArgs e)
        {
            Filmek leghosszabb = Filmek.[0];
            foreach (var item in filmek)
            {
                if (item.Hossz > leghosszabb.Hossz)
                {
                    leghosszabb.Hossz;
                }
            }
            MessageBox.Show($"A leghosszabb film: {leghosszabb.Cim} Hossza: {leghosszabb.Hossz}");
        }

        private void scifi(object sender, RoutedEventArgs e)
        {
            List<Filmek> csakscifi = new List<Filmek>();
            foreach (var Film in csakscifi)
            {
                if (Film.Mufaj == "sci-fi")
                {
                    csakscifi.Add(Film);
                }
                dGrid.ItemsSource = csakscifi;
            }
        }

        private void csakcim(object sender, RoutedEventArgs e)
        {
            List<Cimek> CsakCim = new List<Cimek>();
            foreach (var c in CsakCim)
            {
                CsakCim.Add(new Cimek($"{CsakCim = Cimek.Cim}"));
            }
            dGrid.ItemsSource=CsakCim;
        }

        private void rendezescimszerint(object sender, RoutedEventArgs e)
        {
            List<Filmek> Rendezett = new List<Filmek>();
            dGrid.ItemsSource = Rendezett;
        }

        private void Kattintas(object sender, SelectionChangedEventArgs e)
        {
            if (dGrid.SelectedItem is Filmek)
            {
                progressbar.Value = ((Filmek)dGrid.SelectedItem).Hossz;
            }
            else 
            {
                MessageBox.Show($"A kiválasztott elem nem film tipusú");
            }
        }
    }
}