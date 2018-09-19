using System;
using System.Collections.Generic;
using System.Text;

namespace GRPCServer.Model
{
    class Users
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
