using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class BookStatuses
    {
        [Key]
        public int BookStatusId { get; set; }
        public string status { get; set; }
    }
}
