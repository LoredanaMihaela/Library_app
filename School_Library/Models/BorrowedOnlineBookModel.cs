using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Library.Models
{
    public class BorrowedOnlineBookModel
    {
        public Guid IDBorrowedOnlineBook { get; set; }
        public Guid IDOnlineBook { get; set; }
        public Guid IDUser { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public bool IsAvaible { get; set; }
    }
}