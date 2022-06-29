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
    /// Interaction logic for UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        
        public UserWindow()
        {
            InitializeComponent();
            data.Database database = new data.Database();
            List<objects.Airplane> airplanes = database.SelectAllPlanes();
            
            foreach(objects.Airplane airplane in airplanes)
            {
                ListPlanes.Items.Add($"Id самолета - {airplane.GetId}. Тип самолета - {airplane.GetTypePlane}." +
                    $" Число мест - {airplane.GetSeats}. Число свободных мест - {airplane.GetEmptySeats}. Дата вылета - {airplane.GetDateArroving}.");
            }
            

        }

        private void ListPlanes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            frames.PlaceToAirplane placeToAirplane = new PlaceToAirplane(ListPlanes.SelectedIndex + 1);
            placeToAirplane.Show();
        }
    }
}
