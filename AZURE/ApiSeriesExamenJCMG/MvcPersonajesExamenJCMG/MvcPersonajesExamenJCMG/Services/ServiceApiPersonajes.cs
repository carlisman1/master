using MvcPersonajesExamenJCMG.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MvcPersonajesExamenJCMG.Services
{
    public class ServiceApiPersonajes
    {
        private MediaTypeWithQualityHeaderValue Header;
        private string UrlApi;

        public ServiceApiPersonajes(IConfiguration configuration)
        {
            this.Header =
                new MediaTypeWithQualityHeaderValue("application/json");
            this.UrlApi = configuration.GetValue<string>
                ("ApiUrls:ApiSeriesExamen");
        }

        private async Task<T> CallApiAsync<T>(string request)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(this.UrlApi);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                HttpResponseMessage response =
                    await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    T data = await response.Content.ReadAsAsync<T>();
                    return data;
                }
                else
                {
                    return default(T);
                }
            }
        }

        public async Task<List<Personaje>> GetPersonajeAsync()
        {
            string request = "/api/personajes";
            List<Personaje> per =
                await this.CallApiAsync<List<Personaje>>(request);
            return per;
        }

        public async Task<Personaje> FindPersonajeAsync(int idpersonaje)
        {
            string request = "/api/personajes/" + idpersonaje;
            Personaje per =
                await this.CallApiAsync<Personaje>(request);
            return per;
        }

        public async Task DeletePersonajeAsync(int idpersonaje)
        {
            using (HttpClient client = new HttpClient())
            {
                string request = "/api/personajes/" + idpersonaje;
                client.BaseAddress = new Uri(this.UrlApi);
                client.DefaultRequestHeaders.Clear();
                //NO NECESITA EL HEADER PORQUE NO DEVUELVE NADA
                HttpResponseMessage response =
                    await client.DeleteAsync(request);
                //SI DESEAMOS PERSONALIZAR LA EXPERIENCIA DEVOLVIENDO
                //ALGUN VALOR PARA LA PETICION
                //return response.StatusCode;
            }
        }

        public async Task InsertPersonajeAsync(int idpersonaje, string npersonaje, string imagen, int idserie)
        {
            using (HttpClient client = new HttpClient())
            {
                string request = "/api/personajes";
                client.BaseAddress = new Uri(this.UrlApi);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                //TENEMOS QUE ENVIAR UN OBJETO JSON
                //NOS CREAMOS UN OBJETO DE LA CLASE DEPARTAMENTO
                Personaje per = new Personaje();
                per.IdPersonaje = idpersonaje;
                per.NPersonaje = npersonaje;
                per.Imagen = imagen;
                per.IdSerie = idserie;
                //CONVERTIMOS EL OBJETO A JSON
                string json = JsonConvert.SerializeObject(per);
                //PARA ENVIAR DATOS (data) AL SERVICIO SE UTILIZA
                //LA CLASE StringContent, DONDE DEBEMOS INDICAR
                //LOS DATOS, SU ENCODING Y SU TIPO
                StringContent content =
                    new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response =
                    await client.PostAsync(request, content);
            }
        }

        public async Task UpdatePersonajeAsync(int idpersonaje, string npersonaje, string imagen, int idserie)
        {
            using (HttpClient client = new HttpClient())
            {
                string request = "/api/personajes";
                client.BaseAddress = new Uri(this.UrlApi);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                Personaje per =
                    new Personaje
                    {
                        IdPersonaje = idpersonaje,
                        NPersonaje = npersonaje,
                        Imagen = imagen,
                        IdSerie = idserie
                    };
                string json = JsonConvert.SerializeObject(per);
                StringContent content = new StringContent
                    (json, Encoding.UTF8, "application/json");
                await client.PutAsync(request, content);
            }
        }
    }
}
