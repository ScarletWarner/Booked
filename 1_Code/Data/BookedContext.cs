using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Booked.Models;

namespace Booked.Data
{
    public class BookedContext : DbContext
    {
        public BookedContext (DbContextOptions<BookedContext> options)
            : base(options)
        {
        }

        public DbSet<Booked.Models.Book> Book { get; set; } = default!;
    }
}
