using Plugin.Connectivity;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;


namespace AdminBanda.Servicios
{
    public class ApiRest
    {
        public const string SERVICE_ENDPOINT = "http://remotecoffee.azurewebsites.net/api/";

        public async Task<string> GetJsonAsync()
        {
            if (!CrossConnectivity.Current.IsConnected)
            {
                Debug.WriteLine("Sin conexion");
                return string.Empty;
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(SERVICE_ENDPOINT);
                //client.DefaultRequestHeaders.Add("", "");
                //client.DefaultRequestHeaders.Accept = ...

                var json = await client.GetStringAsync($"Employees?top={10}&pageSize={20}");

                Debug.WriteLine(json);

                return json;
            }
        }

        public async Task<bool> PostAsync(string json)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(SERVICE_ENDPOINT);

            var respuesta = await client.PostAsync("Employees",
                new StringContent(json, System.Text.Encoding.UTF8, "application/json"));

            return respuesta.StatusCode == HttpStatusCode.OK;
        }
    }
}
