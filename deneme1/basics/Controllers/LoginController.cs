using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using basics.Models;
using Microsoft.AspNetCore.Identity;
namespace basics.Controllers
{
    public class LoginController : Controller
    {
        private static List<UserModel> users = new List<UserModel>{
            new UserModel
            {
            id=1, username="fkaanc",password="1234"
            }
        };

        
        public IActionResult Login()
        {
            var giris = new UserModel();

            return View();
        }

        
[HttpPost]
public IActionResult Login(UserModel giris)
{
    if (ModelState.IsValid) 
    {
        var user = users.FirstOrDefault(u => u.username == giris.username && u.password == giris.password);

        if (user != null)
        {            
            TempData["SuccessMessage"] = "Başarıyla giriş yaptınız!";
            return RedirectToAction("Detay", "Araba");
        }
        else
        {
            TempData["ErrorMessage"] = "Kullanıcı adı veya şifre hatalı.";
        }
    }
    else
    {
        TempData["ErrorMessage"] = "Giriş bilgileri eksik veya hatalı.";
    }

    return RedirectToAction("Login");
}

[HttpGet]
public IActionResult Register()
{
    return View();
}

[HttpPost]
public IActionResult Register(UserModel newUser)
{
    if (ModelState.IsValid) 
    {
        users.Add(new UserModel
        {
            id = users.Count + 1,
            username = newUser.username,
            password = newUser.password
        });

        TempData["SuccessMessage"] = "Üye kaydınız başarıyla oluşturuldu!";
        return RedirectToAction("Login");
    }
    else
    {
        TempData["ErrorMessage"] = "Kayıt bilgileri eksik veya hatalı.";
        return View(newUser);
    }
}


        

        }
}
