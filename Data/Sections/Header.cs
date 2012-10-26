using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTLTrainer.Data.DataTypes;

namespace FTLTrainer.Data.Sections
{
    class Header : FTLContainer
    {
        public Header()
        {
            Version = new FTLInt("Version");
            Unknown = new FTLInt("Unkown");
        }
        public FTLInt Version { get; set; }
        public FTLInt Unknown { get; set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return Version;
            yield return Unknown;
        }
    }
}
