namespace JwtTest
{
    public interface IEncoding <T> where T : class
    {
        string Encode (string value);

        T Decode1 (string value);
    }
}
