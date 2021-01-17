using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace backendAPI.Models
{
    public class UserService
    {
        private static string Secret { get; set; } = "this is a simple key";

        public static AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = UserDBContext.get().SingleOrDefault(user => user.Email == model.Email && user.Password == model.Password);

            // return null if user not found
            if (user == null) return null;

            // authentication successful so generate jwt token
            var token = generateJwtToken(user);

            user.Token = token;

            return new AuthenticateResponse(user, token);
        }

       
        private static string generateJwtToken(User user)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(Secret);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new[] { new Claim("email", user.Email.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public static bool validateToken(string token)
        {
            /* validating expiration user token*/
            return true;
        }
    }
}