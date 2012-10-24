using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data
{
    class FTLScoreCategory : FTLContainer
    {
        public FTLScoreCategory()
        {
            CategoryId = new FTLString();
            CategoryValue = new FTLInt();
        }
        public FTLString CategoryId { get; private set; }
        public FTLInt CategoryValue { get; private set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return CategoryId;
            yield return CategoryValue;
        }
        
    }
}
