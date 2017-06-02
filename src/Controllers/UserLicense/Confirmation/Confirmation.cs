using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lovis.Controllers.UserLicense.Confirmation
{
    public class Confirmation
    {


        public string IdUser { get; set; }
        public string IdLicense { get; set; }
        public int Role { get; set; }
        public string Token { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateExpiration { get; set; }
        public static List<Confirmation> lUC = new List<Confirmation>();

        public Confirmation() { }

        public Confirmation(string idUser, string idLicense, int role)
        {
            IdUser = idUser;
            IdLicense = idLicense;
            Role = role;
            Token = Security.CryptoUtils.SHA256HashStringForUTF8String(Security.CryptoUtils.RandomKey());
            DateCreation = DateTime.Now;
            DateExpiration = DateCreation.AddHours(24);
        }

        public void Add()
        {

            lUC.Add(this);
        }

        public void Activate(string token)
        {
            try
            {
                var x = lUC.Single(a => a.Token == token);
                if (DateTime.Now < x.DateExpiration)
                {
                    new Controllers.UserLicense.UserLicense(x.IdUser, x.IdLicense, x.Role, false);
                }
                else
                {
                    lUC.Remove(x);
                    new Exception();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}