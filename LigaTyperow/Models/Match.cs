using System.Collections.Generic;

namespace LigaTyperow.Models
{
    public class Match
    {
        public int MatchId { get; set; }

        public Team TeamA { get; set; }
        public Team TeamB { get; set; }
        
        public int TeamAScore { get; set; }
        public int TeamBScore { get; set; }

        public List<Footballer> Scorers { get; set; }
    }
}