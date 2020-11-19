namespace EmeraldBotany.Data.Models
{
    public class Genus
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public Family Family { get; set; }

        public Links7 Links { get; set; } = new Links7();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
