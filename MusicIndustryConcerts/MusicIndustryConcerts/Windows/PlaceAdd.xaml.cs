using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MusicIndustryConcerts.Windows
{
    /// <summary>
    /// Logika interakcji dla klasy PlaceAdd.xaml
    /// </summary>
    public partial class PlaceAdd : Page
    {
        private readonly MusicIndustryConcertsEntities context = new MusicIndustryConcertsEntities();
        private readonly Validation validation = new Validation();
        public PlaceAdd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPlace();
        }

        private void AddPlace()
        {

            if (validation.ValidateFields(new Control[] { placeNameInput, placeCapacityInput, placeOpeningHourInput, placeClosingHourInput, placeRentalPriceInput }) 
                && validation.ValidateHour(placeOpeningHourInput) 
                && validation.ValidateHour(placeClosingHourInput))
            {
                var newPlace = new Places()
                {
                    PlaceName = placeNameInput.Text,
                    Capacity = Int32.Parse(placeCapacityInput.Text),
                    BarArea = placeBarAreaCheckBox.IsChecked ?? false,
                    VIPArea = placeVipAreaCheckBox.IsChecked ?? false,
                    OpeningHour = Int32.Parse(placeOpeningHourInput.Text),
                    ClosingHour = Int32.Parse(placeClosingHourInput.Text),
                    AdultsOnly = placeAdultsOnlyCheckBox.IsChecked ?? false,
                    RentalPrice = Int32.Parse(placeRentalPriceInput.Text)
                };

                context.Places.Add(newPlace);
                context.SaveChanges();
                this.NavigationService.Navigate(new Uri("Windows/PlacesList.xaml", UriKind.Relative));
            }
            else
            {
                emptyOpeningText.Text = "This field cannot be empty";
                emptyClosingText.Text = "This field cannot be empty";
                emptyCapacityText.Visibility = Visibility.Visible;
                emptyClosingText.Visibility = Visibility.Visible;
                emptyOpeningText.Visibility = Visibility.Visible;
                emptyRentalText.Visibility = Visibility.Visible;
                emptyPlaceText.Visibility = Visibility.Visible;
            }
            if (!validation.ValidateHour(placeOpeningHourInput) && !String.IsNullOrWhiteSpace(placeOpeningHourInput.Text))
            {
                emptyOpeningText.Text = "Invalid hour!";
                emptyOpeningText.Visibility = Visibility.Visible;
            }
            if (!validation.ValidateHour(placeClosingHourInput) && !String.IsNullOrWhiteSpace(placeClosingHourInput.Text))
            {
                emptyClosingText.Text = "Invalid hour!";
                emptyClosingText.Visibility = Visibility.Visible;
            }
        }
        public void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
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
