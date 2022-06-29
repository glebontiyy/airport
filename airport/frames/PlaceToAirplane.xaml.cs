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
            Places.Items.Add($"{id_airplane}");
        }

    }
}
