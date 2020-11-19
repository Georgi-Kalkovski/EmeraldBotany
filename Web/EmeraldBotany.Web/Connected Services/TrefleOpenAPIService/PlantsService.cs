using EmeraldBotany.Data.Common.Repositories;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace EmeraldBotany.Web.TrefleOpenAPIService
{
    public class PlantsService : IPlantsService
    {
        private string baseUrl = "https://trefle.io/api/v1/";
        private string token = "miGGGGWVGX1rIi3fuqaM8-rscHaiP8WzgwjK89LsmHs";

        public async Task<List<Species>> GetPlantsAsync()
        {
            try
            {
                List<Species> jsonObject = new List<Species>();

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(this.baseUrl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage res = await client.GetAsync($"plants?token={this.token}");
                    if (res.IsSuccessStatusCode)
                    {
                        var response = res.Content.ReadAsStringAsync().Result;
                        jsonObject = JsonConvert.DeserializeObject<List<Species>>(response);
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
