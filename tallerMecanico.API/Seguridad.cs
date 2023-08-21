using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using tallerMecanico.LogicaNegocio.Entidades;

namespace tallerMecanico.API
{
    public static class Seguridad
    {

        //crea el password hash y salt
        public static void CrearPasswordHash(string password,out byte[] passwordHash,out byte[]passwordSalt)
        {
            using(var hmac=new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash=hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

        }

        //valida el password
        public static bool VerificarPasswordHash(string password, byte[]passwordHash, byte[]passwordSalt)
        {
        
            using(var hmac=new HMACSHA512(passwordSalt))
            {
                var passwordHasCalculado = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return passwordHasCalculado.SequenceEqual(passwordHash);
            }

        }

        internal static string CrearToken(User usuario,IConfiguration config)
        {
            //claims
            List<Claim> claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Email,usuario.Email),
                new Claim(ClaimTypes.Role,usuario.Rol),

            };
            //genero clave secreta 
            var clave = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(config.GetSection("JWT:key").Value!));
            //genero credenciales
            var credenciales = new SigningCredentials(clave, SecurityAlgorithms.HmacSha512Signature);
            //creo el token
            var token=new JwtSecurityToken(claims:claims,expires:DateTime.Now.AddDays(1),signingCredentials:credenciales);
            var jwt=new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;



        }

    }
}
