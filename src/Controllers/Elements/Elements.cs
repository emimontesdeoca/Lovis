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
        public string Priority { get; set; }
        public string Summary { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public string IdProyect { get; set; }

        #endregion

        #region CONSTRUCTORS

        public Elements() { }

        #endregion

        #region CHECK ELEMENT


        #endregion

        #region NEW 

        public void New()
        {

        }

        #endregion

        #region EDIT

        public void Edit()
        {

        }

        #endregion

        #region REMOVE

        public void Remove()
        {

        }

        #endregion

    }
}