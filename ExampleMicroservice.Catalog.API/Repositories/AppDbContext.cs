using System.Reflection;
using ExampleMicroservice.Catalog.API.Features.Categories;
using ExampleMicroservice.Catalog.API.Features.Courses;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;

namespace ExampleMicroservice.Catalog.API.Repositories;

public class AppDbContext(DbContextOptions<AppDbContext> options):DbContext(options)
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Course> Courses { get; set; }

    public static AppDbContext Create(IMongoDatabase database)
    {
       var optionBuilder = new DbContextOptionsBuilder<AppDbContext>()
           .UseMongoDB(database.Client,database.DatabaseNamespace.DatabaseName);
       
       return new AppDbContext(optionBuilder.Options);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}