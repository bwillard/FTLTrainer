using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTLTrainer.Data.DataTypes;

namespace FTLTrainer.Data.Sections
{
    class Progress : FTLContainer
    {
        public Progress()
        {
            ShipsDefeated = new FTLInt("Ships Defeated");
            JumpsInSector = new FTLInt("Jumps In Sector");
            ScrapCollected = new FTLInt("Scrap Collected");
            CrewRecruited = new FTLInt("Crew Recruited");
        }

        public FTLInt ShipsDefeated { get; set; }
        public FTLInt JumpsInSector { get; set; }
        public FTLInt ScrapCollected { get; set; }
        public FTLInt CrewRecruited { get; set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return ShipsDefeated;
            yield return JumpsInSector;
            yield return ScrapCollected;
            yield return CrewRecruited;
        }
    }
}
