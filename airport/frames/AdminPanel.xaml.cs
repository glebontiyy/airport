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
using System.Windows.Shapes;

namespace airport.frames
{
    /// <summary>
    /// Interaction logic for AdminPanel.xaml
    /// </summary>
    public partial class AdminPanel : Window
    {
        private List<objects.Place> places;
        private data.Database database;

        public AdminPanel()
        {
            InitializeComponent();
            database = new data.Database();
            places = database.SelectAllPlaces();
            InitTable();
        }

        private void airport_events_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selected_index = airport_events.SelectedIndex;
            if (selected_index.Equals(-1))
            {
                return;
            }
            index_selection.Content = selected_index.ToString();
            id_airplane.Text = Convert.ToString(places[Convert.ToInt32(index_selection.Content)].GetId);
            ticket_price.Text = Convert.ToString(places[Convert.ToInt32(index_selection.Content)].GetTicketPrice);
            time_end.Text = places[Convert.ToInt32(index_selection.Content)].GetTimeEnd;
            time_flying.Text = places[Convert.ToInt32(index_selection.Content)].GetTimeFlying;
            time_start.Text = places[Convert.ToInt32(index_selection.Content)].GetTimeStart;
            this.place.Text = places[Convert.ToInt32(index_selection.Content)].GetPlace;
        }

        private void DeletePlace(object sender, RoutedEventArgs e)
        {
            database.DeletePlace(Convert.ToInt32(id_airplane.Text),
                                 this.place.Text,
                                 time_start.Text,
                                 time_end.Text);
            InitTable();

        }
        private void AddPlace(object sender, RoutedEventArgs e)
        {
            database.AddPlace(Convert.ToInt32(id_airplane.Text), place.Text, time_start.Text, time_flying.Text, time_end.Text, Convert.ToInt32(ticket_price.Text));
            InitTable();
        }
        private void InitTable()
        {
            places = database.SelectAllPlaces();
            airport_events.Items.Clear();
            foreach (objects.Place place in places)
            {
                airport_events.Items.Add($"Id самолета - {place.GetId}. Пункт прибытия - {place.GetPlace}. Время вылета {place.GetTimeStart}" +
                    $". Время в полете - {place.GetTimeFlying}. Время прибытия - {place.GetTimeEnd}. Цена билета - {place.GetTicketPrice}");
            }
        }
    }
}
