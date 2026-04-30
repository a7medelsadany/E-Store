using Shared.DTOS.IdentityDtos;

namespace ServicesAbstractions
{
    public interface IAuthenticationService
    {
        Task<UserDto> LoginAsync(LoginDto loginDto);
        Task<UserDto> RegisterAsync(RegisterDto registerDto);

    }
}
