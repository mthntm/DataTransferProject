using System;
using System.Collections.Generic;

namespace DataTransferProject.MssqlModels
{
    public partial class CustomerCompany
    {
        public CustomerCompany()
        {
            CustomerStation = new HashSet<CustomerStation>();
        }

        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? Group { get; set; }

        public virtual CustomerGroup GroupNavigation { get; set; }
        public virtual ICollection<CustomerStation> CustomerStation { get; set; }
    }
}
