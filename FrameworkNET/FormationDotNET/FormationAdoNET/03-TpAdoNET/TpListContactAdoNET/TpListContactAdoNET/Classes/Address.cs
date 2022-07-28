using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpListContactAdoNET.Tools;

namespace TpListContactAdoNET.Classes
{
    public class Address
    {
        private int addressId;
        private int number;
        private string roadName;
        private int postalCode;
        private string town;
        private string country;
        private string _request;
        private static SqlCommand _command;
        private static SqlConnection _connection;
        private static SqlDataReader _reader;



        public Address()
        {
            
        }
        public Address(int number, string roadName, int postalCode, string town, string country)
        {            
            Number = number;
            RoadName = roadName;
            PostalCode = postalCode;
            Town = town;
            Country = country;
        }

        public int AddressId { get => addressId; init => addressId = value; }
        public int Number { get => number; set => number = value; }
        public string RoadName { get => roadName; set => roadName = value; }
        public int PostalCode { get => postalCode; set => postalCode = value; }
        public string Town { get => town; set => town = value; }
        public string Country { get => country; set => country = value; }


        

        public int Add()
        {
            // Connection
            _connection = Connection.New;

            // Redaction Request
            _request = "INSERT INTO ADDRESS (Number, Road_Name, Postal_Code, Town, Country) OUTPUT INSERTED.ID " +
                "VALUES (@Number, @RoadName, @PostalCode, @Town, @Country)";

            // Création objet Command
            _command = new SqlCommand(_request, _connection);

            // Ajout Params
            _command.Parameters.Add(new SqlParameter("@Number", Number));
            _command.Parameters.Add(new SqlParameter("@RoadName", RoadName));
            _command.Parameters.Add(new SqlParameter("@PostalCode", PostalCode));
            _command.Parameters.Add(new SqlParameter("@Town", Town));
            _command.Parameters.Add(new SqlParameter("@Country", Country));

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande
            int addressId = (int)_command.ExecuteScalar();

            // Liberations des objets
            _command.Dispose();
            _connection.Close();

            return addressId;
        }

        public bool Update()
        {
            // Connection
            _connection = Connection.New;

            // Redaction Request
            _request = "UPDATE ADDRESS SET Number=@Number, Road_Name = @RoadName, Postal_Code = @PostalCode, " +
                "Town = @Town, Country = @Country WHERE id = @AddressId";

            // Création objet Command
            _command = new SqlCommand(_request, _connection);

            // Ajout Params
            _command.Parameters.Add(new SqlParameter("@Number", Number));
            _command.Parameters.Add(new SqlParameter("@RoadName", RoadName));
            _command.Parameters.Add(new SqlParameter("@PostalCode", PostalCode));
            _command.Parameters.Add(new SqlParameter("@Town", Town));
            _command.Parameters.Add(new SqlParameter("@Country", Country));
            _command.Parameters.Add(new SqlParameter("@AddressId", AddressId));

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande
            int NbLigne = _command.ExecuteNonQuery();

            // Liberations des objets
            _command.Dispose();
            _connection.Close();

            return NbLigne == 1;
        }

        public bool Delete()
        {
            // Connection
            _connection = Connection.New;

            // Redaction Request
            _request = "DELETE ADDRESS WHERE Id = @AddressId";

            // Création objet Command
            _command = new SqlCommand(_request, _connection);

            // Ajout Params
            _command.Parameters.Add(new SqlParameter("@AddressId", AddressId));

            // Ouverture de la connection
            _connection.Open();

            // Execution de la commande
            int NbLigne = _command.ExecuteNonQuery();

            // Liberations des objets
            _command.Dispose();
            _connection.Close();

            return NbLigne == 1;
        }

        public override string ToString()
        {
            return $"{Number} {RoadName} - {PostalCode} {Town} - {Country} ";
        }
    }
}
