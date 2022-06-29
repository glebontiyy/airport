using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.objects
{
    internal class Airplane
    {
        private int id;
        private string type_plane;
        private int seats;
        private int empty_seats;
        private string date_arroving;
        public Airplane(int id, string type_plane, int seats, int empty_seats, string date_arroving)
        {
            this.id = id;
            this.type_plane = type_plane;
            this.seats = seats;
            this.empty_seats = empty_seats;
            this.date_arroving = date_arroving;
        }

        public int GetId { get { return id; } }
        public int GetSeats { get { return seats; } }
        public int GetEmptySeats { get { return empty_seats; } }
        public string GetTypePlane { get { return type_plane; } }
        public string GetDateArroving { get { return type_plane; } }
    }
}
