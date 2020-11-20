﻿namespace EmeraldBotany.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using EmeraldBotany.Data.Common.Models;
    using EmeraldBotany.Data.Models.Enums;

    public class Foliage : BaseDeletableModel<int>
    {
        public Foliage()
        {
            this.Color = new HashSet<Color?>();
        }

        public bool? LeafRetention { get; set; }

        public FoliageTexture? Texture { get; set; }

        [NotMapped]
        public virtual ICollection<Color?> Color { get; set; }
    }
}
