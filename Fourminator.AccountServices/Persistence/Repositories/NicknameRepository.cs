using Fourminator.Data;

namespace Fourminator.AccountServices.Persistence
{
    internal class NicknameRepository : INicknameRepository
    {
        internal readonly FourminatorContext _context;

        public NicknameRepository(FourminatorContext context) {
            _context = context;
        }
        public string GetNickname(string nickname)
        {
            throw new NotImplementedException();
        }
    }
}
