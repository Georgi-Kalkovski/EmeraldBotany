﻿namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public partial class SpeciesDataDump
    {
        public int Id { get; set; }

        public string ScientificName { get; set; }

        public string Rank { get; set; }

        public string Genus { get; set; }

        public string Family { get; set; }

        public int? Year { get; set; }

        public string Author { get; set; }

        public string Bibliography { get; set; }

        public string CommonName { get; set; }

        public string FamilyCommonName { get; set; }

        public string ImageUrl { get; set; }

        public string FlowerColor { get; set; }

        public bool? FlowerConspicuous { get; set; }

        public string FoliageColor { get; set; }

        public string FoliageTexture { get; set; }

        public string FruitColor { get; set; }

        public bool? FruitConspicuous { get; set; }

        public string FruitMonths { get; set; }

        public string BloomMonths { get; set; }

        public string GroundHumidity { get; set; }

        public string GrowthForm { get; set; }

        public string GrowthHabit { get; set; }

        public string GrowthMonths { get; set; }

        public string GrowthRate { get; set; }

        public string EdiblePart { get; set; }

        public bool? Vegetable { get; set; }

        public bool? Edible { get; set; }

        public int? Light { get; set; }

        public string SoilNutriments { get; set; }

        public string SoilSalinity { get; set; }

        public string AnaerobicTolerance { get; set; }

        public string AtmosphericHumidity { get; set; }

        public int? AverageHeightCm { get; set; }

        public int? MaximumHeightCm { get; set; }

        public int? MinimumRootDepthCm { get; set; }

        public double? PhMaximum { get; set; }

        public double? PhMinimum { get; set; }

        public string PlantingDaysToHarvest { get; set; }

        public string PlantingDescription { get; set; }

        public string PlantingSowingDescription { get; set; }

        public string PlantingRowSpacingCm { get; set; }

        public string PlantingSpreadCm { get; set; }

        public string Synonyms { get; set; }

        public string Distributions { get; set; }

        public string CommonNames { get; set; }

        public string UrlSsda { get; set; }

        public string UrlTropicos { get; set; }

        public string UrlTelaBotanica { get; set; }

        public string UrlPowo { get; set; }

        public string UrlPlantnet { get; set; }

        public string UrlGbif { get; set; }

        public string UrlOpenfarm { get; set; }

        public string UrlCatminat { get; set; }

        public string UrlWikipediaEn { get; set; }
    }
}