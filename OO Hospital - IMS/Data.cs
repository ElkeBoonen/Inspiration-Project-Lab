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

        ////////////////////////
        /// INSERT METHODEN /// 
        ///////////////////////

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

        public List<Patient> SelectPatients(int hospitalID)
        {
            string query = $"select * from person " +
                $" inner join peopleinhospital on person.id = peopleinhospital.Person" +
                $" WHERE Hospital = {hospitalID} and Type = {_patientType};";

            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            
            List<Patient> patients = new List<Patient>();

            try {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string name = (string)reader["Name"];
                    DateOnly birth = DateOnly.FromDateTime((DateTime)reader["Birth"]);
                    string problem = (string)reader["Problem"];
                    string treatment = (string)reader["Treatment"];
                    patients.Add(new Patient(id, birth, name, problem, treatment));
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            
            return patients;
        }

        public List<Person> SelectStaff(int hospitalID)
        {
            string query = $"select * from person " +
                $" inner join peopleinhospital on person.id = peopleinhospital.Person" +
                $" WHERE Hospital = {hospitalID} and Type != {_patientType};";
            
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);

            List<Person> staff = new List<Person>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = (int)reader["ID"];
                    string name = (string)reader["Name"];
                    DateOnly birth = DateOnly.FromDateTime((DateTime)reader["Birth"]);
                    int type = (int)reader["Type"];
                    if (type == _doctorType)
                    {
                        string specialty = (string)reader["Specialty"];
                        staff.Add(new Doctor(id, birth, name, specialty));
                    }
                    else if (type == _nurseType)
                    {
                        string area = (string)reader["Area"];
                        HospitalDepartment department = Enum.Parse<HospitalDepartment>(area);

                        staff.Add(new Nurse(id, birth, name, department));
                    }

                }
                reader.Close();
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return staff;

        }

        //kan gebruikt worden voor INSERT, UPDATE, DELETE
        public int ExecuteQuery(string query)
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            int rows = command.ExecuteNonQuery();
            connection.Close();
            return rows;
        }

        public bool UpdatePatient(Patient patient)
        {
            string query = $"UPDATE person" +
                $" SET Name='{patient.Name}'," +
                $" Problem='{patient.Problem}'," +
                $" Treatment='{patient.Treatment}' " +
                $"WHERE ID = {patient.ID};";
            int rows = ExecuteQuery(query);
            if (rows == 1) return true;
            return false;
        }

    }
}
