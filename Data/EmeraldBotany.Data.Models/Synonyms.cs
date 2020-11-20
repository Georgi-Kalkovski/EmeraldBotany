namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class Synonyms : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Author { get; set; }
    }
}
