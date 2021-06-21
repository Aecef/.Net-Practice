using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using GiphyDotNet.Manager;
using GiphyDotNet.Model.Parameters;
using Nothin.Models;

namespace Nothin.Controllers
{
    public class QuoteApiController : ApiController
    {
        [HttpPost]
        [Route("api/quote/{values}")]
        public async Task<IHttpActionResult> addedQuote(int values)
        {

            return Ok();
        }
    }
}
