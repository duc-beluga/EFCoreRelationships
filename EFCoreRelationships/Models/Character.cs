namespace EFCoreRelationships.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int HouseId { get; set; }

        // One to many
        public ICollection<Weapon> Weapons { get; set; } = null!;
        // One to one
        public House House { get; set; } = null!;
        
    }
}
