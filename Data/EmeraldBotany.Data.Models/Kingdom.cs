namespace EmeraldBotany.Data.Models
{
    public class Kingdom
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public Links Links { get; set; } = new Links();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
