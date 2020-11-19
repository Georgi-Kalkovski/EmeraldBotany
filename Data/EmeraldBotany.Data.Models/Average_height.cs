namespace EmeraldBotany.Data.Models
{
    public partial class Meta
    {
        public class Average_height
        {
            public int? Cm { get; set; }

            private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

            public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
            {
                get { return _additionalProperties; }
                set { _additionalProperties = value; }
            }
        }
    }
}