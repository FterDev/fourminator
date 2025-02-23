namespace Fourminator.AccountServices.Persistence
{
    public interface INicknameRepository
    {
        Task<string?> GetNickname(string nickname);
    }
}
