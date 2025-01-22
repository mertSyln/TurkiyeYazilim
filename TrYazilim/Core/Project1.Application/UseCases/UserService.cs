using Project1.Application.Dtos.LoginRegisterDtos;
using Project1.Application.Interfaces;
using Project1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Application.UseCases
{
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> LoginAsync(LoginDto request)
        {
            var user = await _userRepository.FindAllAsync(u => u.Email == request.Email && u.Password == request.Password);
            return user != null;
        }

        public async Task<bool> RegisterAsync(RegisterDto request)
        {
            var user = new User
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                CompanyName = request.CompanyName,
                CompanyWeb = request.CompanyWeb,
                CompanyFile = request.CompanyFile,
                CompanyAddress = request.CompanyAddress,
                TaxNumber = request.TaxNumber,
            };
            await _userRepository.AddAsync(user);
            return true;
        }
    }
}
