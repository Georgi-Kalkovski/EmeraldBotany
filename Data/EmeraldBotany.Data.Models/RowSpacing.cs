namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class RowSpacing : BaseDeletableModel<int>
    {
        public double? Cm { get; set; }
    }
}
