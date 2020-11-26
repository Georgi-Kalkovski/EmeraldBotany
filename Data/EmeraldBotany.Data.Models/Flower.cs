namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class Flower : BaseDeletableModel<int>
    {
        public bool? Conspicuous { get; set; }

        public virtual Color Color { get; set; }
    }
}
