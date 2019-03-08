using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFotoCore.Models
{
    [Table("SESION_WORKER")]
    public class SESSION_WORKER
    {
        [Column("IDSESION")]
        public int IdSession { get; set; }
        [Column("IDWORKER")]
        public int IdWorker { get; set; }
        [Column("IDWORK")]
        public int IdWork { get; set; }
    }
}
