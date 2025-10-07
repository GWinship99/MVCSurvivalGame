using System.ComponentModel.DataAnnotations;

namespace MVCSurvivalGame.Models
{
    public class Survivor
    {
        public int Id { get; set; }
        public string? Forename { get; set; }
        public string? Surname { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        [Display(Name = "Is Alive")]
        public bool isAlive { get; set; }
    }
}
