namespace WebApplication1.Models.JWT
{
    public interface IJWT
    {
        string Authenticate(string username, string password);
    }
}
