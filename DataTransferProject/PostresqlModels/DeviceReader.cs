using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferProject.PostresqlModels
{
    [Table("device_reader")]
    public partial class DeviceReader
    {
        [Key]
        [Column("id", Order = 0)]
        public int Id { get; set; }
        [Column("devicereadername", Order = 1)]
        public string DeviceReaderName { get; set; }
        public virtual ICollection<Package> Package { get; set; }
    }
}
