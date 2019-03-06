using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPictureManager.Models
{
    [Table("WORK")]
    public class WORK
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        
        [Column("NAME")]
        public String Name { get; set; }

    }
}
