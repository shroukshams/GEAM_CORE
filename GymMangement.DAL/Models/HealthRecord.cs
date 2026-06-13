using System;
using System.Collections.Generic;
using System.Text;

namespace GymMangement.DAL.Models
{
    internal class HealthRecord : baseEntity
    {
        public decimal heigh { get; set; }
        public decimal weight { get; set; }
        public string bloodType { get; set; } = default!;
        public string? Note { get; set; }
        //update at of baseEntity will be the last update of health record
    }
}
