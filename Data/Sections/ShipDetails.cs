using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTLTrainer.Data.DataTypes;

namespace FTLTrainer.Data.Sections
{
    class ShipDetails : FTLContainer
    {
        public ShipDetails()
        {
            ShipId = new FTLString("Ship Id");
            ShipName = new FTLString("Ship Name");
            ShipTypeID = new FTLString("Ship Type Id");
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
