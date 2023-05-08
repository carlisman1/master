using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MvcLogicApp.Services
{
    public class ServiceLogicApps
    {
        private MediaTypeWithQualityHeaderValue Header;

        public ServiceLogicApps()
        {
            this.Header =
                new MediaTypeWithQualityHeaderValue("application/json");
        }

        public async Task SendMailAsync
            (string email, string asunto, string mensaje)
        {
            string urlEmail = "https://prod-10.westeurope.logic.azure.com:443/workflows/b90633bb5ecb41ca94d3c9309c21a590/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=sBb5jbA8m9gWJcdIZpIZUfy-nlBovNc7FkfbtqVPX6Q";
            var model = new
            {
                email = email,
                asunto = asunto,
                mensaje = mensaje
            };

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                string json = JsonConvert.SerializeObject(model);
                StringContent content =
                    new StringContent(json, Encoding.UTF8, "application/json");
                await client.PostAsync(urlEmail, content);
            }
        }
    }
}
