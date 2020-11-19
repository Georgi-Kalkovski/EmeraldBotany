namespace EmeraldBotany.Data.Models
{
    public partial class Meta
    {
        public class Native
        {
            public int Id { get; set; }

            public string Name { get; set; }

            public string Slug { get; set; }

            public string Tdwg_code { get; set; }

            public int Tdwg_level { get; set; }

            public int Species_count { get; set; }

            public Links30 Links { get; set; }

            private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

            public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
            {
                get { return _additionalProperties; }
                set { _additionalProperties = value; }
            }
        }
    }
}