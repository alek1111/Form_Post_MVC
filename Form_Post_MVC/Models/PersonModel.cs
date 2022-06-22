using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Form_Post_MVC.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Gets or sets PersonId.
        /// </summary>
        [Range(1000, 2000)]
        public int PersonId { get; set; }

        /// <summary>
        /// Gets or sets Name.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets Gender.
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// Gets or sets City.
        /// </summary>
        public string City { get; set; }
    }
}