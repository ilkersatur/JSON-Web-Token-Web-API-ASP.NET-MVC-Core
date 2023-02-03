using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WebApplication1.Models.JWT
{
    public class JWT : IJWT
    {
        string _key;
        public JWT(string key)
        {
            _key = key;
        }
        public string Authenticate(string username, string password)
        {
            ProductDBContext db = new ProductDBContext();
            Kullanici kullanici = db.Kullanicilar.Where(x => x.KullaniciAdi == username && x.Sifre == password).SingleOrDefault();

            string result = null;
            if (kullanici!=null)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var bytKey = Encoding.UTF8.GetBytes(_key);

                var tokenDesc = new SecurityTokenDescriptor()
                {
                    Subject = new ClaimsIdentity(new Claim[] { new Claim(ClaimTypes.Name, username) }),
                    Expires = DateTime.Now.AddHours(1),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(bytKey), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDesc);
                result = tokenHandler.WriteToken(token);
            }
            return result;
        }
    }
}
