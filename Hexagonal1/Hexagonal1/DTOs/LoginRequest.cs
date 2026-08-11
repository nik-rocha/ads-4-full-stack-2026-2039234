namespace Hexagonal1.DTOs
{
    public class LoginRequest
    {
        public string Id { get; set; }
        public string Senha { get; set; }
    }

    public class LoginResponse
    {
        public string Key { get; set; }
    }
}
