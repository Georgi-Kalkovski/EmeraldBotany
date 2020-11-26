namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class MaximumPrecipitation : BaseDeletableModel<int>
    {
        public double? Mm { get; set; }
    }
}
