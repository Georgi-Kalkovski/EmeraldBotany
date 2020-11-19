namespace EmeraldBotany.Data.Models
{
    public class Distributions
    {
        public System.Collections.Generic.ICollection<Native> Native { get; set; }

        public System.Collections.Generic.ICollection<Introduced> Introduced { get; set; }

        public System.Collections.Generic.ICollection<Doubtful> Doubtful { get; set; }

        public System.Collections.Generic.ICollection<Absent> Absent { get; set; }

        public System.Collections.Generic.ICollection<Extinct> Extinct { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}