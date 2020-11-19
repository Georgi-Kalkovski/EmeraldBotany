namespace EmeraldBotany.Data.Models
{
    public class Subkingdom
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public Kingdom Kingdom { get; set; } = new Kingdom();

        public Links2 Links { get; set; } = new Links2();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
