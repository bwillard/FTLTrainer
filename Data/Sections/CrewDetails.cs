using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTLTrainer.Data.DataTypes;

namespace FTLTrainer.Data.Sections
{
    class CrewDetails : FTLContainer
    {
        public CrewDetails()
        {
            Crew = new FTLArray("Crew", ()=> new FTLCrewDetail());
        }

        FTLArray Crew { get; set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return Crew;
        }
    }
}
