using System;
using System.Collections.Generic;

namespace LigaTyperow.Models.League
{
    public class Match
    {
        public int MatchId { get; set; }

        public Team TeamA { get; set; }
        public Team TeamB { get; set; }
        
        public int TeamAScore { get; set; }
        public int TeamBScore { get; set; }

        private DateTime ExpirationDate { get; set; }

        private int? GroupId { get; set; }

        public List<Footballer> Scorers { get; set; }
    }
}