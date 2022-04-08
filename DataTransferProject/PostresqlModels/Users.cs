using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferProject.PostresqlModels
{
    [Table("users")]
    public partial class Users
    {
        [Key]
        [Column("id", Order = 0)]
        public int Id { get; set; }
        [Column("username", Order = 1)]
        public string UserName { get; set; }
        [Column("password", Order = 2)]
        public string Password { get; set; }
        [Column("role", Order = 3)]
        public string Role { get; set; }
    }
}
