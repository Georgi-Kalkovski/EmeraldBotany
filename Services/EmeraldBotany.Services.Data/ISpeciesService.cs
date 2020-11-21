namespace EmeraldBotany.Services.Data
{
    using System.Collections.Generic;

    public interface ISpeciesService
    {
        int GetCount();

        IEnumerable<T> GetAll<T>();
    }
}
