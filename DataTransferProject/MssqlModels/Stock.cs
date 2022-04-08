using System;
using System.Collections.Generic;

namespace DataTransferProject.MssqlModels
{
    public partial class Stock
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public int? Category { get; set; }
        public decimal? Price { get; set; }
        public DateTime? DateOfPurchase { get; set; }
        public string Status { get; set; }
        public string StockSerialNo { get; set; }
        public string PackageNo { get; set; }
        public int? CurrencyType { get; set; }
        public string Explanation { get; set; }

        public virtual Category CategoryNavigation { get; set; }
        public virtual DboCurrency CurrencyTypeNavigation { get; set; }
        public virtual Package PackageNoNavigation { get; set; }
    }
}
