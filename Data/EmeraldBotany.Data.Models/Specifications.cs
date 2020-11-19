namespace EmeraldBotany.Data.Models
{
    public class Specifications
    {
        public SpecificationsLigneous_type? Ligneous_type { get; set; }

        public string Growth_form { get; set; }

        public string Growth_habit { get; set; }

        public string Growth_rate { get; set; }

        public Average_height Average_height { get; set; }

        public Maximum_height Maximum_height { get; set; }

        public string Nitrogen_fixation { get; set; }

        public string Shape_and_orientation { get; set; }

        public SpecificationsToxicity? Toxicity { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();

        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    }
}