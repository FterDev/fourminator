using Fourminator.Data;
using Microsoft.EntityFrameworkCore;

namespace Fourminator.AccountServices.Persistence
{
    internal class NicknameRepository : INicknameRepository
    {
        internal readonly FourminatorContext _context;

        public NicknameRepository(FourminatorContext context) {
            _context = context;
        }
        public async Task<string?> GetNickname(string nickname)
        {
            var res = await _context.Users
                .Where(u => u.Nickname == nickname).Select(u => u.Nickname)
                .FirstOrDefaultAsync();
            return res;
        }
    }
}
