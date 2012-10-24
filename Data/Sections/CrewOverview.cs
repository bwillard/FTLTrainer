using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data.Sections
{
    class CrewOverview : FTLContainer
    {
        public CrewOverview()
        {
            Crew = new FTLArray<FTLCrewOverview>();
        }

        FTLArray<FTLCrewOverview> Crew { get; set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return Crew;
        }
    }
}
