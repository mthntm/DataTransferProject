using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferProject.PostresqlModels
{
    [Table("category")]
    public partial class Category
    {
        [Key]
        [Column("categoryid", Order = 0)]
        public int CategoryId { get; set; }
        [Column("categoryname", Order = 1)]
        public string CategoryName { get; set; }
        [Column("iteminstock", Order = 2)]
        public int? ItemInStock { get; set; }
        [Column("productinthepackage", Order = 3)]
        public int? ProductInThePackage { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
