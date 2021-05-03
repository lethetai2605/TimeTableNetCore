using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTableCore.Common;
using TimeTableCore.Dao;
using TimeTableCore.Models;

namespace TimeTableCore.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Login(Account account)
        {
            if (ModelState.IsValid)
            {
                var dao = new AccountDao();
                var result = dao.Login(account.UserName,Encryptor.MD5Hash(account.PassWord));
                if (result)
                {
                    var user = dao.GetAccountByUserName(account.UserName);
                    var userSession = new UserLogin();
                    userSession.UserID = account.Id;
                    userSession.UserName = account.UserName;

                    HttpContext.Session.SetObjectAsJson("USER_SESSION", userSession);      
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "The username or password that you've entered is incorrect");
                }
            }
            return View("Index");
        }
    }
}
