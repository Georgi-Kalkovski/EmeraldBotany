namespace EmeraldBotany.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using EmeraldBotany.Data.Common.Models;
    using EmeraldBotany.Data.Models.Enums;

    public class Foliage : BaseDeletableModel<int>
    {
        public Foliage()
        {
            this.Color = new HashSet<ColorEnum?>();
        }

        public bool? LeafRetention { get; set; }

        public FoliageTextureEnum? Texture { get; set; }

        [NotMapped]
        public virtual ICollection<ColorEnum?> Color { get; set; }
    }
}
