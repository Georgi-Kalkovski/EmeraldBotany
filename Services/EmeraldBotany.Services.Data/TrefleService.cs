namespace EmeraldBotany.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    using EmeraldBotany.Data.Models;
    using Newtonsoft.Json;

    public class TrefleService : ITrefleService
    {
        private readonly string baseUrl = "https://trefle.io/api/v1/";
        private readonly string token = "miGGGGWVGX1rIi3fuqaM8-rscHaiP8WzgwjK89LsmHs";

        public async Task<ICollection<Species>> GetPlantsAsync()
        {
            try
            {
                ICollection<Species> jsonObject = new HashSet<Species>();

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(this.baseUrl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage res = await client.GetAsync($"plants?token={this.token}");
                    if (res.IsSuccessStatusCode)
                    {
                        var response = res.Content.ReadAsStringAsync().Result;
                        var value = JsonConvert.DeserializeObject<Trefle>(response);
                        jsonObject = value.Data;
                    }
                }

                return jsonObject;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
