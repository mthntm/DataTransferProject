using System;
using System.Collections.Generic;

namespace DataTransferProject.MssqlModels
{
    public partial class Gsm
    {
        public int GsmId { get; set; }
        public string GsmNumber { get; set; }
        public string GsmLocation { get; set; }
        public string GsmQuota { get; set; }
        public string GsmCompany { get; set; }
        public string StationName { get; set; }
    }
}
