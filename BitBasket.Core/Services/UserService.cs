using AutoMapper;
using BitBasket.Core.DTO;
using BitBasket.Core.Entities;
using BitBasket.Core.RepositoryContracts;
using BitBasket.Core.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBasket.Core.Services
{
    internal class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<AuthenticationResponse?> LoginUser(LoginRequest loginRequest)
        {
            var user = await _userRepository.GetUserByEmailAndPassword(loginRequest.Email, loginRequest.Password);
            if (user == null)
            {
                return null;
            }
            else
            {
                return _mapper.Map<ApplicationUser, AuthenticationResponse>(user) with { success = true, Token = "token"};
            }
        }

        public async Task<AuthenticationResponse> RegisterUser(RegisterRequest registerRequest)
        {
            var appUser = _mapper.Map<RegisterRequest, ApplicationUser>(registerRequest);

            var user = await _userRepository.AddUser(appUser);
            if (user == null)
            {
                return null;
            }
            else
            {
                return _mapper.Map<ApplicationUser, AuthenticationResponse>(user) with { success = true, Token = "token" };
            }
        }
    }
}
