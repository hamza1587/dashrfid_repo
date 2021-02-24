using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Data;
using DataLib.Entities;
using ManagementSoft.Helper;
using ManagementSoft.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSoft.Controllers
{
    public class AdminController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly DBContext db;
        public AdminController(IHttpContextAccessor httpContextAccessor, DBContext _db)
        {
            this._httpContextAccessor = httpContextAccessor;
            db = _db;
        }
        public IActionResult Login()
        {
            Remove("LoginUserId");
            Remove("LoginUsername");
            Remove("LoginUserRole");            

            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(Users obj)
        {
            try
            {
                obj.is_active = true;
                obj.created_at = DateTime.Now;
                obj.user_pass = obj.user_pass; //SecurePasswordHasher.Hash(obj.user_pass);
                db.Users.Add(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }

            return RedirectToAction("Index", "Home");

        }

        [HttpPost]
        public IActionResult Login(Users login)
        {
            try
            {
                string cookieValueFromContext = _httpContextAccessor.HttpContext.Request.Cookies["LoginUserId"];
                //read cookie from Request object  
                string cookieValueFromReq = Request.Cookies["LoginUserId"];

                Remove("LoginUserId");
                Remove("LoginUsername");
                Remove("LoginUserRole");

                var user = db.Users.Where(x => x.user_name == login.user_name && x.user_pass == login.user_pass).FirstOrDefault();
                if (user != null)
                {
                    //if (SecurePasswordHasher.Verify(login.user_pass, user.user_pass))
                    //{

                        SetCookie("LoginUserId", user.id.ToString(), 1);
                        SetCookie("LoginUsername", user.user_name.ToString(), 1);
                        SetCookie("LoginUserRole", user.user_role.ToString(), 1);
                        
                        return RedirectToAction("Index", "Home");
                   // }                 
                }
                else
                {
                    ViewData["Error"] = "Incorrect User/Password";
                }
            }
            catch (Exception ex)
            {
                ViewData["Error"] = ex.Message;                
            }
            return View();
        }
        /// <summary>  
        /// set the cookie  
        /// </summary>  
        /// <param name="key">key (unique indentifier)</param>  
        /// <param name="value">value to store in cookie object</param>  
        /// <param name="expireTime">expiration time</param>  
        private void SetCookie(string key, string value, int? expireTime)
        {
            CookieOptions option = new CookieOptions();
            if (expireTime.HasValue)
                option.Expires = DateTime.Now.AddHours(expireTime.Value);
            else
                option.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Append(key, value, option);
        }

        public void Remove(string key)
        {
            Response.Cookies.Delete(key);
        }
    }
}
