using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServicesAbstractions;
using Shared.DTOS.IdentityDtos;
using System.Security.Claims;

namespace Presentation.Controller
{
    public class AuthenticationController(IServiceManager serviceManager) : APIBaseController
    {
        #region Register
        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register([FromBody] RegisterDto registerDto)
        {
            try
            {
                var result = await serviceManager.AuthenticationService.RegisterAsync(registerDto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Login
        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login([FromBody] LoginDto loginDto)
        {
            try
            {
                var Result = await serviceManager.AuthenticationService.LoginAsync(loginDto);
                return Ok(Result);
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region Get Current User
        [HttpGet("currentUser")]
        [Authorize]
        public async Task<ActionResult<UserDto>> GetCurrentUser()
        {
            try
            {
                var email = User.FindFirstValue(ClaimTypes.Email);
                var result = await serviceManager.AuthenticationService.GetCurrentUserAsync(email!);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        #endregion

        #region Get Roles
        [HttpGet("roles")]
        [Authorize]
        public async Task<ActionResult<IEnumerable<string>>> GetUserRoles()
        {
            try
            {
                var email = User.FindFirstValue(ClaimTypes.Email);
                var roles = await serviceManager.AuthenticationService.GetUserRolesAsync(email!);
                return Ok(roles);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        } 
        #endregion
    }
}
