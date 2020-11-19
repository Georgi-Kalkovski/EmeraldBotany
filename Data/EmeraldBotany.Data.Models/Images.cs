namespace EmeraldBotany.Data.Models
{
    public class Images
    {
        public System.Collections.Generic.ICollection<Flower2> Flower { get; set; }

        public System.Collections.Generic.ICollection<Leaf> Leaf { get; set; }

        public System.Collections.Generic.ICollection<Habit> Habit { get; set; }

        public System.Collections.Generic.ICollection<Fruit> Fruit { get; set; }

        public System.Collections.Generic.ICollection<Bark> Bark { get; set; }

        public System.Collections.Generic.ICollection<Other> Other { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}