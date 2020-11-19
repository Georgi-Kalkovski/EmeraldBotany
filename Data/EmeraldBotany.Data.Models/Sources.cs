namespace EmeraldBotany.Data.Models
{
    public class Sources
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Citation { get; set; }

        public string Url { get; set; }

        public string Last_update { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}