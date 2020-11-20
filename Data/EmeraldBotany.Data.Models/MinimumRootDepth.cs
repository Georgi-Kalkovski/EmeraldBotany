namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class MinimumRootDepth : BaseDeletableModel<int>
    {
        public double? Cm { get; set; }
    }
}
