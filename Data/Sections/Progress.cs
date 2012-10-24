using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data.Sections
{
    class Progress : FTLContainer
    {
        public Progress()
        {
            ShipsDefeated = new FTLInt();
            JumpsInSector = new FTLInt();
            ScrapCollected = new FTLInt();
            CrewRecruited = new FTLInt();
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
