using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static partial class Registration
    {
        public class ECXDBContextFactory
             : IDesignTimeDbContextFactory<ECXDBContext>
        {
            public ECXDBContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
                var builder = new DbContextOptionsBuilder<ECXDBContext>();
                var connectionString = configuration.GetConnectionString("ECXWeighConnectionString");
                builder.UseSqlServer(connectionString);
                return new ECXDBContext(builder.Options);
            }
        }
    }
}
