using System.Collections.Generic;

namespace LigaTyperow.Models.League
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Points { get; set; }
        public List<Footballer> Players { get; set; } = new List<Footballer>();
    }
}