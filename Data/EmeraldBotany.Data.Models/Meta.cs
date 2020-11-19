using System;
using System.Collections.Generic;
using System.Text;

namespace EmeraldBotany.Data.Models
{
    public partial class Meta
    {


        public enum Color
        {
            White = 0,
            Red = 1,
            Brown = 2,
            Orange = 3,
            Yellow = 4,
            Lime = 5,
            Green = 6,
            Cyan = 7,
            Blue = 8,
            Purple = 9,
            Magenta = 10,
            Grey = 11,
            Black = 12,
        }

        public enum FoliageTexture
        {
            Fine = 0,
            Medium = 1,
            Coarse = 2,
        }

        public enum Color2
        {
            White = 0,
            Red = 1,
            Brown = 2,
            Orange = 3,
            Yellow = 4,
            Lime = 5,
            Green = 6,
            Cyan = 7,
            Blue = 8,
            Purple = 9,
            Magenta = 10,
            Grey = 11,
            Black = 12,
        }

        public enum Color3
        {
            White = 0,
            Red = 1,
            Brown = 2,
            Orange = 3,
            Yellow = 4,
            Lime = 5,
            Green = 6,
            Cyan = 7,
            Blue = 8,
            Purple = 9,
            Magenta = 10,
            Grey = 11,
            Black = 12,
        }

        public enum SpecificationsLigneous_type
        {
            Liana = 0,
            Subshrub = 1,
            Shrub = 2,
            Tree = 3,
            Parasite = 4,
        }

        public enum SpecificationsToxicity
        {
            None = 0,
            Low = 1,
            Medium = 2,
            High = 3,
        }

        public enum Growth_months
        {
            Jan = 0,
            Feb = 1,
            Mar = 2,
            Apr = 3,
            May = 4,
            Jun = 5,
            Jul = 6,
            Aug = 7,
            Sep = 8,
            Oct = 9,
            Nov = 10,
            Dec = 11,
        }

        public enum Bloom_months
        {
            Jan = 0,
            Feb = 1,
            Mar = 2,
            Apr = 3,
            May = 4,
            Jun = 5,
            Jul = 6,
            Aug = 7,
            Sep = 8,
            Oct = 9,
            Nov = 10,
            Dec = 11,
        }

        public enum Fruit_months
        {
            Jan = 0,
            Feb = 1,
            Mar = 2,
            Apr = 3,
            May = 4,
            Jun = 5,
            Jul = 6,
            Aug = 7,
            Sep = 8,
            Oct = 9,
            Nov = 10,
            Dec = 11,
        }



        public enum Correction2Rank
        {
            Species = 0,
            Ssp = 1,
            Var = 2,
            Form = 3,
            Hybrid = 4,
            Subvar = 5,
        }

        public enum Correction2Foliage_texture
        {
            Fine = 0,
            Medium = 1,
            Coarse = 2,
        }
    }
}