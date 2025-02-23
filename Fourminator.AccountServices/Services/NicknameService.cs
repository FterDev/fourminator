using Fourminator.AccountServices.Persistence;
using Fourminator.Data.Exceptions;

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
            try
            {
                var result = await _nicknameRepository.GetNickname(nickname);
                return !string.IsNullOrEmpty(result);
            }
            catch (Exception ex)
            {
                throw new DbException("Error while checking nickname - " + ex.ToString());
            }
        }
    }
}
