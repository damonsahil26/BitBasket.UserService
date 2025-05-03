using BitBasket.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitBasket.Core.DTO
{
    public record AuthenticationResponse(
        Guid UserId, 
        string? Email,
        string? Token,
        string? PersonName,
        string? Gender,
        bool success)
    {
        public AuthenticationResponse() : this(default, default, default, default, default, default) { }
    }
}
