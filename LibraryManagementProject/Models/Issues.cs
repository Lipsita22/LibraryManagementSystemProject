using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Issues
    {
        [Key]
        public int IssueId { get; set; }
        [ForeignKey("StudentId")]
        public Students Student { get; set; }


        [ForeignKey("BookId")]
        public Books Book { get; set; }

        public string Message { get; set; }
    }
}
