namespace LigaTyperow.Models
{
    public class Footballer
    {
        public int FootballerId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Goals { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}