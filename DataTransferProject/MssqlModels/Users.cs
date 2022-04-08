using System;
using System.Collections.Generic;

namespace DataTransferProject.MssqlModels
{
    public partial class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
