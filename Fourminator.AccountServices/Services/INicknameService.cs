using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fourminator.AccountServices.Services
{
    public interface INicknameService
    {
        bool CheckNickname(string nickname);
    }
}
