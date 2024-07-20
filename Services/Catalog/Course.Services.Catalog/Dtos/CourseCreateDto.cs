﻿using System;
namespace TrainingCourses.Services.Catalog.Dtos
{
    public class CourseCreateDto
	{

        public string? Name { get; set; }

        public decimal Price { get; set; }

        public string? UserId { get; set; }

        public FeatureDto? Feature { get; set; }

        public string? CategoryId { get; set; }

        public string? ImageUrl { get; set; }

        public string? Description { get; set; }


    }
}

