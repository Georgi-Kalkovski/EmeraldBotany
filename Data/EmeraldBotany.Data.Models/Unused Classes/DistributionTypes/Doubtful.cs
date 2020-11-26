namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class Doubtful : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Slug { get; set; }

        public string TdwgCode { get; set; }

        public int TdwgLevel { get; set; }

        public int SpeciesCount { get; set; }

        public int? LinksId { get; set; }

        public virtual Links Links { get; set; }
    }
}
