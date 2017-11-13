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
            #region Query测试
            //整数
            //?n1=-1&n2=&n3=%20%20%20%20
            View = null;//不使用View
            Write("?n1=-1&n2=&n3=%20%20%20%20<br/>");
            //不给默认值 => default(T) 默认值表达式：生成类型的默认值。 对于引用类型，将为 NULL；对于值类型，将为零；对于结构，将为 0 位模式。(Default value expressions: Produces the default value of the type. This will be null for reference types and zero for value types, and the 0 bit pattern for structs.)
            Write(string.Format("Query&ltint&gt;(\"n1\")='{0}'<br/>", Query<int>("n1")));
            Write(string.Format("Query&ltint&gt;(\"n2\")='{0}'<br/>", Query<int>("n2")));
            Write(string.Format("Query&ltint&gt;(\"n3\")='{0}'<br/>", Query<int>("n3")));
            Write(string.Format("Query&ltint&gt;(\"n4\")='{0}'<br/>", Query<int>("n4")));
            //给默认值 无效字符，默认值
            Write(string.Format("Query&ltint&gt;(\"n1\",10)='{0}'<br/>", Query<int>("n1", 10)));
            Write(string.Format("Query&ltint&gt;(\"n2\",10)='{0}'<br/>", Query<int>("n2", 10)));
            Write(string.Format("Query&ltint&gt;(\"n3\",10)='{0}'<br/>", Query<int>("n3", 10)));
            Write(string.Format("Query&lt;int&gt;(\"n4\",10)='{0}'<br/>", Query<int>("n4", 10)));
            //浮点数
            //?f1=-3.14&f2=&f3=%20%20%20%20
            Write("?f1=-3.14&f2=&f3=%20%20%20%20<br/>");
            //不给默认值
            Write(string.Format("Query&lt;double&gt;(\"f1\")='{0}'<br/>", Query<double>("f1")));
            Write(string.Format("Query&lt;double&gt;(\"f2\")='{0}'<br/>", Query<double>("f2")));
            Write(string.Format("Query&lt;double&gt;(\"f3\")='{0}'<br/>", Query<double>("f3")));
            Write(string.Format("Query&lt;double&gt;(\"f4\")='{0}'<br/>", Query<double>("f4")));
            //给默认值 无效字符，默认值
            Write(string.Format("Query&lt;double&gt;(\"f1\",10)='{0}'<br/>", Query<double>("f1", 10d)));
            Write(string.Format("Query&lt;double&gt;(\"f2\",10)='{0}'<br/>", Query<double>("f2", 10d)));
            Write(string.Format("Query&lt;double&gt;(\"f3\",10)='{0}'<br/>", Query<double>("f3", 10d)));
            Write(string.Format("Query&lt;double&gt;(\"f4\",10)='{0}'<br/>", Query<double>("f4", 10d)));
            //字符串
            //浮点数
            //?s1=haha&s2=&s3=%20%20%20%20
            Write("?s1=haha&s2=&s3=%20%20%20%20<br/>");
            //不给默认值 空白字符或null => 空字符
            Write(string.Format("Query&lt;string&gt;(\"s1\")='{0}'<br/>", Query<string>("s1")?? "null"));
            Write(string.Format("Query&lt;string&gt;(\"s2\")='{0}'<br/>", Query<string>("s2")?? "null"));
            Write(string.Format("Query&lt;string&gt;(\"s3\")='{0}'<br/>", Query<string>("s3")?? "null"));
            Write(string.Format("Query&lt;string&gt;(\"s4\")='{0}'<br/>", Query<string>("s4") ?? "null"));
            //给默认值 空白字符或null =>  默认值
            Write(string.Format("Query&lt;string&gt;(\"s1\",\"字符串默认值\")='{0}'<br/>", Query<string>("s1", "字符串默认值")?? "null"));
            Write(string.Format("Query&lt;string&gt;(\"s2\",\"字符串默认值\")='{0}'<br/>", Query<string>("s2", "字符串默认值")?? "null"));
            Write(string.Format("Query&lt;string&gt;(\"s3\",\"字符串默认值\")='{0}'<br/>", Query<string>("s3", "字符串默认值")?? "null"));
            Write(string.Format("Query&lt;string&gt;(\"s4\",\"字符串默认值\")='{0}'<br/>", Query<string>("s4", "字符串默认值") ?? "null")); 
            #endregion

            WriteError("异常测试,异常信息：零不能作为除数。");
        }
        public void About() { }
        public void Contact() { }
    }
}
