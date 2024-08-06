using Azure.Core;
using E_TutorApp.Application.Services;
using E_TutorApp.Domain.Entities.Concretes;
using E_TutorApp.Domain.ViewModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace E_TutorApp.Persistence.Services
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<User> _userManager;

        public AccountService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public bool LoginService()
        {
            throw new NotImplementedException();
        }

        public async Task<User?> RegisterServiceAsync(RegisterVM registerVM)
        {
            var newUser = new User()
            {
                Bio = "Me",
                ProfilePicture = "Me.jpeg",
                LastName = registerVM.LastName,
                UserName = registerVM.UserName,
                Email = registerVM.Email,
            };

            var result = await _userManager.CreateAsync(newUser, registerVM.Password);
            if (result.Succeeded)
            {
                return newUser;
                //var newtoken = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
                //var confirmationLink = Url.Action("ConfirmEmail", "Home", new { email = newUser.Email, token = newtoken }, Request.Scheme);
                //// Email Sent SMTP
                //var smtp = new SmtpClient("smtp.gmail.com", 587);
                //smtp.Credentials = new NetworkCredential("mahamguziyev@gmail.com", "pinr ggnw dogk zmle");
                //smtp.EnableSsl = true;

                //MailMessage mail = new MailMessage();
                //mail.Subject = "Confirm your email";
                //mail.Body = $"<a href='{confirmationLink}'>Click to Btn And Comfirm Email</a>";
                //mail.IsBodyHtml = true;
                //mail.From = new MailAddress("mahamguziyev@gmail.com");
                //mail.To.Add(newUser.Email);

                //smtp.Send(mail);
                //await _userManager.AddToRoleAsync(newUser, "Student");




                //return RedirectToAction("Login", "Account");


            }
            else
            {
                return null;
                //foreach (var item in result.Errors) ModelState.AddModelError("All", item.Description);
                //return View(registerVM);
            }
        }
    }
}
