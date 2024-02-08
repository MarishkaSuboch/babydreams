using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;

namespace Catalog.API.Entities
{
    public record Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public required Category Category { get; set; }
        public required SubCategory SubCategory { get; set; }
        public required Consultant Consultant { get; set; }
        public required int Price { get; set; }
        public required string Currency { get; set; }
        public DateTime Date { get; set; }

    }
}
