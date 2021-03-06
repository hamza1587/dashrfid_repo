using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ManagementSoft.Models;
using DataLib.Entities;
using DataLib.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ManagementSoft.Helper;
using Microsoft.Extensions.Configuration;
using System.Data;
using Newtonsoft.Json;
using DataLib.Interface;
using Microsoft.Extensions.Hosting;
using System.IO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Net.Http;
using System.Net;
using System.Text;
using Nancy.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;

namespace ECommerceCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitofWork db;
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public IConfiguration Configuration { get; }
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IUnitofWork _db, IHttpContextAccessor httpContextAccessor, IConfiguration configuration, IHostingEnvironment en)
        {
            _logger = logger;
            db = _db;
            _httpContextAccessor = httpContextAccessor;
            Configuration = configuration;
            _hostingEnvironment = en;
        }

        public async Task<IActionResult> API()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage Response = await client.GetAsync("https://celayawebservice.azurewebsites.net/WS1/3TYRX5GN4LT000008"))
                    {
                        if (Response.IsSuccessStatusCode)
                        {
                            var data = Response.Content.ReadAsStringAsync().Result;
                            var result = JsonConvert.DeserializeObject<Example>(data);
                            return View(result);
                        }
                        return View();
                    }
                }
            }
            catch(Exception)
            {
                return View();
            }
        }

        public IActionResult DashBoard()
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                CurrentUser(GetLoginUserId());
                var data = db.Timespent.GetViewData().Result;                
                return View(data);
            }
        }
        [HttpGet]
        public IActionResult OperationReport()
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                CurrentUser(GetLoginUserId());
                var data = db.Timespent.Get().Result;
                return View(data);
            }
        }
        [HttpPost]
        public IActionResult OperationReport(DateTime FromDate, DateTime ToDate)
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                CurrentUser(GetLoginUserId());
                var data = db.Timespent.GetDateData(FromDate, ToDate).Result;
                return View(data);
            }
        }
        [HttpGet]
        public IActionResult OperationReport2()
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {

                CurrentUser(GetLoginUserId());
                var data = db.Timespent.GetViewData().Result;
                return View(data);
            }
        }
        [HttpPost]
        public IActionResult OperationReport2(DateTime FromDate, DateTime ToDate)
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {

                CurrentUser(GetLoginUserId());
                var data = db.Timespent.GetData(FromDate, ToDate).Result;
                return View(data);
            }
        }

        public IActionResult Index()
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                CurrentUser(GetLoginUserId());
                var data = db.Timespent.GetViewData().Result;
                return View(data);
            }
        }

        public JsonResult SearchtimeSpent(DateTime FromDate,DateTime ToDate)
        {
            if (FromDate != null && ToDate != null)
            {
                var data = db.Timespent.GetByCondtion(null).Result;
                return Json(data);
            }
            else
            {
                return Json(null);
            }
        }

        #region Export
        [HttpPost]
        public IActionResult ExportToExcel(bool export)
        {
            string result = string.Empty;
            try
            {
                if (export)
                {
                    DetailExcel();
                    //DownloadFile();
                }
                else
                    result = "error";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Json(result);
        }

        public IActionResult DetailExcel()
        {
            string sWebRootFolder = _hostingEnvironment.ContentRootPath + "\\Export\\";
            string sFileName = @"ResourceReport.xlsx";
            string path = sWebRootFolder + sFileName;
            string URL = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, sFileName);
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            var memory = new MemoryStream();

            // get data 
            var data = db.Timespent.Get().Result;

            int rowcount = 1;
            using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook;

                workbook = new XSSFWorkbook();

                ISheet excelSheet = workbook.CreateSheet("ResourceSheet");

                IRow row = excelSheet.CreateRow(0);
                row.CreateCell(0).SetCellValue("No");
                row.CreateCell(1).SetCellValue("Team Name");
                row.CreateCell(2).SetCellValue("Indicator");
                row.CreateCell(3).SetCellValue("Activity Category");
                row.CreateCell(4).SetCellValue("Detailed Activity");
                row.CreateCell(5).SetCellValue("Total Mandays Utilized");

                foreach (var item in data)
                {
                    //double totalutilizeday = item.TotalMandaysUtilized * item.TotalMandaysAvailable;
                    //double totaldays = totalutilizeday / 100;
                    //row = excelSheet.CreateRow(rowcount);
                    //row.CreateCell(0).SetCellValue(item.ResourceReportId);
                    //row.CreateCell(1).SetCellValue(item.Team.Name);
                    //row.CreateCell(2).SetCellValue(item.Team.Indicator);
                    //row.CreateCell(3).SetCellValue(item.ActivityCategory.ActivityType);
                    //row.CreateCell(4).SetCellValue(item.DetailedActivity.Details);
                    //row.CreateCell(5).SetCellValue(totaldays);
                    rowcount++;
                }

                workbook.Write(fs);
            }

            using (var stream = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Open))
            {
                stream.CopyTo(memory);
            }
            memory.Position = 0;
            return File(memory, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", sFileName);

        }
        #endregion

        #region User Details
        public IActionResult UsersDetail()
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                CurrentUser(GetLoginUserId());
                var data = db.Users.Get().Result;
                return View(data);
            }
        }
        public IActionResult AddUser(int? Id)
        {
            if (!CheckUserexists())
            {
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                CurrentUser(GetLoginUserId());
                if (Id != null && Id != 0)
                {
                    var data = db.Users.GetById(Id??0).Result;
                    return View(data);
                }
                return View();
            }
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(Users obj)
        {
            try
            {
                if (string.IsNullOrEmpty(obj.user_name))
                {
                    ViewData["Warning"] = "User Saved Successfuly";
                    return View(obj);
                }
                obj.created_at = DateTime.Now;
                //obj.user_pass = SecurePasswordHasher.Hash(obj.user_pass);
                if (obj.id == 0)
                {
                   await db.Users.Add(obj);
                }
                else
                {
                    db.Users.Update(obj);
                }

                await db.SaveAsync();
                ViewData["Success"] = "User Saved Successfuly";
            }
            catch (Exception ex)
            {
                ViewData["Error"]= ex.Message;
            }
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> DeleteUser(int Id)
        {
            try
            {
                string result = string.Empty;
                if (Id != 0)
                {
                    Users obj = await db.Users.GetById(Id);
                    db.Users.Delete(obj);
                    await db.SaveAsync();
                }
                else
                    result = "error";

                return Json(result);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region User validation

        public void CurrentUser(Users User)
        {
            ViewData["User"] = User.user_name;
            ViewData["Userrole"] = User.user_role;
        }
        public bool CheckUserexists()
        {
            var user = GetLoginUserId();

            if (user != null)
            {
                Remove("LoginUserId");
                Remove("LoginUsername");

                SetCookie("LoginUserId", user.id.ToString(), 1);
                SetCookie("LoginUsername", user.user_name.ToString(), 1);
                SetCookie("LoginUserRole", user.user_role.ToString(), 1);
                
                return true;
            }
            else
            {
                return false;
            }
        }

        private Users GetLoginUserId()
        {
            Users obj = new Users();
            string  cookieValueFromReq, cookieValueFromRequser,cookieUserrole;

           //read cookie from Request object  
            cookieValueFromReq = Request.Cookies["LoginUserId"];
            cookieValueFromRequser = Request.Cookies["LoginUsername"];
            cookieUserrole = Request.Cookies["LoginUserRole"];
            

            if (cookieValueFromReq != null && cookieValueFromRequser != null && cookieUserrole!=null)
            {
                obj.id = int.Parse(cookieValueFromReq);
                obj.user_name = cookieValueFromRequser;
                obj.user_role = cookieUserrole;
                return obj;
            }
            else
            {
                return null;
            }
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
        #endregion


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
