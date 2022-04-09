using JWT;
using JWT.Algorithms;
using JWT.Builder;
using JWT.Serializers;
using Newtonsoft.Json;
using System.Text;

namespace JwtTest
{
    public class JwtTest {

        public static void Main (string [] args)
        {
            Class1<TestDto> class1 = new Class1<TestDto>();
            string json = "{\"Id\":\"B4908C47 - EB81 - 4DB0 - B7C7 - 1D6A9CAECD52\",\"Name\":\"D6003819-8B23-4BA4-B246-8CFA5C8B8C20\",\"Date\":\"2022-01-08T00:00:00.0\"}";
            

            var objetoDataCore = new TestDto()
            {
                Id = Guid.NewGuid(),
                Name = "John Doe",
                Date = DateTime.Now,
            };

            var jsonstring = objetoDataCore;
            //Así llega del Data.Core
            Console.WriteLine(jsonstring);
            string token = class1.Encode(json);

            Console.WriteLine(class1.Decode(token));

            //Console.WriteLine(class1.Decode(token));
        }

        /*public static void Main (string [] args)
        {
            //TestEntitie testEntitie = new TestEntitie();
            TestDto testDto = new TestDto();

            List<TestDto> list = new List<TestDto>();
            testDto.Id = Guid.NewGuid();
            testDto.Name = "Juan";
            testDto.Date = DateTime.Now;
            testDto.Edad = 23;
            list.Add(testDto);

            testDto.Id = Guid.NewGuid();
            testDto.Name = "Pedro";
            testDto.Date = DateTime.Now;
            testDto.Edad = 22;

            list.Add(testDto);

            Console.WriteLine(list.Count);

            var payload = new Dictionary<string, object>
            {
                {
                    "Texto1", 0
                },
                {
                    "Texto2", "Valor Texto 211"
                }
            };

            string texto = "Hola";

            const string key = "claveSecreta";

            var llave = new JwtBase64UrlEncoder().Encode(new JwtBase64UrlEncoder().Decode(key));
            Console.WriteLine(llave);

            const string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJUZXh0bzEiOjAsIlRleHRvMiI6IlZhbG9yIFRleHRvIDIifQ.Tqv5S9k6T47OhotBwFa3aFkaFdfVQx6tl60qdkjM184";

            Console.WriteLine (Encode(texto, key));
            Console.WriteLine ("\n"+Decode(token, key));
        }

        //string v = ""

        public static string Encode (string t, string key)
        {
            /*IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            IJsonSerializer serializer = new JsonNetSerializer();
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();*/
            /*IJwtEncoder encoder = new JwtEncoder(
                                  new HMACSHA256Algorithm(), 
                                  new JsonNetSerializer(), 
                                  new JwtBase64UrlEncoder());*/

            /*var token = new JwtEncoder(
                        new HMACSHA256Algorithm(),
                        new JsonNetSerializer(),
                        new JwtBase64UrlEncoder())
                        .Encode(t, key);*/

            //var token = encoder.Encode(testDto, key);

            /*var token = JwtBuilder.Create()
                                  .WithAlgorithm(new HMACSHA256Algorithm())
                                  .WithSecret(key)
                                  .AddClaim(String.Empty, testDto)
                                  .Encode();*/
         //   return token;
        //}

        /*public static string Decode (string token, string key)
        {
            try
            {
                IJsonSerializer serializer = new JsonNetSerializer();
                IDateTimeProvider dateTimeProvider = new UtcDateTimeProvider();
                IJwtValidator validator = new JwtValidator(serializer, dateTimeProvider);
                IBase64UrlEncoder encoder = new JwtBase64UrlEncoder();
                IJwtAlgorithm algoritmo = new HMACSHA256Algorithm();
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, encoder, algoritmo);

                var json = decoder.Decode(token, key, verify: true);

                var json = JwtBuilder.Create()
                     .WithAlgorithm(new HMACSHA256Algorithm())
                     .WithSecret(key)
                     .MustVerifySignature()
                     .Decode(token);

                return json;

            }catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }*/

        /*public string Encode(TestDto obj)
        {
            var token = new JwtEncoder(
                        new HMACSHA256Algorithm(),
                        new JsonNetSerializer(),
                        new JwtBase64UrlEncoder())
                        .Encode(obj, "key");

            return token;
        }*/

        /*public TestDto Decode(string token)
        {
            TestDto json = JwtBuilder.Create()
                     .WithAlgorithm(new HMACSHA256Algorithm())
                     .WithSecret("key")
                     .MustVerifySignature()
                     .Decode<TestDto>(token);

            return json;
        }*/
    }
}