using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTLTrainer.Data.DataTypes;

namespace FTLTrainer.Data
{
    class FTLScoreCategory : FTLContainer
    {
        public FTLScoreCategory() : base("ScoreCategory")
        {
            CategoryId = new FTLString("Category Id");
            CategoryValue = new FTLInt("Category Value");
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
