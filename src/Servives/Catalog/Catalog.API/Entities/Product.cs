using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Catalog.API.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public required string Name { get; set; } 
        public string Description { get; set; }
        public required Category Category { get; set; }
        public required Consultant Consultant { get; set; }
        public required int Price { get; set; }
        public required string Currency { get; set; }

    }
}
