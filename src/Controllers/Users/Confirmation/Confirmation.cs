using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lovis.Controllers.Users.Confirmation
{
    public class Confirmation
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Token { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateExpiration { get; set; }

        public static List<Confirmation> lC = new List<Confirmation>();

        public Confirmation() { }

        public Confirmation(string username, string password, string name, string surname)
        {
            Username = username;
            Password = password;
            Name = name;
            Surname = surname;
            Token = Security.CryptoUtils.SHA256HashStringForUTF8String(Security.CryptoUtils.RandomKey());
            DateCreation = DateTime.Now;
            DateExpiration = DateTime.Now.AddHours(24);

        }

        public void Add()
        {
            lC.Add(this);
            Controllers.Email.Email.SendEmailConfirmationRegistration(this.Username, this.Token, this.Name, this.Surname,this.DateExpiration);
        }

        public void Activate(string token, string username)
        {
            try
            {
                var nu = lC.Single(x => x.Username == username && x.Token == token);
                new Controllers.Users.Users(nu.Username, nu.Password, nu.Name, nu.Surname).New();
            }
            catch (Exception)
            {

                throw;
            }
            

        }

    }
}