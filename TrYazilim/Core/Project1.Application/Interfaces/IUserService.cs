using Project1.Application.Dtos.LoginRegisterDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application.Interfaces
{
    public interface IUserService
    {
        Task<bool> LoginAsync(LoginDto request);
        Task<bool> RegisterAsync(RegisterDto request);
    }
}
