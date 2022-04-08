using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataTransferProject.MssqlModels
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int? ItemInStock { get; set; }
        public int? ProductInThePackage { get; set; }

        public virtual ICollection<Stock> Stock { get; set; }
    }
}
