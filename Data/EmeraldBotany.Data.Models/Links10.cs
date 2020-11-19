namespace EmeraldBotany.Data.Models
{
    public class Links10
    {
        public string Self { get; set; }

        public string Genus { get; set; }

        public string Plant { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}