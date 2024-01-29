using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPage.Models;
using UserPage.Services;

namespace UserPage.ViewModels
{
    public class LoginViewModel:ViewModelBase
    {

        private string username;
        public string UserName
        {
            get { return this.username; }
            set
            {
                this.username = value;
                OnPropertyChanged();
            }
        }

        private string password;
        public string Password
        {
            get { return this.password; }
            set
            {
                this.password = value;
                OnPropertyChanged();
            }
        }

        private string messege;
        public string Messege
        {
            get { return this.messege; }
            set
            {
                this.messege = value;
                OnPropertyChanged();
            }
        }


        private Color color;
        public Color Color
        {
            get { return this.color; }
            set
            {
                this.color = value;
                OnPropertyChanged();
            }
        }





        public LoginViewModel()
        {
            LoginCommand = new Command(CheackUser);
            CancelCommand = new Command(Cancel);
        }

        public Command LoginCommand { get; set; }
        public Command CancelCommand { get; set; }

        private void CheackUser()
        {
            UsersService service = new UsersService();
            User u = new User
            {
                UserName = username,
                Password = password
            };
            if(service.LogInCheack(u) == true )
            {
                messege = "Login succeeded!";
                Color = Colors.Green;
            }
            else
            {
                messege = "Login Failed!";
                Color = Colors.Red;
            }
        }

        private void Cancel()
        {
            UserName = "";
            Password = "";
            Messege = "";
            Color = Colors.Black;
        }

    }
}
