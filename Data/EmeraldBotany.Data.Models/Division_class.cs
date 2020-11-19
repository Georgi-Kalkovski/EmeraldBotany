namespace EmeraldBotany.Data.Models
{
    public class Division_class
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public Division Division { get; set; }

        public Links4 Links { get; set; } = new Links4();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
