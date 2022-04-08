using System;
using System.Collections.Generic;

namespace DataTransferProject.MssqlModels
{
    public partial class DeviceReader
    {
        public DeviceReader()
        {
            Package = new HashSet<Package>();
        }

        public int Id { get; set; }
        public string DeviceReaderName { get; set; }

        public virtual ICollection<Package> Package { get; set; }
    }
}
