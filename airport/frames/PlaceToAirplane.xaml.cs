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
    /// Interaction logic for PlaceToAirplane.xaml
    /// </summary>
    public partial class PlaceToAirplane : Window
    {
        public PlaceToAirplane(int id_airplane)
        {
            InitializeComponent();
            data.Database database = new data.Database();
            List<objects.Place> places = database.GetPlaceToAirplane(id_airplane);
            foreach(objects.Place place in places)
            {
                Places.Items.Add($"Id самолета - {place.GetId}. Пункт прибытия - {place.GetPlace}. Время вылета {place.GetTimeStart}" +
                    $". Время в полете - {place.GetTimeFlying}. Время прибытия - {place.GetTimeEnd}. Цена билета - {place.GetTicketPrice}");
            }
        
        }

    }
}
