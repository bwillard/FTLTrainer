using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data.Sections
{
    class ShipDetails : FTLContainer
    {
        public ShipDetails()
        {
            ShipId = new FTLString();
            ShipName = new FTLString();
            ShipTypeID = new FTLString();
        }
        public FTLString ShipId { get; set; }
        public FTLString ShipName { get; set; }
        public FTLString ShipTypeID { get; set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return ShipId;
            yield return ShipName;
            yield return ShipTypeID;
        }
    }
}
