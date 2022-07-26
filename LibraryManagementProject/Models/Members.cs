using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class Members
    {
        [Key]
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberEmail { get; set; }
        public string MemberPhone { get; set; }

        public string MemberAddress { get; set; }
        public int DesignationId { get; set; }
        public string Designation { get; set; }
    }
}
