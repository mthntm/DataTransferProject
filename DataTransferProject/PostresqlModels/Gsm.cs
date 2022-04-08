using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferProject.PostresqlModels
{
    [Table("gsm")]
    public partial class Gsm
    {
        [Key]
        [Column("gsmid", Order = 0)]
        public int GsmId { get; set; }
        [Column("gsmnumber", Order = 1)]
        public string GsmNumber { get; set; }
        [Column("gsmlocation", Order = 2)]
        public string GsmLocation { get; set; }
        [Column("gsmquota", Order = 3)]
        public string GsmQuota { get; set; }
        [Column("gsmcompany", Order = 4)]
        public string GsmCompany { get; set; }
        [Column("stationname", Order = 5)]
        public string StationName { get; set; }
    }
}
