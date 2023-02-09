using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Crud_mvc_db_mysql_net6.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseMySql(
            "server=127.0.0.1; uid=mac_win; pwd=M123456*; database=Crud_mvc_db_mysql_net6",
            Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"),

            mySqlOptions =>
            {

                mySqlOptions.EnableRetryOnFailure(
                maxRetryCount: 2,
                maxRetryDelay: TimeSpan.FromSeconds(30),
                errorNumbersToAdd: null);
            }

            );

            return new Context(optionsBuilder.Options);
        }

      
    }
}
