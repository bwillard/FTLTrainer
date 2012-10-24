using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FTLTrainer.Data.Sections
{
    class Score : FTLContainer
    {
        public Score()
        {
            ScoreCategories = new FTLArray<FTLScoreCategory>();
        }

        FTLArray<FTLScoreCategory> ScoreCategories { get; set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return ScoreCategories;
        }
    }
}
