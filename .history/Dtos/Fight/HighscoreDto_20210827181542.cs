namespace dotnet_rpg.Dtos.Fight
{
    public class HighscoreDto
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Fights { get; set; }
        public int Defeats {get; set;}
        public int Victories {get; set;}
    }
}