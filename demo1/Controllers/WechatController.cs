using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using demo1.Utils;

namespace demo1.Controllers
{
    public class WechatController : Controller
    {
        // GET: Wechat
        public ActionResult Index()
        {
            return View();   
        }

        public string  Api(string echostr)
        {
            if (echostr=="")
            {
               return "success";
            }
            return echostr;
        }

        [HttpPost]
        public string Api()
        {

            Stream st = Request.InputStream;

            StreamReader sr = new StreamReader(st, Encoding.GetEncoding("UTF-8"));

            String xmlStr = sr.ReadToEnd();

            Log.Info("api", xmlStr);
            
            return "success";
        }
    }
}