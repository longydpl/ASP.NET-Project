using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebBanDoAnNhanh.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create(User user )
        {
            var dao = new UserDao();
            long id = dao.Insert(user);
            if(id>0)
            {
                return RedirectToAction("Index", "User");
            }
            else
            {
                ModelState.AddModelError("", "Thêm user thành công");
            }
            return View("Index");
        }
    }
}