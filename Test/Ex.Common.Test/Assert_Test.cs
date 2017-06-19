/****************************************************************************************
 * 文件名：Assert_Test
 * 作者：黄泽林
 * 创始时间：2017/6/19 19:01:36
 * 创建说明：
****************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ex.Common.Test
{
    [TestClass]
    public class Assert_Test
    {
        [TestMethod]
        public void Test()
        {
            List<string> lst = new List<string>();
            lst.Add("ddddd");
            lst.Add("xxxxx");
            lst.ForEach(s => { Console.WriteLine(s); });
            
            Rx.Common.Assert.AreEqual(200, 200, "两个数不相等");
            Rx.Common.Assert.IsNotEmpty(lst, "集合中没有数据");
        }
    }
}
