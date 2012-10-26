using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FTLTrainer.Data.DataTypes;

namespace FTLTrainer.Data.Sections
{
    class Score : FTLContainer
    {
        public Score()
        {
            ScoreCategories = new FTLArray("ScoreCategories", () => new FTLScoreCategory());
        }

        FTLArray ScoreCategories { get; set; }

        protected override IEnumerable<IFTLVlaue> GetValues()
        {
            yield return ScoreCategories;
        }
    }
}
