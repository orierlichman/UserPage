using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPage.Models;

namespace UserPage.Services
{

    class UsersList
    {
        public List<User> Users { get; private set; }
        public UsersList()
        {
            this.Users = new List<User>();
            FillList();
        }


        private void FillList()
        {
            Users.Add(new User
            {
                UserName = "Guy",
                Password = "guy123"
            });

            Users.Add(new User
            {
                UserName = "Ori",
                Password = "ori123"
            });

            Users.Add(new User
            {
                UserName = "Ran",
                Password = "ran123"
            });

            Users.Add(new User
            {
                UserName = "Dan",
                Password = "dan123"
            });

            Users.Add(new User
            {
                UserName = "Ofer",
                Password = "ofer123"
            });

            Users.Add(new User
            {
                UserName = "Yali",
                Password = "yali123"
            });

            Users.Add(new User
            {
                UserName = "Idan",
                Password = "idan123"
            });
        }
    }




    public class UsersService
    {
        public UsersService()
        {
            users = new UsersList().Users;
        }
        List<User> users;
        public bool LogInCheack(User u)
        {
            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].UserName == u.UserName)
                {
                    if (users[i].Password == u.Password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
