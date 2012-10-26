using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTLTrainer.Data.DataTypes;

namespace FTLTrainer.Data.Sections
{
    class ShipDesignation : FTLContainer
    {
        public ShipDesignation()
        {
            Name = new FTLString("Name");
            ShipId = new FTLString("Ship ID");
            Unkown = new FTLByteArray("Unknown",8);
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
