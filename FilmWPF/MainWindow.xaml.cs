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

namespace FilmWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        film1e4Entities gst;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            gst = new film1e4Entities();

            cboGenre.ItemsSource = gst.genre.ToList();
            lstAllActeurs.ItemsSource = gst.acteur.ToList();
        }

        private void cboGenre_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboGenre.SelectedItem != null)
            {
                var idGenre = (cboGenre.SelectedItem as genre).Id;
                var lesFilms = from ge in gst.genre
                               join ap in gst.appartenir on ge.Id equals ap.NumGenre
                               join fi in gst.film on ap.NumFilm equals fi.Id
                               where ge.Id == idGenre
                               select fi;
                lstFilms.ItemsSource = lesFilms.ToList();
            }
        }

        private void lstFilms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lstFilms.SelectedItem != null)
            {
                var idFilm = (lstFilms.SelectedItem as film).Id;
                var lesActeurs = from ac in gst.acteur
                                 join jo in gst.jouer on ac.Id equals jo.NumActeur
                                 join fi in gst.film on jo.NumFilm equals fi.Id
                                 where fi.Id == idFilm
                                 select ac;
                lstActeurs.ItemsSource = lesActeurs.ToList();
            }
        }

        private void lstActeurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAjouterGenre_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAjouterFilm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lstAllActeurs_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
