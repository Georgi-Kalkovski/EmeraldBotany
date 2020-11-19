namespace EmeraldBotany.Data.Models
{
    public class Division_order
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public Division_class Division_class { get; set; }

        public Links5 Links { get; set; } = new Links5();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
