using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferProject.PostresqlModels
{
    [Table("customer_group")]
    public partial class CustomerGroup
    {
        [Key]
        [Column("groupid", Order = 0)]
        public int GroupId { get; set; }
        [Column("groupname", Order = 1)]
        public string GroupName { get; set; }
        public virtual ICollection<CustomerCompany> CustomerCompany { get; set; }
    }
}
