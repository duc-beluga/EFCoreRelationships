namespace EFCoreRelationships.Models
{
    public class House
    {
        public int Id { get; set; }
        public string City { get; set; } = string.Empty;
        public Character Character { get; set; } = null!;
    }
}
