using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.JWT;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GuvenliController : ControllerBase
    {
        ProductDBContext _db;
        IJWT _jwt;
        public GuvenliController(ProductDBContext db, IJWT jwt)
        {
            _db = db;
            _jwt = jwt;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Uruns.ToList());
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult Post(Login login)
        {
            string token = _jwt.Authenticate(login.UserName, login.Password);
            if (token != null)
            {
                return Ok(token);
            }
            else
            {
                return Unauthorized();
            }
            
        }
    }
}
