using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTLTrainer.Data.DataTypes;

namespace FTLTrainer.Data.Sections
{
    class CrewOverview : FTLContainer
    {
        public CrewOverview()
        {
            Crew = new FTLArray("Crew", () => new FTLCrewOverview());
        }

        FTLArray Crew { get; set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return Crew;
        }
    }
}
