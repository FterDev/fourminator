

using Fourminator.AccountServices.Services;
using Fourminator.Data.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Fourminator.AccountServices.Controller
{
    [Route("api/[controller]")]
    class NicknameController : ControllerBase
    {
        private readonly INicknameService _nicknameService;
        public NicknameController(INicknameService nicknameService)
        {
            _nicknameService = nicknameService;
        }

        [HttpGet("{nickname}")]
        public IActionResult GetNicknameExists(string nickname)
        {
            if(string.IsNullOrEmpty(nickname))
            {
                return BadRequest("Nickname cannot be empty.");
            }
            try
            {
                return Ok(_nicknameService.CheckNicknameExists(nickname).Result);
            }
            catch (Exception ex)
            {
                if (ex is DbException) return StatusCode(500, ex.Message);
                  
                return StatusCode(500, "An error occurred while checking the nickname.");
            }
        }
    }
}
