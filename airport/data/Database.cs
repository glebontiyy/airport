using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace airport.data
{
    internal class Database
    {
        private string loginToDb;
        private MySqlConnection connection;

        public Database()
        {
            loginToDb = @"server=localhost;userid=root;password=5555;database=airport";
            connection = new MySqlConnection(loginToDb);
        }

        public List<objects.Airplane> SelectAllPlanes()
        {
            connection.Open();
            string query = "SELECT * FROM airplane";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<objects.Airplane> airplanes = new List<objects.Airplane>();
            while (reader.Read())
            {
                int id = reader.GetInt32("id");
                string type_plane = reader.GetString("тип самолета");
                int seats = reader.GetInt32("число мест");
                int empty_seats = reader.GetInt32("число свободных мест");
                string date_arroving = reader.GetString("дата вылета");
                airplanes.Add(new objects.Airplane(id, type_plane, seats, empty_seats, date_arroving));
            }
            return airplanes;
        }
        public List<objects.Place> GetPlaceToAirplane(int id)
        {
            connection.Open();
            string query = $"SELECT * FROM place WHERE place.id = {id}";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();
            List<objects.Place> places = new List<objects.Place>();
            while (reader.Read())
            {
                int id_airplane = reader.GetInt32("id");
                string place = reader.GetString("пункт назначения");
                string time_start = reader.GetString("время вылета");
                string time_end = reader.GetString("время прибытия");
                string time_flying = reader.GetString("время в полете");
                int ticket_price = reader.GetInt32("цена билета");
                places.Add(new objects.Place(id_airplane, place, time_start, time_flying, time_end, ticket_price));

            }
            return places;
        }

    }
}
