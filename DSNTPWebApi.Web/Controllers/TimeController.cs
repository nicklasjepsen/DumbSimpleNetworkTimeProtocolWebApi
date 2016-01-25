using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SystenOut.Toolbox.Core.Classic;

namespace DSNTPWebApi.Web.Controllers
{
    public class TimeController : ApiController
    {
        [HttpGet]
        public DateTime Get()
        {
            return SNTPProvider.GetNetworkTime().ToUniversalTime();
        }
    }
}
