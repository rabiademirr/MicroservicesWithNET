using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
namespace TrainingCourses.Services.Catalog.Models
{
	public class Course
	{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
		public string? Id { get; set; }

        public string? Name { get; set; }


        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Price { get; set; }

        public string? ImageUrl { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTime CreatedOn { get; set; }

        public string? UserId { get; set; }

        public Feature? Feature { get; set; }


        [BsonRepresentation(BsonType.ObjectId)]
        public string? CategoryId { get; set; }


        public string? Description { get; set; }


        [BsonIgnore]
        public Category? Category { get; set; }



    }
}

