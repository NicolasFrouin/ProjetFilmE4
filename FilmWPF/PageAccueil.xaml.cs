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
using System.Windows.Shapes;

namespace FilmWPF
{
    /// <summary>
    /// Logique d'interaction pour PageAccueil.xaml
    /// </summary>
    public partial class PageAccueil : Window
    {
        public PageAccueil()
        {
            InitializeComponent();
        }

        private void btnFilm_Click(object sender, RoutedEventArgs e)
        {
            FilmGerer fmr = new FilmGerer();
            fmr.Show();
        }

        private void btnSpectateur_Click(object sender, RoutedEventArgs e)
        {
            SpectateurGerer fmr = new SpectateurGerer();
            fmr.Show();
        }
    }
}
