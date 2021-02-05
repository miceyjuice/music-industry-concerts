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
    /// 

    public partial class TicketOrderAdd : Page
    {
        private readonly MusicIndustryConcertsEntities context = new MusicIndustryConcertsEntities();
        private readonly Validation validation = new Validation();
        public TicketOrderAdd()
        {
            InitializeComponent();
            FillConcerts();
        }

        private void FillConcerts()
        {
            foreach (var rowik in context.Concerts)
            {
                var concertInfo = $"{rowik.ConcertID} |  {rowik.Artists.ArtistName} | {rowik.Places.PlaceName}";

                ticketConcertInput.Items.Add(concertInfo);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ReserveTicket();
        }

        private void ReserveTicket()
        {
            if (validation.ValidateFields(new Control[] { ticketFirstNameInput, ticketLastNameInput, ticketConcertInput, ticketEmailInput}))
            {
                var newTicket = new TicketOrders
                {
                    FirstName = ticketFirstNameInput.Text,
                    LastName = ticketLastNameInput.Text,
                    ConcertID = Int32.Parse(ticketConcertInput.SelectedValue.ToString().Split(new string[] { " | " }, StringSplitOptions.None)[0]),
                    Mail = ticketEmailInput.Text,
                    PhoneNumber = ticketPhoneNumberInput.Text,
                    VIPTicket = ticketVipCheckbox.IsChecked ?? false
                };

                context.TicketOrders.Add(newTicket);
                context.SaveChanges();
            }
            
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
