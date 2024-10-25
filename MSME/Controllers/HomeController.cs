using DTOs;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using MSME.Models;
using MSME.Models.Home;
using System.Diagnostics;
using System.Net.Mail;
using System.Text.RegularExpressions;
using MSME.Models.Masters;

namespace MSME.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //MenuModel menuModel = new MenuModel();
            try
            {
                //var menuItems = _menuManagementServices.GetMenu();
                return View();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        
       
        #region MSME/OTHER USER REGISTRATION
        [HttpGet]
        public async Task<IActionResult> Registration()
        {

            try
            {
                RegistrationModel registrationModel = new RegistrationModel();
                //return View(registrationModel);
                // registrationModel.EnterpriseDistrictList = await _districtService.GetAllDistrict();

                registrationModel.EnterpriseDistrictList = new List<DistrictModel> { };
                return View("~/Views/Home/Registration.cshtml", registrationModel);
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message, ex);
                TempData["error"] = ex.Message;
                return View("~/Views/Home/Registration.cshtml");
            }
            //return View(registrationModel);
            //return View("~/Views/Home/Registration.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> RegistrationAsync(RegistrationModel registrationModel)
        {
            try
            {
                //registrationModel.Id = (int)HttpContext.Session.GetInt32("Id");
                //string ipAddress = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
                //registrationModel.IPAddress = ipAddress;
                //if (ModelState.IsValid)
                //{
               // registrationModel.EnterpriseDistrictList = await _districtService.GetAllDistrict();
                if (registrationModel.RegistrationType == "MSME")
                {
                    if (registrationModel.EnterpriseName == null)
                    {
                        TempData["warning"] = "Please Enter EnterpriseName";
                    }
                    else if (registrationModel.EnterpriseDistrictId == 0)
                    {
                        TempData["warning"] = "Please Select Enterprise District";
                    }
                    else if (registrationModel.EnterpriseAddress == null)
                    {
                        TempData["warning"] = "Please Enter Enterprise Address";
                    }
                    else if (registrationModel.EnterpriseCategory == null)
                    {
                        TempData["warning"] = "Please Select Enterprise Category";
                    }
                    else if (registrationModel.IndustryType == null)
                    {
                        TempData["warning"] = "Please Select Industry Type";
                    }
                    else if (registrationModel.Sector == null)
                    {
                        TempData["warning"] = "Please Select Sector";
                    }
                    else if (registrationModel.UdyamRegistrationNo == null)
                    {
                        TempData["warning"] = "Please Select Udyam RegistrationNo";
                    }
                    else if (registrationModel.IsZEDCertification == null)
                    {
                        TempData["warning"] = "Please Select Are You ZEDCertification?";
                    }
                    else if (registrationModel.IsZEDCertification == "YES" && registrationModel.IsZEDCertificationYear == null)
                    {
                        TempData["warning"] = "Please Select ZED Certification Year of acquisition";
                    }
                    else if (registrationModel.IsZEDCertification == "YES" && registrationModel.IsZEDCertificationType == null)
                    {
                        TempData["warning"] = "Year of incorporation of the Enterprise";
                    }
                    else if (registrationModel.IncorporationYear == null)
                    {
                        TempData["warning"] = "Please Select Incorporation Year";
                    }
                    else if (registrationModel.Promoter_Entreprenuer_Name == null)
                    {
                        TempData["warning"] = "Please Enter Promoter/Entreprenuer Name";
                    }
                    else if (registrationModel.Promoter_Entreprenuer_Contact == null)
                    {
                        TempData["warning"] = "Please Enter Promoter/Entreprenuer Contact";
                    }
                    else if (registrationModel.Promoter_Entreprenuer_EmailId == null)
                    {
                        TempData["warning"] = "Please Enter Promoter/Entreprenuer EmailId";
                    }
                    else if (registrationModel.Promoter_Entreprenuer_Gender == null)
                    {
                        TempData["warning"] = "Please Enter Promoter/Entreprenuer Gender";
                    }
                    else if (registrationModel.Promoter_Entreprenuer_Age == null)
                    {
                        TempData["warning"] = "Please Enter Promoter/Entreprenuer Age";
                    }
                    else if (registrationModel.Promoter_Entreprenuer_SocialCategory == null)
                    {
                        TempData["warning"] = "Please Enter Promoter/Entreprenuer SocialCategory";
                    }
                    else if (registrationModel.IsExporter == null)
                    {
                        TempData["warning"] = "Please Select Are You Exporter?";
                    }
                    else if (registrationModel.IsExporter == "YES" && registrationModel.ExportedProduct == null)
                    {
                        TempData["warning"] = "Please Enter Exported Product";
                    }
                    else if (registrationModel.IsExporter == "YES" && registrationModel.ExportedCountry == null)
                    {
                        TempData["warning"] = "Please Enter Exported Country";
                    }
                    else
                    {
                        //var res = await _registrationService.CreateRegistrationAsync(registrationModel);
                        //if (res.Equals(1))
                        //{
                        //    TempData["success"] = "Data has been saved!";
                        //    return RedirectToAction(nameof(Registration));
                        //}
                        //else
                        //{
                        //    TempData["warning"] = "Data has not been saved!";
                        //}
                    }
                }
                else if (registrationModel.RegistrationType == "OTHER")
                {
                    if (registrationModel.PartcipantsName == null)
                    {
                        TempData["warning"] = "Please enter Partcipants Name!";
                    }
                    else if (registrationModel.OrganisationName == null)
                    {
                        TempData["warning"] = "Please enter Organisation Name!";
                    }
                    else if (registrationModel.PartcipantsDesignation == null)
                    {
                        TempData["warning"] = "Please enter Partcipants esignation!";
                    }
                    else if (registrationModel.PartcipantsContact == null)
                    {
                        TempData["warning"] = "Please enter Partcipants Contact!";
                    }
                    else if (registrationModel.PartcipantsEmailId == null)
                    {
                        TempData["warning"] = "Please enter Partcipants EmailId!";
                    }
                    else
                    {
                        //var res = await _registrationService.CreateRegistrationAsync(registrationModel);
                        //if (res.Equals(1))
                        //{
                        //    TempData["success"] = "Data has been saved!";
                        //    return RedirectToAction(nameof(Registration));
                        //}
                        //else
                        //{
                        //    TempData["warning"] = "Data has not been saved!";
                        //}
                    }
                }
                else
                {
                    TempData["warning"] = "Please Select Registration Type!";
                }
                //}
                //else
                //{
                //    TempData["warning"] ="Some thing went wrong!";
                //}
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.Message;
                //throw new Exception(ex.Message, ex);
            }
            //return View("~/Views/Home/Registration.cshtml");
            return View("~/Views/Home/Registration.cshtml", registrationModel);
        }

        #endregion


        #region ORGANATION REGISTRATION
        [HttpGet]
        public IActionResult UserRegistration()
        {
            RegistrationModel registrationModel = new RegistrationModel();
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                //throw new Exception(ex.Message, ex);
                TempData["error"] = ex.Message;
            }
            return View("~/Views/Home/UserRegistration.cshtml", registrationModel);
        }

        [HttpPost]
        //[ValidateDNTCaptcha(
        //   ErrorMessage = "Please Enter Valid Captcha",
        //   CaptchaGeneratorLanguage = Language.English,
        //   CaptchaGeneratorDisplayMode = DisplayMode.ShowDigits)]
        public async Task<IActionResult> UserRegistration(UserRegistrationModel registrationModel)
        {
            string msg = string.Empty;
            bool res = false;
            bool emailresult = false;
            bool mobileresult = false;
            int data = 0;
            string otp = string.Empty;
            //string ipAddress = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
            string ipAddress = "";
            try
            {
                if (ModelState.IsValid)
                {

                    string mobileotp = string.Empty;
                    bool isEmailValid = IsEmailValid(registrationModel.EmailId);
                    bool isMobileValid = IsMobileValid(registrationModel.ContactNo);
                    if (registrationModel.Name == null)
                    {
                        msg = "Please Enter Name";
                    }
                    else if (registrationModel.EmailId == null)
                    {
                        msg = "Please Enter EmailId";
                    }
                    else if (registrationModel.EmailId != null && isEmailValid == false)
                    {
                        msg = "Please Enter Valid EmailId";
                    }
                    else if (registrationModel.ContactNo == null)
                    {
                        msg = "Please Enter ContactNo";
                    }
                    else if (registrationModel.ContactNo != null && isMobileValid == false)
                    {
                        TempData["warning"] = "Please Enter Valid ContactNo";
                    }
                    else if (registrationModel.OrganisationName == null)
                    {
                        msg = "Please Enter Organisation Name";
                    }
                    else
                    {
                        //var IsMobileExit = await _registrationService.CheckContactNoAlreadyExist(registrationModel.ContactNo);
                        //if (IsMobileExit.Count == 0)
                        //{
                        //    #region random 6 digit number
                        //    Random _rdm = new Random();
                        //    otp = _rdm.Next(0, 1000000).ToString("D6");
                        //    //mobileotp = _rdm.Next(0, 1000000).ToString("D6");
                        //    #endregion


                        //    #region otp send to email
                        //    emailresult = SendOTPInEmail(registrationModel.Name, registrationModel.EmailId, otp);
                        //    #endregion

                        //    #region otp send to mobile
                        //    mobileresult = SendOTPInMobile(registrationModel.Name, registrationModel.ContactNo, mobileotp);
                        //    #endregion
                        //    if (emailresult == true && mobileresult == true)
                        //    {
                        //        registrationModel.OTP = otp;
                        //        registrationModel.IsVerified = false;
                        //        registrationModel.IPAddress = ipAddress;
                        //        registrationModel.IsEmailOTPSend = emailresult;
                        //        registrationModel.IsMobileOTPSend = mobileresult;
                        //        Guid newguid = Guid.NewGuid();
                        //        registrationModel.UniqueId = newguid.ToString();
                        //        data = await _registrationService.InsertOTP(registrationModel);
                        //        if (data.Equals(1))
                        //        {
                        //            HttpContext.Session.SetString("SessionUniqueId", registrationModel.UniqueId.ToString());
                        //            msg = "OTP sent sucessfully";
                        //            res = true;
                        //        }
                        //        else
                        //        {
                        //            msg = "OTP is not saved";
                        //        }
                        //    }
                        //    else
                        //    {
                        //        msg = "OTP is not sent";
                        //    }
                        //}
                        //else
                        //{
                        //    msg = "Mobile No already exits";
                        //}
                    }
                }
                else
                {
                    msg = "Invalid captcha!";
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message.ToString();
            }
            return Json(new { res, msg, otp });
        }

        public async Task<IActionResult> VerifyUserRegistration(UserRegistrationModel registrationModel)
        {
            string msg = string.Empty;
            bool res = false;
            //string sessionUniqueId = HttpContext.Session.GetString("SessionUniqueId");
            //try
            //{
            //    var data = await _registrationService.GetOTPById(sessionUniqueId);
            //    if (data != null)
            //    {
            //        bool isEmailValid = IsEmailValid(registrationModel.EmailId);
            //        bool isMobileValid = IsMobileValid(registrationModel.ContactNo);
            //        if (isEmailValid == true && isMobileValid == true)
            //        {
            //            if (data.EmailId == registrationModel.EmailId && data.ContactNo == registrationModel.ContactNo)
            //            {
            //                if (data.OTP == registrationModel.EmailVerificationCode)//|| data.OTP == registrationModel.MobileVerificationCode
            //                {

            //                    if (registrationModel.Name != null
            //                        && registrationModel.EmailId != null
            //                        && registrationModel.ContactNo != null
            //                        && registrationModel.OrganisationName != null
            //                        //&& registrationModel.MobileVerificationCode != null
            //                        && registrationModel.EmailVerificationCode != null)
            //                    {
            //                        string ipAddress = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
            //                        registrationModel.IPAddress = ipAddress;
            //                        #region insert verification into database

            //                        registrationModel.IsVerified = true;
            //                        registrationModel.UniqueId = sessionUniqueId;
            //                        #endregion
            //                        var result = await _registrationService.CreateUserRegistrationAsync(registrationModel);
            //                        if (result.Equals(1))
            //                        {
            //                            #region send email/sms code
            //                            // bool sendemail = SendCompleteRegistraionEmail(registrationModel);
            //                            //bool sendmobilemessage = SendCompleteRegistraionMessage(fullname, wRNRegistration.MobileNo, wRNRegistration.RegistrationNo, wRNRegistration.EmailId);
            //                            #endregion
            //                            msg = registrationModel.ReturnMsg;//"Data has been saved";
            //                            res = true;
            //                        }
            //                        else
            //                        {
            //                            msg = registrationModel.ReturnMsg;
            //                        }

            //                    }
            //                    else
            //                    {
            //                        msg = "Some fields are blank!";
            //                    }
            //                }
            //                else
            //                {
            //                    msg = "OTP does not match!";
            //                }
            //            }
            //            else
            //            {
            //                msg = "OTP verify email/mobile does not match from enter email/mobile!";
            //            }
            //        }
            //        else
            //        {
            //            msg = "Invalid email-id/mobileno!";
            //        }
            //    }
            //    else
            //    {
            //        msg = "OTP data is not found!";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    msg = ex.Message.ToString();
            //}
            return Json(new { res, msg });
        }


        //[HttpPost]
        //public async Task<IActionResult> UserRegistration(RegistrationModel registrationModel, string a)
        //{
        //    try
        //    {
        //        //registrationModel.EnterpriseDistrictList = await _districtService.GetAllDistrict();
        //        if (registrationModel.Name == null)
        //        {
        //            TempData["warning"] = "Please Enter Name";
        //        }
        //        else if (registrationModel.EmailId == null)
        //        {
        //            TempData["warning"] = "Please Enter EmailId";
        //        }
        //        else if (registrationModel.ContactNo == null)
        //        {
        //            TempData["warning"] = "Please Enter ContactNo";
        //        }
        //        else if (registrationModel.OrganisationName == null)
        //        {
        //            TempData["warning"] = "Please Enter Organisation Name";
        //        }
        //        else if (registrationModel.Captcha == null)
        //        {
        //            TempData["warning"] = "Please Enter Captcha";
        //        }

        //        else
        //        {
        //            var res = await _registrationService.CreateUserRegistrationAsync(registrationModel);
        //            if (res.Equals(1))
        //            {
        //                TempData["success"] = "Data has been saved!";
        //                return RedirectToAction(nameof(UserRegistration));
        //            }
        //            else
        //            {
        //                TempData["warning"] = "Data has not been saved!";
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        TempData["error"] = ex.Message;
        //        //throw new Exception(ex.Message, ex);
        //    }
        //    return View("~/Views/Home/UserRegistration.cshtml", registrationModel);
        //}
        #endregion


        public IActionResult QuickLinks()
        {
            return View("~/Views/QuickLinks/Index.cshtml");
        }
        public IActionResult About()
        {
            return View("~/Views/About/Index.cshtml");
        }

        //Start : RAMP Static Pages
        public IActionResult ZEDHome()
        {
            return View("~/Views/RampHome/ZEDHome.cshtml");
        }
        public IActionResult TUSHome()
        {
            return View("~/Views/RampHome/TUSHome.cshtml");
        }
        public IActionResult VishwakarmaHome()
        {
            return View("~/Views/RampHome/VishwakarmaHome.cshtml");
        }
        public IActionResult ESGHome()
        {
            return View("~/Views/RampHome/ESGHome.cshtml");
        }
        public IActionResult PledgeHome()
        {
            return View("~/Views/RampHome/PledgeHome.cshtml");
        }
        //End : RAMP Static Pages

        public IActionResult CentralDepartments()
        {
            return View("~/Views/Departments/CentralDepartments/Index.cshtml");
        }
        public IActionResult StateDepartments()
        {
            return View("~/Views/Departments/StateDepartments/Index.cshtml");
        }
        //public IActionResult StateSchemes()
        //{
        //    return View("~/Views/Schemes/StateSchemes/Index.cshtml");
        //}
        public IActionResult Schemes()
        {
            return View("~/Views/Schemes/Index.cshtml");
        }

        public IActionResult ViewRegistration()
        {
            if (HttpContext.Session.GetInt32("RegistrationId") != null)
            {
                RegistrationModel registrationModel = new RegistrationModel();
                //registrationModel.RegistrationList = await _registrationService.GetAllRegistrationAsync();
                //return View(registrationModel);
                return View("~/Views/Home/ViewRegistration.cshtml", registrationModel);
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }
        [HttpPost]
        public async Task<IActionResult> ViewRegistration(RegistrationModel registrationModel)
        {
            if (HttpContext.Session.GetInt32("RegistrationId") != null)
            {
                //string Rtype=Request.Form["Rtype"].ToString();
                if (registrationModel.RegistrationType == null)
                {
                    TempData["warning"] = "Please Select Registration Type";
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    //registrationModel.RegistrationList = await _registrationService.GetAllRegistrationByRegType(registrationModel.RegistrationType);
                    //return View(registrationModel);
                    return View("~/Views/Home/ViewRegistration.cshtml", registrationModel);
                }
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        public async Task<IActionResult> WorkshopSchedule()
        {
            try
            {
                //start encrypt id for update, delete & details
                //var data = await _trainingService.GetAllTrainingAsync();
                var data = "null";

                return View("~/Views/WorkshopTraining/Index.cshtml",data);
            }
            catch (Exception ex)
            {
                TempData["error"] = ex.ToString();
            }
            //return View();

            return View("~/Views/WorkshopTraining/Index.cshtml");
        }

        public IActionResult ReportsAnalytics()
        {
            return View("~/Views/ReportsAnalytics/Index.cshtml");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpGet]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Logout()
        {
            var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            if (HttpContext.Session.GetInt32("RoleId") != null)
            {
                //int RoleId = (int)HttpContext.Session.GetInt32("RoleId");
                //f (RoleId == 38 || RoleId == 31)
                //{
                //_httpContextAccessor.HttpContext.Session.Clear();
                //return RedirectToAction("Index", "StudentLogin");
                //}
            }
            //_httpContextAccessor.HttpContext.Session.Clear();
          //  _httpContextAccessor.HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        #region common code
        private bool IsEmailValid(string email)
        {
            var valid = true;
            try
            {
                var emailAddress = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }
            return valid;
        }
        public bool IsMobileValid(string input)
        {
            bool result = false;
            try
            {
                if (Regex.IsMatch(input, "\\A[0-9]{10}\\z"))
                {
                    result = true;
                }
                else
                {
                    // Nope, no match, do your worst
                }
            }
            catch (Exception)
            {
                // Syntax error in the regular expression
            }
            return result;
        }

        public bool SendOTPInEmail(string name, string emailid, string emailotp)
        {
            //MailRequest request = new MailRequest();
            //request.Subject = "WRN REGISTRATION OTP!!";
            //request.Body = "Dear " + name + ",<br/><br/>" +
            //       "<br/> " + emailotp + " is the OTP for verification. Please do not share with anyone." +
            //"<br/><br/> CSJM University";
            //request.ToEmail = emailid;
            //return _commonController.SendMail_Fromcsjmusms(request.ToEmail, request.Subject, request.Body);
            return true;
        }
        public bool SendOTPInMobile(string username, string mobile, string mobileotp)
        {
            //bool result = false;
            //string message = mobileotp + " is the One Time Password (OTP)  valid till " + "10 minutes";
            //message += " IST. Do not share your OTP with anyone, CSJMU never calls to verify OTP.";
            //result = _commonController.SendSMSWithTemplateId(mobile, message, "1607100000000192259");
            //return result;
            return true;
        }
        #endregion


        #region Login
        public IActionResult Login()
        {
         return View(new LoginDTO());
        }
        [HttpPost]
        public IActionResult Login(LoginDTO _login)
        {
            if (ModelState.IsValid)
            {
                if (_login.Email =="admin@gmail.com" && _login.Password=="123456")
                {                   
                    return RedirectToAction("Index", "Dashboard", new { area = "admin" });
                }
            }
            return View(_login);
        }
        #endregion
    }
}