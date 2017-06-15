/****************************************************************************************
 * 文件名：Product
 * 作者：黄泽林
 * 创始时间：2017/6/15 17:26:09
 * 创建说明：
****************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rx.Common;

namespace Ex.Common.Test
{
    public class Product
    {
        public string Title { get; set; }
        public decimal Price { get; set; }

        public T MapTo<T>()
        {
            return this.Map<Product, T>();
        }
    }
}
