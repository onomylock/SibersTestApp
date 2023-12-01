namespace Application.Common.Interfaces
{
    public interface ITokenGeneratorService
    {
        string GenerateJwtToken((string userId, string userName, IList<string> roles) userDetails);
    }
}
