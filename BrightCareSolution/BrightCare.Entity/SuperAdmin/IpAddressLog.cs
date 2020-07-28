﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BrightCare.Entity.SuperAdmin
{
    public class IpAddressLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [MaxLength(500)]

        public string LocalIP { get; set; }
        [MaxLength(500)]

        public string PublicIP { get; set; }
        public string HostMachine { get; set; }

        [MaxLength(500)]
        public string UserHost { get; set; }
        public int Count { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
