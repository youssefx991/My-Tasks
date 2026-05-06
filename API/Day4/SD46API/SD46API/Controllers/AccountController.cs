using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using SD46API.DTOs;
using SD46API.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SD46API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        UserManager<ApplicationUser> _userManger;
        public AccountController(UserManager<ApplicationUser> userManger)
        {
            _userManger = userManger;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(RegisterDTO userDto)
        {
            if (ModelState.IsValid)
            {
                //mapping from DTO to ApplicationUser
                ApplicationUser user = new ApplicationUser()
                {
                    UserName = userDto.UserName,
                    Email = userDto.Email,
                    Address = userDto.Address

                };

                //save db
                IdentityResult res = await  _userManger.CreateAsync(user, userDto.Password);
                if (res.Succeeded)
                {
                    return Ok("User Created");
                }
                foreach(var err in res.Errors)
                {
                    ModelState.AddModelError("",err.Description);
                }
              }
            return BadRequest(ModelState);
        }
        [HttpPost("Login")]
        public async Task<IActionResult> Login(LoginDTO userDTO)
        {
            if (ModelState.IsValid)
            {

                ApplicationUser user = await _userManger.FindByNameAsync(userDTO.UserName);
                if (user != null)
                {
                    bool found = await _userManger.CheckPasswordAsync(user, userDTO.Password);

                    if (found)
                    {

                        //Create Claims

                        List<Claim> userClaims = new List<Claim>();
                        userClaims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
                        userClaims.Add(new Claim(ClaimTypes.Name, user.UserName));
                        userClaims.Add(new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()));
                        //create signing Cred
                        SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("1fe9456a16ecee57f8a4755811fa3536473a9b11c48ada9acc8d988076f4d438"));
                        SigningCredentials signCred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);


                        //create yoken

                        JwtSecurityToken myToken = new JwtSecurityToken(

                            issuer: "http://localhost:5004/",
                            audience: "http://localhost:5015/",
                            expires: DateTime.Now.AddMinutes(30),
                            claims: userClaims,
                            signingCredentials: signCred
                            );





                        return Ok(

                            new
                            {
                                token = new JwtSecurityTokenHandler().WriteToken(myToken),
                                Expire = myToken.ValidTo
                            }


                            );
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid UserName Or Password");

                    }
                }
                return BadRequest(ModelState);
            }
            return BadRequest(ModelState);











            return Ok();
        }
    }
}
