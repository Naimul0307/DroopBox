using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using DoorBoxApp.Data;
using DoorBoxApp.Models;
using DoorBoxApp.Models.Common.Authentication;
using DoorBoxApp.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DoorBoxApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(ApplicationDbContext context, SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _signInManager = signInManager;
            _userManager = userManager;
        }

        // GET: /Account/Login
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Public()
        {
            return View();
        }
          [HttpGet]
        [AllowAnonymous]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                //Find User
                var user = await _userManager.FindByNameAsync(loginViewModel.UserName);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.RememberMe, false);
                    if (result.Succeeded)
                    {
                        if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                        {
                            return Redirect(returnUrl);
                        }
                        else
                        {
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Provided Password is Incorrect!");
                    }
                }
                else
                {
                    ModelState.TryAddModelError("", "The UserName or Password Provided is Incorrect");
                }
            }

            //Not found user or password did not matched            
            return View(loginViewModel);
        }

        [HttpGet]
        //[Authorize]
        public IActionResult Register()
        {
            //var userTypes = _context.UserTypes.ToList();
            //ViewData["UserTypeId"] = new SelectList(userTypes, "Id", "Name");

            //var gates = _context.Gates.ToList();
            //ViewData["GateId"] = new SelectList(gates, "Id", "Name");

            //var yards = _context.Yards.ToList();
            //ViewData["YardId"] = new SelectList(yards, "Id", "Name");

            return View();
        }

        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                //var loggedInUser = await _userManager.FindByNameAsync(HttpContext.User.Identity.Name); //LoggedIn User

                //Create user
                var user = new ApplicationUser()
                {
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email,
                    UserTypeId = 2,
                    PaymentMethod = registerViewModel.PaymentMethod,
                    BankName = registerViewModel.BankName,
                    BranchName = registerViewModel.BranchName,
                    AccountNumber = registerViewModel.AccountNumber,
                    RoutingNumber = registerViewModel.RoutingNumber,
                    BankCustomerName = registerViewModel.BankCustomerName,
                    PhoneNumber = registerViewModel.PhoneNumber,
                    MobileBankingNumber = registerViewModel.MobileBankingNumber,
                    Status = 0
                };
                //Create user with password
                var result = await _userManager.CreateAsync(user, registerViewModel.Password);

                //user.
                //var result = await _userManager.ResetPasswordAsync user
                //Redirect User
                if (result.Succeeded)
                {
                    var merchant = new Merchant
                    {
                        ApplicationUserId = user.Id,
                        Name = registerViewModel.FullName,
                        Address = registerViewModel.Address
                    };
                    _context.Add(merchant);
                    int count = await _context.SaveChangesAsync();

                    if (count == 1)
                    {
                        merchant.MerchantIdNo = "M000" + merchant.Id.ToString();
                        _context.Update(merchant);
                        int count2 = await _context.SaveChangesAsync();
                    }
                    

                    return RedirectToAction("Index", "Home");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(registerViewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> UpdatePassword(string userId)
        {
            if (userId == null)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            var updatePasswordViewModel = new UpdatePasswordViewModel
            {
                UserId = user.Id
            };

            return View();
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UpdatePassword(string userId, UpdatePasswordViewModel updatePasswordViewModel)
        {

            if (userId == null)
            {
                return NotFound();
            }

            if (userId != updatePasswordViewModel.UserId)
            {
                return NotFound();
            }

            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                //Update password of user
                var result = await _userManager.ChangePasswordAsync(user, updatePasswordViewModel.PreviousPassword, updatePasswordViewModel.NewPassword);
                //Redirect User
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(updatePasswordViewModel);
        }
        [HttpPost]
        public async Task<JsonResult> SendOTP(string userName)
        {
            var user = await _userManager.FindByNameAsync(userName);

            Random generator = new Random();
            String r = generator.Next(0, 1000000).ToString("D6");

            user.OTPUser = r;
            var result = await _userManager.UpdateAsync(user);
            if (!await _userManager.IsInRoleAsync(user, "DeliveryMan"))
            {
                if (result.Succeeded)
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://api.mobireach.com.bd/");
                        var responseTask = client.GetAsync("SendTextMessage?Username=Doorbox&Password=Rabbi@123&From=8801842871143&To="+user.PhoneNumber+"&Message=Your OTP is " + user.OTPUser + " for changing password ");
                        responseTask.Wait();

                        var result1 = responseTask.Result;
                        return Json(true);
                    }
                }
                else
                {
                    return Json(false);
                }

            }

            return Json(false);
        }
        [HttpPost]
        public async Task<JsonResult> SendNewPassMessage(string userName ,string otp)
        {
            var user = await _userManager.FindByNameAsync(userName);
            

            if (user.OTPUser==otp)
            {
                Random generator = new Random();
                String pass = generator.Next(0, 1000000).ToString("D6");
               
                String newPassword = pass;
                String hashedNewPassword = _userManager.PasswordHasher.HashPassword(user,newPassword);
                UserStore<ApplicationUser> store = new UserStore<ApplicationUser>(_context);
                 await store.SetPasswordHashAsync(user, hashedNewPassword);




                Random generator2 = new Random();
                String r = generator2.Next(0, 1000000).ToString("D6");

                user.OTPUser = r;
                var result = await _userManager.UpdateAsync(user);

                if (result.Succeeded)
                {
                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri("https://api.mobireach.com.bd/");
                        var responseTask = client.GetAsync("SendTextMessage?Username=Doorbox&Password=Rabbi@123&From=8801842871143&To=" + user.PhoneNumber + "&Message=Your new temporary password is" + pass + " . Please change it ");
                        responseTask.Wait();

                        var result1 = responseTask.Result;
                        return Json(true);
                    }

                }
                return Json(true);
            }
            return Json(true);
        }





    }
}