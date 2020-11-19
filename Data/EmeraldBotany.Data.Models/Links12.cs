namespace EmeraldBotany.Data.Models
{
    public class Links12
    {
        public string Self { get; set; }

        public string Plants { get; set; }

        public string Species { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
