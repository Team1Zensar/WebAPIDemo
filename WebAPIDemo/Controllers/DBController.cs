using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;

namespace WebAPIDemo.Controllers
{
    public class DBController : ApiController
    {
        ProjectContextCls P = new ProjectContextCls();
        [HttpGet]
        public IEnumerable<Product> GetProduct()
        {
            return P.products.ToList();
        }
        [HttpGet]
        public Product GetProduct(int Id)
        {
            return P.products.FirstOrDefault(x=>x.ProductId==Id);
        }
        [HttpPost]
        public string PostProduct([FromBody]Product product)
        {
            P.products.Add(product);
            P.SaveChanges();
            return "1 row inserted";
        }
        [HttpPut]
        public string Putproduct(int id, [FromBody] Product product)
        {
            //Select * from product where productId=1
            var Prod = P.products.FirstOrDefault(x => x.ProductId == id);
            Prod.ProductName = product.ProductName;
            Prod.Price = product.Price;
            P.SaveChanges();
            return "1 row updated";
        }
        [HttpDelete]
        public string DeleteProduct(int id)
        {
            var Prod = P.products.FirstOrDefault(x => x.ProductId == id);
            P.products.Remove(Prod);
            P.SaveChanges();
            return "1 Row deleted";
        }
    }
}
