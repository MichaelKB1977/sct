using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShortCodeTestAzureRepo.Controllers
{
    [ApiController]
    public class ListifyController : ControllerBase
    {
        [HttpGet]
        [Route("listifyyy/{startRange?}/{endRange?}/{requestedIndex?}")]
        [Route("listify/")]
        public ActionResult<IList<int>> Get(int? startRange, int? endRange, int? requestedIndex)
        {
            if(startRange == null)
            {
                throw new ArgumentNullException(nameof(startRange));
            }
            else if (startRange == null)
            {
                throw new ArgumentNullException(nameof(endRange));
            }
            if (startRange == null)
            {
                throw new ArgumentNullException(nameof(requestedIndex));
            }
            else
                return Enumerable.Range((int)startRange, (int)endRange).Skip((int)requestedIndex).Take(1).ToList();
        }
    }
}
