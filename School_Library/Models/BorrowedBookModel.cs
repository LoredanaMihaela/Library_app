using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School_Library.Models
{
    public class BorrowedBookModel
    {
        public Guid IDBorrowedBook { get; set; }
        public Guid IDBook { get; set; }
        public Guid IDUser { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public bool IsReturned { get; set; }
    }
}