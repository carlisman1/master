namespace AppTorneos.Models
{
    [Serializable]
    public class User
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Nombre { get; set; }
    }
}
