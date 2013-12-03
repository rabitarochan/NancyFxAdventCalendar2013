using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace TodoApp.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            // GET "/"
            Get["/"] = parameter => {
                return View["index"];
            };

            // GET "/goal"
            // 完成イメージ
            Get["/goal"] = parameter => {
                return View["goal"];
            };
        }
    }
}