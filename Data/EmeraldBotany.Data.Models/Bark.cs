namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class Bark : BaseDeletableModel<int>
    {
        public string ImageUrl { get; set; }

        public string Copyright { get; set; }
    }
}
