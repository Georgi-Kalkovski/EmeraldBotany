namespace EmeraldBotany.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using EmeraldBotany.Data.Common.Models;

    public class Images : BaseDeletableModel<int>
    {
        [NotMapped]
        public ICollection<string> ImageUrl { get; set; }

        // public Images()
        // {
        //     this.Flower = new HashSet<Flower>();
        //     this.Leaf = new HashSet<Leaf>();
        //     this.Habit = new HashSet<Habit>();
        //     this.Fruit = new HashSet<Fruit>();
        //     this.Bark = new HashSet<Bark>();
        //     this.Other = new HashSet<Other>();
        // }
        //
        // public virtual ICollection<Flower> Flower { get; set; }
        //
        // public virtual ICollection<Leaf> Leaf { get; set; }
        //
        // public virtual ICollection<Habit> Habit { get; set; }
        //
        // public virtual ICollection<Fruit> Fruit { get; set; }
        //
        // public virtual ICollection<Bark> Bark { get; set; }
        //
        // public virtual ICollection<Other> Other { get; set; }
    }
}
