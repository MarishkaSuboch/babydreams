namespace Catalog.API.Entities
{
    public record SubCategory
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
