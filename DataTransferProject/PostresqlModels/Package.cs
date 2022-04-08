using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferProject.PostresqlModels
{
    [Table("package")]
    public partial class Package
    {
        [Key]
        [Column("id", Order = 0)]
        public int Id { get; set; }
        [Column("packageno", Order = 1)]
        public string PackageNo { get; set; }
        [Column("customerid", Order = 2)]
        public int CustomerId { get; set; }
        [Column("devicereaderid", Order = 3)]
        public int DeviceReaderId { get; set; }
        [Column("sellingdate", Order = 4)]
        public DateTime SellingDate { get; set; }
        [Column("cargonumber", Order = 5)]
        public string CargoNumber { get; set; }
        [Column("isactive", Order = 6)]
        public bool? IsActive { get; set; }
        public virtual CustomerStation Customer { get; set; }
        public virtual DeviceReader DeviceReader { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
