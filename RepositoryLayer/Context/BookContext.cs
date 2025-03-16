using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;

namespace RepositoryLayer.Context
{
    public class BookContext :DbContext
    {
        public virtual DbSet<BookEntity> Books { get; set; }

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }
    }
}
