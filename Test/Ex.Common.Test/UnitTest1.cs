using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rx.Common;

namespace Ex.Common.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Product pd = new Product();
            pd.Title = "苹果";
            pd.Price = 20m;

            //var dto = pd.Map<Product,ProductDto>();
            var dto = pd.MapTo<ProductDto>();
            Console.WriteLine(dto.Title);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Product p1 = new Product();
            p1.Title = "苹果";
            p1.Price = 20m;

            Product p2 = new Product();
            p2.Title = "西瓜";
            p2.Price = 5m;

            Order od = new Order();
            od.OrderNumber = "a00008";
            od.Pros = new List<Product>();
            od.Pros.Add(p1);
            od.Pros.Add(p2);


            List<ProductDto> pDtos = new List<ProductDto>();
            foreach (var product in od.Pros)
            {
                pDtos.Add(product.Map<Product, ProductDto>());
            }

            List<Expression<Func<OrderDto, object>>>  ignores = new List<Expression<Func<OrderDto, object>>>();
            ignores.Add((s) => s.Pros);

            var dto = od.Map<Order, OrderDto>(ignoreMembers: ignores.ToArray());
            dto.Pros = pDtos;
            Console.WriteLine(dto.OrderNumber);
        } 
    }
}
