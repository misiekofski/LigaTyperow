using System.Collections.Generic;

namespace LigaTyperow.Models
{
    public class Team
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public List<Footballer> Players { get; set; }
    }
}