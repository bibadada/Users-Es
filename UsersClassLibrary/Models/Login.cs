using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersClassLibrary.Models
{
    public class Login
    {
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public bool LoginSuccessfull { get; set; }
        public string Notes { get; set; }

        public Login()
        {

        }

        public Login(int userId, bool success, DateTime d)
        {
            UserId = userId;
            LoginSuccessfull = success;
            Date = d;
        }

        public Login(int userId, bool success)
        {
            UserId = userId;
            LoginSuccessfull = success;
            Date = DateTime.Now;
        }

        public Login(int userId, bool success, string notes) : this(userId,success)
        {
            Notes = notes;
        }
    }
}
