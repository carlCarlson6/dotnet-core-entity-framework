using System;
using Microsoft.EntityFrameworkCore;

namespace Repository.Models
{
    public class PostgresDbContext: DbContext
    {
        public PostgresDbContext(DbContextOptions<PostgresDbContext> options): base(options) { }

        public DbSet<Article> Articles {get; set;}
    }
}
