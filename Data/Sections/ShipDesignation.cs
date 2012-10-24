using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data.Sections
{
    class ShipDesignation : FTLContainer
    {
        public ShipDesignation()
        {
            Name = new FTLString();
            ShipId = new FTLString();
            Unkown = new FTLByteArray(8);
        }
        public FTLString Name { get; set; }
        public FTLString ShipId { get; set; }
        public FTLByteArray Unkown { get; set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return Name;
            yield return ShipId;
            yield return Unkown;
        }
    }
}
