namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class MaximumHeight : BaseDeletableModel<int>
    {
        public int? Cm { get; set; }
    }
}
