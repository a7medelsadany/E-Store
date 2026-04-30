using Domain.Entities.IdentityModule;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ServicesAbstractions;
using Shared.DTOS.IdentityDtos;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Services
{
    public class AuthenticationService(UserManager<ApplicationUser> userManager, IConfiguration configuration) : IAuthenticationService
    {
        public async Task<UserDto> LoginAsync(LoginDto loginDto)
        {
            var Result = await userManager.FindByEmailAsync(loginDto.Email);
            if (Result is null)
            {
                throw new Exception($"user not found {loginDto.Email}");
            }
            var IsPasswordValid = await userManager.CheckPasswordAsync(Result, loginDto.Password);
            if (IsPasswordValid)
            {
                return new UserDto
                {
                    Email = Result.Email,
                    DisplayName = Result.FirstName + " " + Result.LastName,
                    Token = await GenerateJwtToken(Result)
                };
            }
            else
            {
                throw new UnauthorizedAccessException("Invalid Email or Password");
            }
        }

        public async Task<UserDto> RegisterAsync(RegisterDto registerDto)
        {
            //mapping the registerDto to ApplicationUser
            var user = new ApplicationUser()
            {
                Email = registerDto.Email,
                UserName = registerDto.UserName,
                FirstName = registerDto.DisplayName.Split(" ")[0],
                LastName = registerDto.DisplayName.Split(" ")[1],
                PhoneNumber = registerDto.PhoneNumber
            };

            var Result = await userManager.CreateAsync(user, registerDto.Password);
            if (Result.Succeeded)
            {
                return new UserDto
                {
                    Email = user.Email,
                    DisplayName = user.FirstName + " " + user.LastName,
                    Token = await GenerateJwtToken(user)
                };
            }
            else
            {
                var errors = Result.Errors.Select(E => E.Description).ToList();
                throw new Exception($"User registration failed: {errors}");
            }
        }

        private async Task<string> GenerateJwtToken(ApplicationUser user)
        {
            var Claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email,user.Email!),
                new Claim(ClaimTypes.NameIdentifier,user.Id),
                new Claim(ClaimTypes.Name,user.UserName!)
            };
            var Roles=await userManager.GetRolesAsync(user);

            foreach (var role in Roles)
            {
                Claims.Add(new Claim(ClaimTypes.Role, role));
            }
            //Create Secret Key
            var SecKey = configuration.GetSection("JWTOptions")["SecretKey"];
            var Key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecKey!));
            var creds=new SigningCredentials(Key, SecurityAlgorithms.HmacSha256);


            //create token
            var Token=new JwtSecurityToken(
                issuer: configuration.GetSection("JWTOptions")["Issuer"],
                audience: configuration.GetSection("JWTOptions")["Audience"],
                claims: Claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds
                );

            return new JwtSecurityTokenHandler().WriteToken(Token);
        }
    }
}
