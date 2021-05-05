using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Library.Models
{
    public class OnlineBookModel
    {
        public Guid IDOnlineBook { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Field { get; set; }
        public string Description { get; set; }
        public bool IsAvaible { get; set; }
    }
}