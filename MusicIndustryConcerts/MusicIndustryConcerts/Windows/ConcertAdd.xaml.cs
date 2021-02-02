using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Logika interakcji dla klasy ConcertAdd.xaml
    /// </summary>
    public partial class ConcertAdd : Page
    {
        public ConcertAdd()
        {
            InitializeComponent();
            FillPlaces();
            FillArtists();
        }

        public void FillPlaces()
        {
            var context = new MusicIndustryConcertsEntities();

            foreach(var rowik in context.Places.Select(p => p.PlaceName))
            {
                concertPlaceNameComboBox.Items.Add(rowik);
            }
        }

        public void FillArtists()
        {
            var context = new MusicIndustryConcertsEntities();

            foreach (var rowik in context.Artists.Select(p => p.ArtistName))
            {
                concertArtistNameComboBox.Items.Add(rowik);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateConcert();
        }

        private void CreateConcert()
        {
            var context = new MusicIndustryConcertsEntities();

            /*var newConcert = new Concert()
            {
                ArtistName = artistNameInput.Text,
                MusicGenre = artistMusicGenreInput.SelectedValue.ToString(),
                PerformancePrice = Convert.ToInt32(artistPerformancePriceInput.Text),
                ExplicitContent = artistExplicitCheckbox.IsChecked ?? false,
                ArtistAvailability = artistAvailabilityCheckbox.IsChecked ?? false
            };*/

            var newConcert = new Concerts()
            {
                PlaceID = context.Places
                    .Where(u => u.PlaceName.ToString().Equals(concertPlaceNameComboBox.SelectedValue.ToString()))
                    .Select(u => u.PlaceID)
                    .FirstOrDefault(),
                ArtistID = context.Artists
                    .Where( u => u.ArtistName.ToString().Equals(concertArtistNameComboBox.SelectedValue.ToString()))
                    .Select( u => u.ArtistID)
                    .FirstOrDefault(),
                EventDate = concertDateInput.SelectedDate.Value,
                BaseTicketPrice = Int32.Parse(concertBaseTicketPriceInput.Text),
                VIPTicketPrice = Int32.Parse(concertVipTicketPriceInput.Text),
                RemainingCapacity = Int32.Parse(concertRemainingCapacityInput.Text)
            };

            context.Concerts.Add(newConcert);
            context.SaveChanges();
        }

        public void CalcSuggestedTicketPrice()
        {

        }

        private void Close_btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void Place_btn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Windows/PlaceAdd.xaml", UriKind.Relative));
        }

        private void Artist_btn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Windows/ArtistAdd.xaml", UriKind.Relative));
        }

        private void Tickets_btn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Windows/TicketOrderAdd.xaml", UriKind.Relative));
        }

        private void Concerts_btn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Windows/ConcertAdd.xaml", UriKind.Relative));
        }

        private void Home_btn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Windows/MainView.xaml", UriKind.Relative));
        }

    }
}
