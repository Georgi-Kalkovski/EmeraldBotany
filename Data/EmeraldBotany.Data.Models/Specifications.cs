namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;
    using EmeraldBotany.Data.Models.Enums;

    public class Specifications : BaseDeletableModel<int>
    {
        public string GrowthForm { get; set; }

        public string GrowthHabit { get; set; }

        public string GrowthRate { get; set; }

        public string NitrogenFixation { get; set; }

        public string ShapeAndOrientation { get; set; }

        public int? AverageHeightId { get; set; }

        public int? MaximumHeightId { get; set; }

        public virtual AverageHeight AverageHeight { get; set; }

        public virtual MaximumHeight MaximumHeight { get; set; }

        public SpecificationsLigneousType? LigneousType { get; set; }

        public SpecificationsToxicity? Toxicity { get; set; }
    }
}
