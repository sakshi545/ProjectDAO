using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectMVC.Models
{
    public class StdResponse
    {
        public string message { get; set; }
        public Boolean error { get; set; }
        public object data { get; set; }

        public StdResponse()
        {
            message = String.Empty;
            error = false;
            data = null;
        }

        public StdResponse(string message, bool error, object data)
        {
            this.message = message;
            this.error = error;
            this.data = data;
        }
    }
}