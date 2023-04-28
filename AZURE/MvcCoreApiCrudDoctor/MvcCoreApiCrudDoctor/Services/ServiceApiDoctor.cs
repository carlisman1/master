using MvcCoreApiCrudDoctor.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace MvcCoreApiCrudDoctor.Services
{
    public class ServiceApiDoctor
    {
        private MediaTypeWithQualityHeaderValue Header;
        private string UrlApi;

        public ServiceApiDoctor(IConfiguration configuration)
        {
            this.Header =
                new MediaTypeWithQualityHeaderValue("application/json");
            this.UrlApi = configuration.GetValue<string>
                ("ApiUrls:ApiCrudDoctores");
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

        public async Task<List<Doctor>> GetDoctoresAsync()
        {
            string request = "/api/doctores";
            List<Doctor> doc =
                await this.CallApiAsync<List<Doctor>>(request);
            return doc;
        }

        public async Task<Doctor> FindDoctorAsync(string iddoctor)
        {
            string request = "/api/doctores/" + iddoctor;
            Doctor doc =
                await this.CallApiAsync<Doctor>(request);
            return doc;
        }

        //LOS METODOS DE ACCION NO SUELEN SER GENERICOS,
        //YA QUE NORMALMENTE, CADA UNO RECIBE DISTINTOS PARAMETROS
        public async Task DeleteDoctorAsync(string iddoctor)
        {
            using (HttpClient client = new HttpClient())
            {
                string request = "/api/doctores/" + iddoctor;
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

        public async Task InsertDoctorAsync(string idhospital ,string iddoctor, string apellido
            , string especialidad, int salario)
        {
            using (HttpClient client = new HttpClient())
            {
                string request = "/api/doctores";
                client.BaseAddress = new Uri(this.UrlApi);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                //TENEMOS QUE ENVIAR UN OBJETO JSON
                //NOS CREAMOS UN OBJETO DE LA CLASE DEPARTAMENTO
                Doctor departamento = new Doctor();
                departamento.IdHospital = idhospital;
                departamento.IdDoctor = iddoctor;
                departamento.Apellido = apellido;
                departamento.Especialidad = especialidad;
                departamento.Salario = salario;
                //CONVERTIMOS EL OBJETO A JSON
                string json = JsonConvert.SerializeObject(departamento);
                //PARA ENVIAR DATOS (data) AL SERVICIO SE UTILIZA
                //LA CLASE StringContent, DONDE DEBEMOS INDICAR
                //LOS DATOS, SU ENCODING Y SU TIPO
                StringContent content =
                    new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response =
                    await client.PostAsync(request, content);
            }
        }

        public async Task UpdateDoctorAsync
            (string idhospital, string iddoctor, string apellido
            , string especialidad, int salario)
        {
            using (HttpClient client = new HttpClient())
            {
                string request = "/api/doctores";
                client.BaseAddress = new Uri(this.UrlApi);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                Doctor doc =
                    new Doctor
                    {
                        IdHospital = idhospital,
                        IdDoctor = iddoctor,
                        Apellido = apellido,
                        Especialidad = especialidad,
                        Salario = salario
                    };
                string json = JsonConvert.SerializeObject(doc);
                StringContent content = new StringContent
                    (json, Encoding.UTF8, "application/json");
                await client.PutAsync(request, content);
            }
        }
    }
}
