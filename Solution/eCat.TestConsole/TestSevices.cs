namespace eCat.TestConsole
{
    #region Using

    using System.Net.Http;
    using System;
    using System.Threading.Tasks;
    using System.Configuration;
    using Models;
    using System.Net.Http.Headers;
    using Newtonsoft.Json;

    #endregion

    public class TestSevices
    {
        static HttpClient _client = new HttpClient();
        static string _route = ConfigurationManager.AppSettings["ROUTE_SERVICE"];
        static string _token = string.Empty;

        public static async Task Test_echoping()
        {
            Console.WriteLine("");
            Console.WriteLine("Call echoping ...");

            var response = await _client.GetAsync($"{_route}login/echoping");
            if (response.IsSuccessStatusCode)
            {
                var echoping = await response.Content.ReadAsStringAsync();
                Console.WriteLine(echoping);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public static async Task Test_echouser()
        {
            Console.WriteLine("");
            Console.WriteLine("Call echouser ...");

            var response = await _client.GetAsync($"{_route}login/echouser");
            if (response.IsSuccessStatusCode)
            {
                var echouser = await response.Content.ReadAsStringAsync();
                Console.WriteLine(echouser);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public static async Task Test_authenticate()
        {
            Console.WriteLine("");
            Console.WriteLine("Call authenticate ...");

            var response = await _client.PostAsJsonAsync($"{_route}login/authenticate", new LoginRequest { Username = "adminecat", Password = "ecatadm1n" });
            if (response.IsSuccessStatusCode)
            {
                _token = await response.Content.ReadAsStringAsync();
                Console.WriteLine(_token);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public static async Task Test_FichasBaseGet_old(string id)
        {
            Console.WriteLine("");
            Console.WriteLine($"Call FichasBaseGet({id}) ...");

            if (string.IsNullOrEmpty(_token))
            {
                var authenticate = await _client.PostAsJsonAsync($"{_route}login/authenticate", new LoginRequest { Username = "adminecat", Password = "ecatadm1n" });
                if (authenticate.IsSuccessStatusCode)
                {
                    var stringResult = await authenticate.Content.ReadAsStringAsync();
                    _token = JsonConvert.DeserializeObject<string>(stringResult);

                    _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                    var response = await _client.GetAsync($"{_route}fichasbase/{id}");
                    if (response.IsSuccessStatusCode)
                    {
                        var fichasBase = await response.Content.ReadAsStringAsync();
                        Console.WriteLine(fichasBase);
                    }
                    else
                    {
                        Console.WriteLine($"Error FichasBaseGet -> {response.StatusCode}");
                    }
                }
                else
                {
                    Console.WriteLine($"Error authenticate -> {authenticate.StatusCode}");
                }
            }
            else
            {
                _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _token);
                var response = await _client.GetAsync($"{_route}fichasbase/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var fichasBase = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(fichasBase);
                }
                else
                {
                    Console.WriteLine($"Error FichasBaseGet -> {response.RequestMessage}");
                }
            }
        }

        public static async Task Test_FichasBaseGet(string id)
        {
            Console.WriteLine("");
            Console.WriteLine($"Call FichasBaseGet({id}) ...");

            if (await GetToken())
            {
                var response = await _client.GetAsync($"{_route}fichasbase/{id}");
                if (response.IsSuccessStatusCode)
                {
                    var fichasBase = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(fichasBase);
                }
                else
                {
                    Console.WriteLine($"Error FichasBaseGet -> {response.StatusCode}");
                }
            }
        }

        private static async Task<bool> GetToken()
        {
            if (string.IsNullOrEmpty(_token))
            {
                var authenticate = await _client.PostAsJsonAsync($"{_route}login/authenticate", new LoginRequest { Username = "adminecat", Password = "ecatadm1n" });
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
    }
}
