namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class MinimumPrecipitation : BaseDeletableModel<int>
    {
        public double? Mm { get; set; }
    }
}
