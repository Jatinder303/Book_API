using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Book_API.Models;

namespace Book_API.Data
{
    public class Book_API_Database : DbContext
    {
        public Book_API_Database (DbContextOptions<Book_API_Database> options)
            : base(options)
        {
        }

        public DbSet<Book_API.Models.Book> Book { get; set; }
    }
}
