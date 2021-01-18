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

namespace MusicIndustryConcerts.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy ArtistAdd.xaml
    /// </summary>
    public partial class ArtistAdd : Page
    {
        public ArtistAdd()
        {
            InitializeComponent();
            FillGenres();
        }

        private void AddArtist()
        {
            var context = new MusicIndustryConcertsEntities();

            var newArtist = new Artists() {
                ArtistName = artistNameInput.Text,
                MusicGenre = artistMusicGenreInput.SelectedValue.ToString(),
                PerformancePrice = Convert.ToInt32(artistPerformancePriceInput.Text),
                ExplicitContent = artistExplicitContentInput.IsChecked ?? false,
                ArtistAvailability = artistAvailabilityInput.IsChecked ?? false
            };

            context.Artists.Add(newArtist);
            context.SaveChanges();
        }

        private void FillGenres()
        {
            var genreList = new List<string>();

            artistMusicGenreInput.Items.Add("Metal");
            artistMusicGenreInput.Items.Add("Pop");
            artistMusicGenreInput.Items.Add("Rap");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddArtist();
        }
    }
}
