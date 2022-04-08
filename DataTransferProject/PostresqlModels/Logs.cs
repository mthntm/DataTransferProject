using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferProject.PostresqlModels
{
    [Table("logs")]
    public partial class Logs
    {
        [Key]

        [Column("id", Order = 0)]
        public int Id { get; set; }
        [Column("whichmenu", Order = 1)]
        public string WhichMenu { get; set; }
        [Column("generalid", Order = 2)]
        public string GeneralId { get; set; }
        [Column("createdobject", Order = 3)]
        public bool CreatedObject { get; set; }
        [Column("updatedobject", Order = 4)]
        public bool UpdatedObject { get; set; }
        [Column("deletedobject", Order = 5)]
        public bool DeletedObject { get; set; }
        [Column("transactiondate", Order = 6)]
        public DateTime? TransactionDate { get; set; }
        [Column("nameoftheproduct", Order = 7)]
        public string NameOfTheProduct { get; set; }
        [Column("stationname", Order = 8)]
        public string StationName { get; set; }
        [Column("explanation", Order = 9)]
        public string Explanation { get; set; }
        [Column("customer", Order = 10)]
        public int? Customer { get; set; }
        public virtual CustomerStation CustomerNavigation { get; set; }
    }
}
