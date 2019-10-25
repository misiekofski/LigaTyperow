using System.Collections.Generic;

namespace LigaTyperow.Models.League
{
    public class Group
    {
        public int GroupId { get; set; }
        public List<Team> Teams { get; set; }
        public List<Match> GroupMatches { get; set; }
    }
}