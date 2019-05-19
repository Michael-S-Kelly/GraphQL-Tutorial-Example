using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RealEstateManager.Database
{
    class RealEstateContextFactory : IDesignTimeDbContextFactory<RealEstateContext>
    {
        public RealEstateContext CreateDbContext(string[] args)
        {
            // Needs to add Microsoft.Extensions.Configuration.Json to the RealEstateManager.Database project with Manager NuGet Packages
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<RealEstateContext>();
            var connectionString = configuration.GetConnectionString("RealEstateDb");
            // Needs to add Microsoft.EntityFrameworkCore.SqlServer to the RealEstateManager.Database project with Manager NuGet Packages
            builder.UseSqlServer(connectionString);

            return new RealEstateContext(builder.Options);
        }
    }
}
