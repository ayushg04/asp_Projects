using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
//using YAMS_Repository;

namespace YAMS_Data.API
{
    [Table("UserTable")]
    public class UserTable
    {
        //   private DatabaseConnection dbconn;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required(ErrorMessage ="Name Required")]
        public string username { get; set; }
        [Required(ErrorMessage ="Password Required")]
        public string password { get; set; }
    }
}
