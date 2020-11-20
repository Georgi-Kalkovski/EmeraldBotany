namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class Links : BaseDeletableModel<int>
    {
        public string Self { get; set; }

        public string Genus { get; set; }

        public string Entity { get; set; }
    }
}
