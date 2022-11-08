using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UsersClassLibrary.Controllers;
using UsersClassLibrary.Models;

namespace CreaTabelleADO
{
    class MainWindowViewModel
    {
        private string connectionString = @"Server=DESKTOP-9GRQ3GS\SQLEXPRESS; Database=Users; Integrated Security=True;TrustServerCertificate=True";
        internal void DropTables()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DROP TABLE Logins", connection);
                    command.ExecuteNonQuery();
                    command = new SqlCommand("DROP TABLE Users", connection);
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        internal void CreateTables()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query1 = @"CREATE TABLE Users
                                    (
                                        Id              INT PRIMARY KEY,
                                        FirstName       VARCHAR(1000)   NOT NULL,
                                        LastName        VARCHAR(1000)   NOT NULL,
                                        Age             INT             NOT NULL,
                                        Gender          VARCHAR(10)     NOT NULL,
                                        Email           VARCHAR(1000)   NOT NULL,
                                        Username        VARCHAR(1000)   NOT NULL,
                                        Password        VARCHAR(1000)   NOT NULL,
                                        BirthDate       DATETIME        NOT NULL,
                                        Address         VARCHAR(1000)   NOT NULL,
                                        City            VARCHAR(1000)   NOT NULL,
                                        PostalCode      VARCHAR(1000)   NOT NULL,
                                        State           VARCHAR(1000)   NOT NULL

                                    )";
                    string query2 = @"CREATE TABLE Logins
                                    (
                                        UserId          INT             NOT NULL,
                                        Date            DATETIME        NOT NULL,
                                        LoginSuccessful BIT             NOT NULL,
                                        Note            VARCHAR(1000),


                                        FOREIGN KEY(UserId) REFERENCES Users(Id)
                                    )";

                    connection.Open();
                    SqlCommand command = new SqlCommand(query1, connection);
                    command.ExecuteNonQuery();
                    command = new SqlCommand(query2, connection);
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        internal void DeleteTables()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM Logins", connection);
                    int rowCount = command.ExecuteNonQuery();
                    command = new SqlCommand("DELETE FROM Users", connection);
                    rowCount += command.ExecuteNonQuery();
                    if (rowCount <= 0) throw new Exception("Le tabelle sono già vuote");
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        internal void InsertInto()
        {
            /*
            List<User> usersDaInserire = new List<User>();
            usersDaInserire = Users.GetAll();
            List<Login> loginsDaInserire = new List<Login>();
            loginsDaInserire = Logins.GetAll();
            */

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    int rowCount = 0;
                    foreach (User u in Users.GetAll())
                    {
                        SqlCommand command = new SqlCommand
                            ($"INSERT INTO Users VALUES " +
                            $"({u.Id}, '{u.FirstName.Replace("'", "''")}', '{u.LastName.Replace("'", "''")}', '{u.Age}', '{u.Gender}', '{u.Email}', '{u.Username}', '{u.Password}', '{u.BirthDate}', '{u.Address.Address.Replace("'", "''")}', '{u.Address.City.Replace("'", "''")}', '{u.Address.PostalCode}', '{u.Address.State.Replace("'", "''")}' " +
                            $");", connection);
                        rowCount += command.ExecuteNonQuery();
                    }
                    
                    foreach (Login l in Logins.GetAll())
                    {
                        int loginSucc = l.LoginSuccessfull == true ? 1 : 0;
                        SqlCommand command = new SqlCommand($"INSERT INTO Logins VALUES " +
                            $"('{l.UserId}', '{l.Date}' , '{loginSucc}', '{l.Notes}' )", connection);
                        rowCount += command.ExecuteNonQuery();
                    }
                    MessageBox.Show(rowCount + " rows affected");
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message);
                }
                

            }

        }

    }
}
