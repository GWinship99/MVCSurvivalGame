namespace MVCSurvivalGame.Models
{
    public class Survivor
    {
        public int Id { get; set; }
        public string? Forename { get; set; }
        public string? Surname { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        public bool isAlive { get; set; }
    }
}
