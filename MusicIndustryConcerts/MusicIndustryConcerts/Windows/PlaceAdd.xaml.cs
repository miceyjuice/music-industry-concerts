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
    /// Logika interakcji dla klasy PlaceAdd.xaml
    /// </summary>
    public partial class PlaceAdd : Page
    {
        public PlaceAdd()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddPlace();
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("I GO BACK");
        }

        private void AddPlace()
        {
            var context = new MusicIndustryConcertsEntities();

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
        }
    }
}
