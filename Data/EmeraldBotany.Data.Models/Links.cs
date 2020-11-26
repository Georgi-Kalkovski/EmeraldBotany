namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class Links : BaseDeletableModel<int>
    {
        public string UrlUsda { get; set; }

        public string UrlTropicos { get; set; }

        public string UrlTelaBotanica { get; set; }

        public string UrlPowo { get; set; }

        public string UrlPlantnet { get; set; }

        public string UrlGbif { get; set; }

        public string UrlOpenfarm { get; set; }

        public string UrlCatminat { get; set; }

        public string UrlWikipediaEn { get; set; }

        // public string Self { get; set; }
        //
        // public string Genus { get; set; }
        //
        // public string Entity { get; set; }
    }
}
