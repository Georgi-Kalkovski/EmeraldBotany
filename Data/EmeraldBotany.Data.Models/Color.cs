namespace EmeraldBotany.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using EmeraldBotany.Data.Common.Models;

    public class Color : BaseDeletableModel<int>
    {
        [NotMapped]
        public ICollection<string> Colors { get; set; }
    }
}
