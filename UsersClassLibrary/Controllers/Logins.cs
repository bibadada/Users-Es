using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersClassLibrary.Models;

namespace UsersClassLibrary.Controllers
{
    public static class Logins
    {
        private static List<Login> _logins;

        private static string connectionString { get; } = Users.connectionString;

        public static List<Login> GetAll()
        {
            if (_logins == null)
            {
                if (!File.Exists(@".\Models\logins.json")) return new List<Login>();
                string json = File.ReadAllText(@".\Models\logins.json");
                _logins = JsonConvert.DeserializeObject<List<Login>>(json);
            }
            return _logins;
        }

        public static List<Login> FindAll(Predicate<Login> condizione)
        {
            return GetAll().FindAll(condizione);
        }

        public static Login Find(Predicate<Login> condizione)
        {
            return GetAll().Find(condizione);
        }

        public static void Add(Login u)
        {
            GetAll().Add(u);
        }
    }
}
