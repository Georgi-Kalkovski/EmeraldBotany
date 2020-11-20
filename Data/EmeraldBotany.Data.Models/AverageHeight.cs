namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class AverageHeight : BaseDeletableModel<int>
    {
        public int? Cm { get; set; }
    }
}
