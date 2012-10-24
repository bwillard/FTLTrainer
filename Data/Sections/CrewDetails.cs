using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data.Sections
{
    class CrewDetails : FTLContainer
    {
        public CrewDetails()
        {
            Crew = new FTLArray<FTLCrewDetail>();
        }

        FTLArray<FTLCrewDetail> Crew { get; set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return Crew;
        }
    }
}
