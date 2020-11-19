﻿namespace EmeraldBotany.Data.Models
{
    public class Flower
    {
        public System.Collections.Generic.ICollection<Color?> Color { get; set; }

        public bool? Conspicuous { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}