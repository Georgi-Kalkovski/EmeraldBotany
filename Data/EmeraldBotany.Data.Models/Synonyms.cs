namespace EmeraldBotany.Data.Models
{
    public class Synonyms
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Author { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}