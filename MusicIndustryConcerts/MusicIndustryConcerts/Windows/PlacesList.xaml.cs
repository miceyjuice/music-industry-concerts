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
    /// Logika interakcji dla klasy PlacesList.xaml
    /// </summary>
    public partial class PlacesList : Page
    {
        public PlacesList()
        {
            InitializeComponent();
            ShowPlaces();
        }

        private void ShowPlaces()
        {
            var context = new MusicIndustryConcertsEntities();
            var gridView = new GridView();

            placesList.View = gridView;

            foreach(var rowik in context.Places)
            {
                var lista = new ListView();
                
                string[] row = { 
                    rowik.PlaceID.ToString(), 
                    rowik.PlaceName, 
                    rowik.RentalPrice.ToString(), 
                    rowik.OpeningHour.ToString(), 
                    rowik.ClosingHour.ToString(), 
                    rowik.VIPArea ? "Yes" : "No",
                    rowik.BarArea ? "Yes" : "No"
                };
                placesList.Items.Add(row);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Windows/PlaceAdd.xaml", UriKind.Relative));
        }

        private void Close_btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close();
        }

        private void Place_btn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Windows/PlacesList.xaml", UriKind.Relative));
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

        private void placesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
