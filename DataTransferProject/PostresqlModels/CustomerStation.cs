using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferProject.PostresqlModels
{
    [Table("customer_station")]
    public partial class CustomerStation
    {
        [Key]
        [Column("stationid", Order = 0)]
        public int StationId { get; set; }
        [Column("stationname", Order = 1)]
        public string StationName { get; set; }
        [Column("company", Order = 2)]
        public int? Company { get; set; }
        [Column("stationofficer", Order = 3)]
        public string StationOfficer { get; set; }
        [Column("contact", Order = 4)]
        public string Contact { get; set; }
        [Column("powerplant", Order = 5)]
        public string PowerPlant { get; set; }
        public virtual CustomerCompany CompanyNavigation { get; set; }
        public virtual ICollection<Logs> Logs { get; set; }
        public virtual ICollection<Package> Package { get; set; }
    }
}
