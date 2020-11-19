namespace EmeraldBotany.Data.Models
{
    public class Foliage
    {
        public FoliageTexture? Texture { get; set; }

        public System.Collections.Generic.ICollection<Color2?> Color { get; set; }

        public bool? Leaf_retention { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}