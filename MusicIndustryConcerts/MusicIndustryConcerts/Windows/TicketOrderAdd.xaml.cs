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
    /// Logika interakcji dla klasy TicketOrderAdd.xaml
    /// </summary>
    public partial class TicketOrderAdd : Page
    {
        public TicketOrderAdd()
        {
            InitializeComponent();
            FillConcerts();
        }

        private void FillConcerts()
        {
            var context = new MusicIndustryConcertsEntities();

            foreach (var rowik in context.Concerts)
            {
                var concertInfo = $"{rowik.Places.PlaceName} | {rowik.Artists.ArtistName}";

                ticketConcertInput.Items.Add(concertInfo);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReserveTicket();
        }

        private void ReserveTicket()
        {
            var context = new MusicIndustryConcertsEntities();

            var newTicket = new TicketOrders
            {
                FirstName = ticketFirstNameInput.Text,
                LastName = ticketLastNameInput.Text,
                /*ConcertID = context.Places
                            .Where(c => c.PlaceName.Equals(ticketConcertInput.Text))*/
            };
        }

        private void Close_btn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.Close(); ;
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
