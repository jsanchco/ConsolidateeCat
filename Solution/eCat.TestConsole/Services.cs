using System.IO;

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

        public static async Task InsertCampana(DataInsertTCampana dataInsertTCampana)
        {
            Console.WriteLine("");
            Console.WriteLine("InsertCampana ...");

            if (await GetToken())
            {
                var url = $"{_route}consolidateecat/insertcampana/?{dataInsertTCampana.ToUri()}";
                var response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var code = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"InsertCampana [code] -> {code}");
                }
                else
                {
                    Console.WriteLine($"InsertCampanas -> {response.StatusCode}");
                }
            }
        }

        public static async Task InsertFichasBase(DataFichasBase dataFichaBase)
        {
            Console.WriteLine("");
            Console.WriteLine("InsertFichasBase ...");

            if (await GetToken())
            {
                var url = $"{_route}consolidateecat/insertfichasbase/?{dataFichaBase.ToUri()}";
                var response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var code = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"InsertFichasBase [code] -> {code}");
                }
                else
                {
                    Console.WriteLine($"Error InsertFichasBase -> {response.StatusCode}");
                }
            }
        }

        public static async Task InsertFichasBase()
        {
            Console.WriteLine("Enter parameters ... [format example -> IdInterno=AR191707&Titulo=Biolog%c3%ada+Savia.+Los+seres+vivos%3a+unidad&IdLineaNegocio=25&Coeditorial=&Idioma=13&CodLinea_P=TXT&IdTipoMaterialSAP=6&CodigoGrupo=GR01&IdProyecto=185&IdProyectoAdicional=&IdProyectoGestion=166&IdCampana=23&IdUsoComercial=3&FechaComerializacion=2017-12-26&NecesidadInfo=&IdColeccion=&IdSerie=&ZGeografica=&UsuarioCreacion=PruebasIECISA&IdInternoOrigen=&IdInternoOrigenSAP=&IdPais=4&PorcentajeCoedicion=&TipoMaterialEducativo=1&JerarquiaProducto=090104009040007004]");
            Console.WriteLine("");
            Console.SetIn(new StreamReader(Console.OpenStandardInput(),
                Console.InputEncoding,
                false,
                1024));
            var parameters = Console.ReadLine();

            Console.WriteLine("");
            if (await GetToken())
            {
                var url = $"{_route}consolidateecat/insertfichasbase/?{parameters}";
                var response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var code = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"InsertFichasBase [code] -> {code}");
                }
                else
                {
                    Console.WriteLine($"Error InsertFichasBase -> {response.StatusCode}");
                }
            }
        }

        public static async Task GetLog()
        {
            Console.WriteLine("");
            Console.WriteLine("GetLog ...");

            if (await GetToken())
            {
                var url = $"{_route}consolidateecat/getlog";
                var response = await _client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var code = await response.Content.ReadAsStringAsync();
                    Console.WriteLine($"GetLog [code] -> {code}");
                }
                else
                {
                    Console.WriteLine($"Error GetLog -> {response.StatusCode}");
                }
            }
        }

    }
}
