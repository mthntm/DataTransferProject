using System;
using System.Collections.Generic;

namespace DataTransferProject.MssqlModels
{
    public partial class CustomerGroup
    {
        public CustomerGroup()
        {
            CustomerCompany = new HashSet<CustomerCompany>();
        }

        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public virtual ICollection<CustomerCompany> CustomerCompany { get; set; }
    }
}
