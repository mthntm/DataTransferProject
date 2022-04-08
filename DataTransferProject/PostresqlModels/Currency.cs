using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferProject.PostresqlModels
{
    [Table("currency")]
    public partial class Currency
    {
        [Key]
        [Column("currencyid", Order = 0)]
        public int CurrencyId { get; set; }
        [Column("name", Order = 1)]
        public string Name { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
