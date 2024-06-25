using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using MiniDriveApi.Data;
using MiniDriveApi.Models;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly string Key;
    private readonly string Issuer;
    private readonly string Audience;
    private readonly IConfiguration _configuration;
    private readonly BaseContext _context;

    public AuthController(IConfiguration configuration, BaseContext context)
    {
        _context = context;
        Key = configuration["Jwt:Key"];
        Issuer = configuration["Jwt:Issuer"];
        Audience = configuration["Jwt:Audience"];
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] Usuario login)
    {
        var user = await _context.Usuarios.SingleOrDefaultAsync(u => u.Correo == login.Correo && u.Contrasena == login.Contrasena);

        if (user != null)
        {
            var token = GenerateJwtToken(user.Correo);
            return Ok(new { token });
        }

        return Unauthorized();
    }

    private string GenerateJwtToken(string username)
    {
        
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        var claims = new[]
        {
            new Claim(JwtRegisteredClaimNames.Sub, username),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

        var token = new JwtSecurityToken(
            issuer: Issuer,
            audience: Audience,
            claims: claims,
            expires: DateTime.UtcNow.AddHours(1),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
