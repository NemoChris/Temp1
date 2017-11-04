using System;
using System.Collections.Generic;
using System.Text;
using Taurus.Core;

namespace Taurus.Controllers
{
    public class HomeController : Controller
    {
        public override void Default()
        {
            Context.Response.Redirect("/home/index");
        }
        public void Index()
        {
            //?pageIndex=&total=%20%20%20%20&key=
            int pageSize = Query<int>("pageSize", 10);//空字符 10
            int pageIndex = Query<int>("pageIndex", 1);//null  1
            int total = Query<int>("total", 99);//非空空白字符，tab，空格等. 99

            //Write("pageSize =" + pageSize + ";");
            //Write("pageIndex =" + pageIndex + ";");
            
        }
        public void About() { }
        public void Contact() { }
    }
}
