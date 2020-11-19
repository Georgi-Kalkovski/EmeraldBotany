namespace EmeraldBotany.Data.Models
{
    public partial class Meta
    {
        public class Leaf
        {
            public int Id { get; set; }

            public string Image_url { get; set; }

            public string Copyright { get; set; }

            private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

            public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
            {
                get { return _additionalProperties; }
                set { _additionalProperties = value; }
            }
        }
    }
}