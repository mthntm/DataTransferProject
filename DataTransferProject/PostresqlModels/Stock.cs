using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferProject.PostresqlModels
{
    [Table("stock")]
    public partial class Stock
    {
        [Key]
        [Column("productid", Order = 0)]
        public int ProductId { get; set; }
        [Column("productname", Order = 1)]
        public string ProductName { get; set; }
        [Column("brand", Order = 2)]
        public string Brand { get; set; }
        [Column("category", Order = 3)]
        public int? Category { get; set; }
        [Column("price", Order = 4)]
        public decimal? Price { get; set; }
        [Column("dateofpurchase", Order = 5)]
        public DateTime? DateOfPurchase { get; set; }
        [Column("status", Order = 6)]
        public string Status { get; set; }
        [Column("stockserialno", Order = 7)]
        public string StockSerialNo { get; set; }
        [Column("packageno", Order = 8)]
        public string PackageNo { get; set; }
        [Column("currencytype", Order = 9)]
        public int? CurrencyType { get; set; }
        [Column("explanation", Order = 10)]
        public string Explanation { get; set; }
        public virtual Category CategoryNavigation { get; set; }
        public virtual Currency CurrencyTypeNavigation { get; set; }
        public virtual Package PackageNoNavigation { get; set; }
    }
}
