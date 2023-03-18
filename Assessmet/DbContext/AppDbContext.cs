using Assessmet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace Assessmet.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public System.Data.Entity.DbSet<ApplicationForm> application { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var accountEndpoint = "https://localhost:8081";
        var accountKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
        var dbName = "misk-db";
        optionsBuilder.UseCosmos(accountEndpoint, accountKey, dbName);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<ApplicationForm>()
            .ToContainer("application")
            .HasPartitionKey(x => x.ApplicationId);

        builder.Entity<ApplicationForm>().OwnsMany(x => x.Educations);
        builder.Entity<ApplicationForm>().OwnsMany(x => x.Experiences);
       // builder.Entity<ApplicationForm>().OwnsMany(x => x.Questions).OwnsMany(x => x.InterviewQuestion);
    }
}
}
