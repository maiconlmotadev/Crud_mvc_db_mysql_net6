
using Microsoft.EntityFrameworkCore;
using Crud_mvc_db_mysql_net6.Models;

namespace Crud_mvc_db_mysql_net6.Data
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options)   
            : base(options)
        { }

        public DbSet<User> User { get; set; }
    }
}
