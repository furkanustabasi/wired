using Microsoft.Extensions.Configuration;
using System.Text;
using Wired.Data.Entities;
using Wired.Data.IRepository;
using Wired.Service.Abstract;
using Wired.Service.Helper;
using Wired.Service.Mapster;
using Wired.Service.Models;
using Wired.Service.Models.Request;
using Wired.Service.Models.Response;

namespace Wired.Service.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly IAuthRepository _authRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;

        public AuthService(IAuthRepository authRepository, IMapper mapper, IConfiguration configuration)
        {
            _authRepository = authRepository;
            _mapper = mapper;
            _configuration = configuration;
        }

        public LoginResponseModel Login(LoginRequestModel loginRequestModel)
        {
            var user = _authRepository.UserByEmail(loginRequestModel.Email);

            var verifyPassword = AuthHelper.VerifyPasswordHash(loginRequestModel.Password);

            if (user.Password.Equals(verifyPassword,System.StringComparison.OrdinalIgnoreCase))
            {
                return null;
            }

            var secretKey = Encoding.ASCII.GetBytes(_configuration.GetSection("Appsettings:Token").Value);

            var userDto = _mapper.Map<User, UserDto>(user);

            var token = AuthHelper.CreateToken(secretKey, userDto);

            return new LoginResponseModel
            {
                Token = token
            };
        }

        public int AddUser()
        {
            User user = new User
            {
                Email = "asd@asd",
                Password = "string",
                Name = "Fag"
            };
            var response = _authRepository.Add(user);
            return response;
        }

    }
}
