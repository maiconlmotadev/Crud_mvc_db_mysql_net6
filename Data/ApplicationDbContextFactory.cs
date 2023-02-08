﻿using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Crud_mvc_db_mysql_net6.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Context>();
            optionsBuilder.UseMySql("server=127.0.0.1:3306;Initial Catalog=Crud_mvc_db_mysql_net6; uid=mac_win; pwd=M123456*",
            Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.32-mysql"));

            return new Context(optionsBuilder.Options);
        }
    }
}