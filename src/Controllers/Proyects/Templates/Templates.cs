using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lovis.Controllers.Proyects.Templates
{
    public class Templates
    {
        #region ATTRIBUTES

        public int Id { get; set; }
        public string Title { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public string Type3 { get; set; }
        public string Type4 { get; set; }
        public string Type5 { get; set; }

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Templates() { }

        /// <summary>
        /// Constructor filled with template
        /// </summary>
        /// <param name="T">Template</param>
        public Templates(Templates T) { }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="title">Template title</param>
        /// <param name="type1">Type 1</param>
        /// <param name="type2">Type 2</param>
        /// <param name="type3">Type 3</param>
        /// <param name="type4">Type 4</param>
        /// <param name="type5">Type 5</param>
        public Templates(string title, string type1, string type2, string type3, string type4, string type5)
        {
            // Get count from templates table in database


            // Save it to a counter
            int tCounter = 0;

            // Save other stuff
            Id = tCounter++;
            Title = title;
            Type1 = type1;
            Type2 = type2;
            Type3 = type3;
            Type4 = type4;
            Type5 = type5;
        }

        #endregion

        #region NEW

        /// <summary>
        /// Method that creates a templates.
        /// </summary>
        public void New()
        {
            // Add to database
            // entityframework

        }

        #endregion

        #region EDIT

        /// <summary>
        /// Method that edits a template.
        /// </summary>
        public void Edit()
        {
            // Edit template in database
            // entityframework
        }

        #endregion

        #region REMOVE

        /// <summary>
        /// Method that removes a template.
        /// </summary>
        public void Remove()
        {
            // Remove template from database
            // entityframework
        }

        #endregion
    }
}