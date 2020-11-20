﻿namespace EmeraldBotany.Data.Models
{
    using EmeraldBotany.Data.Common.Models;

    public class Sources : BaseDeletableModel<int>
    {
        public string Name { get; set; }

        public string Citation { get; set; }

        public string Url { get; set; }

        public string LastUpdate { get; set; }
    }
}
