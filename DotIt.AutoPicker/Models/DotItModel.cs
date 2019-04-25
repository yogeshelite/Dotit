using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotIt.AutoPicker.Models
{
    public class AuthenticateModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class ResponseModel
    {
        public bool success { get; set; }
        public string Response { get; set; }
    }
   
}
