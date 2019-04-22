using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class BomInfo
    {
        #region 属性
        //bom编码
        public string bomCode { get; set; }
        //手机型号
        public string phoneModel { get; set; }
        //产品系列
        public string majorModel { get; set; }
        //子型号
        public string subModel { get; set; }
        //主板丝印
        public string mBSIYIN { get; set; }
        //内存丝印
        public string memoryInfo { get; set; }
        //运存丝印
        public string rmemoryInfo { get; set; }
        #endregion


    }
}