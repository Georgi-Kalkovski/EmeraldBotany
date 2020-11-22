namespace EmeraldBotany.Services.Data
{
    using System.Collections.Generic;

    public interface IExploresService
    {
        int GetCount();

        IEnumerable<T> GetAll<T>();
    }
}
