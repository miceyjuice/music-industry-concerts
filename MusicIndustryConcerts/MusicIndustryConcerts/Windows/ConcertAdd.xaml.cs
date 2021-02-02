﻿using System;
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

        public void CalcSuggestedBaseTicketPrice()
        {
            //Jezeli wybrane sa wartosci z obu list, wtedy ma wygenerowac 
            //sugerowaną cenę biletów (Base i VIP) nad odpowiednimi polami

            if (concertPlaceNameComboBox.SelectedValue == null || concertArtistNameComboBox.SelectedValue == null || concertRemainingCapacityInput.Text == "") return;

            var context = new MusicIndustryConcertsEntities();

            var placeName = concertPlaceNameComboBox.SelectedValue.ToString();
            var artistName = concertArtistNameComboBox.SelectedValue.ToString();

            var place = context.Places.First(p => p.PlaceName.Equals(placeName));
            var artist = context.Artists.First(a => a.ArtistName.Equals(artistName));
            var desiredCapacity = Int32.Parse(concertRemainingCapacityInput.Text);

            var suggestedPrice = Math.Round((Convert.ToDouble(place.RentalPrice) + Convert.ToDouble(artist.PerformancePrice)) / Convert.ToDouble(desiredCapacity),2);

            concertBaseTicketPriceSuggested.Text = suggestedPrice.ToString("0.00");
            concertBaseTicketPriceInput.Text = suggestedPrice.ToString("0.00");
            concertVipTicketPriceSuggested.Text = Math.Round((suggestedPrice * 1.2),2).ToString("0.00");
            concertVipTicketPriceInput.Text = Math.Round((suggestedPrice * 1.2),2).ToString("0.00");
        }



        private void concertPlaceNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var context = new MusicIndustryConcertsEntities();
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
