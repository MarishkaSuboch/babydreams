﻿namespace Catalog.API.Entities
{
    public record Category
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
