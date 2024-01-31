using System.Globalization;

namespace Catalog.API.Entities
{
    public class Consultant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Middlename { get; set; }
        public string Email { get; set; }
        public string ModilePhone { get; set; }
        public SocialType SocialType { get; set; }
        public string Social { get; set; }
    }
}
