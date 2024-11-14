using MongoDB.Bson.Serialization.Attributes;

namespace ExampleMicroservice.Catalog.API.Repositories;

public class BaseEntity
{
    [BsonElement("_id")] public Guid Id { get; set; }
}