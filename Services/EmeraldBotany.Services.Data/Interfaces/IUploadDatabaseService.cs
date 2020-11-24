namespace EmeraldBotany.Services.Data
{
    using System.Collections.Generic;

    public interface IUploadDatabaseService
    {
        public List<string[]> PopulateDatabaseWithPlants();
    }
}
