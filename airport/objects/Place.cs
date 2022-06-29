using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.objects
{
    internal class Place
    {
        int id;
        string place;
        string time_start;
        string time_flying;
        string time_end;
        int ticket_price;

        public Place(int id, string place, string time_start, string time_flying, string time_end, int ticket_price)
        {
            this.id = id;
            this.place = place;
            this.time_start = time_start;
            this.time_flying = time_flying;
            this.time_end = time_end;
            this.ticket_price = ticket_price;
        }

        public int GetId { get { return id; } }
        public int GetTicketPrice { get { return ticket_price; } }
        public string GetTimeStart { get { return time_start; } }
        public string GetTimeEnd { get { return time_end; } }
        public string GetPlace { get { return place; } }
        public string GetTimeFlying { get { return time_flying; } }

    }
}
