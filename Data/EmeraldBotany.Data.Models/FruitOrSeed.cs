namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class FruitOrSeed : BaseDeletableModel<int>
    {
        public bool? Conspicuous { get; set; }

        public virtual Color Color { get; set; }

        // public string Shape { get; set; }
        //
        // public bool? SeedPersistence { get; set; }
    }
}
