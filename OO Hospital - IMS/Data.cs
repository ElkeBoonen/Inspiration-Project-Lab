using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OO_Hospital___IMS
{
    class Data
    {
        private string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=hospital;";
        
        public bool InsertPatient(Patient patient)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            string query = $"INSERT INTO patient(ID,Name,Birth,Problem,Treatment) VALUES (NULL,'{patient.Name}', '{patient.Birth.ToString("yyyy-MM-dd")}', '{patient.Problem}', '{patient.Treatment}');";
            Console.WriteLine(query);
            
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                int result = commandDatabase.ExecuteNonQuery();
                connection.Close();
                if (result > 0)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

    }
}
