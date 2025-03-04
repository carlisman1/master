﻿using Mvc_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace Mvc_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Services
{
    public class ServiceCubos
    {
        private MediaTypeWithQualityHeaderValue Header;
        private string UrlApi;
        private IHttpClientFactory HttpClientFactory;

        public ServiceCubos(IConfiguration configuration, IHttpClientFactory httpClientFactory)
        {
            this.Header = new MediaTypeWithQualityHeaderValue("application/json");
            this.UrlApi = configuration.GetValue<string>("ApiUrl:ApiCubos");
            this.HttpClientFactory = httpClientFactory;
        }

        public async Task<string?> GetTokenAsync(string email, string pass)
        {
            using (HttpClient client = this.HttpClientFactory.CreateClient())
            {
                string request = "/api/auth/login";
                client.BaseAddress = new Uri(this.UrlApi);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);

                LoginModel model = new()
                {
                    Email = email,
                    Pass = pass
                };

                var response = await client.PostAsJsonAsync(request, model);
                var data = await response.Content.ReadAsStringAsync();
                return JObject.Parse(data).Value<string>("response");
            }
        }

        private async Task<T> CallApiAsync<T>(string request)
        {
            using (HttpClient client = this.HttpClientFactory.CreateClient())
            {
                client.BaseAddress = new Uri(this.UrlApi);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                HttpResponseMessage response = await client.GetAsync(request);
                if (response.IsSuccessStatusCode)
                {
                    T data = await response.Content.ReadAsAsync<T>();
                    return data;
                }
                else
                {
                    return default;
                }
            }
        }

        public async Task<T?> CallApiAsync<T>(string request, string token)
        {
            using (HttpClient client = this.HttpClientFactory.CreateClient())
            {
                client.BaseAddress = new Uri(this.UrlApi);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Add("Authorization", "bearer " + token);

                return await client.GetFromJsonAsync<T>(request);
            }
        }

        public async Task<List<Cubo>> GetCubosAsync()
        {
            string request = "api/Cubos";
            List<Cubo> cubos = await this.CallApiAsync<List<Cubo>>(request);
            return cubos;
        }

        public async Task<List<Cubo>> FindCubo(string marca)
        {
            string request = "/api/Cubos/" + marca;
            List<Cubo> cub = await this.CallApiAsync<List<Cubo>>(request);
            return cub;
        }

        public async Task<UsuarioCubos> PerfilUsuario()
        {
            string request = "/api/Cubos/GetUsuario";
            UsuarioCubos usu = await this.CallApiAsync<UsuarioCubos>(request);
            return usu;
        }

        public async Task InsertCubo(int idcubo, string nombre, string marca, string imagen, int precio)
        {
            using (HttpClient client = this.HttpClientFactory.CreateClient())
            {
                string request = "api/Cubos/InsertCubo";
                client.BaseAddress = new Uri(this.UrlApi);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                //tenemos que enviar un objeto JSON
                //nos creamos un objeto de la clase Hospital
                Cubo cub = new Cubo
                {
                    IdCubo = idcubo,
                    Nombre = nombre,
                    Marca = marca,
                    Imagen = imagen,
                    Precio = precio
                };
                //convertimos el objeto a json
                string json = JsonConvert.SerializeObject(cub);
                //para enviar datos al servicio se utiliza 
                //la clase SytringContent, donde debemos indicar
                //los datos, de ending  y su tipo
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(request, content);
            }
        }

        public async Task InsertUsuario(int idusuario, string nombre, string email, string pass, string imagen)
        {
            using (HttpClient client = this.HttpClientFactory.CreateClient())
            {
                string request = "api/Cubos/InsertUsuario";
                client.BaseAddress = new Uri(this.UrlApi);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                //tenemos que enviar un objeto JSON
                //nos creamos un objeto de la clase Hospital
                UsuarioCubos usu = new UsuarioCubos
                {
                    IdUsuario = idusuario,
                    Nombre = nombre,
                    Email = email,
                    Pass = pass,
                    Imagen = imagen
                };
                //convertimos el objeto a json
                string json = JsonConvert.SerializeObject(usu);
                //para enviar datos al servicio se utiliza 
                //la clase SytringContent, donde debemos indicar
                //los datos, de ending  y su tipo
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(request, content);
            }
        }
    }
}
