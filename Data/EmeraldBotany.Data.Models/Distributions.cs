namespace EmeraldBotany.Data.Models
{
    using System.Collections.Generic;

    using EmeraldBotany.Data.Common.Models;

    public class Distributions : BaseDeletableModel<int>
    {
        public Distributions()
        {
            this.Native = new HashSet<Native>();
            this.Introduced = new HashSet<Introduced>();
            this.Doubtful = new HashSet<Doubtful>();
            this.Absent = new HashSet<Absent>();
            this.Extinct = new HashSet<Extinct>();
        }

        public virtual ICollection<Native> Native { get; set; }

        public virtual ICollection<Introduced> Introduced { get; set; }

        public virtual ICollection<Doubtful> Doubtful { get; set; }

        public virtual ICollection<Absent> Absent { get; set; }

        public virtual ICollection<Extinct> Extinct { get; set; }
    }
}
