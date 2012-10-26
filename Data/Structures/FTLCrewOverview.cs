using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTLTrainer.Data.DataTypes;

namespace FTLTrainer.Data
{
    class FTLCrewOverview : FTLContainer
    {
        public FTLCrewOverview()
        {
            Race = new FTLString("Race");
            Name = new FTLString("Name");
        }

        public FTLString Race { get; private set; }
        public FTLString Name { get; private set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return Race;
            yield return Name;
        }
    }
}
