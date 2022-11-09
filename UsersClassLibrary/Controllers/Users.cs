using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersClassLibrary.Models;

namespace UsersClassLibrary.Controllers
{
    public static class Users
    {
        public static string connectionString { get; } = ConfigurationManager.ConnectionStrings["DatabaseUsers"].ConnectionString;
        public static List<User> GetAll()
        {


            /* //VECCHIA IMPLEMENTAZIONE PER JSON
            if (_users == null)
            {
                if (!File.Exists(@".\Models\database.json")) return new List<User>();
                string json = File.ReadAllText(@".\Models\database.json");
                _users = JsonConvert.DeserializeObject<List<User>>(json);
            }
            return _users;*/
            return FindAll(null, null);
            
        }

        //public static List<User> FindAll(Predicate<User> condizione)
        public static List<User> FindAll(string nome, string sex)
        {
            List<User> retVal = new List<User>();
            if (string.IsNullOrWhiteSpace(nome)) nome = "";
            if (string.IsNullOrWhiteSpace(sex)) sex = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT * FROM Users ";
                    cmd.CommandText += "WHERE (FirstName LIKE @name OR LastName LIKE @name) AND Gender LIKE @sex ";
                    
                    cmd.Parameters.AddWithValue("@name", $"%{nome}%");
                    cmd.Parameters.AddWithValue("@sex", $"{sex}%");

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            retVal.Add(new User
                            {
                                Id = (int)reader["Id"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Age = (int)reader["Age"],
                                Gender = (string)reader["Gender"],
                                Email = (string)reader["Email"],
                                Username = (string)reader["Username"],
                                Password = (string)reader["Password"],
                                BirthDate = (DateTime)reader["BirthDate"],
                                Address = new FullAddress
                                { 
                                    Address = (string)reader["Address"],
                                    City = (string)reader["City"],
                                    PostalCode = (string)reader["PostalCode"],
                                    State = (string)reader["State"]
                                }

                            });

                        }
                    }
                    //fine usingDataReader

                }
                catch (Exception)
                {

                    throw;
                }
            }

            return retVal;
            //return GetAll().FindAll(condizione);
        }

        public static User Find(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //User retVal = new User();
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT TOP 1 * FROM Users ";
                    cmd.CommandText += "WHERE Id = @Id ";

                    cmd.Parameters.AddWithValue("@Id", Id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if(reader.Read())
                        {
                            User retVal = new User
                            {
                                Id = (int)reader["Id"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Age = (int)reader["Age"],
                                Gender = (string)reader["Gender"],
                                Email = (string)reader["Email"],
                                Username = (string)reader["Username"],
                                Password = (string)reader["Password"],
                                BirthDate = (DateTime)reader["BirthDate"],
                                Address = new FullAddress
                                {
                                    Address = (string)reader["Address"],
                                    City = (string)reader["City"],
                                    PostalCode = (string)reader["PostalCode"],
                                    State = (string)reader["State"]
                                }

                            };
                            return retVal;

                        }
                        else
                        {
                            return null;
                        }
                    }
                    //fine usingDataReader

                }
                catch (Exception)
                {

                    throw;
                }
                
            }

        }

        public static User Find(string Email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //User retVal = new User();
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    cmd.CommandText = "SELECT TOP 1 * FROM Users ";
                    cmd.CommandText += "WHERE Email = @Email ";

                    cmd.Parameters.AddWithValue("@Email", Email);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User retVal = new User
                            {
                                Id = (int)reader["Id"],
                                FirstName = (string)reader["FirstName"],
                                LastName = (string)reader["LastName"],
                                Age = (int)reader["Age"],
                                Gender = (string)reader["Gender"],
                                Email = (string)reader["Email"],
                                Username = (string)reader["Username"],
                                Password = (string)reader["Password"],
                                BirthDate = (DateTime)reader["BirthDate"],
                                Address = new FullAddress
                                {
                                    Address = (string)reader["Address"],
                                    City = (string)reader["City"],
                                    PostalCode = (string)reader["PostalCode"],
                                    State = (string)reader["State"]
                                }

                            };
                            return retVal;

                        }
                        else
                            return null;
                    }
                    //fine usingDataReader

                }
                catch (Exception)
                {

                    throw;
                }

            }

        }

        /*public static User Find(Predicate<User> condizione)
        {
            return GetAll().Find(condizione);
        }*/

        public static void Add(User u)
        {
            GetAll().Add(u);
        }

        public static bool Update(int id, User u)
        {
            if (u.Id != id) return false;
            User candidate = Find(id);
            if (candidate == null) return false;

            candidate.FirstName = u.FirstName;
            candidate.LastName = u.LastName;
            candidate.Age = u.Age;
            candidate.Email = u.Email;
            candidate.Username = u.Username;
            candidate.Password = u.Password;
            candidate.BirthDate = u.BirthDate;
            candidate.Gender = u.Gender;

            return true;
        }
        public static List<string> GetGenders()
        {
            return GetAll().Select(s => s.Gender).Distinct().ToList();
        }

        public static string[] FormatAsTable(List<User> users)
        {
            string[] table = new string[users.Count+4];

            int i = 0;

            table[i++] = new String('-', 170);
            table[i++] = string.Format("|{0,3}|{1,10}|{2,12}|{3,3}|{4,7}|{5,27}|{6,13}|{7,13}|{8,11}|{9,30}|{10,15}|{11,6}|{12,6}|",
                "Id", "FirstName","LastName", "Age", "Gender", "Email", "Username", "Password", "BirthDate", "Address","City", "Zip", "State");
            table[i++] = new String('-', 170);

            foreach (User u in users)
            {
                string s = string.Format("|{0,3}|{1,10}|{2,12}|{3,3}|{4,7}|{5,27}|{6,13}|{7,13}|{8,11}|{9,30}|{10,15}|{11,6}|{12,6}|",
                    u.Id, u.FirstName, u.LastName, u.Age, u.Gender, u.Email, u.Username, u.Password, u.BirthDate.ToShortDateString(), u.Address.Address, u.Address.City, u.Address.PostalCode, u.Address.State);

                table[i++] = s;
            }
            table[i++] = new String('-', 170);
            return table;
        }

        public static bool VerificaCredenziali(string u, string p)
        {
            if (u == null || p == null) return false;
            if (string.IsNullOrEmpty(u) || string.IsNullOrEmpty(p)) return false;

            //User user = Find(q => q.Username.ToLower() == u.ToLower());
            //string connectionString = @"Server=DESKTOP-9GRQ3GS\SQLEXPRESS; Database=Users; Integrated Security=True;TrustServerCertificate=True";
            //string connectionString = ConfigurationManager.ConnectionStrings["DatabaseUsers"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = "SELECT COUNT(*) AS UtentiValidi FROM Users";
                    command.CommandText += " WHERE Username = @u AND Password= @p";
                    command.Parameters.AddWithValue("@u", u);
                    command.Parameters.AddWithValue("@p", p);

                    return ((int)command.ExecuteScalar()) > 0;

                }
                catch (Exception)
                {

                    throw;
                }

            }

            /*
            if (user != null && user.Password == p)
            {
                Logins.Add(new Login(user.Id, true, DateTime.Now));
                return true;
            }
            else if (user != null && user.Password != p)
            {
                Logins.Add(new Login(user.Id, false, DateTime.Now));
                return false;
            }
            else
            {
                Logins.Add(new Login(-1, false, DateTime.Now));
                return false;
            }
            */
        }

        public static bool InviaMailDiRecupero(string m)
        {
            return Find(m) != null;
        }
    }
}
