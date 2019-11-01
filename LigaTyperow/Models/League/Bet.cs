using System;


namespace LigaTyperow.Models.League
{
    public class Bet
    {
        public int BetId { get; set; }
        public DateTime ExpirationDate { get; set; }

        public int? MatchId { get; set; }
        public Match Match { get; set; }

        public int PointsToGain { get; set; }
    }
}