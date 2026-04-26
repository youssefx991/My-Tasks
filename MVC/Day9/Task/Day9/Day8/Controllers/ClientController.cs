using Day9.Models;
using Day9.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Day9.Controllers
{
    public class ClientController : Controller
    {
        UserManager<Client> userManager;
        SignInManager<Client> signInManager;

        public ClientController(UserManager<Client> userManager, SignInManager<Client> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterUserViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Client client = new Client
                {
                    UserName = vm.UserName,
                    Email = vm.Email,
                    FirstName = vm.FirstName,
                    LastName = vm.LastName,
                    Nationality = vm.Nationality,
                    EducationLevel = vm.EducationLevel,
                };
                
                IdentityResult result = await userManager.CreateAsync(client, vm.Password);

                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(client, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(vm);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginUserViewModel vm)
        {
            if (ModelState.IsValid)
            {
                Client userFromDB = await userManager.FindByEmailAsync(vm.Email);

                if (userFromDB != null)
                {
                    var result = await signInManager.PasswordSignInAsync(userFromDB, vm.Password, isPersistent: vm.RememberMe, lockoutOnFailure: false);
                    if (result.Succeeded)
                        return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("", "Invalid login attempt.");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
     
    }
}
