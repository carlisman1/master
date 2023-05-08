using Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Helpers;
using Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Models;
using Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Api_SEGUNDO_EXAMEN_PRACTICO_AZURE_JCMG.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private HelperOAuthToken authToken;
        private RepositoryCubos repository;

        public AuthController(RepositoryCubos repository, HelperOAuthToken authToken)
        {
            this.repository = repository;
            this.authToken = authToken;
        }

        [HttpPost("[action]")]
        public async Task<ActionResult> Login(LoginModel loginModel)
        {
            UsuarioCubos? usu = await this.repository.GetUsuarioAsync(loginModel.Email, loginModel.Pass);

            if (usu == null)
            {
                return Unauthorized();
            }

            SigningCredentials credentials = new(this.authToken.GetKeyToken(), SecurityAlgorithms.HmacSha512);

            string jsonUsu = JsonConvert.SerializeObject(usu);
            Claim[] informacion = new[]
            {
                new Claim("UserData", jsonUsu)
            };

            JwtSecurityToken token = new(
                            claims: informacion,
                            issuer: this.authToken.Issuer,
                            audience: this.authToken.Audience,
                            signingCredentials: credentials,
                            expires: DateTime.UtcNow.AddMinutes(30),
                            notBefore: DateTime.UtcNow);
            return Ok(new
            {
                response = new JwtSecurityTokenHandler().WriteToken(token),
            });
        }
    }
}
