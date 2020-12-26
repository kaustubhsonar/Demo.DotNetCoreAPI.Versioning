using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.DotNetCoreAPI.Swagger.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.DotNetCoreAPI.Versioning.Controllers
{   
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/books")] //use for querystring versioning 
    //[Route("api/{v:apiVersion}/books")] //use for url based versioning 
    public class BooksController : Controller
    {

        private readonly BookRepository bookRepository = null;
        public BooksController()
        {
            bookRepository = new BookRepository();
        }

        /// <summary>
        /// Get all the books 
        /// </summary>
        /// <returns></returns>        
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var data = "All books from books controller.";
                return Ok(data);
            }
            catch (Exception)
            {
                return new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }
        }

    }
}
