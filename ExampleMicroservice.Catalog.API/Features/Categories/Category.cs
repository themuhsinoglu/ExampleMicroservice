using ExampleMicroservice.Catalog.API.Features.Courses;
using ExampleMicroservice.Catalog.API.Repositories;

namespace ExampleMicroservice.Catalog.API.Features.Categories;

public class Category : BaseEntity
{
    public string Name { get; set; }=default!;  
    public List<Course>? Courses { get; set; } 
    
}