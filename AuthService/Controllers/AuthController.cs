using AuthService.DTO;
using AuthService.Entities;
using AuthService.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController (AuthDbContext _context) : ControllerBase
    {
        [HttpPost("Login")]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.email == username && u.password == password);
            if (user == null)
            {
                return Unauthorized();
            }
            // Generate JWT token here (omitted for brevity)
            var token = GenerateJwtToken(user);
            return Ok(new { Token = token });
        }
        private string GenerateJwtToken(User user)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.id.ToString()),
                new Claim(ClaimTypes.Email, user.email),
                new Claim(ClaimTypes.Name, user.name)
            };


            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("e652a7190c582a43ca5f37b10363321d8d741edb433cf2e283765ce5e1c17830"));


            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


            var token = new JwtSecurityToken(
                issuer: "rajat_issuer",
                audience: "rajat_audience",
                claims: claims,
                expires: DateTime.Now.AddHours(1),
                signingCredentials: creds

                );

            return new JwtSecurityTokenHandler().WriteToken(token);

        }
        [HttpPost("Register")]
        public IActionResult Register(RegisterDTO request)
        {
            if (_context.Users.Any(u => u.email == request.Email))
            {
                return BadRequest("Email already exists.");
            }
            var user = new User
            {
                name = request.Name,
                email = request.Email,
                password = request.Password
            };
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok("User registered successfully.");
        }


    }
}
