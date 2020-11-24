namespace EmeraldBotany.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using EmeraldBotany.Data.Common.Models;
    using EmeraldBotany.Data.Models.Enums;

    public class Growth : BaseDeletableModel<int>
    {
        public Growth()
        {
            this.GrowthMonths = new HashSet<GrowthMonths?>();
            this.BloomMonths = new HashSet<BloomMonths?>();
            this.FruitMonths = new HashSet<FruitMonths?>();
        }

        public double? DaysToHarvest { get; set; }

        public string Description { get; set; }

        public string Sowing { get; set; }

        public double? PhMaximum { get; set; }

        public double? PhMinimum { get; set; }

        public int? Light { get; set; }

        public int? AtmosphericHumidity { get; set; }

        public int? SoilNutriments { get; set; }

        public int? SoilSalinity { get; set; }

        public int? SoilTexture { get; set; }

        public int? SoilHumidity { get; set; }

        public int? RowSpacingId { get; set; }

        public int? SpreadId { get; set; }

        public int? MinimumPrecipitationId { get; set; }

        public int? MaximumPrecipitationId { get; set; }

        public int? MinimumRootDepthId { get; set; }

        public int? MinimumTemperatureId { get; set; }

        public int? MaximumTemperatureId { get; set; }

        public virtual RowSpacing RowSpacing { get; set; }

        public virtual Spread Spread { get; set; }

        public virtual MinimumPrecipitation MinimumPrecipitation { get; set; }

        public virtual MaximumPrecipitation MaximumPrecipitation { get; set; }

        public virtual MinimumRootDepth MinimumRootDepth { get; set; }

        public virtual MinimumTemperature MinimumTemperature { get; set; }

        public virtual MaximumTemperature MaximumTemperature { get; set; }

        [NotMapped]
        public virtual ICollection<GrowthMonths?> GrowthMonths { get; set; }

        [NotMapped]
        public virtual ICollection<BloomMonths?> BloomMonths { get; set; }

        [NotMapped]
        public virtual ICollection<FruitMonths?> FruitMonths { get; set; }
    }
}
