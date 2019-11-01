using System.Collections.Generic;

namespace LigaTyperow.Models.League
{
    public class KOTree
    {
        public List<KOMatch> KOMatches { get; set; }
        
        public Team? ThirdPlace { get; set; }
        public Team SecondPlace { get; set; }
        public Team Winner { get; set; }
    }
}