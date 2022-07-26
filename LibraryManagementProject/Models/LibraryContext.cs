using LibraryManagementProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Books> Books { get; set; }

        public DbSet<Ebooks> EBooks { get; set; }
        public DbSet<Issues> Issues { get; set; }

        public DbSet<Members> Members { get; set; }
        
        public DbSet<BookStatuses> BStatus { get; set; }
    }
}

