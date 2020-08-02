using APIBarDG1.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace web_api_tests
{
    public static class DbContextMocker
    {
        public static ComandaContext GeComandaImportersDbContext(string dbName)
        {
            var options = new DbContextOptionsBuilder<ComandaContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            var dbContext = new ComandaContext(options);

            return dbContext;
        }

        public static ComandaItensContext GeComandaItensImportersDbContext(string dbName)
        {
            var options = new DbContextOptionsBuilder<ComandaItensContext>()
                .UseInMemoryDatabase(databaseName: dbName)
                .Options;

            var dbContext = new ComandaItensContext(options);

            dbContext.SeedItemComanda();

            return dbContext;
        }
    }
}
