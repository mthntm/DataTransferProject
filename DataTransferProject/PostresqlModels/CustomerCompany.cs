using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferProject.PostresqlModels
{
    [Table("customer_company")]
    public partial class CustomerCompany
    {
        [Key]
        [Column("companyid", Order = 0)]
        public int CompanyId { get; set; }
        [Column("companyname", Order = 1)]
        public string CompanyName { get; set; }
        [Column("group", Order = 2)]
        public int? Group { get; set; }
        public virtual CustomerGroup GroupNavigation { get; set; }
        public virtual ICollection<CustomerStation> CustomerStation { get; set; }
    }
}
