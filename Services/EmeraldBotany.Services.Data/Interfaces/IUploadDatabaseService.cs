namespace EmeraldBotany.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IUploadDatabaseService
    {
        Task PopulateDatabaseWithPlants();
    }
}
