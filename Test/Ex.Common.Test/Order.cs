/****************************************************************************************
 * 文件名：Order
 * 作者：黄泽林
 * 创始时间：2017/6/15 17:35:46
 * 创建说明：
****************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex.Common.Test
{
    public class Order
    {
        public string OrderNumber { get; set; }

        public List<Product> Pros { get; set; }
    }

    public class OrderDto
    {
        public string OrderNumber { get; set; }

        public List<ProductDto> Pros { get; set; }
    }
}
