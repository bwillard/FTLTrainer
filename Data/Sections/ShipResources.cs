using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data.Sections
{
    class ShipResources : FTLContainer
    {
        public ShipResources()
        {
            Hull = new FTLInt();
            Fuel = new FTLInt();
            Drones = new FTLInt();
            Missiles = new FTLInt();
            Scrap = new FTLInt();
        }
        public FTLInt Hull { get; set; }
        public FTLInt Fuel { get; set; }
        public FTLInt Drones { get; set; }
        public FTLInt Missiles { get; set; }
        public FTLInt Scrap { get; set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return Hull;
            yield return Fuel;
            yield return Drones;
            yield return Missiles;
            yield return Scrap;
        }
    }
}
