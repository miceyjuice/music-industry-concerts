using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MusicIndustryConcerts.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy ConcertsList.xaml
    /// </summary>
    public partial class ConcertsList : Page
    {
        private readonly MusicIndustryConcertsEntities context = new MusicIndustryConcertsEntities();
        public ConcertsList()
        {
            InitializeComponent();
            ShowConcerts();
        }

        private void ShowConcerts()
        {
            concertsDataGrid.ItemsSource = context.Concerts.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Windows/ConcertAdd.xaml", UriKind.Relative));
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
            this.NavigationService.Navigate(new Uri("Windows/ArtistsList.xaml", UriKind.Relative));
        }

        private void Tickets_btn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Windows/TicketOrdersList.xaml", UriKind.Relative));
        }

        private void Concerts_btn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Windows/ConcertsList.xaml", UriKind.Relative));
        }

        private void Home_btn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Windows/MainView.xaml", UriKind.Relative));
        }
    }
}
