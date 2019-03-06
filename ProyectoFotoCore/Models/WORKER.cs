﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPictureManager.Models
{
    [Table("WORKER")]
    public class WORKER
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }

        [Column("NAME")]
        public String Name { get; set; }

        [Column("CONTACT")]
        public String Contact { get; set; }

        [Column("URLCONTACT")]
        public String UrlContact { get; set; }
    }
}