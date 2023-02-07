using Microsoft.EntityFrameworkCore;

namespace Crud_mvc_db_mysql_net6.Data
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { }


    }
}
