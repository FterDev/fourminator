using Fourminator.AccountServices.Persistence;

namespace Fourminator.AccountServices.Services
{
    internal class NicknameService : INicknameService
    {
        private readonly INicknameRepository _nicknameRepository;
        public NicknameService(INicknameRepository nicknameRepository) {
            _nicknameRepository = nicknameRepository;
        }
        public async Task<bool> CheckNicknameExists(string nickname)
        {
            var result = await _nicknameRepository.GetNickname(nickname);
            return !string.IsNullOrEmpty(result);
        }
    }
}
