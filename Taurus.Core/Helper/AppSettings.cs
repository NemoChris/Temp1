using CYQ.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Taurus.Core.Helper
{
    public class AppSettings
    {
        /// <summary>
        /// 是否为开发者模式（开发者输出更多的调试和错误信息）
        /// </summary>
        public static readonly bool IsDevMode = AppConfig.GetAppBool("IsDevMode", false);
    }
}
