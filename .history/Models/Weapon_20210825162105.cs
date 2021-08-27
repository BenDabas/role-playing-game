namespace dotnet_rpg.Models
{
    public class Weapon
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public int Damage {get; set;}
        public Character Character {get; set;}
        public int CharacterId {get; set;}  // Because of the Character and CharacterId properties the entity framework knows that this is the corresponding foreign key for the character property.
    }
}