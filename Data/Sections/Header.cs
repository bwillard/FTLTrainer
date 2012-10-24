using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data.Sections
{
    class Header : FTLContainer
    {
        public Header()
        {
            Version = new FTLInt();
            Unknown = new FTLInt();
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
