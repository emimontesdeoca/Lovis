using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lovis.Controllers.Elements
{
    public class Elements
    {
        #region ATTRIBUTES

        public string Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string State { get; set; }
        public string AssignedTo { get; set; }
        public string Priority { get; set; }
        public string Summary { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public string IdProyect { get; set; }

        #endregion

        #region CONSTRUCTORS

        public Elements() { }

        public Elements(Elements e) { }

        public Elements(string title, string type, string state, string priority, string assigendTo, string summary, DateTime dateStart, DateTime dateFinish, Proyects.Proyects p)
        {
            Id = Security.CryptoUtils.SHA1HashStringForUTF8String(lovis.Security.CryptoUtils.RandomKey());
            Title = Security.CryptoUtils.EncodeElementString(p, title);
            Type = Security.CryptoUtils.EncodeElementString(p, type);
            State = Security.CryptoUtils.EncodeElementString(p, state);
            AssignedTo = Security.CryptoUtils.EncodeElementString(p, assigendTo);
            Priority = Security.CryptoUtils.EncodeElementString(p, priority);
            Summary = Security.CryptoUtils.EncodeElementString(p, summary);
            DateCreation = DateTime.Now;
            DateStart = dateStart;
            DateFinish = dateFinish;
            IdProyect = p.Id;
        }

        #endregion

        #region CHECK ELEMENT

        /// <summary>
        /// Method that decodes a element
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public Elements DecodeElement(Proyects.Proyects p, Elements e)
        {
            e.Title = Security.CryptoUtils.DecodeElementString(p, e.Title);
            e.Type = Security.CryptoUtils.DecodeElementString(p, e.Type);
            e.State = Security.CryptoUtils.DecodeElementString(p, e.State);
            e.AssignedTo = Security.CryptoUtils.DecodeElementString(p, e.AssignedTo);
            e.Priority = Security.CryptoUtils.DecodeElementString(p, e.Priority);
            e.Summary = Security.CryptoUtils.DecodeElementString(p, e.Summary);
            e.DateCreation = e.DateCreation;
            e.DateStart = e.DateStart;
            e.DateFinish = e.DateFinish;
            e.IdProyect = e.IdProyect;

            return e;
        }

        /// <summary>
        /// Method that decodes an elements list from a proyect
        /// </summary>
        /// <param name="p">Proyect</param>
        /// <returns></returns>
        public List<Elements> GetAllElementsDecoded(Proyects.Proyects p)
        {

            List<Elements> LE = new List<Elements>();

            // Its necessary to fill this LIST with elements from the P introduced
            // Do a linq query and get all elements from a certain idProyect
            // then add it to this LE list

            // Decode the entire list
            foreach (Elements e in LE)
            {
                e.DecodeElement(p, e);
            }

            return LE;
        }

        #endregion

        #region NEW 

        public void New()
        {
            // Add to database
            // entityframework
        }

        #endregion

        #region EDIT

        public void Edit()
        {
            // Edit in database
            // entityframework
        }

        #endregion

        #region REMOVE

        public void Remove()
        {

            // Removef in database
            // entityframework
        }

        #endregion

    }
}