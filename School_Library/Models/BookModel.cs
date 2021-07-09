using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace School_Library.Models
{
    public class BookModel
    {
        public Guid IDBook { get; set; }

        [Required(ErrorMessage = "Mandatory field")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Mandatory field")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Mandatory field")]
        public string Field { get; set; }

        [StringLength(250,ErrorMessage ="You can`t type more than 300 chars")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Mandatory field")]
        public int NumberOfBooks { get; set; }
        [Required(ErrorMessage = "Mandatory field")]
        public int NumberOfBooksAvaible { get; set; }
    }
}