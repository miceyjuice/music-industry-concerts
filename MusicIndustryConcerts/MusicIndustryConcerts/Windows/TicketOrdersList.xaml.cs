using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace MusicIndustryConcerts.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy TicketOrdersList.xaml
    /// </summary>
    public partial class TicketOrdersList : Page
    {
        private readonly MusicIndustryConcertsEntities context = new MusicIndustryConcertsEntities();

        /// <summary>
        /// Konstruktor klasy TicketOrdersList
        /// </summary>
        public TicketOrdersList()
        {
            InitializeComponent();
            ShowTicketOrders();
        }

        private void ShowTicketOrders()
        {
            ticketOrdersDataGrid.ItemsSource = context.TicketOrders.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Windows/TicketOrderAdd.xaml", UriKind.Relative));
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
