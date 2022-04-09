using JWT;
using JWT.Algorithms;
using JWT.Builder;
using JWT.Serializers;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JwtTest
{
    public class Class1<T> : IEncoding <T> where T : class
    {
        public string Decode(string value)
        {
            var json = JwtBuilder.Create()
                     .WithAlgorithm(new HMACSHA256Algorithm())
                     .WithSecret("jeje")
                     .MustVerifySignature()
                     .Decode(value);
            return json;
        }

        public string Decode(string value, string key1)
        {
            string secret = "this is a string used for encrypt and decrypt token";
            var key = Encoding.ASCII.GetBytes(key1);
            var handler = new JwtSecurityTokenHandler();
            var validations = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };
            var claims = handler.ValidateToken(value, validations, out var tokenSecure);
            return claims.ToString();
        }

        public T Decode1(string value)
        {
            var json = JwtBuilder.Create()
                     .WithAlgorithm(new HMACSHA256Algorithm())
                     .WithSecret("jeje")
                     .MustVerifySignature()
                     .Decode<T>(value);
            return json;
        }

        public string Encode(string _value)
        {
            var token = new JwtEncoder(
                        new HMACSHA256Algorithm(),
                        new JsonNetSerializer(),
                        new JwtBase64UrlEncoder())
                        .Encode(_value, Encoding.ASCII.GetBytes("jeje"));
            return token;
        }
    }
}
