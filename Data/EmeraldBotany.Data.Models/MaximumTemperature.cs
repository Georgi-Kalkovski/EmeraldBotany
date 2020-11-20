namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class MaximumTemperature : BaseDeletableModel<int>
    {
        public double? DegF { get; set; }

        public double? DegC { get; set; }
    }
}
