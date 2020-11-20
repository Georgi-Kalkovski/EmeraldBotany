namespace EmeraldBotany.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using EmeraldBotany.Data.Common.Models;
    using EmeraldBotany.Data.Models.Enums;

    public class Flower : BaseDeletableModel<int>
    {
        public Flower()
        {
            this.Color = new HashSet<Color?>();
        }

        public bool? Conspicuous { get; set; }

        [NotMapped]
        public virtual ICollection<Color?> Color { get; set; }
    }
}
