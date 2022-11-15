using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersEF.Models;

namespace UsersEF.ViewModels
{
    class MainWindowViewModel
    {
        private List<User> _dati;

        public List<User> Dati
        {
            get { return _dati; }
            set { _dati = value; }
        }


        public MainWindowViewModel()
        {
            using (UsersContext context = new UsersContext())
            {
                /*
                //Insert
                User newUser = new User
                {
                    Id = 100,
                    FirstName = "Nuovo",
                    LastName = "Nuovo",
                    Email = "nuovo@Entity.frame",
                    Age = 33,
                    BirthDate = DateTime.Today.AddDays(-30 * 365),
                    Gender = "male",
                    Username = "Nuovo",
                    Password = "Nuovo",
                    Address = "Via del nuovo",
                    City = "Viano",
                    State = "Italy",
                    PostalCode = "333"
                };

                context.Users.Add(newUser);
                context.SaveChanges();
                */

                Dati = context.Users.ToList();

                /*
                //Update
                User candidate = Dati.Find(u => u.FirstName.Contains("Nuovo"));
                if(candidate != null)
                {
                    candidate.LastName = "Modificato";
                }
                context.SaveChanges();
                */

                /*
                //Delete
                User candidate = Dati.Find(u => u.Id == 99);
                if (candidate != null)
                {
                    context.Users.Remove(candidate);
                }
                context.SaveChanges();
                */



            }
            
        }

    }
}
