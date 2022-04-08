using System;
using System.Collections.Generic;

namespace DataTransferProject.MssqlModels
{
    public partial class CustomerStation
    {
        public CustomerStation()
        {
            Logs = new HashSet<Logs>();
            Package = new HashSet<Package>();
        }

        public int StationId { get; set; }
        public string StationName { get; set; }
        public int? Company { get; set; }
        public string StationOfficer { get; set; }
        public string Contact { get; set; }
        public string PowerPlant { get; set; }

        public virtual CustomerCompany CompanyNavigation { get; set; }
        public virtual ICollection<Logs> Logs { get; set; }
        public virtual ICollection<Package> Package { get; set; }
    }
}
