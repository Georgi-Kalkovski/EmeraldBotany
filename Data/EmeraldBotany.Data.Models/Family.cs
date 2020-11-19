namespace EmeraldBotany.Data.Models
{
    public class Family
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Common_name { get; set; }

        public string Slug { get; set; }

        public Division_order Division_order { get; set; }

        public Links6 Links { get; set; } = new Links6();

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}
