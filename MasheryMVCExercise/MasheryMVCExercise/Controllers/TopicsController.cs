using MasheryMVCExercise.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MasheryMVCExercise.Controllers
{
    public class TopicsController : Controller
    {
        //
        // GET: /Topics/
        
        [Authorize]
        public ActionResult Index(FormCollection form)
        {
          Session["UserName"] = form["txtUserName"];
          return View();
        }


        //Mehtod to get Topics from API
        public JsonResult GetTopics()
        {
            Connection cn = new Connection(1, Session["UserName"].ToString());
            var json = "";
            try
            {
                json = cn.GetJSON();
            }
            catch (Exception ex)
            {
                json = ex.ToString();
            }

            return Json(json, JsonRequestBehavior.AllowGet);
        }

       

    
      

       

    
      
        
    }
}