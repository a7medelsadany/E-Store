using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Contracts.Response
{
    public class ResponseBase
    {
        public ResponseBase()
        {
            Messages=new List<string>();
        }
        public HttpStatusCode StatusCode { get; set; }
        public List<string> Messages { get; set; }
    }
}
