namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;
    using EmeraldBotany.Data.Models.Enums;

    public class Foliage : BaseDeletableModel<int>
    {
        public bool? LeafRetention { get; set; }

        public string Texture { get; set; }

        public virtual Color Color { get; set; }
    }
}
