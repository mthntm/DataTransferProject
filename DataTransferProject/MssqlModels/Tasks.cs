using System;
using System.Collections.Generic;

namespace DataTransferProject.MssqlModels
{
    public partial class Tasks
    {
        public int TaskId { get; set; }
        public string TaskDescription { get; set; }
        public DateTime? Date { get; set; }
    }
}
