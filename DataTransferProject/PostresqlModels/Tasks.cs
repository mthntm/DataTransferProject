using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferProject.PostresqlModels
{
    [Table("tasks")]
    public partial class Tasks
    {
        [Key]
        [Column("taskid", Order = 0)]
        public int TaskId { get; set; }
        [Column("taskdescription", Order = 1)]
        public string TaskDescription { get; set; }
        [Column("date", Order = 2)]
        public DateTime? Date { get; set; }
    }
}
