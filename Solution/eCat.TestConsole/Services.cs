namespace eCat.TestConsole
{
    #region Using

    using System.Configuration;
    using System.Net.Http;
    using System;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using Models;
    using Newtonsoft.Json;
    using Data.Parameters;

    #endregion

    public class Services
    {
        static HttpClient _client = new HttpClient();
        static string _route = ConfigurationManager.AppSettings["ROUTE_SERVICE"];
        static string _token = string.Empty;

        #region Pivate Methods 

        private static async Task<bool> GetToken()
        {
            if (string.IsNullOrEmpty(_token))
            {
                var authenticate = await _client.PostAsJsonAsync($"{_route}login/authenticate", new LoginRequest { Username = "admin", Password = "123456" });
                if (authenticate.IsSuccessStatusCode)
                {
                    var stringResult = await authenticate.Content.ReadAsStringAsync();
                    _token = JsonConvert.DeserializeObject<string>(stringResult);

                    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);

                    return true;
                }

                Console.WriteLine($"Error authenticate -> {authenticate.StatusCode}");

                return false;
            }

            return true;
        }

        #endregion

        public static async Task TCampanas_Get()
        {
            Console.WriteLine("");
            Console.WriteLine("TCampanas_Get ...");

            if (await GetToken())
            {
                var response = await _client.GetAsync($"{_route}campanas");
                if (response.IsSuccessStatusCode)
                {
                    var campanas = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(campanas);
                }
                else
                {
                    Console.WriteLine($"Error TCampanas_Get -> {response.StatusCode}");
                }
            }
        }

        public static async Task pa_Get_T_Campañas(DataCampana dataCampana)
        {
            Console.WriteLine("");
            Console.WriteLine("pa_Get_T_Campañas ...");

            if (await GetToken())
            {                
                var url = $"{_route}campanas/paCampanas/?{dataCampana.ToUri()}";
                var response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var campanas = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(campanas);
                }
                else
                {
                    Console.WriteLine($"Error pa_Get_T_Campañas -> {response.StatusCode}");
                }
            }
        }

        public static async Task pa_InsertFichasBase(DataFichasBase dataFichaBase)
        {
            Console.WriteLine("");
            Console.WriteLine("pa_InsertFichasBase ...");

            if (await GetToken())
            {
                var url = $"{_route}fichasbase/pa_InsertFichasBase/?{dataFichaBase.ToUri()}";
                var response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var code = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"pa_InsertFichasBase [code] -> {code}");
                }
                else
                {
                    Console.WriteLine($"Error pa_InsertFichasBase -> {response.StatusCode}");
                }
            }
        }
    }
}
