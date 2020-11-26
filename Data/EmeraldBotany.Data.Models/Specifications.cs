namespace EmeraldBotany.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using EmeraldBotany.Data.Common.Models;

    public class Specifications : BaseDeletableModel<int>
    {
        public string GrowthForm { get; set; }

        public string GrowthHabit { get; set; }

        public string GrowthRate { get; set; }

        public AverageHeight AverageHeight { get; set; }

        public MaximumHeight MaximumHeight { get; set; }

        // public Specifications()
        // {
        //    this.LigneousType = new HashSet<string>();
        //    this.Toxicity = new HashSet<string>();
        // }

        // public string NitrogenFixation { get; set; }
        //
        // public string ShapeAndOrientation { get; set; }

        // [NotMapped]
        // public ICollection<string> LigneousType { get; set; }
        //
        // [NotMapped]
        // public ICollection<string> Toxicity { get; set; }
    }
}
