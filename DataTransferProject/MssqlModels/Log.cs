using System;
using System.Collections.Generic;

namespace DataTransferProject.MssqlModels
{
    public partial class Log
    {
        public int SerialNoId { get; set; }
        public string SerialNo { get; set; }
        public string StationName { get; set; }
        public string Statement { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
    }
}
