namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class Fruit : BaseDeletableModel<int>
    {
        public string ImageUrl { get; set; }

        public string Copyright { get; set; }
    }
}
