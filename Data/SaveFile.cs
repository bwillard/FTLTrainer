using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTLTrainer.Data.Sections;
using FTLTrainer.Data.DataTypes;

namespace FTLTrainer.Data
{
    public class SaveFile : FTLContainer
    {
        public SaveFile()
        {
            Header = new Header();
            Progress = new Progress();
            ShipDesignation = new ShipDesignation();
            Score = new Score();
            ShipDetails = new ShipDetails();
            CrewOverview = new CrewOverview();
            ShipResources = new ShipResources();
            CrewDetails = new CrewDetails();
            FTLRemainder = new FTLRemainder("Remainder");
        }

        Header Header { get; set; }
        Progress Progress { get; set; }
        ShipDesignation ShipDesignation { get; set; }
        Score Score { get; set; }
        ShipDetails ShipDetails { get; set; }
        CrewOverview CrewOverview { get; set; }
        ShipResources ShipResources { get; set; }
        CrewDetails CrewDetails { get; set; }
        FTLRemainder FTLRemainder { get; set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return Header;
            yield return Progress;
            yield return ShipDesignation;
            yield return Score;
            yield return ShipDetails;
            yield return CrewOverview;
            yield return ShipResources;
            yield return CrewDetails;
            yield return FTLRemainder;
        }
    }
}
