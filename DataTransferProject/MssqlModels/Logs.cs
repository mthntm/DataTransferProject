using System;
using System.Collections.Generic;

namespace DataTransferProject.MssqlModels
{
    public partial class Logs
    {
        public int Id { get; set; }
        public string WhichMenu { get; set; }
        public string GeneralId { get; set; }
        public bool CreatedObject { get; set; }
        public bool UpdatedObject { get; set; }
        public bool DeletedObject { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string NameOfTheProduct { get; set; }
        public string StationName { get; set; }
        public string Explanation { get; set; }
        public int? Customer { get; set; }

        public virtual CustomerStation CustomerNavigation { get; set; }
    }
}
