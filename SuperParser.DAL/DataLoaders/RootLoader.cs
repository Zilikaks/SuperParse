using SuperParser.DAL.Entities;
using SuperParser.DAL.Interfaces;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace SuperParser.DAL.DataLoaders
{
    public class RootLoader : ILoader<Root>
    {
        private static HttpClient _httpClient;

        static RootLoader()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _httpClient.DefaultRequestHeaders.Add("User-Agent", "Deda/1.0 (mobvac2020@gmail.com)");
        }

        public async Task<Root> GetResponseAsync(string url)
        {
            using (var httpResponse = await _httpClient.GetAsync(url).ConfigureAwait(false))
            {
                if (!httpResponse.IsSuccessStatusCode)
                    throw new Exception(httpResponse.ReasonPhrase);

                return await httpResponse.Content.ReadAsAsync<Root>().ConfigureAwait(false);
            }
        }

        public async Task<Vacancy> GetVacancyAsync(string url)
        {
            using (var httpResponse = await _httpClient.GetAsync(url).ConfigureAwait(false))
            {
                if (!httpResponse.IsSuccessStatusCode)
                    throw new Exception(httpResponse.ReasonPhrase);

                return await httpResponse.Content.ReadAsAsync<Vacancy>().ConfigureAwait(false);
            }
        }
    }
}
