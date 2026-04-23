using _7_NetCORE.Models;
using _7_NetCORE.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _7_NetCORE.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        public UserManager<AppUser> UserManager { get; }
        public SignInManager<AppUser> SignInManager { get; }

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel newUserVM)
        {
            if (ModelState.IsValid)
            {
                //Map data from UserViewModel to User domain model "AppUser"

                AppUser userModel = new AppUser
                {
                    UserName = newUserVM.UserName,
                    PasswordHash = newUserVM.Password,
                    FirstName = newUserVM.FirstName,
                    LastName = newUserVM.LastName,
                    Job = newUserVM.Job
                };

                //Save userModel to database using UserManager 
                IdentityResult result =  await UserManager.CreateAsync(userModel, newUserVM.Password);

                if (result.Succeeded)
                {
                    //Create Cookie for the user and redirect to home page

                    await SignInManager.SignInAsync(userModel, isPersistent: false);

                    return RedirectToAction("Index", "Student");
                }
                else
                {                    
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

            }
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserViewModel newUserVM)
        {
            if (ModelState.IsValid)
            {
                //Check if the user exist in the database using UserManager

                AppUser userFromDB = await UserManager.FindByNameAsync(newUserVM.UserName);

                if (userFromDB != null)
                {
                    //Check if the password is correct using SignInManager
                    bool found = await UserManager.CheckPasswordAsync(userFromDB, newUserVM.Password);
                    if (found == true)
                    {
                        //if found create cookie for the user and redirect to home page
                        await SignInManager.SignInAsync(userFromDB, isPersistent: newUserVM.RememberMe);
                        return RedirectToAction("Index", "Student");
                    }
                }

            }
            ModelState.AddModelError("", "Invalid username or password");
            return View();
        }


        public IActionResult Logout()
        {
            SignInManager.SignOutAsync();  //Delete the cookie of the user
            return RedirectToAction("Login", "Account");
            //return RedirectToAction("Register", "Account");
        }
    }
}
