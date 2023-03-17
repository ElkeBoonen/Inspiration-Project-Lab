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
        private string connectionString = 
            "datasource=127.0.0.1;" +
            "port=3306;" +
            "username=root;" +
            "password=;database=hospital;";

        private const int _patientType = 1;
        private const int _nurseType = 2;
        private const int _doctorType = 3;

        private int Insert(string query)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                int result = commandDatabase.ExecuteNonQuery();
                return (int)commandDatabase.LastInsertedId;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return -1;
        }

        public int InsertPatient(Patient patient)
        {
            string query = 
                $"INSERT INTO person (ID, Name, Birth, Type, Problem, Treatment)" +
                $" VALUES(NULL, '{patient.Name}', " +
                $"'{patient.Birth.ToString("yyyy-MM-dd")}', " +
                $"'{_patientType}', '{patient.Problem}', '{patient.Treatment}');";
            return Insert(query);
        }
        public int InsertDoctor(Doctor doctor)
        {
            string query =
                $"INSERT INTO person (ID, Name, Birth, Type, Specialty)" +
                $" VALUES(NULL, '{doctor.Name}', " +
                $"'{doctor.Birth.ToString("yyyy-MM-dd")}', " +
                $"'{_doctorType}', '{doctor.Specialty}');";
            return Insert(query);
        }
        public int InsertNurse(Nurse nurse)
        {
            string query =
                $"INSERT INTO person (ID, Name, Birth, Type, Area)" +
                $" VALUES(NULL, '{nurse.Name}', " +
                $"'{nurse.Birth.ToString("yyyy-MM-dd")}', " +
                $"'{_nurseType}', '{nurse.Department}');";
            return Insert(query);
        }

        public int InsertHospital(Hospital hospital)
        {
            string query = $"INSERT INTO hospital(ID, Name)" +
                $" VALUES(NULL,'{hospital.Name}');";
            return Insert(query);
        }

        public void AddPersonToHospital(int personID, int hospitalID)
        {
            string query = $"INSERT INTO peopleinhospital(Person, Hospital)" +
                $" VALUES({personID}, {hospitalID});";
            Insert(query);
        }

    }
}
