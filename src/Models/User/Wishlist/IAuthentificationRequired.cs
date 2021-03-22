namespace Saison.Models
{
    public interface IAuthentificationRequired
    {
        string AccessToken { get; set; }
    }

    public abstract class AbstractAuthentificationRequired
    {
        public string AccessToken { get; set; }
    }
}