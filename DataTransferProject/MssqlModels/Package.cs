using System;
using System.Collections.Generic;

namespace DataTransferProject.MssqlModels
{
    public partial class Package
    {
        public Package()
        {
            Stock = new HashSet<Stock>();
        }

        public int Id { get; set; }
        public string PackageNo { get; set; }
        public int CustomerId { get; set; }
        public int DeviceReaderId { get; set; }
        public DateTime SellingDate { get; set; }
        public string CargoNumber { get; set; }
        public bool? IsActive { get; set; }

        public virtual CustomerStation Customer { get; set; }
        public virtual DeviceReader DeviceReader { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
