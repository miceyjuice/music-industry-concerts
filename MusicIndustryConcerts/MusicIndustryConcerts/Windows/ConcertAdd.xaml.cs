using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MusicIndustryConcerts.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy ConcertAdd.xaml
    /// </summary>
    public partial class ConcertAdd : Page
    {
        private readonly MusicIndustryConcertsEntities context = new MusicIndustryConcertsEntities();
        private readonly Validation validation = new Validation();
        public ConcertAdd()
        {
            InitializeComponent();
            FillPlaces();
            FillArtists();
        }

        public void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        public void FillPlaces()
        {
            foreach(var rowik in context.Places.Select(p => p.PlaceName))
            {
                concertPlaceNameComboBox.Items.Add(rowik);
            }
        }

        public void FillArtists()
        {
            foreach (var rowik in context.Artists.Select(p => p.ArtistName))
            {
                concertArtistNameComboBox.Items.Add(rowik);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateConcert();
        }

        private void CreateConcert() { 
        
            if (validation.ValidateFields(new Control[] { concertPlaceNameComboBox, concertArtistNameComboBox, concertDateInput, concertBaseTicketPriceInput, concertVipTicketPriceInput, concertRemainingCapacityInput }))
            {
                var newConcert = new Concerts()
                {
                    PlaceID = context.Places
                    .Where(u => u.PlaceName.ToString().Equals(concertPlaceNameComboBox.SelectedValue.ToString()))
                    .Select(u => u.PlaceID)
                    .FirstOrDefault(),
                    ArtistID = context.Artists
                    .Where(u => u.ArtistName.ToString().Equals(concertArtistNameComboBox.SelectedValue.ToString()))
                    .Select(u => u.ArtistID)
                    .FirstOrDefault(),
                    EventDate = concertDateInput.SelectedDate.Value,
                    BaseTicketPrice = Convert.ToDecimal(concertBaseTicketPriceInput.Text),
                    VIPTicketPrice = Convert.ToDecimal(concertVipTicketPriceInput.Text),
                    RemainingCapacity = Convert.ToInt32(concertRemainingCapacityInput.Text)
                };

                context.Concerts.Add(newConcert);
                context.SaveChanges();
                this.NavigationService.Navigate(new Uri("Windows/ConcertsList.xaml", UriKind.Relative));
            }
            else
            {
                emptyArtistText.Visibility = Visibility.Visible;
                emptyPlaceText.Visibility = Visibility.Visible;
                emptyDateText.Visibility = Visibility.Visible;
                emptyBaseTicketText.Visibility = Visibility.Visible;
                emptyVipTextText.Visibility = Visibility.Visible;
                emptyCapacityText.Visibility = Visibility.Visible;
            }
        }

        public void CalcSuggestedBaseTicketPrice()
        {

            if (concertPlaceNameComboBox.SelectedValue == null || concertArtistNameComboBox.SelectedValue == null || concertRemainingCapacityInput.Text == "") return;
            {
                var placeName = concertPlaceNameComboBox.SelectedValue.ToString();
                var artistName = concertArtistNameComboBox.SelectedValue.ToString();

                var place = context.Places.First(p => p.PlaceName.Equals(placeName));
                var artist = context.Artists.First(a => a.ArtistName.Equals(artistName));
                var desiredCapacity = Int32.Parse(concertRemainingCapacityInput.Text);

                var suggestedPrice = Math.Round((Convert.ToDouble(place.RentalPrice) + Convert.ToDouble(artist.PerformancePrice)) / Convert.ToDouble(desiredCapacity), 2);

                concertBaseTicketPriceSuggested.Text = suggestedPrice.ToString("0.00");
                concertBaseTicketPriceInput.Text = suggestedPrice.ToString("0.00");
                concertVipTicketPriceSuggested.Text = Math.Round((suggestedPrice * 3.1), 2).ToString("0.00");
                concertVipTicketPriceInput.Text = Math.Round((suggestedPrice * 3.1), 2).ToString("0.00");
            }
        }


        private void concertPlaceNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var placeName = concertPlaceNameComboBox.SelectedValue.ToString();
            var place = context.Places.First(p => p.PlaceName.Equals(placeName));

            concertRemainingCapacityInput.Text = place.Capacity.ToString();
            concertMaxCapacity.Text = place.Capacity.ToString();

            CalcSuggestedBaseTicketPrice();
        }


        private void concertArtistNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CalcSuggestedBaseTicketPrice();
        }


        private void concertRemainingCapacityInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalcSuggestedBaseTicketPrice();
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
