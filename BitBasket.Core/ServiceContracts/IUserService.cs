using BitBasket.Core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBasket.Core.ServiceContracts
{
    public interface IUserService
    {
        Task<AuthenticationResponse?> RegisterUser(RegisterRequest registerRequest);
        Task<AuthenticationResponse?> LoginUser(LoginRequest loginRequest);
    }
}
