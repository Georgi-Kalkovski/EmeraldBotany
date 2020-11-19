namespace EmeraldBotany.Data.Models
{
    public class Fruit_or_seed
    {
        public bool? Conspicuous { get; set; }

        public System.Collections.Generic.ICollection<Color3?> Color { get; set; }

        public string Shape { get; set; }

        public bool? Seed_persistence { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}