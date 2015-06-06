using System.Data.Entity.Migrations.Model;
using System.Web.Http.Cors;
using HN.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HN.WebAPI.Controllers
{
 
    /* the constructor has three parameters. Second argument for valid headers, Third parameter for a valid set of methods*/
    [EnableCors("http://localhost:63009", "*", "*")]
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public IEnumerable<Product> Get()
        {
            var repo = new ProductRepository();
            return repo.Retrieve();
        }

        // GET: api/Products/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
