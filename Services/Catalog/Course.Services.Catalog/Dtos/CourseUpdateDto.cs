using System;
namespace TrainingCourses.Services.Catalog.Dtos
{
    public class CourseUpdateDto
	{
        public string? Id { get; set; }

        public string? Name { get; set; }

        public decimal Price { get; set; }

        public string? UserId { get; set; }

        public string? ImageUrl { get; set; }

        public FeatureDto? Feature { get; set; }

        public string? CategoryId { get; set; }

        public string? Description { get; set; }
    }
}

