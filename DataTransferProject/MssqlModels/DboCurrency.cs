using System;
using System.Collections.Generic;

namespace DataTransferProject.MssqlModels
{
    public partial class DboCurrency
    {
        public DboCurrency()
        {
            Stock = new HashSet<Stock>();
        }

        public int CurrencyId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Stock> Stock { get; set; }
    }
}
