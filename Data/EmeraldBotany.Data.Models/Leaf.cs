namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class Leaf : BaseDeletableModel<int>
    {
        public string ImageUrl { get; set; }

        public string Copyright { get; set; }
    }
}
