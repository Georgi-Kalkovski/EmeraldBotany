namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class Extinct : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public string TdwgCode { get; set; }

        public int TdwgLevel { get; set; }

        public int SpeciesCount { get; set; }

        public int? LinksId { get; set; }

        public Links Links { get; set; }
    }
}
