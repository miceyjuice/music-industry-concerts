﻿using System;
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
        private readonly MusicIndustryConcertsEntities context = new MusicIndustryConcertsEntities();
        private readonly Validation validation = new Validation();
        public ArtistAdd()
        {
            InitializeComponent();
            FillGenres();
        }

        private void AddArtist()
        {
            if (validation.ValidateFields(new Control[] { artistNameInput, artistMusicGenreInput, artistPerformancePriceInput }))
            {
                var newArtist = new Artists()
                {
                    ArtistName = artistNameInput.Text,
                    MusicGenre = artistMusicGenreInput.SelectedValue.ToString(),
                    PerformancePrice = Convert.ToInt32(artistPerformancePriceInput.Text),
                    ExplicitContent = artistExplicitCheckbox.IsChecked ?? false,
                    ArtistAvailability = artistAvailabilityCheckbox.IsChecked ?? false
                };

                context.Artists.Add(newArtist);
                context.SaveChanges();
            }
        }

        private void FillGenres()
        {
            artistMusicGenreInput.Items.Add("Metal");
            artistMusicGenreInput.Items.Add("Pop");
            artistMusicGenreInput.Items.Add("Rap");
            artistMusicGenreInput.Items.Add("Rock");
            artistMusicGenreInput.Items.Add("Blues");
            artistMusicGenreInput.Items.Add("Country");
            artistMusicGenreInput.Items.Add("Techno");
            artistMusicGenreInput.Items.Add("Dubstep");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddArtist();
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
