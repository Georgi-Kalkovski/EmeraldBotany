namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class Source : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Url { get; set; }

        public string LastUpdate { get; set; }

        public string Citation { get; set; }
    }
}
