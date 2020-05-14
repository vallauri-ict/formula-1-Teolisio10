using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

// using Microsoft.SqlServer.Management.Smo;

namespace FormulaOneDll
{
    [Serializable]

    public class SerializableBindingList<T> : BindingList<T> { }

    public class DbTools
    {
        public const string WORKINGPATH = @"C:\dati\";
        public const string CONNSTR = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + WORKINGPATH + "FormulaOne.mdf;Integrated Security=True";
        
        private Dictionary<string, Country> countries;
        private Dictionary<int, Driver> drivers;
        private Dictionary<int, Team> teams;
        private Dictionary<int, Circuit> circuits;

        public void ExecuteSqlScript(string sqlScriptName)
        {
            var fileContent = File.ReadAllText(WORKINGPATH + sqlScriptName);
            fileContent = fileContent.Replace("\r\n", "");
            fileContent = fileContent.Replace("\n", "");
            fileContent = fileContent.Replace("\t", "");
            fileContent = fileContent.Replace("\r", "");
            var sqlqueries = fileContent.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries);

            var con = new SqlConnection(CONNSTR);
            var cmd = new SqlCommand("query", con);
            con.Open();

            int i = 0;
            foreach (var query in sqlqueries)
            {
                cmd.CommandText = query;
                i++;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException err)
                {
                    Console.WriteLine("Errore in esecuzione della query numero: " + i);
                    Console.WriteLine("\tErrore: " + err.Number + " - " + err.Message);
                }
            }
            con.Close();
        }

        // ELIMINAZIONE TABELLA
        public void DropTable(string tableName)
        {
            var con = new SqlConnection(CONNSTR);
            var cmd = new SqlCommand("Drop Table " + tableName + ";", con);

            con.Open();
            try { cmd.ExecuteNonQuery(); }
            catch (SqlException err) { Console.WriteLine("\tErrore SQL: " + err.Number + " - " + err.Message); }
            con.Close();
        }

        // RICEZIONE COUNTRIES
        public Dictionary<string, Country> GetCountries()
        {
            if(countries == null)
            {
                countries = new Dictionary<string, Country>();
                var con = new SqlConnection(CONNSTR);
                using (con)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Countries;", con);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string countryIsoCode = reader.GetString(0);
                        Country country = new Country(countryIsoCode, reader.GetString(1));
                        countries.Add(countryIsoCode, country);
                    }
                    reader.Close();
                }
            }
            return countries;
        }

        // RICEZIONE DRIVERS
        public Dictionary<int, Driver> GetDrivers()
        {
            if (drivers == null)
            {
                drivers = new Dictionary<int, Driver>();
                var con = new SqlConnection(CONNSTR);
                using (con)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Drivers;", con);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string driverCountryCode = reader.GetString(5);
                        Country driverCountry = GetCountries()[driverCountryCode];
                        int driverIsoCode = reader.GetInt32(0);
                        Driver driver = new Driver(driverIsoCode, reader.GetString(1), reader.GetString(2), reader.GetDateTime(3), reader.GetString(4), driverCountry);
                        drivers.Add(driverIsoCode, driver);
                    }
                    reader.Close();
                }
            }
            return drivers;
        }

        // RICEZIONE TEAMS
        public Dictionary<int, Team> GetTeams()
        {
            if (teams == null)
            {
                teams = new Dictionary<int, Team>();
                var con = new SqlConnection(CONNSTR);
                using (con)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Teams;", con);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string teamCountryCode = reader.GetString(3);
                        Country teamCountry = GetCountries()[teamCountryCode];
                        int teamDriverCode1 = reader.GetInt32(7);
                        Driver teamDriver1 = GetDrivers()[teamDriverCode1];
                        int teamDriverCode2 = reader.GetInt32(8);
                        Driver teamDriver2 = GetDrivers()[teamDriverCode2];
                        int TeamId = reader.GetInt32(0);
                        Team team = new Team(TeamId, reader.GetString(1), reader.GetString(2), teamCountry, reader.GetString(4), reader.GetString(5), reader.GetString(6), teamDriver1.ToString(), teamDriver2.ToString());
                        teams.Add(TeamId, team);
                    }
                    reader.Close();
                }
            }
            return teams;
        }

        // RICEZIONE CIRCUITS
        public Dictionary<int, Circuit> GetCircuits()
        {
            if (circuits == null)
            {
                circuits = new Dictionary<int, Circuit>();
                var con = new SqlConnection(CONNSTR);
                using (con)
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM Circuits;", con);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        int CircuitCode = reader.GetInt32(0);
                        Circuit circuit = new Circuit(CircuitCode, reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
                        circuits.Add(CircuitCode, circuit);
                    }
                    reader.Close();
                }
            }
            return circuits;
        }



        // CARICAMENTO TEAMS
        public List<Team> LoadTeams()
        {
            List<Team> retVal = new List<Team>();
            var con = new SqlConnection(CONNSTR);
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Teams;", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string teamCountryCode = reader.GetString(3);
                    //Country teamCountry = countries.Find(item => item.CountryCode == teamCountryCode);
                    Country teamCountry = GetCountries()[teamCountryCode];
                    int teamDriverCode1 = reader.GetInt32(7);
                    Driver teamDriver1 = GetDrivers()[teamDriverCode1];
                    int teamDriverCode2 = reader.GetInt32(8);
                    Driver teamDriver2 = GetDrivers()[teamDriverCode2];

                    Team t = new Team(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), teamCountry, reader.GetString(4), reader.GetString(5), reader.GetString(6), teamDriverCode1.ToString(), teamDriverCode2.ToString());
                    retVal.Add(t);
                }
                reader.Close();
            }
            return retVal;
        }

        public List<object> LoadTeamsTable()
        {
            List<object> retVal = new List<object>();
            var con = new SqlConnection(CONNSTR);
            using (con)
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Teams;", con);
                con.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string teamCountryCode = reader.GetString(3);
                    Country teamCountry = GetCountries()[teamCountryCode];
                    int teamDriverCode1 = reader.GetInt32(7);
                    Driver teamDriver1 = GetDrivers()[teamDriverCode1];
                    int teamDriverCode2 = reader.GetInt32(8);
                    Driver teamDriver2 = GetDrivers()[teamDriverCode2];

                    // Team t = new Team(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), teamCountry, reader.GetString(4), reader.GetString(5), reader.GetString(6), teamDriverCode1.ToString(), teamDriverCode2.ToString());
                    List<object> l = new List<object>();
                    l.Add(reader.GetInt32(0));
                    l.Add(reader.GetString(1));
                    l.Add(reader.GetString(2));
                    l.Add(teamCountry.CountryName);
                    l.Add(reader.GetString(4));
                    l.Add(reader.GetString(5));
                    l.Add(reader.GetString(6));
                    l.Add(teamDriver1.Lastname + " " + teamDriver1.Lastname);
                    l.Add(teamDriver2.Lastname + " " + teamDriver2.Lastname);
                    retVal.Add(l);
                }
                reader.Close();
            }
            return retVal;
        }

        /*// BACKUP OF A DB
        public void backupDB()
        {
            var con = new SqlConnection(CONNSTR);
            var cmd = new SqlCommand("BACKUP DATABASE FORMULAONE TO DISK='C:\\Dati\\FormulaOne.mdf'", con);
            con.Open();
            try { cmd.ExecuteNonQuery(); }
            catch (SqlException err) { Console.WriteLine("\tErrore SQL: " + err.Number + " - " + err.Message); }
            con.Close();
        }*/


        public static IEnumerable<string> ToCsv<T>(IEnumerable<T> objectlist, string separator = "|")
        {
            foreach (var o in objectlist)
            {
                FieldInfo[] fields = o.GetType().GetFields();
                PropertyInfo[] properties = o.GetType().GetProperties();

                yield return string.Join(separator, fields.Select(f => (f.GetValue(o) ?? "").ToString())
                    .Concat(properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray());
            }
        }

        public static string ToCsvString<T>(IEnumerable<T> objectlist, string separator = "|")
        {
            StringBuilder csvdata = new StringBuilder();
            foreach (var o in objectlist)
            {
                FieldInfo[] fields = o.GetType().GetFields();
                PropertyInfo[] properties = o.GetType().GetProperties();

                csvdata.AppendLine(string.Join(separator, fields.Select(f => (f.GetValue(o) ?? "").ToString())
                    .Concat(properties.Select(p => (p.GetValue(o, null) ?? "").ToString())).ToArray()));
            }
            return csvdata.ToString();
        }

        public static void SerializeToCsv<T>(IEnumerable<T> objectlist, string pathName, string separator = "|")
        {
            IEnumerable<string> dataToSave = DbTools.ToCsv(objectlist, separator);
            File.WriteAllLines(pathName, dataToSave);
        }
    }
}
